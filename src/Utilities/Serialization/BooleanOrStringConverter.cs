using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CyberSource.Utilities.Serialization
{
    public sealed class BooleanOrStringConverter : JsonConverter<bool>
    {
        public override bool Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.True:
                    return true;

                case JsonTokenType.False:
                    return false;

                case JsonTokenType.String:
                    string value = reader.GetString();

                    if (bool.TryParse(value, out bool boolValue))
                    {
                        return boolValue;
                    }

                    throw new JsonException(
                        $"Cannot convert string value '{value}' to bool.");

                default:
                    throw new JsonException(
                        $"Cannot convert JSON token {reader.TokenType} to bool.");
            }
        }

        public override void Write(
            Utf8JsonWriter writer,
            bool value,
            JsonSerializerOptions options)
        {
            writer.WriteBooleanValue(value);
        }
    }
}
