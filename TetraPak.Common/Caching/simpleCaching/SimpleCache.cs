using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using TetraPak.Logging;

namespace TetraPak.Caching
{
    /// <summary>
    ///   Implements a very simple memory cache with automatic purging.
    /// </summary>
    // ReSharper disable once ClassWithVirtualMembersNeverInherited.Global
    public class SimpleCache : ITimeLimitedRepositories
    {
        readonly IDictionary<string, SimpleCacheEntry> _values;
        TaskCompletionSource<bool> _purgingTcs;
        DateTime _lastPurge;
        SimpleCacheConfig _config;

        /// <summary>
        ///   Gets a logging provider.
        /// </summary>
        public ILogger<SimpleCache> Logger { get; }
        
        /// <inheritdoc />
        public TimeSpan DefaultLifeSpan { get; set; } = TimeSpan.FromMinutes(1);
        
        /// <inheritdoc />
        public TimeSpan DefaultExtendedLifeSpan { get; set; } = TimeSpan.Zero;

        /// <inheritdoc />
        public TimeSpan DefaultMaxLifeSpan { get; set; } = TimeSpan.Zero;
        
        /// <inheritdoc />
        public TimeSpan DefaultAdjustedLifeSpan { get; set; } = TimeSpan.Zero;

        ITimeLimitedRepositoryOptions DefaultOptions => SimpleTimeLimitedRepositoryOptions.AsDefault(this);
        
        /// <summary>
        ///   Gets or sets an interval between automatic purging processes.
        /// </summary>
        /// <remarks>
        ///   By setting this value to anything lower than <see cref="TimeSpan.MaxValue"/> the
        ///   <see cref="SimpleCache"/> instance will automatically remove all entries regularly,
        ///   to avoid resources leaks.  
        /// </remarks>
        public TimeSpan AutoPurgeInterval { get; set; } = TimeSpan.FromMinutes(5);

        /// <inheritdoc />
        public bool IsTypeStrict { get; set; } = true;

        /// <inheritdoc />
        public Task AddAsync(string repository, string key, object value, TimeSpan? customLifeSpan = null)
        {
            OnPurgeDeadEntriesAsync();
            lock (_values)
            {
                var valueKey = MakeKey(repository, key);
                if (!_values.TryGetValue(valueKey, out var entry))
                {
                    _values.Add(valueKey, new SimpleCacheEntry(this, repository, key,value, customLifeSpan));
                    return Task.CompletedTask;
                }

                if (entry.IsLive())
                    throw new IdentityConflictException(nameof(key),
                        $"Cannot add new cached value '{value}'. Value is already cached");

                entry.UpdateValue(value, customLifeSpan);
                return Task.CompletedTask;
            }
        }

        /// <inheritdoc />
        public Task UpdateAsync(string repository, string key, object value, TimeSpan? customLifeSpan = null)
        {
            OnPurgeDeadEntriesAsync();
            lock (_values)
            {
                var valueKey = MakeKey(repository, key);
                if (!_values.TryGetValue(valueKey, out var entry))
                    throw new ArgumentOutOfRangeException(nameof(key),
                        $"Cannot update cached value '{valueKey}'. Value does not exist");
                
                entry.UpdateValue(value, customLifeSpan);
                return Task.CompletedTask;
            }
        }

        /// <inheritdoc />
        public Task AddOrUpdateAsync(string repository, string key, object value, TimeSpan? customLifeSpan)
        {
            OnPurgeDeadEntriesAsync();
            lock (_values)
            {
                var valueKey = MakeKey(repository, key);
                if (!_values.TryGetValue(valueKey, out var entry))
                {
                    _values.Add(valueKey, new SimpleCacheEntry(this, repository, key, value, customLifeSpan));
                    return Task.CompletedTask;
                }

                if (!entry.IsLive())
                {
                    Logger.Trace($"Updating dead cached value '{valueKey}'. Removing and re-adding it");
                    _values.Remove(valueKey);
                    _values.Add(valueKey, new SimpleCacheEntry(this, repository, key, value, customLifeSpan));
                    return Task.CompletedTask;
                }
                entry.UpdateValue(value, customLifeSpan);
                return Task.CompletedTask;
            }
        }

        /// <inheritdoc />
        public TimeSpan GetLifeSpan(string repository)
        {
            return _config.GetRepositoryOptions(repository)?.LifeSpan ?? DefaultLifeSpan;
        }

        /// <inheritdoc />
        public TimeSpan GetMaxLifeSpan(string repository)
        {
            return _config.GetRepositoryOptions(repository)?.MaxLifeSpan ?? DefaultMaxLifeSpan;
        }

        /// <inheritdoc />
        public TimeSpan GetExtendedLifeSpan(string repository)
        {
            return _config.GetRepositoryOptions(repository)?.ExtendedLifeSpan ?? DefaultLifeSpan;
        }

        /// <inheritdoc />
        public TimeSpan GetAdjustedLifeSpan(string repository)
        {
            return _config.GetRepositoryOptions(repository)?.AdjustedLifeSpan ?? DefaultAdjustedLifeSpan;
        }

