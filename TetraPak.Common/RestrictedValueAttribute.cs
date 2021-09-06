using System;
using Microsoft.Extensions.Logging;
using TetraPak.Logging;

namespace TetraPak
{
    /// <summary>
    ///   Decorating a property with this attribute indicates the property should not be disclosed
    ///   in log, traces or similar output when the declaring object's state is presented. 
    /// </summary>
    /// <seealso cref="StateDump"/>
    /// <seealso cref="WebLoggerHelper.GetStateDump"/>
    [AttributeUsage(AttributeTargets.Property)]
    public class RestrictedValueAttribute : Attribute
    {
        /// <summary>
        ///   Specifies a <see cref="LogLevel"/> at which the restricted value can be disclosed.
        /// </summary>
        public LogLevel[] DisclosureLogLevels { get; set; } = Array.Empty<LogLevel>();
    }
}