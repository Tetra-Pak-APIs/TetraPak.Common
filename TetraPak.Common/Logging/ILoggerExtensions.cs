using System;
using Microsoft.Extensions.Logging;

namespace TetraPak.Logging
{
    public static class LoggerExtensions
    {
        public static string Prefix { get; set; } = "------> ";

        public static void Debug(this ILogger logger, string message)
        {
            // ReSharper disable once TemplateIsNotCompileTimeConstantProblem
            logger?.LogDebug($"{Prefix}{message}");
        }
        
        public static void Warning(this ILogger logger, string message)
        {
            // ReSharper disable once TemplateIsNotCompileTimeConstantProblem
            logger?.LogWarning($"{Prefix}{message}");
        }

        public static void Information(this ILogger logger, string message)
        {
            // ReSharper disable once TemplateIsNotCompileTimeConstantProblem
            logger?.LogInformation($"{Prefix}{message}");
        }
        
        public static void Error(this ILogger logger, Exception exception, string message)
        {
            // ReSharper disable once TemplateIsNotCompileTimeConstantProblem
            logger?.LogError(exception, $"{Prefix}{message}");
        }
    }
}