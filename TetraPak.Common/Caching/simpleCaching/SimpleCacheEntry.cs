using System;
using System.Diagnostics;

namespace TetraPak.Caching
{
    [DebuggerDisplay("{ToString()}")]
    class SimpleCacheEntry : ITimeLimitedRepositoryEntry
    {
        readonly ITimeLimitedRepositories _repositories;
        
        DateTime SpawnTimeUtc { get; set; }

        DateTime InitialSpawnTimeUtc { get; set; }

        TimeSpan? _customLifeSpan;

        readonly TimeSpan? _customMaxLifeSpan;

        object _value;

        public string Repository { get; }
        
        public string Key { get; }
        
        public bool IsLive(out TimeSpan remainingLifeSpan)
        {
            remainingLifeSpan = GetRemainingLifeSpan();
            return remainingLifeSpan != TimeSpan.Zero;
        }

        public TimeSpan GetRemainingLifeSpan(DateTime? from = null)
        {
            from ??= DateTime.UtcNow;
            var maxLifeSpan = getMaxLifeSpan();
            var spawnTime = maxLifeSpan == TimeSpan.Zero
                ? SpawnTimeUtc
                : InitialSpawnTimeUtc;
            
            var lifeSpan = getLifeSpan();
            if (maxLifeSpan != TimeSpan.Zero && lifeSpan > maxLifeSpan)
            {
                lifeSpan = maxLifeSpan;
            }

            var adjustedLifeSpan = getAdjustedLifeSpan();
            if (adjustedLifeSpan != TimeSpan.Zero)
            {
                lifeSpan = lifeSpan.Add(adjustedLifeSpan);
            }
            var expires = spawnTime.Add(lifeSpan);
            return from < expires 
                ? expires.Subtract(from.Value) 
                : TimeSpan.Zero;
        }

        public override string ToString() => SimpleCache.MakeKey(Repository, Key);

        TimeSpan getLifeSpan() => _customLifeSpan ?? _repositories.GetLifeSpan(Repository);

        TimeSpan getMaxLifeSpan() => _customMaxLifeSpan ?? _repositories.GetMaxLifeSpan(Repository);

        TimeSpan getExtendedLifeSpan() => _repositories.GetExtendedLifeSpan(Repository);

        TimeSpan getAdjustedLifeSpan() => _repositories.GetAdjustedLifeSpan(Repository);

        public Outcome<T> GetValue<T>(bool checkIsLive = true)
        {
            if (checkIsLive && !IsLive(out _))
                return Outcome<T>.Fail(new Exception("Value has expired"));

            var outcome = _value is T tValue
                ? Outcome<T>.Success(tValue) 
                : Outcome<T>.Fail(new InvalidCastException("Value is not of requested type"));

            if (!outcome)
                return outcome;
            
            var extendedLifSpan = getExtendedLifeSpan();
            if (extendedLifSpan != TimeSpan.Zero)
            {
                extendLifeSpan();
            }

            return outcome;
        }

        public void UpdateValue(object value, DateTime spawnTimeUtc, TimeSpan? customLifeSpan)
        {
            if (value is null)
                throw new ArgumentNullException(nameof(value));
            
            if (_repositories.IsTypeStrict && !value.GetType().IsInstanceOfType(_value))
                throw new InvalidCastException();
            
            _value = value;
            if (spawnTimeUtc.Kind != DateTimeKind.Utc)
            {
                spawnTimeUtc = spawnTimeUtc.ToUniversalTime();
            }
            SpawnTimeUtc = spawnTimeUtc;

            if (customLifeSpan.HasValue)
            {
                _customLifeSpan = customLifeSpan;
            }

            var extendedLifSpan = getExtendedLifeSpan();
            if (extendedLifSpan != TimeSpan.Zero)
            {
                extendLifeSpan();
            }
        }

        void extendLifeSpan()
        {
            SpawnTimeUtc = DateTime.UtcNow;
        }

        public SimpleCacheEntry(
            ITimeLimitedRepositories repositories,
            string repository,
            string key,
            object value,
            TimeSpan? customLifeSpan = null,
            TimeSpan? customMaxLifeSpan = null)
        {
            Repository = repository;
            Key = key;
            _value = value ?? throw new ArgumentNullException(nameof(value));
            _repositories = repositories;
            _customLifeSpan = customLifeSpan;
            _customMaxLifeSpan = customMaxLifeSpan;
            InitialSpawnTimeUtc = SpawnTimeUtc = DateTime.UtcNow;
        }
    }
}