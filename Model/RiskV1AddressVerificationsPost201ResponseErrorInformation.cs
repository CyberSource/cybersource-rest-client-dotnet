/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

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
    /// RiskV1AddressVerificationsPost201ResponseErrorInformation
    /// </summary>
    [DataContract]
    public partial class RiskV1AddressVerificationsPost201ResponseErrorInformation :  IEquatable<RiskV1AddressVerificationsPost201ResponseErrorInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RiskV1AddressVerificationsPost201ResponseErrorInformation" /> class.
        /// </summary>
        /// <param name="Reason">The reason of the status. Value can be   - &#x60;APARTMENT_NUMBER_NOT_FOUND&#x60;   - &#x60;INSUFFICIENT_ADDRESS_INFORMATION&#x60;   - &#x60;HOUSE_OR_BOX_NUMBER_NOT_FOUND&#x60;   - &#x60;MULTIPLE_ADDRESS_MATCHES&#x60;   - &#x60;BOX_NUMBER_NOT_FOUND&#x60;   - &#x60;ROUTE_SERVICE_NOT_FOUND&#x60;   - &#x60;STREET_NAME_NOT_FOUND&#x60;   - &#x60;POSTAL_CODE_NOT_FOUND&#x60;   - &#x60;UNVERIFIABLE_ADDRESS&#x60;   - &#x60;MULTIPLE_ADDRESS_MATCHES_INTERNATIONAL&#x60;   - &#x60;ADDRESS_MATCH_NOT_FOUND&#x60;   - &#x60;UNSUPPORTED_CHARACTER_SET&#x60;   - &#x60;INVALID_MERCHANT_CONFIGURATION&#x60; .</param>
        /// <param name="Message">The detail message related to the status and reason listed above..</param>
        /// <param name="Details">Details.</param>
        public RiskV1AddressVerificationsPost201ResponseErrorInformation(string Reason = default(string), string Message = default(string), List<PtsV2PaymentsPost201ResponseErrorInformationDetails> Details = default(List<PtsV2PaymentsPost201ResponseErrorInformationDetails>))
        {
            this.Reason = Reason;
            this.Message = Message;
            this.Details = Details;
        }
        
        /// <summary>
        /// The reason of the status. Value can be   - &#x60;APARTMENT_NUMBER_NOT_FOUND&#x60;   - &#x60;INSUFFICIENT_ADDRESS_INFORMATION&#x60;   - &#x60;HOUSE_OR_BOX_NUMBER_NOT_FOUND&#x60;   - &#x60;MULTIPLE_ADDRESS_MATCHES&#x60;   - &#x60;BOX_NUMBER_NOT_FOUND&#x60;   - &#x60;ROUTE_SERVICE_NOT_FOUND&#x60;   - &#x60;STREET_NAME_NOT_FOUND&#x60;   - &#x60;POSTAL_CODE_NOT_FOUND&#x60;   - &#x60;UNVERIFIABLE_ADDRESS&#x60;   - &#x60;MULTIPLE_ADDRESS_MATCHES_INTERNATIONAL&#x60;   - &#x60;ADDRESS_MATCH_NOT_FOUND&#x60;   - &#x60;UNSUPPORTED_CHARACTER_SET&#x60;   - &#x60;INVALID_MERCHANT_CONFIGURATION&#x60; 
        /// </summary>
        /// <value>The reason of the status. Value can be   - &#x60;APARTMENT_NUMBER_NOT_FOUND&#x60;   - &#x60;INSUFFICIENT_ADDRESS_INFORMATION&#x60;   - &#x60;HOUSE_OR_BOX_NUMBER_NOT_FOUND&#x60;   - &#x60;MULTIPLE_ADDRESS_MATCHES&#x60;   - &#x60;BOX_NUMBER_NOT_FOUND&#x60;   - &#x60;ROUTE_SERVICE_NOT_FOUND&#x60;   - &#x60;STREET_NAME_NOT_FOUND&#x60;   - &#x60;POSTAL_CODE_NOT_FOUND&#x60;   - &#x60;UNVERIFIABLE_ADDRESS&#x60;   - &#x60;MULTIPLE_ADDRESS_MATCHES_INTERNATIONAL&#x60;   - &#x60;ADDRESS_MATCH_NOT_FOUND&#x60;   - &#x60;UNSUPPORTED_CHARACTER_SET&#x60;   - &#x60;INVALID_MERCHANT_CONFIGURATION&#x60; </value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// The detail message related to the status and reason listed above.
        /// </summary>
        /// <value>The detail message related to the status and reason listed above.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public List<PtsV2PaymentsPost201ResponseErrorInformationDetails> Details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RiskV1AddressVerificationsPost201ResponseErrorInformation {\n");
            if (Reason != null) sb.Append("  Reason: ").Append(Reason).Append("\n");
            if (Message != null) sb.Append("  Message: ").Append(Message).Append("\n");
            if (Details != null) sb.Append("  Details: ").Append(Details).Append("\n");
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
            return this.Equals(obj as RiskV1AddressVerificationsPost201ResponseErrorInformation);
        }

        /// <summary>
        /// Returns true if RiskV1AddressVerificationsPost201ResponseErrorInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of RiskV1AddressVerificationsPost201ResponseErrorInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RiskV1AddressVerificationsPost201ResponseErrorInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.Details == other.Details ||
                    this.Details != null &&
                    this.Details.SequenceEqual(other.Details)
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
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.Details != null)
                    hash = hash * 59 + this.Details.GetHashCode();
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
