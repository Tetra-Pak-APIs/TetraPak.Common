﻿using System.Linq;
using System.Reflection;
using System.Text;

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
                    var isRestricted = pi.GetCustomAttribute<RestrictedValueAttribute>() is { };
                    var value = isRestricted && !options.DiscloseSensitiveData
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
            
            // void renderChildStateIfApplicable(PropertyInfo propertyInfo, object o, int indent) obsolete
            // {
            //     if (propertyInfo.CanRead && options.IsSubOptionsSet(o))
            //         renderObjectState(propertyInfo.GetValue(o), indent);
            // }
            
            string getJsonValue(PropertyInfo propertyInfo, object o)
            {
                var value = options.TryGetOverridden(propertyInfo.Name, out var overridden)
                    ? overridden 
                    : propertyInfo.GetValue(o);
                if (value is null)
                    return "null";
                
                return value is bool || value.IsNumeric() && !propertyInfo.PropertyType.IsEnum 
                    ? value.ToString()?.ToLower()
                    : $"\"{value}\"";
            }
            
            string getRestrictedJsonValue(PropertyInfo propertyInfo, object o)
            {
                var value = options.TryGetOverridden(propertyInfo.Name, out var overridden)
                    ? overridden 
                    : propertyInfo.GetValue(o);

                return value is null 
                    ? "null" 
                    : "\"**** RESTRICTED ****\"";
            }
        }
    }
}