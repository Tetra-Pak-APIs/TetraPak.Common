using System;
using System.Linq;
using System.Text;
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
        
        internal static string ToStringValues(this IConfiguration self, bool recursive = false, int indent = 0)
        {
            if (self.IsEmpty())
                return string.Empty;

            var indentation = indent == 0 ? string.Empty : new string(' ', indent);
            var children = self.GetChildren();
            var sb = new StringBuilder();
            foreach (var child in children)
            {
                sb.Append(indentation);
                sb.Append(child.Key);
                sb.Append(": ");
                if (child.Value is { })
                {
                    sb.AppendLine(child.Value);
                    continue;
                }

                if (!child.GetChildren().Any())
                {
                    sb.AppendLine("(empty)");
                    continue;
                }

                if (!recursive)
                {
                    sb.AppendLine("{ ... }");
                    continue;
                }

                sb.AppendLine(" {");
                sb.AppendLine(child.ToStringValues(true, indent + 3));
                sb.Append(indentation);
                sb.AppendLine("}");
            }

            return sb.ToString();
        }
    }
}