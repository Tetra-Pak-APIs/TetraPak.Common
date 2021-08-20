using System;

namespace TetraPak.Caching
{
    /// <summary>
    ///   Implementors of this class can represent individual time limited repository entries. 
    /// </summary>
    public interface ITimeLimitedRepositoryEntry
    {
        /// <summary>
        ///   The name of the repository.
        /// </summary>
        string Repository { get; }
        
        /// <summary>
        ///   A key identifying the value to be stored within the time limited repository. 
        /// </summary>
        string Key { get; }

        bool IsLive(out TimeSpan remainingLifeSpan);
    }
    
    // ReSharper disable once InconsistentNaming
    public static class ITimeLimitedRepositoryEntryExtensions
    {
        /// <summary>
        ///   Just a parameter-less variant of the <see cref="ITimeLimitedRepositoryEntry.IsLive"/> method,
        ///   for cleaner syntax :-).
        /// </summary>
        public static bool IsLive(this ITimeLimitedRepositoryEntry self) => self.IsLive(out _);
    }
}