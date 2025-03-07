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
    /// Ptsv2paymentsidcapturesOrderInformationShippingDetails
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsidcapturesOrderInformationShippingDetails :  IEquatable<Ptsv2paymentsidcapturesOrderInformationShippingDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsidcapturesOrderInformationShippingDetails" /> class.
        /// </summary>
        /// <param name="ShipFromPostalCode">Postal code for the address from which the goods are shipped, which is used to establish nexus. The default is the postal code associated with your CyberSource account.  The postal code must consist of 5 to 9 digits. When the billing country is the U.S., the 9-digit postal code must follow this format:  &#x60;[5 digits][dash][4 digits]&#x60;  Example 12345-6789  When the billing country is Canada, the 6-digit postal code must follow this format:  &#x60;[alpha][numeric][alpha][space] [numeric][alpha][numeric]&#x60;  Example A1B 2C3  This field is frequently used for Level II and Level III transactions. .</param>
        public Ptsv2paymentsidcapturesOrderInformationShippingDetails(string ShipFromPostalCode = default(string))
        {
            this.ShipFromPostalCode = ShipFromPostalCode;
        }
        
        /// <summary>
        /// Postal code for the address from which the goods are shipped, which is used to establish nexus. The default is the postal code associated with your CyberSource account.  The postal code must consist of 5 to 9 digits. When the billing country is the U.S., the 9-digit postal code must follow this format:  &#x60;[5 digits][dash][4 digits]&#x60;  Example 12345-6789  When the billing country is Canada, the 6-digit postal code must follow this format:  &#x60;[alpha][numeric][alpha][space] [numeric][alpha][numeric]&#x60;  Example A1B 2C3  This field is frequently used for Level II and Level III transactions. 
        /// </summary>
        /// <value>Postal code for the address from which the goods are shipped, which is used to establish nexus. The default is the postal code associated with your CyberSource account.  The postal code must consist of 5 to 9 digits. When the billing country is the U.S., the 9-digit postal code must follow this format:  &#x60;[5 digits][dash][4 digits]&#x60;  Example 12345-6789  When the billing country is Canada, the 6-digit postal code must follow this format:  &#x60;[alpha][numeric][alpha][space] [numeric][alpha][numeric]&#x60;  Example A1B 2C3  This field is frequently used for Level II and Level III transactions. </value>
        [DataMember(Name="shipFromPostalCode", EmitDefaultValue=false)]
        public string ShipFromPostalCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsidcapturesOrderInformationShippingDetails {\n");
            if (ShipFromPostalCode != null) sb.Append("  ShipFromPostalCode: ").Append(ShipFromPostalCode).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsidcapturesOrderInformationShippingDetails);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsidcapturesOrderInformationShippingDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsidcapturesOrderInformationShippingDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsidcapturesOrderInformationShippingDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ShipFromPostalCode == other.ShipFromPostalCode ||
                    this.ShipFromPostalCode != null &&
                    this.ShipFromPostalCode.Equals(other.ShipFromPostalCode)
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
                if (this.ShipFromPostalCode != null)
                    hash = hash * 59 + this.ShipFromPostalCode.GetHashCode();
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
