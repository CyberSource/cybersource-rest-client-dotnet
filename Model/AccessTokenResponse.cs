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
    /// AccessTokenResponse
    /// </summary>
    [DataContract]
    public partial class AccessTokenResponse : IEquatable<AccessTokenResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessTokenResponse" /> class.
        /// </summary>
        /// <param name="AccessToken">AccessToken.</param>
        /// <param name="TokenType">TokenType.</param>
        /// <param name="Scope">Scope.</param>
        /// <param name="ClientStatus">ClientStatus.</param>
        /// <param name="RefreshToken">RefreshToken.</param>
        /// <param name="ExpiresIn">ExpiresIn.</param>
        /// <param name="RefreshTokenExpiresIn">RefreshTokenExpiresIn.</param>
        public AccessTokenResponse(string AccessToken = default(string), string TokenType = default(string), string Scope = default(string), string ClientStatus = default(string), string RefreshToken = default(string), int ExpiresIn = default(int), int RefreshTokenExpiresIn = default(int))
        {
            this.AccessToken = AccessToken;
            this.TokenType = TokenType;
            this.Scope = Scope;
            this.ClientStatus = ClientStatus;
            this.RefreshToken = RefreshToken;
            this.ExpiresIn = ExpiresIn;
            this.RefreshTokenExpiresIn = RefreshTokenExpiresIn;
        }

        /// <summary>
        /// Gets or Sets AccessToken
        /// </summary>
        [DataMember(Name = "access_token", EmitDefaultValue = false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or Sets TokenType
        /// </summary>
        [DataMember(Name = "token_type", EmitDefaultValue = false)]
        public string TokenType { get; set; }

        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name = "scope", EmitDefaultValue = false)]
        public string Scope { get; set; }

        /// <summary>
        /// Gets or Sets ClientStatus
        /// </summary>
        [DataMember(Name = "client_status", EmitDefaultValue = false)]
        public string ClientStatus { get; set; }

        /// <summary>
        /// Gets or Sets RefreshToken
        /// </summary>
        [DataMember(Name = "refresh_token", EmitDefaultValue = false)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresIn
        /// </summary>
        [DataMember(Name = "expires_in", EmitDefaultValue = false)]
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// Gets or Sets RefreshTokenExpiresIn
        /// </summary>
        [DataMember(Name = "refresh_token_expires_in", EmitDefaultValue = false)]
        public int? RefreshTokenExpiresIn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessTokenResponse {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  ClientStatus: ").Append(ClientStatus).Append("\n");
            sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  RefreshTokenExpiresIn: ").Append(RefreshTokenExpiresIn).Append("\n");
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
            return this.Equals(obj as AccessTokenResponse);
        }

        /// <summary>
        /// Returns true if AccessTokenResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AccessTokenResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessTokenResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.AccessToken == other.AccessToken ||
                    this.AccessToken != null &&
                    this.AccessToken.Equals(other.AccessToken)
                ) &&
                (
                    this.TokenType == other.TokenType ||
                    this.TokenType != null &&
                    this.TokenType.Equals(other.TokenType)
                ) &&
                (
                    this.Scope == other.Scope ||
                    this.Scope != null &&
                    this.Scope.Equals(other.Scope)
                ) &&
                (
                    this.ClientStatus == other.ClientStatus ||
                    this.ClientStatus != null &&
                    this.ClientStatus.Equals(other.ClientStatus)
                ) &&
                (
                    this.RefreshToken == other.RefreshToken ||
                    this.RefreshToken != null &&
                    this.RefreshToken.Equals(other.RefreshToken)
                ) &&
                (
                    this.ExpiresIn == other.ExpiresIn ||
                    this.ExpiresIn != null &&
                    this.ExpiresIn.Equals(other.ExpiresIn)
                ) &&
                (
                    this.RefreshTokenExpiresIn == other.RefreshTokenExpiresIn ||
                    this.RefreshTokenExpiresIn != null &&
                    this.RefreshTokenExpiresIn.Equals(other.RefreshTokenExpiresIn)
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
                if (this.AccessToken != null)
                    hash = hash * 59 + this.AccessToken.GetHashCode();
                if (this.TokenType != null)
                    hash = hash * 59 + this.TokenType.GetHashCode();
                if (this.Scope != null)
                    hash = hash * 59 + this.Scope.GetHashCode();
                if (this.ClientStatus != null)
                    hash = hash * 59 + this.ClientStatus.GetHashCode();
                if (this.RefreshToken != null)
                    hash = hash * 59 + this.RefreshToken.GetHashCode();
                if (this.ExpiresIn != null)
                    hash = hash * 59 + this.ExpiresIn.GetHashCode();
                if (this.RefreshTokenExpiresIn != null)
                    hash = hash * 59 + this.RefreshTokenExpiresIn.GetHashCode();
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
