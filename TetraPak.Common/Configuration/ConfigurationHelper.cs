using System;
using System.Linq;
using Microsoft.Extensions.Configuration;

namespace TetraPak.Configuration
{
    public static class ConfigurationHelper
    {
        public static bool ContainsKey(this IConfiguration configuration, string key, bool ignoreCase = false)
        {
            if (configuration is null)
                return false;

            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentNullException(nameof(key));

            var children = configuration.GetChildren();
            return ignoreCase 
                ? children.Any(i => i.Key.Equals(key, StringComparison.InvariantCultureIgnoreCase)) 
                : children.Any(i => i.Key == key);
        }

        public static bool IsEmpty(this IConfiguration configuration)
        {
            if (configuration is null)
                throw new ArgumentNullException(nameof(configuration));

            return !configuration.GetChildren().Any();
        }
    }
}