using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CyberSource.Utilities.Serialization
{
    /// <summary>
    /// SDK-owned wrapper around the <see cref="JsonSerializerOptions"/> used exclusively for the
    /// PBL (Payment Links) model deserialization path
    /// (<see cref="CyberSource.Model.PblPaymentLinksAllGet200Response"/>).
    /// </summary>
    /// <remarks>
    /// <para>
    /// Kept as a distinct wrapper from <see cref="SdkDeserializerOptions"/> because the PBL model
    /// requires <see cref="CustomContractResolver"/> as its
    /// <see cref="JsonSerializerOptions.PropertyNamingPolicy"/>, which differs from the default
    /// <see cref="JsonSerializerDefaults.Web"/> policy used for other CyberSource models. Merging
    /// the two would break either PBL deserialization or general-model deserialization.
    /// </para>
    /// <para>
    /// This type is <c>internal</c> because the PBL invariants are non-negotiable: consumers must
    /// not be able to post-configure the PBL options wrapper (neither through
    /// <see cref="Microsoft.Extensions.Options.IPostConfigureOptions{TOptions}"/> nor through any
    /// direct-injection fluent surface). The PBL track is derived entirely from the general
    /// <see cref="SdkDeserializerOptions"/> monitor / seed, with the SDK's PBL invariants applied
    /// on top by <see cref="SdkPblDeserializerOptionsPostConfigure.Apply(JsonSerializerOptions)"/>.
    /// </para>
    /// </remarks>
    internal sealed class SdkPblDeserializerOptions
    {
        /// <summary>
        /// Gets or sets the <see cref="JsonSerializerOptions"/> instance carried by this wrapper.
        /// Post-configure implementations mutate this instance in place; readers observe the fully
        /// post-configured value.
        /// </summary>
        public JsonSerializerOptions Options { get; set; } = new JsonSerializerOptions
        {
            PropertyNamingPolicy = new CustomContractResolver(),
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };
    }
}
