using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CyberSource.Utilities.Serialization
{
    public sealed class StringOrNumberConverter : JsonConverter<string>
    {
        public override string Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.String:
                    return reader.GetString();

                case JsonTokenType.Number:
                    if (reader.TryGetInt64(out long longValue))
                    {
                        return longValue.ToString(CultureInfo.InvariantCulture);
                    }

                    if (reader.TryGetDecimal(out decimal decimalValue))
                    {
                        return decimalValue.ToString(CultureInfo.InvariantCulture);
                    }

                    return reader.GetDouble().ToString(CultureInfo.InvariantCulture);

                case JsonTokenType.True:
                    return "true";

                case JsonTokenType.False:
                    return "false";

                case JsonTokenType.Null:
                    return null;

                default:
                    throw new JsonException(
                        $"Cannot convert JSON token {reader.TokenType} to string.");
            }
        }

        public override void Write(
            Utf8JsonWriter writer,
            string value,
            JsonSerializerOptions options)
        {
            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(value);
            }
        }
    }
}