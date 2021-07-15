using System;

namespace TetraPak.Caching
{
    public interface ITimeLimitedRepositoryEntry
    {
        string Repository { get; }
        
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