using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using CyberSource.Utilities.Extensibility;

namespace CyberSource.Utilities.Serialization
{
    /// <summary>
    /// SDK-owned wrapper around the <see cref="JsonSerializerOptions"/> used for response-payload
    /// deserialization by <see cref="CyberSource.Client.ApiClient.Deserialize(System.Net.Http.HttpResponseMessage, System.Type)"/>
    /// AND for the extra-field read path in <see cref="ModelExtensions.GetExtraField{TValue}(string)"/> and
    /// <see cref="ModelExtensions.TryGetExtraField{TValue}(string, out TValue)"/>.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Deliberately distinct from <see cref="SdkSerializerOptions"/> so that the SDK's
    /// serialization and deserialization pipelines never share an options instance. Consumers can
    /// post-configure the two independently through
    /// <see cref="Microsoft.Extensions.Options.IPostConfigureOptions{TOptions}"/>.
    /// </para>
    /// <para>
    /// The parameterless constructor seeds <see cref="Options"/> with a fresh
    /// <see cref="JsonSerializerDefaults.Web"/> instance. The SDK's
    /// <see cref="SdkDeserializerOptionsPostConfigure"/> layers the mandatory converters and
    /// <see cref="JsonIgnoreCondition.WhenWritingNull"/> on top so this class remains safe to
    /// construct in isolation.
    /// </para>
    /// </remarks>
    public sealed class SdkDeserializerOptions
    {
        /// <summary>
        /// Gets or sets the <see cref="JsonSerializerOptions"/> instance carried by this wrapper.
        /// Post-configure implementations mutate this instance in place; readers observe the fully
        /// post-configured value.
        /// </summary>
        public JsonSerializerOptions Options { get; set; } = new JsonSerializerOptions(JsonSerializerDefaults.Web)
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };
    }
}
