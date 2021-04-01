using System;

namespace TetraPak.Logging
{
    /// <summary>
    ///   Implementors of this interface represents an individual entry in a log.
    /// </summary>
    public interface ILogEntry
    {
        /// <summary>
        ///   Gets a unique if. Can be used to reference a specific entry in support scenarios.
        /// </summary>
        string Id { get; }
        
        /// <summary>
        ///   Gets the log rank (see <see cref="LogRank"/>).
        /// </summary>
        LogRank Rank { get; }

        /// <summary>
        ///   Gets the log entry timestamp (should be UTC).
        /// </summary>
        DateTime Time { get; }

        /// <summary>
        ///   Get the log message.
        /// </summary>
        string Message { get; }
    }
}