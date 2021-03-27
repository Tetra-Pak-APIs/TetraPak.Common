using System;
using System.Text.Json;
using DynamicEntity = tetrapak.dynamicEntities.DynamicEntity;

namespace tetrapak.serialization
{
    /// <summary>
    ///   A slower but more flexible JSON converter. This might come in handy when dealing with
    ///   an inconsistent api that can't be relied on to serialize the same data type consistently
    ///   at all times (such as <c>true</c> or sometimes <c>"True"</c> for booleans).
    /// </summary>
    /// <typeparam name="T">
    ///   The type of (<see cref="DynamicEntity"/>) type to be converted.
    /// </typeparam>
    public class DynamicEntitySafeJsonConverter<T> : DynamicEntityJsonConverter<T>
    where T : DynamicEntity
    {
        protected override object OnReadValueFromPropertyType(
            ref Utf8JsonReader reader, 
            Type propertyType, 
            string key,
            JsonSerializerOptions options)
        {
            if (!propertyType.IsValueType)
                try
                {
                    return base.OnReadValueFromPropertyType(ref reader, propertyType, key, options);
                }
                catch (Exception ex)
                {
                    WriteError(ex, $"When reading value for '{key}' (Last ID={LastId})");
                    return null;
                }

            var isNullable = propertyType.IsNullable(); 

            try
            {
                var value = base.OnReadValueFromPropertyType(ref reader, typeof(object), key, options);
                var typeCode = Type.GetTypeCode(isNullable ? Nullable.GetUnderlyingType(propertyType) : propertyType);
                if (value is JsonElement jsonElement)
                {
                    // ReSharper disable HeapView.BoxingAllocation
                    if (typeCode == TypeCode.Boolean)
                        return asBoolean(jsonElement, isNullable);

                    if (propertyType.IsNumeric())
                        return asNumeric(jsonElement, propertyType, isNullable);
                        
                    return base.OnReadValueFromPropertyType(ref reader, propertyType, key, options);
                }
                
                
                // ReSharper disable HeapView.BoxingAllocation
                switch (typeCode)
                {
                    case TypeCode.Boolean:
                        if (value is null)
                            return isNullable ? (object) null : false;
                            
                        if (value is string s)
                            return bool.TryParse(s, out var bValue) ? bValue : interpretBoolean(s);

                        return !value.IsZero();

                    case TypeCode.Decimal:
                    case TypeCode.Byte:
                    case TypeCode.SByte:
                    case TypeCode.Double:
                    case TypeCode.Int16:
                    case TypeCode.Int32:
                    case TypeCode.Int64:
                    case TypeCode.UInt16:
                    case TypeCode.UInt32:
                    case TypeCode.UInt64:
                    case TypeCode.Single:
                        return value switch
                        {
                            null => isNullable ? null : Convert.ChangeType(0, propertyType),
                            _ => value
                        };

                    default:
                        return base.OnReadValueFromPropertyType(ref reader, propertyType, key, options);
                }
                // ReSharper restore HeapView.BoxingAllocation
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        static object asNumeric(JsonElement jsonElement, Type propertyType, bool isNullable)
        {
            // ReSharper disable HeapView.BoxingAllocation
            switch (jsonElement.ValueKind)
            {
                case JsonValueKind.String:
                    var s = jsonElement.GetString();
                    return interpretNumeric(s, propertyType, isNullable);
                
                case JsonValueKind.Number:
                    var typeCode = Type.GetTypeCode(isNullable ? Nullable.GetUnderlyingType(propertyType) : propertyType);
                    return typeCode switch
                    {
                        TypeCode.Decimal => jsonElement.GetDecimal(),
                        TypeCode.Byte => jsonElement.GetByte(),
                        TypeCode.SByte => jsonElement.GetSByte(),
                        TypeCode.Int16 => jsonElement.GetInt16(),
                        TypeCode.Int32 => jsonElement.GetInt32(),
                        TypeCode.Int64 => jsonElement.GetInt64(),
                        TypeCode.UInt16 => jsonElement.GetUInt16(),
                        TypeCode.UInt32 => jsonElement.GetUInt32(),
                        TypeCode.UInt64 => jsonElement.GetUInt64(),
                        TypeCode.Single => jsonElement.GetSingle(),
                        TypeCode.Double => jsonElement.GetDouble(),
                        _ => 0
                    };
                
                case JsonValueKind.Null:
                    return isNullable ? (object) null : false;

                default:
                    return false;
            }
            // ReSharper restore HeapView.BoxingAllocation
        }

        static object interpretNumeric(string s, Type propertyType, bool isNullable)
        {
            var typeCode = Type.GetTypeCode(isNullable ? Nullable.GetUnderlyingType(propertyType) : propertyType);
            return typeCode switch
            {
                TypeCode.Decimal => decimal.Parse(s),
                TypeCode.Byte => byte.Parse(s),
                TypeCode.SByte => sbyte.Parse(s),
                TypeCode.Double => double.Parse(s),
                TypeCode.Int16 => short.Parse(s),
                TypeCode.Int32 => short.Parse(s),
                TypeCode.Int64 => long.Parse(s),
                TypeCode.UInt16 => ushort.Parse(s),
                TypeCode.UInt32 => uint.Parse(s),
                TypeCode.UInt64 => ulong.Parse(s),
                TypeCode.Single => float.Parse(s),
                _ => 0
            };
        }

        static object asBoolean(JsonElement jsonElement, bool isNullable)
        {
            // ReSharper disable HeapView.BoxingAllocation
            switch (jsonElement.ValueKind)
            {
                case JsonValueKind.String:
                    var s = jsonElement.GetString();
                    return interpretBoolean(s);
                
                case JsonValueKind.False:
                    return false;
                
                case JsonValueKind.True:
                    return true;
                
                case JsonValueKind.Number:
                    var d = jsonElement.GetDecimal();
                    return !d.IsZero();
                
                case JsonValueKind.Null:
                    return isNullable ? (object) null : false;

                default:
                    return false;
            }
            // ReSharper restore HeapView.BoxingAllocation
        }

        static bool interpretBoolean(string s)
        {
            if (s is null)
                return false;
                
            if (bool.TryParse(s, out var b))
                return b;

            if (double.TryParse(s.ToLower(), out var d))
                return !d.IsZero();

            return s.Equals("yes", StringComparison.InvariantCultureIgnoreCase);
        }
    }
}