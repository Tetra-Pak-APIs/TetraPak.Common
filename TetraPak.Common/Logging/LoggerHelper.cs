using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using Microsoft.Extensions.Logging;

#nullable enable

namespace TetraPak.Logging
{
    public static class LoggerHelper
    {
        /// <summary>
        ///   Generates and returns a string to reflect the state of an object.
        /// </summary>
        /// <param name="obj">
        ///   The object.
        /// </param>
        /// <param name="options">
        ///   Specifies how to render state from the specified object. 
        /// </param>
        /// <returns>
        ///   A JSON formatted string, reflecting the object's current state.
        /// </returns>
        /// <seealso cref="RestrictedValueAttribute"/>
        public static string GetStateDump(this object obj, StateDumpOptions options)
        {
            const int Indent = 3;
            var sb = new StringBuilder();
            renderObjectState(obj, 0);
            return sb.ToString();

            void renderObjectState(object o, int indent)
            {
                var objectIndent = new string(' ', indent);
                var contentIndent = new string(' ', indent + Indent);
                sb.Append(objectIndent);
                if (o is StackTrace)
                {
                    sb.AppendLine("\"");
                    sb.AppendLine($"{o}\"");
                    return;
                }
                    
                sb.AppendLine("{");
                var propertyInfos = o.GetType().GetProperties().ToArray();
                var lastSeparatorIndex = -1;
                for (var i = 0; i < propertyInfos.Length; i++)
                {
                    var pi = propertyInfos[i];
                    if (!options.IsSet(pi.Name) && !options.IsOverridden(pi.Name))
                        continue;

                    sb.Append(contentIndent);
                    sb.Append('"');
                    sb.Append(pi.Name);
                    sb.Append('"');
                    sb.Append(": ");
                    var restricted = pi.GetCustomAttribute<RestrictedValueAttribute>();
                    var isRestricted = restricted is { };
                    if (restricted is { } && options.Logger is { })
                    {
                        isRestricted = !restricted.IsDisclosedForLogger(options.Logger);
                    }
                    var value = isRestricted 
                        ? getRestrictedJsonValue(pi, o) 
                        : getJsonValue(pi, o);
                    
                    sb.Append(value);
                    lastSeparatorIndex = sb.Length;
                    sb.AppendLine(",");
                }

                sb.Remove(lastSeparatorIndex, 1); // remove final separator (',')
                sb.Append(objectIndent);
                sb.AppendLine("}");
            }
            
            string getJsonValue(PropertyInfo propertyInfo, object o)
            {
                var value = options.TryGetOverridden(propertyInfo.Name, out var overridden)
                    ? overridden 
                    : propertyInfo.GetValue(o);
                if (value is null)
                    return "null";

                var result = value is bool || value.IsNumeric() && !propertyInfo.PropertyType.IsEnum 
                    ? value.ToString()?.ToLower()
                    : $"\"{value}\"";
                return result ?? "null";
            }
            
            string getRestrictedJsonValue(PropertyInfo propertyInfo, object o)
            {
                var value = options.TryGetOverridden(propertyInfo.Name, out var overridden)
                    ? overridden 
                    : propertyInfo.GetValue(o);

                return value is null 
                    ? "null" 
                    : "\"[**** RESTRICTED ****]\"";
            }
        }

        /// <summary>
        ///   Examines the <see cref="RestrictedValueAttribute"/> and returns a value indicating whether
        ///   the decorated value can be disclosed for a specified <see cref="ILogger"/>.
        /// </summary>
        /// <param name="self">
        ///   The attribute.
        /// </param>
        /// <param name="logger">
        ///   The intended logger provider.
        /// </param>
        /// <returns>
        ///   <c>true</c> if the decorated value can be disclosed for <paramref name="logger"/>;
        ///   otherwise <c>false</c>. 
        /// </returns>
        public static bool IsDisclosedForLogger(this RestrictedValueAttribute self, ILogger logger)
        {
            return self.DisclosureLogLevels.Any() && self.DisclosureLogLevels.Any(logger.IsEnabled);
        }
    }
}