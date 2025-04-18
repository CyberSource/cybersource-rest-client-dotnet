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
    /// InlineResponse4001
    /// </summary>
    [DataContract]
    public partial class InlineResponse4001 :  IEquatable<InlineResponse4001>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse4001" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineResponse4001() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse4001" /> class.
        /// </summary>
        /// <param name="CorrelationId">CorrelationId.</param>
        /// <param name="Details">Details.</param>
        /// <param name="InformationLink">InformationLink.</param>
        /// <param name="Message">Message (required).</param>
        /// <param name="Reason">Possible values: - INVALID_APIKEY - INVALID_SHIPPING_INPUT_PARAMS - CAPTURE_CONTEXT_INVALID - CAPTURE_CONTEXT_EXPIRED - SDK_XHR_ERROR - UNIFIEDPAYMENTS_VALIDATION_PARAMS - UNIFIEDPAYMENTS_VALIDATION_FIELDS - UNIFIEDPAYMENT_PAYMENT_PARAMITERS - CREATE_TOKEN_TIMEOUT - CREATE_TOKEN_XHR_ERROR - SHOW_LOAD_CONTAINER_SELECTOR - SHOW_LOAD_INVALID_CONTAINER - SHOW_TOKEN_TIMEOUT - SHOW_TOKEN_XHR_ERROR - SHOW_PAYMENT_TIMEOUT (required).</param>
        public InlineResponse4001(string CorrelationId = default(string), List<InlineResponse4001Details> Details = default(List<InlineResponse4001Details>), string InformationLink = default(string), string Message = default(string), string Reason = default(string))
        {
            this.CorrelationId = CorrelationId;
            this.Details = Details;
            this.InformationLink = InformationLink;
            this.Message = Message;
            this.Reason = Reason;
        }
        
        /// <summary>
        /// Gets or Sets CorrelationId
        /// </summary>
        [DataMember(Name="correlationId", EmitDefaultValue=false)]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public List<InlineResponse4001Details> Details { get; set; }

        /// <summary>
        /// Gets or Sets InformationLink
        /// </summary>
        [DataMember(Name="informationLink", EmitDefaultValue=false)]
        public string InformationLink { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Possible values: - INVALID_APIKEY - INVALID_SHIPPING_INPUT_PARAMS - CAPTURE_CONTEXT_INVALID - CAPTURE_CONTEXT_EXPIRED - SDK_XHR_ERROR - UNIFIEDPAYMENTS_VALIDATION_PARAMS - UNIFIEDPAYMENTS_VALIDATION_FIELDS - UNIFIEDPAYMENT_PAYMENT_PARAMITERS - CREATE_TOKEN_TIMEOUT - CREATE_TOKEN_XHR_ERROR - SHOW_LOAD_CONTAINER_SELECTOR - SHOW_LOAD_INVALID_CONTAINER - SHOW_TOKEN_TIMEOUT - SHOW_TOKEN_XHR_ERROR - SHOW_PAYMENT_TIMEOUT
        /// </summary>
        /// <value>Possible values: - INVALID_APIKEY - INVALID_SHIPPING_INPUT_PARAMS - CAPTURE_CONTEXT_INVALID - CAPTURE_CONTEXT_EXPIRED - SDK_XHR_ERROR - UNIFIEDPAYMENTS_VALIDATION_PARAMS - UNIFIEDPAYMENTS_VALIDATION_FIELDS - UNIFIEDPAYMENT_PAYMENT_PARAMITERS - CREATE_TOKEN_TIMEOUT - CREATE_TOKEN_XHR_ERROR - SHOW_LOAD_CONTAINER_SELECTOR - SHOW_LOAD_INVALID_CONTAINER - SHOW_TOKEN_TIMEOUT - SHOW_TOKEN_XHR_ERROR - SHOW_PAYMENT_TIMEOUT</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse4001 {\n");
            if (CorrelationId != null) sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            if (Details != null) sb.Append("  Details: ").Append(Details).Append("\n");
            if (InformationLink != null) sb.Append("  InformationLink: ").Append(InformationLink).Append("\n");
            if (Message != null) sb.Append("  Message: ").Append(Message).Append("\n");
            if (Reason != null) sb.Append("  Reason: ").Append(Reason).Append("\n");
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
            return this.Equals(obj as InlineResponse4001);
        }

        /// <summary>
        /// Returns true if InlineResponse4001 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse4001 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse4001 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CorrelationId == other.CorrelationId ||
                    this.CorrelationId != null &&
                    this.CorrelationId.Equals(other.CorrelationId)
                ) && 
                (
                    this.Details == other.Details ||
                    this.Details != null &&
                    this.Details.SequenceEqual(other.Details)
                ) && 
                (
                    this.InformationLink == other.InformationLink ||
                    this.InformationLink != null &&
                    this.InformationLink.Equals(other.InformationLink)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
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
                if (this.CorrelationId != null)
                    hash = hash * 59 + this.CorrelationId.GetHashCode();
                if (this.Details != null)
                    hash = hash * 59 + this.Details.GetHashCode();
                if (this.InformationLink != null)
                    hash = hash * 59 + this.InformationLink.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
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
