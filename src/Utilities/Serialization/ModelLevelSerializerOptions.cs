using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CyberSource.Utilities.Serialization
{
    public static class ModelLevelSerializerOptions
    {
        /// <summary>
        /// Shared, cached serializer options for model <c>ToJson()</c> diagnostic output.
        /// <see cref="JsonSerializerOptions"/> is expensive to construct (it builds internal
        /// metadata caches on first use), so a single static instance is reused across all
        /// model classes instead of allocating one per <c>ToJson()</c> call.
        /// </summary>
        internal static readonly JsonSerializerOptions ToJsonOptions = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };
    }
}
