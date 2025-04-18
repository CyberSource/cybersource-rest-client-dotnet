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
    /// PtsV2ModifyBillingAgreementPost201ResponseOrderInformationShipTo
    /// </summary>
    [DataContract]
    public partial class PtsV2ModifyBillingAgreementPost201ResponseOrderInformationShipTo :  IEquatable<PtsV2ModifyBillingAgreementPost201ResponseOrderInformationShipTo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2ModifyBillingAgreementPost201ResponseOrderInformationShipTo" /> class.
        /// </summary>
        /// <param name="FirstName">First name of the recipient. .</param>
        /// <param name="LastName">Last name of the recipient. .</param>
        /// <param name="Address1">First line of the shipping address. .</param>
        /// <param name="Address2">Second line of the shipping address. .</param>
        /// <param name="Locality">City of the shipping address. .</param>
        /// <param name="AdministrativeArea">State or province of the shipping address. Use the [State, Province, and Territory Codes for the United States and Canada](https://developer.cybersource.com/library/documentation/sbc/quickref/states_and_provinces.pdf) (maximum length: 2) .</param>
        /// <param name="PostalCode">Postal code for the shipping address. The postal code must consist of 5 to 9 digits. .</param>
        /// <param name="Country">Country of the shipping address. Use the two-character [ISO Standard Country Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf) .</param>
        public PtsV2ModifyBillingAgreementPost201ResponseOrderInformationShipTo(string FirstName = default(string), string LastName = default(string), string Address1 = default(string), string Address2 = default(string), string Locality = default(string), string AdministrativeArea = default(string), string PostalCode = default(string), string Country = default(string))
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address1 = Address1;
            this.Address2 = Address2;
            this.Locality = Locality;
            this.AdministrativeArea = AdministrativeArea;
            this.PostalCode = PostalCode;
            this.Country = Country;
        }
        
        /// <summary>
        /// First name of the recipient. 
        /// </summary>
        /// <value>First name of the recipient. </value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of the recipient. 
        /// </summary>
        /// <value>Last name of the recipient. </value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// First line of the shipping address. 
        /// </summary>
        /// <value>First line of the shipping address. </value>
        [DataMember(Name="address1", EmitDefaultValue=false)]
        public string Address1 { get; set; }

        /// <summary>
        /// Second line of the shipping address. 
        /// </summary>
        /// <value>Second line of the shipping address. </value>
        [DataMember(Name="address2", EmitDefaultValue=false)]
        public string Address2 { get; set; }

        /// <summary>
        /// City of the shipping address. 
        /// </summary>
        /// <value>City of the shipping address. </value>
        [DataMember(Name="locality", EmitDefaultValue=false)]
        public string Locality { get; set; }

        /// <summary>
        /// State or province of the shipping address. Use the [State, Province, and Territory Codes for the United States and Canada](https://developer.cybersource.com/library/documentation/sbc/quickref/states_and_provinces.pdf) (maximum length: 2) 
        /// </summary>
        /// <value>State or province of the shipping address. Use the [State, Province, and Territory Codes for the United States and Canada](https://developer.cybersource.com/library/documentation/sbc/quickref/states_and_provinces.pdf) (maximum length: 2) </value>
        [DataMember(Name="administrativeArea", EmitDefaultValue=false)]
        public string AdministrativeArea { get; set; }

        /// <summary>
        /// Postal code for the shipping address. The postal code must consist of 5 to 9 digits. 
        /// </summary>
        /// <value>Postal code for the shipping address. The postal code must consist of 5 to 9 digits. </value>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Country of the shipping address. Use the two-character [ISO Standard Country Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf) 
        /// </summary>
        /// <value>Country of the shipping address. Use the two-character [ISO Standard Country Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf) </value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2ModifyBillingAgreementPost201ResponseOrderInformationShipTo {\n");
            if (FirstName != null) sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            if (LastName != null) sb.Append("  LastName: ").Append(LastName).Append("\n");
            if (Address1 != null) sb.Append("  Address1: ").Append(Address1).Append("\n");
            if (Address2 != null) sb.Append("  Address2: ").Append(Address2).Append("\n");
            if (Locality != null) sb.Append("  Locality: ").Append(Locality).Append("\n");
            if (AdministrativeArea != null) sb.Append("  AdministrativeArea: ").Append(AdministrativeArea).Append("\n");
            if (PostalCode != null) sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            if (Country != null) sb.Append("  Country: ").Append(Country).Append("\n");
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
            return this.Equals(obj as PtsV2ModifyBillingAgreementPost201ResponseOrderInformationShipTo);
        }

        /// <summary>
        /// Returns true if PtsV2ModifyBillingAgreementPost201ResponseOrderInformationShipTo instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2ModifyBillingAgreementPost201ResponseOrderInformationShipTo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2ModifyBillingAgreementPost201ResponseOrderInformationShipTo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.Address1 == other.Address1 ||
                    this.Address1 != null &&
                    this.Address1.Equals(other.Address1)
                ) && 
                (
                    this.Address2 == other.Address2 ||
                    this.Address2 != null &&
                    this.Address2.Equals(other.Address2)
                ) && 
                (
                    this.Locality == other.Locality ||
                    this.Locality != null &&
                    this.Locality.Equals(other.Locality)
                ) && 
                (
                    this.AdministrativeArea == other.AdministrativeArea ||
                    this.AdministrativeArea != null &&
                    this.AdministrativeArea.Equals(other.AdministrativeArea)
                ) && 
                (
                    this.PostalCode == other.PostalCode ||
                    this.PostalCode != null &&
                    this.PostalCode.Equals(other.PostalCode)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
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
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.Address1 != null)
                    hash = hash * 59 + this.Address1.GetHashCode();
                if (this.Address2 != null)
                    hash = hash * 59 + this.Address2.GetHashCode();
                if (this.Locality != null)
                    hash = hash * 59 + this.Locality.GetHashCode();
                if (this.AdministrativeArea != null)
                    hash = hash * 59 + this.AdministrativeArea.GetHashCode();
                if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
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
