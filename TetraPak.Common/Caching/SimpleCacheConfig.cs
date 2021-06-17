using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using TetraPak.Configuration;
using TetraPak.Logging;

namespace TetraPak.Caching
{
    public class SimpleCacheConfig : ConfigurationSection, IEnumerable<KeyValuePair<string,SimpleCacheRepositoryConfig>>
    {
        SimpleCache _simpleCache;
        readonly Dictionary<string, SimpleCacheRepositoryConfig> _repositoryConfigs;

        protected override string SectionIdentifier { get; }

        public IEnumerator<KeyValuePair<string, SimpleCacheRepositoryConfig>> GetEnumerator()
        {
            return _repositoryConfigs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        
        internal static string ValidateIsAssigned(string sectionIdentifier)
        {
            return string.IsNullOrWhiteSpace(sectionIdentifier)
                ? throw new ArgumentNullException(nameof(sectionIdentifier))
                : sectionIdentifier;
        }

        void loadRepositoryConfigs()
        {
            var childSections = Section.GetChildren();
            foreach (var childSection in childSections)
            {
                var config = new SimpleCacheRepositoryConfig(_simpleCache, Section, Logger, childSection.Key);
                _repositoryConfigs.Add(childSection.Key, config);
            }
        }
        
        public SimpleCacheRepositoryConfig GetRepositoryConfig(string repository)
        {
            return _repositoryConfigs.TryGetValue(repository, out var config)
                ? config
                : null;
        }

        public SimpleCacheConfig(
            SimpleCache simpleCache,
            IConfiguration configuration, 
            ILogger logger, 
            string sectionIdentifier = null) 
        : base(configuration, logger, ValidateIsAssigned(sectionIdentifier))
        {
            _simpleCache = simpleCache;
            _repositoryConfigs = new Dictionary<string, SimpleCacheRepositoryConfig>();
            SectionIdentifier = sectionIdentifier;
            loadRepositoryConfigs();
        }

        public SimpleCacheConfig WithCache(SimpleCache cache)
        {
            _simpleCache = cache;
            foreach (var config in _repositoryConfigs.Values)
            {
                config.WithCache(cache);
            }
            return this;
        }
    }

    /// <summary>
    ///   Represents configuration for a named cache repository.
    /// </summary>
    /// <seealso cref="SimpleCache"/>
    /// <seealso cref="SimpleCacheConfig"/>
    public class SimpleCacheRepositoryConfig : ConfigurationSection
    {
        SimpleCache _simpleCache;
        // ReSharper disable NotAccessedField.Local
        TimeSpan? _lifeSpan;
        TimeSpan? _extendedLifeSpan;
        TimeSpan? _maxLifeSpan;
        // ReSharper restore NotAccessedField.Local

        protected override string SectionIdentifier { get; }

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
        
        internal static SimpleCacheRepositoryConfig AsDefault(SimpleCache simpleCache)
        {
            return new()
            {
                _simpleCache = simpleCache,
                _lifeSpan = simpleCache.DefaultLifeSpan,
                _extendedLifeSpan = simpleCache.DefaultExtendedLifeSpan
            };
        }
        
        internal SimpleCacheRepositoryConfig WithCache(SimpleCache cache)
        {
            _simpleCache = cache;
            return this;
        }

        public SimpleCacheRepositoryConfig(
            SimpleCache simpleCache,
            IConfiguration configuration, 
            ILogger logger, 
            string sectionIdentifier) 
        : base(configuration, logger,  SimpleCacheConfig.ValidateIsAssigned(sectionIdentifier))
        {
            _simpleCache = simpleCache;
            SectionIdentifier = sectionIdentifier;
        }

        SimpleCacheRepositoryConfig() : base(null, null)
        {
        }
    }
}