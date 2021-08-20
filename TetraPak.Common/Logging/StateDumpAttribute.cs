using System;
using Microsoft.Extensions.Logging;

namespace TetraPak.Logging
{
    /// <summary>
    ///   Add this attribute to properties of classes that are to be included in a "state dump".
    /// </summary>
    /// <seealso cref="LoggerHelper.GetStateDump"/>
    /// <seealso cref="StateDumpOptions"/>
    public class StateDumpAttribute : Attribute
    {
        /// <summary>
        ///   Specifies a minimum <see cref="LogLevel"/> for this attribute to be included in a "state dump".
        /// </summary>
        /// <seealso cref="LoggerHelper.GetStateDump"/>
        /// <seealso cref="StateDumpOptions"/>
        public LogLevel LogLevel { get; set; }

        /// <summary>
        ///   Initializes the <see cref="StateDumpAttribute"/>.
        /// </summary>
        /// <param name="logLevel">
        ///   Initializes the <see cref="LogLevel"/> property.
        /// </param>
        public StateDumpAttribute(LogLevel logLevel = LogLevel.Debug)
        {
            LogLevel = logLevel;
        }
    }
}