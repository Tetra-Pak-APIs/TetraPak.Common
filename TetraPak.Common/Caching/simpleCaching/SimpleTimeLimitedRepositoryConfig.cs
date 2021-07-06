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
    public class SimpleTimeLimitedRepositoryConfig : ConfigurationSection, ITimeLimitedRepositoryOptions
    {
        SimpleCache _simpleCache;
        // ReSharper disable NotAccessedField.Local
        TimeSpan? _lifeSpan;
        TimeSpan? _extendedLifeSpan;
        TimeSpan? _maxLifeSpan;
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
        
        internal static SimpleTimeLimitedRepositoryConfig AsDefault(SimpleCache simpleCache)
        {
            return new()
            {
                _simpleCache = simpleCache,
                _lifeSpan = simpleCache.DefaultLifeSpan,
                _extendedLifeSpan = simpleCache.DefaultExtendedLifeSpan
            };
        }
        
        internal SimpleTimeLimitedRepositoryConfig WithCache(SimpleCache cache)
        {
            _simpleCache = cache;
            return this;
        }

        public static SimpleTimeLimitedRepositoryConfig Zero => new SimpleTimeLimitedRepositoryConfig
        {
            _lifeSpan = TimeSpan.Zero,
            _extendedLifeSpan = TimeSpan.Zero,
            _maxLifeSpan = TimeSpan.Zero
        };

        public SimpleTimeLimitedRepositoryConfig(
            SimpleCache simpleCache,
            IConfiguration configuration, 
            ILogger logger, 
            string sectionIdentifier) 
            : base(configuration, logger,  SimpleCacheConfig.ValidateIsAssigned(sectionIdentifier))
        {
            _simpleCache = simpleCache;
        }

        SimpleTimeLimitedRepositoryConfig() : base(null, null)
        {
            
        }
    }
}