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
    /// InlineResponse2004ResponseRecordAdditionalUpdates
    /// </summary>
    [DataContract]
    public partial class InlineResponse2004ResponseRecordAdditionalUpdates :  IEquatable<InlineResponse2004ResponseRecordAdditionalUpdates>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2004ResponseRecordAdditionalUpdates" /> class.
        /// </summary>
        /// <param name="CustomerId">CustomerId.</param>
        /// <param name="PaymentInstrumentId">PaymentInstrumentId.</param>
        /// <param name="Creator">Creator.</param>
        /// <param name="State">Valid Values:   * ACTIVE   * CLOSED .</param>
        /// <param name="Message">Message.</param>
        public InlineResponse2004ResponseRecordAdditionalUpdates(string CustomerId = default(string), string PaymentInstrumentId = default(string), string Creator = default(string), string State = default(string), string Message = default(string))
        {
            this.CustomerId = CustomerId;
            this.PaymentInstrumentId = PaymentInstrumentId;
            this.Creator = Creator;
            this.State = State;
            this.Message = Message;
        }
        
        /// <summary>
        /// Gets or Sets CustomerId
        /// </summary>
        [DataMember(Name="customerId", EmitDefaultValue=false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// Gets or Sets PaymentInstrumentId
        /// </summary>
        [DataMember(Name="paymentInstrumentId", EmitDefaultValue=false)]
        public string PaymentInstrumentId { get; set; }

        /// <summary>
        /// Gets or Sets Creator
        /// </summary>
        [DataMember(Name="creator", EmitDefaultValue=false)]
        public string Creator { get; set; }

        /// <summary>
        /// Valid Values:   * ACTIVE   * CLOSED 
        /// </summary>
        /// <value>Valid Values:   * ACTIVE   * CLOSED </value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2004ResponseRecordAdditionalUpdates {\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  PaymentInstrumentId: ").Append(PaymentInstrumentId).Append("\n");
            sb.Append("  Creator: ").Append(Creator).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(obj as InlineResponse2004ResponseRecordAdditionalUpdates);
        }

        /// <summary>
        /// Returns true if InlineResponse2004ResponseRecordAdditionalUpdates instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2004ResponseRecordAdditionalUpdates to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2004ResponseRecordAdditionalUpdates other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CustomerId == other.CustomerId ||
                    this.CustomerId != null &&
                    this.CustomerId.Equals(other.CustomerId)
                ) && 
                (
                    this.PaymentInstrumentId == other.PaymentInstrumentId ||
                    this.PaymentInstrumentId != null &&
                    this.PaymentInstrumentId.Equals(other.PaymentInstrumentId)
                ) && 
                (
                    this.Creator == other.Creator ||
                    this.Creator != null &&
                    this.Creator.Equals(other.Creator)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
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
                if (this.CustomerId != null)
                    hash = hash * 59 + this.CustomerId.GetHashCode();
                if (this.PaymentInstrumentId != null)
                    hash = hash * 59 + this.PaymentInstrumentId.GetHashCode();
                if (this.Creator != null)
                    hash = hash * 59 + this.Creator.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
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