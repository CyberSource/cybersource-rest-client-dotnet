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
    /// PtsV2PaymentsPost201ResponseProcessingInformationBankTransferOptions
    /// </summary>
    [DataContract]
    public partial class PtsV2PaymentsPost201ResponseProcessingInformationBankTransferOptions :  IEquatable<PtsV2PaymentsPost201ResponseProcessingInformationBankTransferOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PaymentsPost201ResponseProcessingInformationBankTransferOptions" /> class.
        /// </summary>
        /// <param name="SettlementMethod">Method used for settlement.  Possible values: - **A**: Automated Clearing House (default for credits and for transactions using Canadian dollars) - **F**: Facsimile draft (U.S. dollars only) - **B**: Best possible (U.S. dollars only) (default if the field has not already been configured for your merchant ID)  See \&quot;Settlement Delivery Methods,\&quot; page 44. .</param>
        /// <param name="FraudScreeningLevel">Level of fraud screening.  Possible values: - **1**: Validation — default if the field has not already been configured for your merchant ID - **2**: Verification  For a description of this feature and a list of supported processors, see \&quot;Verification and Validation,\&quot; page 24. .</param>
        public PtsV2PaymentsPost201ResponseProcessingInformationBankTransferOptions(string SettlementMethod = default(string), string FraudScreeningLevel = default(string))
        {
            this.SettlementMethod = SettlementMethod;
            this.FraudScreeningLevel = FraudScreeningLevel;
        }
        
        /// <summary>
        /// Method used for settlement.  Possible values: - **A**: Automated Clearing House (default for credits and for transactions using Canadian dollars) - **F**: Facsimile draft (U.S. dollars only) - **B**: Best possible (U.S. dollars only) (default if the field has not already been configured for your merchant ID)  See \&quot;Settlement Delivery Methods,\&quot; page 44. 
        /// </summary>
        /// <value>Method used for settlement.  Possible values: - **A**: Automated Clearing House (default for credits and for transactions using Canadian dollars) - **F**: Facsimile draft (U.S. dollars only) - **B**: Best possible (U.S. dollars only) (default if the field has not already been configured for your merchant ID)  See \&quot;Settlement Delivery Methods,\&quot; page 44. </value>
        [DataMember(Name="settlementMethod", EmitDefaultValue=false)]
        public string SettlementMethod { get; set; }

        /// <summary>
        /// Level of fraud screening.  Possible values: - **1**: Validation — default if the field has not already been configured for your merchant ID - **2**: Verification  For a description of this feature and a list of supported processors, see \&quot;Verification and Validation,\&quot; page 24. 
        /// </summary>
        /// <value>Level of fraud screening.  Possible values: - **1**: Validation — default if the field has not already been configured for your merchant ID - **2**: Verification  For a description of this feature and a list of supported processors, see \&quot;Verification and Validation,\&quot; page 24. </value>
        [DataMember(Name="fraudScreeningLevel", EmitDefaultValue=false)]
        public string FraudScreeningLevel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PaymentsPost201ResponseProcessingInformationBankTransferOptions {\n");
            sb.Append("  SettlementMethod: ").Append(SettlementMethod).Append("\n");
            sb.Append("  FraudScreeningLevel: ").Append(FraudScreeningLevel).Append("\n");
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
            return this.Equals(obj as PtsV2PaymentsPost201ResponseProcessingInformationBankTransferOptions);
        }

        /// <summary>
        /// Returns true if PtsV2PaymentsPost201ResponseProcessingInformationBankTransferOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PaymentsPost201ResponseProcessingInformationBankTransferOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PaymentsPost201ResponseProcessingInformationBankTransferOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SettlementMethod == other.SettlementMethod ||
                    this.SettlementMethod != null &&
                    this.SettlementMethod.Equals(other.SettlementMethod)
                ) && 
                (
                    this.FraudScreeningLevel == other.FraudScreeningLevel ||
                    this.FraudScreeningLevel != null &&
                    this.FraudScreeningLevel.Equals(other.FraudScreeningLevel)
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
                if (this.SettlementMethod != null)
                    hash = hash * 59 + this.SettlementMethod.GetHashCode();
                if (this.FraudScreeningLevel != null)
                    hash = hash * 59 + this.FraudScreeningLevel.GetHashCode();
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
            // SettlementMethod (string) maxLength
            if(this.SettlementMethod != null && this.SettlementMethod.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SettlementMethod, length must be less than 1.", new [] { "SettlementMethod" });
            }

            // FraudScreeningLevel (string) maxLength
            if(this.FraudScreeningLevel != null && this.FraudScreeningLevel.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FraudScreeningLevel, length must be less than 1.", new [] { "FraudScreeningLevel" });
            }

            yield break;
        }
    }

}