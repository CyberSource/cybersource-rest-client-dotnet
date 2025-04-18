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
    /// Tmsv2customersMerchantDefinedInformation
    /// </summary>
    [DataContract]
    public partial class Tmsv2customersMerchantDefinedInformation :  IEquatable<Tmsv2customersMerchantDefinedInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tmsv2customersMerchantDefinedInformation" /> class.
        /// </summary>
        /// <param name="Name">The number you assign as the name for your merchant-defined data or secure field. Possible Values are data1 to data4 and sensitive1 to sensitive4  For example, to set the name for merchant-defined data 2 field, you would reference merchantDefinedInformation[x].name as data2 Possible Values: - data1 - data2 - data3 - data4 - sensitive1 - sensitive2 - sensitive3 - sensitive4 .</param>
        /// <param name="Value">The value you assign for your merchant-defined data field.  **Warning** Merchant-defined data fields are not intended to and must not be used to capture personally identifying information. Accordingly, merchants are prohibited from capturing, obtaining, and/or transmitting any personally identifying information in or via the merchant-defined data fields. Personally identifying information includes, but is not limited to, address, credit card number, social security number, driver&#39;s license number, state-issued identification number, passport number, and card verification numbers (CVV, CVC2, CVV2, CID, CVN). In the event it is discovered a merchant is capturing and/or transmitting personally identifying information via the merchant-defined data fields, whether or not intentionally, the merchant&#39;s account will immediately be suspended, which will result in a rejection of any and all transaction requests submitted by the merchant after the point of suspension. .</param>
        public Tmsv2customersMerchantDefinedInformation(string Name = default(string), string Value = default(string))
        {
            this.Name = Name;
            this.Value = Value;
        }
        
        /// <summary>
        /// The number you assign as the name for your merchant-defined data or secure field. Possible Values are data1 to data4 and sensitive1 to sensitive4  For example, to set the name for merchant-defined data 2 field, you would reference merchantDefinedInformation[x].name as data2 Possible Values: - data1 - data2 - data3 - data4 - sensitive1 - sensitive2 - sensitive3 - sensitive4 
        /// </summary>
        /// <value>The number you assign as the name for your merchant-defined data or secure field. Possible Values are data1 to data4 and sensitive1 to sensitive4  For example, to set the name for merchant-defined data 2 field, you would reference merchantDefinedInformation[x].name as data2 Possible Values: - data1 - data2 - data3 - data4 - sensitive1 - sensitive2 - sensitive3 - sensitive4 </value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The value you assign for your merchant-defined data field.  **Warning** Merchant-defined data fields are not intended to and must not be used to capture personally identifying information. Accordingly, merchants are prohibited from capturing, obtaining, and/or transmitting any personally identifying information in or via the merchant-defined data fields. Personally identifying information includes, but is not limited to, address, credit card number, social security number, driver&#39;s license number, state-issued identification number, passport number, and card verification numbers (CVV, CVC2, CVV2, CID, CVN). In the event it is discovered a merchant is capturing and/or transmitting personally identifying information via the merchant-defined data fields, whether or not intentionally, the merchant&#39;s account will immediately be suspended, which will result in a rejection of any and all transaction requests submitted by the merchant after the point of suspension. 
        /// </summary>
        /// <value>The value you assign for your merchant-defined data field.  **Warning** Merchant-defined data fields are not intended to and must not be used to capture personally identifying information. Accordingly, merchants are prohibited from capturing, obtaining, and/or transmitting any personally identifying information in or via the merchant-defined data fields. Personally identifying information includes, but is not limited to, address, credit card number, social security number, driver&#39;s license number, state-issued identification number, passport number, and card verification numbers (CVV, CVC2, CVV2, CID, CVN). In the event it is discovered a merchant is capturing and/or transmitting personally identifying information via the merchant-defined data fields, whether or not intentionally, the merchant&#39;s account will immediately be suspended, which will result in a rejection of any and all transaction requests submitted by the merchant after the point of suspension. </value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Tmsv2customersMerchantDefinedInformation {\n");
            if (Name != null) sb.Append("  Name: ").Append(Name).Append("\n");
            if (Value != null) sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(obj as Tmsv2customersMerchantDefinedInformation);
        }

        /// <summary>
        /// Returns true if Tmsv2customersMerchantDefinedInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Tmsv2customersMerchantDefinedInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Tmsv2customersMerchantDefinedInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
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
