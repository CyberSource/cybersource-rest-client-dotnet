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
    /// Tmsv2customersEmbeddedDefaultPaymentInstrumentBillTo
    /// </summary>
    [DataContract]
    public partial class Tmsv2customersEmbeddedDefaultPaymentInstrumentBillTo :  IEquatable<Tmsv2customersEmbeddedDefaultPaymentInstrumentBillTo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tmsv2customersEmbeddedDefaultPaymentInstrumentBillTo" /> class.
        /// </summary>
        /// <param name="FirstName">Customer&#39;s first name. This name must be the same as the name on the card. .</param>
        /// <param name="LastName">Customer&#39;s last name. This name must be the same as the name on the card. .</param>
        /// <param name="Company">Name of the customer&#39;s company. .</param>
        /// <param name="Address1">Payment card billing street address as it appears on the credit card issuer&#39;s records. .</param>
        /// <param name="Address2">Additional address information. .</param>
        /// <param name="Locality">Payment card billing city. .</param>
        /// <param name="AdministrativeArea">State or province of the billing address. Use the State, Province, and Territory Codes for the United States and Canada. .</param>
        /// <param name="PostalCode">Postal code for the billing address. The postal code must consist of 5 to 9 digits.  When the billing country is the U.S., the 9-digit postal code must follow this format: [5 digits][dash][4 digits]  **Example** &#x60;12345-6789&#x60;  When the billing country is Canada, the 6-digit postal code must follow this format: [alpha][numeric][alpha][space][numeric][alpha][numeric]  **Example** &#x60;A1B 2C3&#x60; .</param>
        /// <param name="Country">Payment card billing country. Use the two-character ISO Standard Country Codes. .</param>
        /// <param name="Email">Customer&#39;s email address, including the full domain name. .</param>
        /// <param name="PhoneNumber">Customer&#39;s phone number. .</param>
        public Tmsv2customersEmbeddedDefaultPaymentInstrumentBillTo(string FirstName = default(string), string LastName = default(string), string Company = default(string), string Address1 = default(string), string Address2 = default(string), string Locality = default(string), string AdministrativeArea = default(string), string PostalCode = default(string), string Country = default(string), string Email = default(string), string PhoneNumber = default(string))
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Company = Company;
            this.Address1 = Address1;
            this.Address2 = Address2;
            this.Locality = Locality;
            this.AdministrativeArea = AdministrativeArea;
            this.PostalCode = PostalCode;
            this.Country = Country;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
        }
        
        /// <summary>
        /// Customer&#39;s first name. This name must be the same as the name on the card. 
        /// </summary>
        /// <value>Customer&#39;s first name. This name must be the same as the name on the card. </value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Customer&#39;s last name. This name must be the same as the name on the card. 
        /// </summary>
        /// <value>Customer&#39;s last name. This name must be the same as the name on the card. </value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Name of the customer&#39;s company. 
        /// </summary>
        /// <value>Name of the customer&#39;s company. </value>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public string Company { get; set; }

        /// <summary>
        /// Payment card billing street address as it appears on the credit card issuer&#39;s records. 
        /// </summary>
        /// <value>Payment card billing street address as it appears on the credit card issuer&#39;s records. </value>
        [DataMember(Name="address1", EmitDefaultValue=false)]
        public string Address1 { get; set; }

        /// <summary>
        /// Additional address information. 
        /// </summary>
        /// <value>Additional address information. </value>
        [DataMember(Name="address2", EmitDefaultValue=false)]
        public string Address2 { get; set; }

        /// <summary>
        /// Payment card billing city. 
        /// </summary>
        /// <value>Payment card billing city. </value>
        [DataMember(Name="locality", EmitDefaultValue=false)]
        public string Locality { get; set; }

        /// <summary>
        /// State or province of the billing address. Use the State, Province, and Territory Codes for the United States and Canada. 
        /// </summary>
        /// <value>State or province of the billing address. Use the State, Province, and Territory Codes for the United States and Canada. </value>
        [DataMember(Name="administrativeArea", EmitDefaultValue=false)]
        public string AdministrativeArea { get; set; }

        /// <summary>
        /// Postal code for the billing address. The postal code must consist of 5 to 9 digits.  When the billing country is the U.S., the 9-digit postal code must follow this format: [5 digits][dash][4 digits]  **Example** &#x60;12345-6789&#x60;  When the billing country is Canada, the 6-digit postal code must follow this format: [alpha][numeric][alpha][space][numeric][alpha][numeric]  **Example** &#x60;A1B 2C3&#x60; 
        /// </summary>
        /// <value>Postal code for the billing address. The postal code must consist of 5 to 9 digits.  When the billing country is the U.S., the 9-digit postal code must follow this format: [5 digits][dash][4 digits]  **Example** &#x60;12345-6789&#x60;  When the billing country is Canada, the 6-digit postal code must follow this format: [alpha][numeric][alpha][space][numeric][alpha][numeric]  **Example** &#x60;A1B 2C3&#x60; </value>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Payment card billing country. Use the two-character ISO Standard Country Codes. 
        /// </summary>
        /// <value>Payment card billing country. Use the two-character ISO Standard Country Codes. </value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Customer&#39;s email address, including the full domain name. 
        /// </summary>
        /// <value>Customer&#39;s email address, including the full domain name. </value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Customer&#39;s phone number. 
        /// </summary>
        /// <value>Customer&#39;s phone number. </value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Tmsv2customersEmbeddedDefaultPaymentInstrumentBillTo {\n");
            if (FirstName != null) sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            if (LastName != null) sb.Append("  LastName: ").Append(LastName).Append("\n");
            if (Company != null) sb.Append("  Company: ").Append(Company).Append("\n");
            if (Address1 != null) sb.Append("  Address1: ").Append(Address1).Append("\n");
            if (Address2 != null) sb.Append("  Address2: ").Append(Address2).Append("\n");
            if (Locality != null) sb.Append("  Locality: ").Append(Locality).Append("\n");
            if (AdministrativeArea != null) sb.Append("  AdministrativeArea: ").Append(AdministrativeArea).Append("\n");
            if (PostalCode != null) sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            if (Country != null) sb.Append("  Country: ").Append(Country).Append("\n");
            if (Email != null) sb.Append("  Email: ").Append(Email).Append("\n");
            if (PhoneNumber != null) sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
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
            return this.Equals(obj as Tmsv2customersEmbeddedDefaultPaymentInstrumentBillTo);
        }

        /// <summary>
        /// Returns true if Tmsv2customersEmbeddedDefaultPaymentInstrumentBillTo instances are equal
        /// </summary>
        /// <param name="other">Instance of Tmsv2customersEmbeddedDefaultPaymentInstrumentBillTo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Tmsv2customersEmbeddedDefaultPaymentInstrumentBillTo other)
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
                    this.Company == other.Company ||
                    this.Company != null &&
                    this.Company.Equals(other.Company)
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
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
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
                if (this.Company != null)
                    hash = hash * 59 + this.Company.GetHashCode();
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
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
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
