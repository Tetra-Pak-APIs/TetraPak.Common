using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using TetraPak.Configuration;
using TetraPak.Logging;

namespace TetraPak.Caching
{
    /// <summary>
    ///   Represents configuration for a named cache repository.
    /// </summary>
    /// <seealso cref="SimpleCache"/>
    /// <seealso cref="SimpleCacheConfig"/>
    public class SimpleTimeLimitedRepositoryOptions : ConfigurationSection, ITimeLimitedRepositoryOptions
    {
        SimpleCache _simpleCache;
        // ReSharper disable NotAccessedField.Local
        TimeSpan? _lifeSpan;
        TimeSpan? _extendedLifeSpan;
        TimeSpan? _maxLifeSpan;
        TimeSpan? _adjustedLifeSpan;
        // ReSharper restore NotAccessedField.Local
        
        /// <summary>
        ///   Gets or sets the life span for entries of the configured cache repository.
        /// </summary>
        public TimeSpan LifeSpan
        {
            get => GetFromFieldThenSection(_simpleCache.DefaultLifeSpan, (string value, out TimeSpan span) =>
            {
                if (value.TryParseConfiguredTimeSpan(out span))
                    return true;
                
                Logger.Warning($"Invalid value for {nameof(LifeSpan)}: \"{value}\"");
                return false;
            });
            set => _lifeSpan = value;
        }

        /// <summary>
        ///   Gets or sets a value specifying a lifespan to be re-applied to a value as it is being
        ///   read from the cache.
        /// </summary>
        /// <remarks>
        ///   Set this value to an asterisk (*) to always renew by same value as <see cref="LifeSpan"/>.
        /// </remarks>
        public TimeSpan ExtendedLifeSpan
        {
            get => GetFromFieldThenSection(_simpleCache.DefaultExtendedLifeSpan, (string value, out TimeSpan span) =>
            {
                if (value == "*")
                {
                    // extended lifespan is same as initial lifespan ...
                    span = LifeSpan;
                    return true;
                }

                if (value.TryParseConfiguredTimeSpan(out span))
                    return true;
                    
                Logger.Warning($"Invalid value for {nameof(ExtendedLifeSpan)}: \"{value}\"");
                return false;

            });
            set => _extendedLifeSpan = value;
        }

        /// <summary>
        ///   Gets or sets a value specifying the maximum total lifespan allowed for any cached value
        ///   within a specific repository. Setting this to anything other than zero will limit the
        ///   total lifespan of cached values to unlimited lifespan due to dynamic lifespan extension
        ///   when reading/updating values (see <see cref="ExtendedLifeSpan"/>).
        /// </summary>
        public TimeSpan MaxLifeSpan
        {
            get => GetFromFieldThenSection(_simpleCache.DefaultMaxLifeSpan, (string value, out TimeSpan span) =>
            {
                // 0 or absent = unlimited
                if (value.TryParseConfiguredTimeSpan(out span))
                {
                    span = span == TimeSpan.Zero ? TimeSpan.MaxValue : span;
                    return true;
                }
                
                Logger.Warning($"Invalid value for {nameof(MaxLifeSpan)}: \"{value}\"");
                return false;
            });
            set => _maxLifeSpan = value;
        }

        /// <summary>
        ///   Gets or sets a value that always adjusts the <see cref="LifeSpan"/>
        ///   (and <see cref="ExtendedLifeSpan"/> when applicable).
        ///   This value can be used to always increase or decrease the lifespan values.
        /// </summary>
        /// <remarks>
        ///   <para>
        ///   One typical application for this is to create a "safe zone" for values that themselves
        ///   have a limited lifetime (outside of the repository),
        ///   and that might expire within this time span, before they can be consumed.</para>
        ///   <para>
        ///   Consider, for example, cached security tokens. Those are typically intended to be used
        ///   when consuming remote services, such as APIs. Depending on network load/capacity you might see
        ///   that after your code retrieves a cached token for your request to the service that validates the
        ///   token needs some extra seconds. If the token is about to expire in, say, three seconds, and your call
        ///   takes that (or more) time to get through to the remote service, the token will not be accepted by that
        ///   service. In those scenarios it is usually a good idea to simply decrease the lifespan of such tokens
        ///   with a few seconds to discard the cached (about to expire) security token
        ///   and force acquiring of a new one. 
        ///   </para>
        /// </remarks>
        public TimeSpan AdjustedLifeSpan
        {
            get => GetFromFieldThenSection(_simpleCache.DefaultAdjustedLifeSpan, (string value, out TimeSpan span) =>
            {
                // 0 or absent = Zero
                if (value.TryParseConfiguredTimeSpan(out span))
                {
                    span = span == TimeSpan.Zero ? TimeSpan.MaxValue : span;
                    return true;
                }

                Logger.Warning($"Invalid value for {nameof(AdjustedLifeSpan)}: \"{value}\"");
                return false;
            });
            set => _adjustedLifeSpan = value;
        }
        
        internal static SimpleTimeLimitedRepositoryOptions AsDefault(SimpleCache simpleCache) 
        {
            return new()
            {
                _simpleCache = simpleCache,
                _lifeSpan = simpleCache.DefaultLifeSpan,
                _extendedLifeSpan = simpleCache.DefaultExtendedLifeSpan,
                _maxLifeSpan = simpleCache.DefaultMaxLifeSpan,
                _adjustedLifeSpan = simpleCache.DefaultAdjustedLifeSpan
            };
        }
        
        /// <summary>
        ///   Simply sets the internal reference to the parent <see cref="SimpleCache"/> instance.
        /// </summary>
        /// <param name="cache">
        ///   The parent <see cref="SimpleCache"/> instance.
        /// </param>
        internal void SetCache(SimpleCache cache)
        {
            _simpleCache = cache;
        }

        /// <summary>
        ///   Returns a configuration with all values initialized to <see cref="TimeSpan.Zero"/>.
        /// </summary>
        public static SimpleTimeLimitedRepositoryOptions Zero => new()
        {
            _lifeSpan = TimeSpan.Zero,
            _extendedLifeSpan = TimeSpan.Zero,
            _maxLifeSpan = TimeSpan.Zero,
            _adjustedLifeSpan = TimeSpan.Zero
        };

        /// <summary>
        ///   Merges options with other options.
        /// </summary>
        /// <param name="options"></param>
        /// <remarks>
        ///   If <paramref name="options"/> is a <see cref="ConfigurationSection"/> only values
        ///   that are assigned to property backing fields will be merged.
        /// </remarks>
        public void MergeFrom(ITimeLimitedRepositoryOptions options)
        {
            var type = options.GetType();
            var properties = type.GetProperties();
            foreach (var property in properties)
            {
                if (property.IsIndexer() || !property.CanWrite)
                    continue;

                object value;
                if (options is ConfigurationSection section)
                {
                    if (!section.TryGetFieldValue(property.Name, out value))
                        continue;

                    SetFieldValue(property.Name, value);
                    continue;
                }

                value = property.GetValue(options);
                SetFieldValue(property.Name, value);
            }
        }

        public SimpleTimeLimitedRepositoryOptions(
            SimpleCache simpleCache,
            IConfiguration configuration, 
            ILogger logger, 
            string sectionIdentifier) 
        : base(configuration, logger, SimpleCacheConfig.ValidateIsAssigned(sectionIdentifier))
        {
            _simpleCache = simpleCache;
        }

        SimpleTimeLimitedRepositoryOptions() : base(null, null)
        {
        }
    }
}