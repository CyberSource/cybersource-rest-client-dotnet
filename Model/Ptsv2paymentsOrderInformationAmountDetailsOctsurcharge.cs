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
    /// Ptsv2paymentsOrderInformationAmountDetailsOctsurcharge
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsOrderInformationAmountDetailsOctsurcharge :  IEquatable<Ptsv2paymentsOrderInformationAmountDetailsOctsurcharge>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsOrderInformationAmountDetailsOctsurcharge" /> class.
        /// </summary>
        /// <param name="Amount">The surcharge amount is included in the total transaction amount but is passed in a separate field to the issuer and acquirer for tracking.  The issuer can provide information about the surcharge amount to the customer.   If the amount is positive, then it is a debit for the customer.   If the amount is negative, then it is a credit for the customer. .</param>
        public Ptsv2paymentsOrderInformationAmountDetailsOctsurcharge(string Amount = default(string))
        {
            this.Amount = Amount;
        }
        
        /// <summary>
        /// The surcharge amount is included in the total transaction amount but is passed in a separate field to the issuer and acquirer for tracking.  The issuer can provide information about the surcharge amount to the customer.   If the amount is positive, then it is a debit for the customer.   If the amount is negative, then it is a credit for the customer. 
        /// </summary>
        /// <value>The surcharge amount is included in the total transaction amount but is passed in a separate field to the issuer and acquirer for tracking.  The issuer can provide information about the surcharge amount to the customer.   If the amount is positive, then it is a debit for the customer.   If the amount is negative, then it is a credit for the customer. </value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsOrderInformationAmountDetailsOctsurcharge {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsOrderInformationAmountDetailsOctsurcharge);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsOrderInformationAmountDetailsOctsurcharge instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsOrderInformationAmountDetailsOctsurcharge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsOrderInformationAmountDetailsOctsurcharge other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
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
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
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