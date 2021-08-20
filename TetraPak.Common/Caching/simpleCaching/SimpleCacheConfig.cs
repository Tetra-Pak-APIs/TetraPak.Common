using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using TetraPak.Configuration;

namespace TetraPak.Caching
{
    /// <summary>
    ///   A configuration section specifying caching strategies. 
    /// </summary>
    public class SimpleCacheConfig : ConfigurationSection, IEnumerable<KeyValuePair<string,ITimeLimitedRepositoryOptions>>
    {
        SimpleCache _simpleCache;
        readonly Dictionary<string, ITimeLimitedRepositoryOptions> _repositoryConfigs;

        public IEnumerator<KeyValuePair<string, ITimeLimitedRepositoryOptions>> GetEnumerator()
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
                var config = new SimpleTimeLimitedRepositoryOptions(_simpleCache, Section, Logger, childSection.Key);
                _repositoryConfigs.Add(childSection.Key, config);
            }
        }
        
        public ITimeLimitedRepositoryOptions GetRepositoryOptions(string repository)
        {
            return _repositoryConfigs.TryGetValue(repository, out var config)
                ? config
                : null;
        }

        public void Configure(string repository, ITimeLimitedRepositoryOptions options)
        {
            if (_repositoryConfigs.TryGetValue(repository, out var existing))
            {
                ((SimpleTimeLimitedRepositoryOptions) existing).MergeFrom(options);
                return;
            }

            _repositoryConfigs.Add(repository, options);
        }

        public SimpleCacheConfig(
            SimpleCache simpleCache,
            IConfiguration configuration, 
            ILogger logger, 
            string sectionIdentifier = null) 
        : base(configuration, logger, ValidateIsAssigned(sectionIdentifier))
        {
            _simpleCache = simpleCache;
            _repositoryConfigs = new Dictionary<string, ITimeLimitedRepositoryOptions>();
            loadRepositoryConfigs();
        }

        public SimpleCacheConfig WithCache(SimpleCache cache)
        {
            _simpleCache = cache;
            foreach (var options in _repositoryConfigs.Values)
            {
                ((SimpleTimeLimitedRepositoryOptions) options).SetCache(cache);
            }
            return this;
        }
    }
}