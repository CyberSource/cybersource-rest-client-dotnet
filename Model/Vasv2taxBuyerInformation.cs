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
    /// Vasv2taxBuyerInformation
    /// </summary>
    [DataContract]
    public partial class Vasv2taxBuyerInformation :  IEquatable<Vasv2taxBuyerInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Vasv2taxBuyerInformation" /> class.
        /// </summary>
        /// <param name="VatRegistrationNumber">Customer&#39;s government-assigned tax identification number.  #### Tax Calculation Optional for international and value added taxes only. Not applicable to U.S. and Canadian taxes. .</param>
        public Vasv2taxBuyerInformation(string VatRegistrationNumber = default(string))
        {
            this.VatRegistrationNumber = VatRegistrationNumber;
        }
        
        /// <summary>
        /// Customer&#39;s government-assigned tax identification number.  #### Tax Calculation Optional for international and value added taxes only. Not applicable to U.S. and Canadian taxes. 
        /// </summary>
        /// <value>Customer&#39;s government-assigned tax identification number.  #### Tax Calculation Optional for international and value added taxes only. Not applicable to U.S. and Canadian taxes. </value>
        [DataMember(Name="vatRegistrationNumber", EmitDefaultValue=false)]
        public string VatRegistrationNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Vasv2taxBuyerInformation {\n");
            if (VatRegistrationNumber != null) sb.Append("  VatRegistrationNumber: ").Append(VatRegistrationNumber).Append("\n");
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
            return this.Equals(obj as Vasv2taxBuyerInformation);
        }

        /// <summary>
        /// Returns true if Vasv2taxBuyerInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Vasv2taxBuyerInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Vasv2taxBuyerInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.VatRegistrationNumber == other.VatRegistrationNumber ||
                    this.VatRegistrationNumber != null &&
                    this.VatRegistrationNumber.Equals(other.VatRegistrationNumber)
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
                if (this.VatRegistrationNumber != null)
                    hash = hash * 59 + this.VatRegistrationNumber.GetHashCode();
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
