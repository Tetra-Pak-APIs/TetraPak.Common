using System;

namespace tetrapak.logging
{
    /// <summary>
    ///   Provides a basic logging mechanism to the package.
    /// </summary>
    public interface ILog : IDisposable
    {
        /// <summary>
        ///   Triggered whenever a log entry gets added.
        /// </summary>
        event EventHandler<TextLogEventArgs> Logged;

        /// <summary>
        ///   Gets or sets a delegate used for querying the log.
        /// </summary>
        QueryAsyncDelegate QueryAsync { get; set; }

        /// <summary>
        ///   Adds a message of rank <see cref="LogRank.Debug"/>.
        /// </summary>
        /// <param name="message">
        ///   A textual message to be logged.
        /// </param>
        void Debug(string message);

        /// <summary>
        ///   Adds a message of rank <see cref="LogRank.Info"/>.
        /// </summary>
        /// <param name="message">
        ///   A textual message to be logged.
        /// </param>
        void Info(string message);

        /// <summary>
        ///   Adds a message of rank <see cref="LogRank.Warning"/>.
        /// </summary>
        /// <param name="message">
        ///   A textual message to be logged.
        /// </param>
        void Warning(string message);

        /// <summary>
        ///   Adds an <see cref="Exception"/> and message of rank <see cref="LogRank.Error"/>.
        /// </summary>
        /// <param name="exception">
        ///   An <see cref="Exception"/> to be logged.
        /// </param>
        /// <param name="message">
        ///   A textual message to be logged.
        /// </param>
        void Error(Exception exception, string message = null);

        /// <summary>
        ///   Adds a log message for any log rank (such as a log section entry/exit.
        /// </summary>
        /// <param name="message">
        ///   The message to be logged.
        /// </param>
        void Any(string message);

        /// <summary>
        ///   Another, more arbitrary, alternative to writing a log entry.
        /// </summary>
        /// <param name="rank">
        ///   Specifies the <see cref="LogRank"/>   
        /// </param>
        /// <param name="message">
        ///   The message to log.
        /// </param>
        /// <param name="exception">
        ///   (optional)<br/>
        ///   An exception to be logged with the log entry. 
        /// </param>
        void Write(LogRank rank, string message, Exception exception = null);

        ILogSection Section(LogRank? rank = null, string caption = null, int indent = 3, string sectionSuffix = null);
    }

    public interface ILogSection : ILog
    {
    }
}