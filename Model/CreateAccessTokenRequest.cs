using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// CreateAccessTokenRequest
    /// </summary>
    [DataContract]
    public partial class CreateAccessTokenRequest : IEquatable<CreateAccessTokenRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAccessTokenRequest" /> class.
        /// </summary>
        /// <param name="GrantType">GrantType.</param>
        /// <param name="Code">Code.</param>
        /// <param name="ClientId">ClientId.</param>
        /// <param name="ClientSecret">ClientSecret.</param>
        /// <param name="RefreshToken">RefreshToken.</param>
        public CreateAccessTokenRequest(string GrantType = default(string), string Code = default(string), string ClientId = default(string), string ClientSecret = default(string), string RefreshToken = default(string))
        {
            this.GrantType = GrantType;
            this.Code = Code;
            this.ClientId = ClientId;
            this.ClientSecret = ClientSecret;
            this.RefreshToken = RefreshToken;
        }

        /// <summary>
        /// Gets or Sets GrantType
        /// </summary>
        [DataMember(Name = "grant_type", EmitDefaultValue = false)]
        public string GrantType { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets ClientId
        /// </summary>
        [DataMember(Name = "client_id", EmitDefaultValue = false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or Sets ClientSecret
        /// </summary>
        [DataMember(Name = "client_secret", EmitDefaultValue = false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Gets or Sets RefreshToken
        /// </summary>
        [DataMember(Name = "refresh_token", EmitDefaultValue = false)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAccessTokenRequest {\n");
            sb.Append("  GrantType: ").Append(GrantType).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as CreateAccessTokenRequest);
        }

        /// <summary>
        /// Returns true if CreateAccessTokenRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateAccessTokenRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateAccessTokenRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.GrantType == other.GrantType ||
                    this.GrantType != null &&
                    this.GrantType.Equals(other.GrantType)
                ) &&
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) &&
                (
                    this.ClientId == other.ClientId ||
                    this.ClientId != null &&
                    this.ClientId.Equals(other.ClientId)
                ) &&
                (
                    this.ClientSecret == other.ClientSecret ||
                    this.ClientSecret != null &&
                    this.ClientSecret.Equals(other.ClientSecret)
                ) &&
                (
                    this.RefreshToken == other.RefreshToken ||
                    this.RefreshToken != null &&
                    this.RefreshToken.Equals(other.RefreshToken)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.GrantType != null)
                    hash = hash * 59 + this.GrantType.GetHashCode();
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this.ClientId != null)
                    hash = hash * 59 + this.ClientId.GetHashCode();
                if (this.ClientSecret != null)
                    hash = hash * 59 + this.ClientSecret.GetHashCode();
                if (this.RefreshToken != null)
                    hash = hash * 59 + this.RefreshToken.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
