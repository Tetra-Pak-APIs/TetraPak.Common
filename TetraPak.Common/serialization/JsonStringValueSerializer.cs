using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace tetrapak.serialization
{
    public class JsonStringValueSerializer<T> : JsonConverter<T> where T : IStringValue
    {
        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            try
            {
                var s = reader.GetString();
                if (s is null)
                    return default;

                typeToConvert.TryDeserializeStringValue(s, out var o);
                return (T) o;
            }
            catch (Exception ex)
            {
                reader.Skip();
                var error = (T) Activator.CreateInstance(typeof(T), $"{StringValueError.Qualifier} {ex.Message}");
                return error;
            }
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.StringValue);
        }
    }
}