        /// <inheritdoc />
        public virtual Task<Outcome<T>> GetAsync<T>(string repository, string key) => GetAsync<T>(repository, key, out _);

        /// <inheritdoc />
        public virtual Task<Outcome<T>> GetAsync<T>(string repository, string key, out TimeSpan remainingLifeSpan)
        {
            lock (_values)
            {
                var valueKey = MakeKey(repository, key);
                if (_values.TryGetValue(valueKey, out var entry) && entry.IsLive(out remainingLifeSpan))
                    return Task.FromResult(entry.GetValue<T>(false));
                
                remainingLifeSpan = TimeSpan.Zero;
                return Task.FromResult(Outcome<T>.Fail(
                    new ArgumentOutOfRangeException(nameof(valueKey), $"Unknown value: {valueKey}")));
            }
        }
        
        /// <inheritdoc />
        public virtual Task DeleteAsync(string repository, string key)
        {
            return OnDeleteAsync(repository, key, false);
        }

        /// <inheritdoc />
        public virtual Task ConfigureAsync(string repository, ITimeLimitedRepositoryOptions options)
        {
            if (options is SimpleTimeLimitedRepositoryOptions config)
            {
                config.SetCache(this);
            }
            _config.Configure(repository, options);
            return Task.CompletedTask;
        }

        /// <inheritdoc />
        public Task<ITimeLimitedRepositoryOptions> GetRepositoryOptionsAsync(string repository, bool useDefault = true)
        {
            var options = _config.GetRepositoryOptions(repository);
            return Task.FromResult(options ?? (useDefault
                ? DefaultOptions
                : null));
        }

        /// <summary>
        ///    Removes a time limited value, optionally without validation.
        /// </summary>
        /// <param name="repository">
        ///   Identifies the repository to remove the value from.
        /// </param>
        /// <param name="key">
        ///   Value's unique identifier.
        /// </param>
        /// <param name="safe">
        ///   When set no validation will take place. Attempting to remove an unrecognized
        ///   value will not throw an exception.
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        ///   The <paramref name="key"/> was not recognized and <paramref name="safe"/> was not set.
        /// </exception>
        protected virtual Task OnDeleteAsync(string repository, string key, bool safe)
        {
            lock (_values)
            {
                var valueKey = MakeKey(repository, key);
                if (!_values.TryGetValue(valueKey, out _))
                {
                    return safe
                        ? Task.CompletedTask
                        : throw new ArgumentOutOfRangeException(nameof(key), $"Unknown value: {valueKey}");
                }

                _values.Remove(valueKey);
            }
            return Task.CompletedTask;
        }

        /// <summary>
        ///   Gets called automatically (in a background thread) to remove dead entries. 
        /// </summary>
        protected virtual Task OnPurgeDeadEntriesAsync()
        {
            lock (_values)
            {
                if (_purgingTcs is { })
                    return _purgingTcs.Task;
                
                if (AutoPurgeInterval == TimeSpan.MaxValue || _lastPurge.Add(AutoPurgeInterval) < DateTime.Now)
                    return Task.CompletedTask;
            }
            
            Logger.Debug($"Commences automatic purging from {this} ...");
            
            _purgingTcs = new TaskCompletionSource<bool>();
            Task.Run(async () =>
            {
                var allEntries = _values.Values.Cast<ITimeLimitedRepositoryEntry>().ToArray(); 
                var purgedEntries = await OnPurgeDeadEntries(allEntries);
                // ReSharper disable once ForCanBeConvertedToForeach
                for (var i = 0; i < purgedEntries.Length; i++)
                {
                    var e = purgedEntries[i];
                    await OnDeleteAsync(e.Repository, e.Key, true);
                }
                _lastPurge = DateTime.Now;
                _purgingTcs.SetResult(true);
                _purgingTcs = null;
                
                Logger.Debug($"Automatic purging from {this} is DONE");
            });
            return _purgingTcs.Task;
        }

        /// <summary>
        ///   This method gets called from a background thread to allow selecting entries to be removed.
        ///   The default implementation simply returns a collection of entries that are "dead"
        ///   (the <see cref="ITimeLimitedRepositoryEntry.IsLive"/> returns <c>false</c>).
        /// </summary>
        /// <param name="entries">
        ///   A collection of entries that should be examined. 
        /// </param>
        /// <returns>
        ///   A collection of entries that should be removed.
        /// </returns>
        protected virtual Task<ITimeLimitedRepositoryEntry[]> OnPurgeDeadEntries(
            IEnumerable<ITimeLimitedRepositoryEntry> entries)
        {
            return Task.FromResult(entries.Where(entry => !entry.IsLive()).ToArray());
        }

        internal static string MakeKey(string repository, string key) => $"{repository}://{key}";

        public SimpleCache WithConfiguration(SimpleCacheConfig config)
        {
            _config = config;
            return this;
        }

        public SimpleCache(ILogger<SimpleCache> logger)
        {
            Logger = logger;
            _values = new Dictionary<string, SimpleCacheEntry>();
        }
    }
}