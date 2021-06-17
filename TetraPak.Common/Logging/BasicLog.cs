using System;

// NOTE: ignores warning about 'Logged' never being used 
#pragma warning disable 0067

namespace TetraPak.Logging
{
    /// <summary>
    ///   Provides a very basic <see cref="ILog"/> implementation.
    /// </summary>
    /// <remarks>
    ///   Invoking the different log methods of this implementation simply
    ///   triggers the <see cref="Logged"/> event. This can be utilized to
    ///   dispatch the actual log entries to various logging solutions.
    /// </remarks>
    public class BasicLog : ILog
    {
        /// <inheritdoc />
        public event EventHandler<TextLogEventArgs> Logged;

        /// <inheritdoc />
        public QueryAsyncDelegate QueryAsync { get; set; }

        /// <inheritdoc />
        public void Debug(string message)
        {
            Logged?.Invoke(this, new TextLogEventArgs(LogRank.Debug, message));
        }

        /// <inheritdoc />
        public void Warning(string message)
        {
            Logged?.Invoke(this, new TextLogEventArgs(LogRank.Warning, message));
        }

        /// <inheritdoc />
        public void Error(Exception exception, string message = null)
        {
            Logged?.Invoke(this, new TextLogEventArgs(LogRank.Error, message, exception));
        }

        public void Any(string message)
        {
            Logged?.Invoke(this, new TextLogEventArgs(LogRank.Any, message));
        }

        public void Write(LogRank rank, string message, Exception exception = null)
        {
            switch (rank)
            {
                case LogRank.Debug:
                    Debug(message);
                    break;
                case LogRank.Info:
                    Info(message);
                    break;
                case LogRank.Warning:
                    Warning(message);
                    break;
                case LogRank.Error:
                    Error(exception, message);
                    break;
                case LogRank.Any:
                    Any(message);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(rank), rank, null);
            }
        }

        public ILogSection Section(LogRank? rank = null, string caption = null, int indent = 3, string sectionSuffix = null)
        {
            return new BasicLogSection(this, rank ?? LogRank.Any, caption);
        }

        /// <inheritdoc />
        public void Info(string message)
        {
            Logged?.Invoke(this, new TextLogEventArgs(LogRank.Info, message));
        }

        protected virtual void Dispose(bool disposing)
        {
            // currently no implementation at this level
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }

    // ReSharper disable once ClassWithVirtualMembersNeverInherited.Global
    class BasicLogSection : ILogSection
    {
        readonly ILog _log;
        readonly LogRank _logRank; // todo is rank really necessary for a log section? This implementation uses the original log anyway
        readonly string _indent;
        readonly int _indentLength;
        readonly string _sectionSuffix;
        bool _isDisposed;

        public event EventHandler<TextLogEventArgs> Logged;

        public QueryAsyncDelegate QueryAsync { get; set; }
        public void Debug(string message) => _log.Debug(indentMessage(message));

        public void Info(string message) => _log.Info(indentMessage(message));

        public void Warning(string message) => _log.Warning(indentMessage(message));

        public void Error(Exception exception, string message = null) => _log.Error(exception, indentMessage(message));

        public void Any(string message) => _log.Any(indentMessage(message));

        public void Write(LogRank rank, string message, Exception exception = null) => _log.Write(rank, indentMessage(message), exception);

        string indentMessage(string message)
        {
            if (_isDisposed) throw new InvalidOperationException("Invalid attempt to log using a disposed log section");
            return message is null ? null : $"{_indent}{message}";
        }

        /// <inheritdoc />
        public ILogSection Section(LogRank? rank = LogRank.Any, string caption = null, int indent = 3, string sectionSuffix = null)
        {
            return new BasicLogSection(this, rank ?? LogRank.Any, caption, _indentLength);
        }
        
        public BasicLogSection(ILog log, LogRank logRank, string caption, int indentLength = 3, string sectionSuffix = null)
        {
            _log = log;
            _logRank = logRank;
            _indentLength = indentLength;
            _indent = new string(' ', indentLength);
            _sectionSuffix = sectionSuffix;
            if (!string.IsNullOrEmpty(caption))
            {
                log.Write(logRank, caption);
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing || _isDisposed) 
                return;
            
            _log.Write(_logRank, _sectionSuffix);
            _isDisposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}