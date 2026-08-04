using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using CyberSource.Utilities.Extensibility;

namespace CyberSource.Utilities.Serialization
{
    /// <summary>
    /// SDK-owned wrapper around the <see cref="JsonSerializerOptions"/> used for request-payload
    /// serialization by <see cref="CyberSource.Client.ApiClient.Serialize(object)"/> AND for the
    /// extra-field write path in <see cref="ModelExtensions.SetExtraField(string, object)"/>.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Using an SDK-owned wrapper (rather than binding directly to <see cref="JsonSerializerOptions"/>)
    /// scopes every registered <see cref="Microsoft.Extensions.Options.IPostConfigureOptions{TOptions}"/>
    /// exclusively to the CyberSource pipeline. An unrelated library that also uses
    /// <see cref="JsonSerializerOptions"/> in the same DI container cannot accidentally trigger — or be
    /// mutated by — the SDK's serialization post-configure.
    /// </para>
    /// <para>
    /// The parameterless constructor seeds <see cref="Options"/> with a fresh instance carrying the
    /// SDK's baseline serialization defaults: <see cref="JsonSerializerDefaults.Web"/> naming/reads
    /// and <see cref="JsonIgnoreCondition.WhenWritingNull"/>. The SDK's
    /// <see cref="SdkSerializerOptionsPostConfigure"/> layers the mandatory invariants on top
    /// (the <c>EnforceExtraFieldConflicts</c> resolver and required converters) so this class stays
    /// safe to construct in isolation without duplicating the invariant list.
    /// </para>
    /// </remarks>
    public sealed class SdkSerializerOptions
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
