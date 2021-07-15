using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;

namespace TetraPak.Logging
{
    /// <summary>
    ///   Adds convenient logging extension methods to an <see cref="ILogger"/> instance.
    /// </summary>
    public static class LoggerExtensions
    {
        /// <summary>
        ///   Gets (or sets) a default <see cref="string"/> value to be inserted as a prefix to all
        ///   log entries. This can be used to distinguish entries sourced by your code from other log entries..  
        /// </summary>
        // ReSharper disable once AutoPropertyCanBeMadeGetOnly.Global
        public static string Prefix { get; set; } = "------> ";

        /// <summary>
        ///   Writes a trace log entry in a standardized format.  
        /// </summary>
        /// <param name="logger">
        ///   The logging provider.
        /// </param>
        /// <param name="message">
        ///   A message to be written to <paramref name="logger"/>.
        /// </param>
        /// <param name="messageId">
        ///   (optional)<bt/>
        ///   A unique string value to be used for referencing/diagnostics purposes.
        /// </param>
        public static void Trace(this ILogger logger, string message, string messageId = null)
        {
            // ReSharper disable once TemplateIsNotCompileTimeConstantProblem
            logger?.LogTrace(Format(message, messageId));
        }
        
        /// <summary>
        ///   Writes a debug log entry in a standardized format.  
        /// </summary>
        /// <param name="logger">
        ///   The logging provider.
        /// </param>
        /// <param name="message">
        ///   A message to be written to <paramref name="logger"/>.
        /// </param>
        /// <param name="messageId">
        ///   (optional)<bt/>
        ///   A unique string value to be used for referencing/diagnostics purposes.
        /// </param>
        public static void Debug(this ILogger logger, string message, string messageId = null)
        {
            // ReSharper disable once TemplateIsNotCompileTimeConstantProblem
            logger?.LogDebug(Format(message, messageId));
        }
        
        /// <summary>
        ///   Writes a warning log entry in a standardized format.  
        /// </summary>
        /// <param name="logger">
        ///   The logging provider.
        /// </param>
        /// <param name="message">
        ///   A message to be written to <paramref name="logger"/>.
        /// </param>
        /// <param name="messageId">
        ///   (optional)<bt/>
        ///   A unique string value to be used for referencing/diagnostics purposes.
        /// </param>
        public static void Warning(this ILogger logger, string message, string messageId = null)
        {
            // ReSharper disable once TemplateIsNotCompileTimeConstantProblem
            logger?.LogWarning(Format(message, messageId));
        }

        /// <summary>
        ///   Writes an information log entry in a standardized format.  
        /// </summary>
        /// <param name="logger">
        ///   The logging provider.
        /// </param>
        /// <param name="message">
        ///   A message to be written to <paramref name="logger"/>.
        /// </param>
        /// <param name="messageId">
        ///   (optional)<bt/>
        ///   A unique string value to be used for referencing/diagnostics purposes.
        /// </param>
        public static void Information(this ILogger logger, string message, string messageId = null)
        {
            // ReSharper disable once TemplateIsNotCompileTimeConstantProblem
            logger?.LogInformation(Format(message, messageId));
        }
        
        /// <summary>
        ///   Writes an <see cref="Exception"/> (error) log entry in a standardized format.  
        /// </summary>
        /// <param name="logger">
        ///   The logging provider.
        /// </param>
        /// <param name="exception">
        ///   An <see cref="Exception"/> to be logged.
        /// </param>
        /// <param name="message">
        ///   A message to be written to <paramref name="logger"/>.
        /// </param>
        /// <param name="messageId">
        ///   (optional)<bt/>
        ///   A unique string value to be used for referencing/diagnostics purposes.
        /// </param>
        public static void Error(this ILogger logger, Exception exception, string message = null, string messageId = null)
        {
            var logMessage = Format(exception, message, messageId);
            // ReSharper disable once TemplateIsNotCompileTimeConstantProblem
            logger?.LogError(exception, logMessage);
        }

        /// <summary>
        ///   Create a standardized logging format and returns the result.
        /// </summary>
        /// <param name="message">
        ///   The message to be logged.
        /// </param>
        /// <param name="messageId">
        ///   (optional)<bt/>
        ///   A unique string value to be used for referencing/diagnostics purposes.
        /// </param>
        /// <returns>
        ///   A standardized logging message (<see cref="string"/> value).
        /// </returns>
        public static string Format(string message, string messageId = null)
        {
            return string.IsNullOrEmpty(messageId) 
                ? $"{Prefix}{message}"
                : $"{Prefix} [{messageId}] {message}";
        }

        /// <summary>
        ///   Creates a standardized logging error format and returns the result.
        /// </summary>
        /// <param name="exception">
        ///   An <see cref="Exception"/> to be logged.
        /// </param>
        /// <param name="message">
        ///   A message to be logged.
        /// </param>
        /// <param name="messageId">
        ///   (optional)<bt/>
        ///   A unique string value to be used for referencing/diagnostics purposes.
        /// </param>
        /// <returns>
        ///   A standardized logging message (<see cref="string"/> value).
        /// </returns>
        public static string Format(Exception exception, string message, string messageId = null)
        {
            return string.IsNullOrEmpty(messageId)
                ? $"{Prefix}{message ?? exception.Message}"
                : $"{Prefix} [{messageId}] {message ?? exception.Message}";
        }

        /// <summary>
        ///   Writes the contents of a <see cref="IDictionary{TKey,TValue}"/> to a <see cref="ILogger"/>
        ///   for a specified <see cref="LogLevel"/>.
        /// </summary>
        /// <param name="logger">
        ///   The logging provider.
        /// </param>
        /// <param name="dictionary">
        ///   The dictionary to be written.
        /// </param>
        /// <param name="level">
        ///   The <see cref="LogLevel"/> to be used for teh log entry.
        /// </param>
        /// <typeparam name="TKey">
        ///   The dictionary key <see cref="Type"/>.
        /// </typeparam>
        /// <typeparam name="TValue">
        ///   The dictionary value <see cref="Type"/>.
        /// </typeparam>
        public static void LogDictionary<TKey,TValue>(
            this ILogger logger, 
            IDictionary<TKey,TValue> dictionary, 
            LogLevel level)
        {
            // ReSharper disable once TemplateIsNotCompileTimeConstantProblem
            var message = new StringBuilder();
            foreach (var (key, value) in dictionary)
            {
                message.AppendLine($"{key.ToString()}={value?.ToString()}");
            }
            logger.Log(level, "{Prefix}{Message}", Prefix, message);
        }
    }
}