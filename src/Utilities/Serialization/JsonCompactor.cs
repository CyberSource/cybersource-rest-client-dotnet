using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CyberSource.Utilities.Serialization
{
    internal sealed class JsonCompactor
    {
        private static readonly JsonSerializerOptions _options = new JsonSerializerOptions
        {
            WriteIndented = false
        };

        public static string CompactJsonForPrinting(string json)
        {
            if (string.IsNullOrWhiteSpace(json))
            {
                return json;
            }

            try
            {
                using JsonDocument document = JsonDocument.Parse(json);

                string prettyJson = JsonSerializer.Serialize(document.RootElement, _options);

                return prettyJson;
            } catch (JsonException)
            {
                return json;
            }
        }
    }
}
