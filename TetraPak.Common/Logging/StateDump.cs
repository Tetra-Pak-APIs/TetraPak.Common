using System;
using System.Diagnostics;
using System.Text;
using Microsoft.Extensions.Logging;

#nullable enable

namespace TetraPak.Logging
{
    /// <summary>
    ///   Assists in creating a well formatted state dump of one or more objects.
    /// </summary>
    /// <seealso cref="RestrictedValueAttribute"/>
    public class StateDump
    {
        readonly StringBuilder _stringBuilder = new();
        readonly ILogger? _logger;

        StackTrace? _stackTrace;

        /// <summary>
        ///   Adds an object (a "<paramref name="source"/>) to the state dump.
        /// </summary>
        /// <param name="source">
        ///   The object to be added.
        /// </param>
        /// <param name="name">
        ///   (optional; default = <see cref="Type"/> of <paramref name="source"/>)<br/>
        ///   A name for the source. 
        /// </param>
        /// <param name="options">
        ///   (optional)<br/>
        ///   Specifies options for dumping the state of <paramref name="source"/>.
        /// </param>
        /// <exception cref="ArgumentNullException">
        ///   <paramref name="source"/> was unassigned.
        /// </exception>
        /// <seealso cref="StateDumpOptions"/>
        /// <seealso cref="RestrictedValueAttribute"/>
        public void Add(object source, string? name = null, StateDumpOptions? options = null)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            if (options is null)
            {
                options = new StateDumpOptions(source);
                if (_logger is { })
                {
                    options.WithTargetLogger(_logger);
                }
            }

            name ??= source.GetType().FullName;
            add(_stringBuilder, source, name!, options);
        }

        static void add(StringBuilder sb, object source, string name, StateDumpOptions options)
        {
            sb.Append('"');
            sb.Append(name);
            sb.Append(": ");
            sb.AppendLine(source.GetStateDump(options));
        }
        
        /// <summary>
        ///   Invoking this method will have a <see cref="StateDump"/> include a stacktrace.   
        /// </summary>
        /// <param name="skipFrames">
        ///   (optional; default = 1)<br/>
        ///   Specifies how many stacktrace frames to be removed from the end of the stacktrace.
        ///   This is to avoid including frames representing calls to the state dump logic itself.
        /// </param>
        /// <returns>
        ///   This object (fluent API).
        /// </returns>
        public StateDump WithStackTrace(int skipFrames = 1)
        {
            _stackTrace = new StackTrace(skipFrames);
            return this;
        }

        /// <summary>
        ///   Overrides the base method to also add a prefix and suffix to the state dump.
        /// </summary>
        /// <returns>
        ///   A <see cref="string"/> presenting the state dump, with a prefix/suffix pair for easy recognition. 
        /// </returns>
        /// <see cref="ToString(string)"/>
        public override string ToString() => ToString("STATE DUMP");

        /// <summary>
        ///   Returns the <see cref="StateDump"/>'s textual representation.
        /// </summary>
        /// <param name="caption">
        ///   (optional; default="STATE DUMP)<br/>
        ///   A caption to be included in the state dump prefix and suffix elements.
        /// </param>
        /// <returns>
        ///   A <see cref="string"/> presenting the state dump, with a prefix/suffix pair for easy recognition. 
        /// </returns>
        public string ToString(string caption)
        {
            caption = string.IsNullOrWhiteSpace(caption) ? "STATE DUMP" : caption;
            var sb = new StringBuilder();
            sb.AppendLine($">===== {caption} BEGIN =====<");
            sb.AppendLine(_stringBuilder.ToString());
            if (_stackTrace is {})
            {
                addStackTrace(sb);
            }
            sb.AppendLine($">====== {caption} END ======<");
            return sb.ToString();
        }

        void addStackTrace(StringBuilder sb)
        {
            add(sb, _stackTrace!, "StackTrace", null!);
        }

        public StateDump(ILogger? logger = null)
        {
            _logger = logger;
        }
    }
}