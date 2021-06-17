using System;

namespace TetraPak.Caching
{
    public interface ITimeLimitedRepositoryEntry
    {
        string Repository { get; }
        
        string Key { get; }

        bool IsLive { get; }
    }
}