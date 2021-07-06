using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using TetraPak.Configuration;
using TetraPak.Logging;

namespace TetraPak
{
    /// <summary>
    ///   Provides convenience extension methods for managing configuration. 
    /// </summary>
    public static class ConfigurationHelper
    {
        /// <summary>
        ///   Gets the name of the running ASP.NET Core environment
        ///   ("<c>ASPNETCORE_ENVIRONMENT</c>" environment variable). 
        /// </summary>
        /// <returns>
        ///   The name of the running ASP.NET Core web environment.
        /// </returns>
        public static string GetWebEnvironment(this IConfiguration _)
        {
            return Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", EnvironmentVariableTarget.Process);
        }
        
        /// <summary>
        ///   Gets a <see cref="bool"/> value indicating whether the process is running in development mode.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if the web host is running in development mode; otherwise <c>false</c>. 
        /// </returns>
        public static bool IsWebDevelopment(this IConfiguration self)
        {
            var environment = self.GetWebEnvironment();
            return environment == "Development";
        }

        public static T GetValue<T>(this IConfigurationSection section, string key, T useDefault, ValueParser<T> parser)
        {
            var s = section[key];
            if (string.IsNullOrEmpty(s))
                return useDefault;

            return !parser(s, out var value) 
                ? useDefault 
                : value;
        }

        public static List<T> GetList<T>(this IConfiguration configuration, string key, ILogger logger = null)
        {
            try
            {
                return configuration.GetSection(key).Get<List<T>>();
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"Invalid configuration section: '{key}'. {ex}");
                return new List<T>();
            }
        }
        
        public static T[] GetArray<T>(this IConfiguration configuration, string key, ILogger logger = null)
        {
            try
            {
                return configuration.GetList<T>(key).ToArray();
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"Invalid configuration section: '{key}'. {ex}");
                return Array.Empty<T>();
            }
        }
            
        /// <summary>
        ///   Gets a <see cref="bool"/> value from the section, or a specified default value.
        /// </summary>
        /// <param name="section">
        ///   The configuration section.
        /// </param>
        /// <param name="key">
        ///   Identifies the value.
        /// </param>
        /// <param name="useDefault">
        ///   A default value to be used if the requested <paramref name="key"/> is not found.
        /// </param>
        /// <returns>
        ///   A <see cref="bool"/> value.
        /// </returns>
        public static bool GetBool(this IConfigurationSection section, string key, bool useDefault)
        {
            return section.GetNullableBool(key, useDefault) ?? useDefault;
        }

        /// <summary>
        ///   Gets a nullable <see cref="bool"/> value from the section, or (optionally) a specified default value.
        /// </summary>
        /// <param name="section">
        ///   The configuration section.
        /// </param>
        /// <param name="key">
        ///   Identifies the value.
        /// </param>
        /// <param name="useDefault">
        ///   (optional)<br/>
        ///   A default value to be used if the requested <paramref name="key"/> is not found.
        /// </param>
        /// <returns>
        ///   A <see cref="bool"/> value, or null if <paramref name="key"/> was not found
        ///   and no <paramref name="useDefault"/> value was passed.
        /// </returns>
        public static bool? GetNullableBool(this IConfigurationSection section, string key, bool? useDefault = null)
        {
            return section[key].TryParseConfiguredBool(out var value)
                ? value
                : useDefault;
        }

        /// <summary>
        ///   Parses a <see cref="string"/> as a configured <see cref="bool"/> value. 
        /// </summary>
        /// <param name="stringValue">
        ///   The (configured) <see cref="bool"/> string representation.
        /// </param>
        /// <param name="value">
        ///   Passes back the parsed boolean value.
        /// </param>
        /// <returns>
        ///   <c>true</c> if <paramref name="stringValue"/> was successfully parsed; otherwise <c>false</c>.
        /// </returns>
        /// <remarks>
        ///   A configured <see cref="bool"/> value accepts three forms:
        ///   <list type="bullet">
        ///     <item>
        ///       <term>true/false</term>
        ///       <description>
        ///       - Just use standard C# identifiers <c>true</c> or <c>false</c> (not case sensitive).
        ///       </description>
        ///     </item>
        ///     <item>
        ///       <term>yes/no</term>
        ///       <description>
        ///       - Use plain English words <c>yes</c> or <c>no</c> for true/false (not case sensitive).
        ///       </description>
        ///     </item>
        ///     <item>
        ///       <term>1/0</term>
        ///       <description>
        ///       - Use numbers <c>1</c> or <c>0</c> for true/false.
        ///       </description>
        ///     </item>
        ///   </list>
        /// </remarks>
        public static bool TryParseConfiguredBool(
            this string stringValue, 
            out bool value)
        {
            value = false;
            if (string.IsNullOrWhiteSpace(stringValue))
                return false;
            
            if (bool.TryParse(stringValue.ToLowerInvariant(), out value))
                return true;

            switch (stringValue)
            {
                case "1":
                    return true;
                case "0":
                    return false;
            }

            if (stringValue.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
            {
                value = true;
                return true;
            }

            if (stringValue.Equals("no", StringComparison.InvariantCultureIgnoreCase))
            {
                value = false;
                return true;
            }

            return false;
        }
        
        /// <summary>
        ///   Parses a <see cref="string"/> as a configured <see cref="TimeSpan"/> value. 
        /// </summary>
        /// <param name="stringValue">
        ///   The (configured) <see cref="TimeSpan"/> string representation.
        /// </param>
        /// <param name="value">
        ///   Passes back the parsed <see cref="TimeSpan"/> value.
        /// </param>
        /// <returns>
        ///   <c>true</c> if <paramref name="stringValue"/> was successfully parsed; otherwise <c>false</c>.
        /// </returns>
        /// <remarks>
        ///   A configured <see cref="TimeSpan"/> value accepts two forms:
        ///   <list type="bullet">
        ///     <item>
        ///       <term>hh:mm:ss</term>
        ///       <description>
        ///       - Use standard C# syntax for <see cref="TimeSpan"/> string representation.
        ///       </description>
        ///     </item>
        ///     <item>
        ///       <term>seconds</term>
        ///       <description>
        ///       - Use integer value to express <see cref="TimeSpan"/> in seconds.
        ///       </description>
        ///     </item>
        ///   </list>
        /// </remarks>
        public static bool TryParseConfiguredTimeSpan(this string stringValue, out TimeSpan value) 
        {
            if (int.TryParse(stringValue, out var seconds))
            {
                value = TimeSpan.FromSeconds(seconds);
                return true;
            }

            if (TimeSpan.TryParse(stringValue, out var timeSpan))
            {
                value = timeSpan;
                return true;
            }

            value = TimeSpan.Zero;
            return false;
        }
    }
}