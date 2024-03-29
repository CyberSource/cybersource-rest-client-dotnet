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
    /// Contains embedded actions, that includes status and response for every actions in the list.
    /// </summary>
    [DataContract]
    public partial class PtsV2PaymentsPost201ResponseEmbeddedActions :  IEquatable<PtsV2PaymentsPost201ResponseEmbeddedActions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PaymentsPost201ResponseEmbeddedActions" /> class.
        /// </summary>
        /// <param name="CAPTURE">CAPTURE.</param>
        /// <param name="DECISION">DECISION.</param>
        /// <param name="CONSUMER_AUTHENTICATION">CONSUMER_AUTHENTICATION.</param>
        /// <param name="VALIDATE_CONSUMER_AUTHENTICATION">VALIDATE_CONSUMER_AUTHENTICATION.</param>
        /// <param name="WATCHLIST_SCREENING">WATCHLIST_SCREENING.</param>
        public PtsV2PaymentsPost201ResponseEmbeddedActions(PtsV2PaymentsPost201ResponseEmbeddedActionsCAPTURE CAPTURE = default(PtsV2PaymentsPost201ResponseEmbeddedActionsCAPTURE), PtsV2PaymentsPost201ResponseEmbeddedActionsDECISION DECISION = default(PtsV2PaymentsPost201ResponseEmbeddedActionsDECISION), PtsV2PaymentsPost201ResponseEmbeddedActionsCONSUMERAUTHENTICATION CONSUMER_AUTHENTICATION = default(PtsV2PaymentsPost201ResponseEmbeddedActionsCONSUMERAUTHENTICATION), PtsV2PaymentsPost201ResponseEmbeddedActionsCONSUMERAUTHENTICATION VALIDATE_CONSUMER_AUTHENTICATION = default(PtsV2PaymentsPost201ResponseEmbeddedActionsCONSUMERAUTHENTICATION), PtsV2PaymentsPost201ResponseEmbeddedActionsWATCHLISTSCREENING WATCHLIST_SCREENING = default(PtsV2PaymentsPost201ResponseEmbeddedActionsWATCHLISTSCREENING))
        {
            this.CAPTURE = CAPTURE;
            this.DECISION = DECISION;
            this.CONSUMER_AUTHENTICATION = CONSUMER_AUTHENTICATION;
            this.VALIDATE_CONSUMER_AUTHENTICATION = VALIDATE_CONSUMER_AUTHENTICATION;
            this.WATCHLIST_SCREENING = WATCHLIST_SCREENING;
        }
        
        /// <summary>
        /// Gets or Sets CAPTURE
        /// </summary>
        [DataMember(Name="CAPTURE", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseEmbeddedActionsCAPTURE CAPTURE { get; set; }

        /// <summary>
        /// Gets or Sets DECISION
        /// </summary>
        [DataMember(Name="DECISION", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseEmbeddedActionsDECISION DECISION { get; set; }

        /// <summary>
        /// Gets or Sets CONSUMER_AUTHENTICATION
        /// </summary>
        [DataMember(Name="CONSUMER_AUTHENTICATION", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseEmbeddedActionsCONSUMERAUTHENTICATION CONSUMER_AUTHENTICATION { get; set; }

        /// <summary>
        /// Gets or Sets VALIDATE_CONSUMER_AUTHENTICATION
        /// </summary>
        [DataMember(Name="VALIDATE_CONSUMER_AUTHENTICATION", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseEmbeddedActionsCONSUMERAUTHENTICATION VALIDATE_CONSUMER_AUTHENTICATION { get; set; }

        /// <summary>
        /// Gets or Sets WATCHLIST_SCREENING
        /// </summary>
        [DataMember(Name="WATCHLIST_SCREENING", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseEmbeddedActionsWATCHLISTSCREENING WATCHLIST_SCREENING { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PaymentsPost201ResponseEmbeddedActions {\n");
            sb.Append("  CAPTURE: ").Append(CAPTURE).Append("\n");
            sb.Append("  DECISION: ").Append(DECISION).Append("\n");
            sb.Append("  CONSUMER_AUTHENTICATION: ").Append(CONSUMER_AUTHENTICATION).Append("\n");
            sb.Append("  VALIDATE_CONSUMER_AUTHENTICATION: ").Append(VALIDATE_CONSUMER_AUTHENTICATION).Append("\n");
            sb.Append("  WATCHLIST_SCREENING: ").Append(WATCHLIST_SCREENING).Append("\n");
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
            return this.Equals(obj as PtsV2PaymentsPost201ResponseEmbeddedActions);
        }

        /// <summary>
        /// Returns true if PtsV2PaymentsPost201ResponseEmbeddedActions instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PaymentsPost201ResponseEmbeddedActions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PaymentsPost201ResponseEmbeddedActions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CAPTURE == other.CAPTURE ||
                    this.CAPTURE != null &&
                    this.CAPTURE.Equals(other.CAPTURE)
                ) && 
                (
                    this.DECISION == other.DECISION ||
                    this.DECISION != null &&
                    this.DECISION.Equals(other.DECISION)
                ) && 
                (
                    this.CONSUMER_AUTHENTICATION == other.CONSUMER_AUTHENTICATION ||
                    this.CONSUMER_AUTHENTICATION != null &&
                    this.CONSUMER_AUTHENTICATION.Equals(other.CONSUMER_AUTHENTICATION)
                ) && 
                (
                    this.VALIDATE_CONSUMER_AUTHENTICATION == other.VALIDATE_CONSUMER_AUTHENTICATION ||
                    this.VALIDATE_CONSUMER_AUTHENTICATION != null &&
                    this.VALIDATE_CONSUMER_AUTHENTICATION.Equals(other.VALIDATE_CONSUMER_AUTHENTICATION)
                ) && 
                (
                    this.WATCHLIST_SCREENING == other.WATCHLIST_SCREENING ||
                    this.WATCHLIST_SCREENING != null &&
                    this.WATCHLIST_SCREENING.Equals(other.WATCHLIST_SCREENING)
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
                if (this.CAPTURE != null)
                    hash = hash * 59 + this.CAPTURE.GetHashCode();
                if (this.DECISION != null)
                    hash = hash * 59 + this.DECISION.GetHashCode();
                if (this.CONSUMER_AUTHENTICATION != null)
                    hash = hash * 59 + this.CONSUMER_AUTHENTICATION.GetHashCode();
                if (this.VALIDATE_CONSUMER_AUTHENTICATION != null)
                    hash = hash * 59 + this.VALIDATE_CONSUMER_AUTHENTICATION.GetHashCode();
                if (this.WATCHLIST_SCREENING != null)
                    hash = hash * 59 + this.WATCHLIST_SCREENING.GetHashCode();
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
