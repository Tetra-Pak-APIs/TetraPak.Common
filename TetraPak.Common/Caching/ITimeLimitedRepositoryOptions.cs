using System;

namespace TetraPak.Caching
{
    public interface ITimeLimitedRepositoryOptions
    {
        /// <summary>
        ///   Gets the life span for entries of the cache repository.
        /// </summary>
        TimeSpan LifeSpan { get; }
        
        /// <summary>
        ///   Gets a lifespan to be re-applied to a value as it is being read from the cache, extending its life span.
        /// </summary>
        TimeSpan ExtendedLifeSpan { get; }
        
        /// <summary>
        ///   Gets the maximum total lifespan allowed for any cached value
        ///   within a cache repository. Setting this to anything other than zero will limit the
        ///   total lifespan of cached values to unlimited lifespan due to dynamic lifespan extension
        ///   when reading/updating values (see <see cref="ExtendedLifeSpan"/>).
        /// </summary>
        TimeSpan MaxLifeSpan { get; }
    }
}