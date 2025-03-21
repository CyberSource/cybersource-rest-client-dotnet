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
    /// Ptsv2paymentsPaymentInformationBankAccount
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsPaymentInformationBankAccount :  IEquatable<Ptsv2paymentsPaymentInformationBankAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsPaymentInformationBankAccount" /> class.
        /// </summary>
        /// <param name="Type">Account type.  Possible values:  - **C**: Checking.  - **G**: General ledger. This value is supported only on Wells Fargo ACH.  - **S**: Savings (U.S. dollars only).  - **X**: Corporate checking (U.S. dollars only). .</param>
        /// <param name="Number">Account number.  When processing encoded account numbers, use this field for the encoded account number. .</param>
        /// <param name="EncoderId">Identifier for the bank that provided the customer&#39;s encoded account number.  To obtain the bank identifier, contact your processor. .</param>
        /// <param name="CheckNumber">Check number.  Chase Paymentech Solutions - Optional. CyberSource ACH Service - Not used. RBS WorldPay Atlanta - Optional on debits. Required on credits. TeleCheck - Strongly recommended on debit requests. Optional on credits. .</param>
        /// <param name="CheckImageReferenceNumber">Image reference number associated with the check. You cannot include any special characters. .</param>
        /// <param name="Iban">International Bank Account Number (IBAN) for the bank account. For some countries you can provide this number instead of the traditional bank account information. You can use this field only when scoring a direct debit transaction. .</param>
        public Ptsv2paymentsPaymentInformationBankAccount(string Type = default(string), string Number = default(string), string EncoderId = default(string), string CheckNumber = default(string), string CheckImageReferenceNumber = default(string), string Iban = default(string))
        {
            this.Type = Type;
            this.Number = Number;
            this.EncoderId = EncoderId;
            this.CheckNumber = CheckNumber;
            this.CheckImageReferenceNumber = CheckImageReferenceNumber;
            this.Iban = Iban;
        }
        
        /// <summary>
        /// Account type.  Possible values:  - **C**: Checking.  - **G**: General ledger. This value is supported only on Wells Fargo ACH.  - **S**: Savings (U.S. dollars only).  - **X**: Corporate checking (U.S. dollars only). 
        /// </summary>
        /// <value>Account type.  Possible values:  - **C**: Checking.  - **G**: General ledger. This value is supported only on Wells Fargo ACH.  - **S**: Savings (U.S. dollars only).  - **X**: Corporate checking (U.S. dollars only). </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Account number.  When processing encoded account numbers, use this field for the encoded account number. 
        /// </summary>
        /// <value>Account number.  When processing encoded account numbers, use this field for the encoded account number. </value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }

        /// <summary>
        /// Identifier for the bank that provided the customer&#39;s encoded account number.  To obtain the bank identifier, contact your processor. 
        /// </summary>
        /// <value>Identifier for the bank that provided the customer&#39;s encoded account number.  To obtain the bank identifier, contact your processor. </value>
        [DataMember(Name="encoderId", EmitDefaultValue=false)]
        public string EncoderId { get; set; }

        /// <summary>
        /// Check number.  Chase Paymentech Solutions - Optional. CyberSource ACH Service - Not used. RBS WorldPay Atlanta - Optional on debits. Required on credits. TeleCheck - Strongly recommended on debit requests. Optional on credits. 
        /// </summary>
        /// <value>Check number.  Chase Paymentech Solutions - Optional. CyberSource ACH Service - Not used. RBS WorldPay Atlanta - Optional on debits. Required on credits. TeleCheck - Strongly recommended on debit requests. Optional on credits. </value>
        [DataMember(Name="checkNumber", EmitDefaultValue=false)]
        public string CheckNumber { get; set; }

        /// <summary>
        /// Image reference number associated with the check. You cannot include any special characters. 
        /// </summary>
        /// <value>Image reference number associated with the check. You cannot include any special characters. </value>
        [DataMember(Name="checkImageReferenceNumber", EmitDefaultValue=false)]
        public string CheckImageReferenceNumber { get; set; }

        /// <summary>
        /// International Bank Account Number (IBAN) for the bank account. For some countries you can provide this number instead of the traditional bank account information. You can use this field only when scoring a direct debit transaction. 
        /// </summary>
        /// <value>International Bank Account Number (IBAN) for the bank account. For some countries you can provide this number instead of the traditional bank account information. You can use this field only when scoring a direct debit transaction. </value>
        [DataMember(Name="iban", EmitDefaultValue=false)]
        public string Iban { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsPaymentInformationBankAccount {\n");
            if (Type != null) sb.Append("  Type: ").Append(Type).Append("\n");
            if (Number != null) sb.Append("  Number: ").Append(Number).Append("\n");
            if (EncoderId != null) sb.Append("  EncoderId: ").Append(EncoderId).Append("\n");
            if (CheckNumber != null) sb.Append("  CheckNumber: ").Append(CheckNumber).Append("\n");
            if (CheckImageReferenceNumber != null) sb.Append("  CheckImageReferenceNumber: ").Append(CheckImageReferenceNumber).Append("\n");
            if (Iban != null) sb.Append("  Iban: ").Append(Iban).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsPaymentInformationBankAccount);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsPaymentInformationBankAccount instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsPaymentInformationBankAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsPaymentInformationBankAccount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Number == other.Number ||
                    this.Number != null &&
                    this.Number.Equals(other.Number)
                ) && 
                (
                    this.EncoderId == other.EncoderId ||
                    this.EncoderId != null &&
                    this.EncoderId.Equals(other.EncoderId)
                ) && 
                (
                    this.CheckNumber == other.CheckNumber ||
                    this.CheckNumber != null &&
                    this.CheckNumber.Equals(other.CheckNumber)
                ) && 
                (
                    this.CheckImageReferenceNumber == other.CheckImageReferenceNumber ||
                    this.CheckImageReferenceNumber != null &&
                    this.CheckImageReferenceNumber.Equals(other.CheckImageReferenceNumber)
                ) && 
                (
                    this.Iban == other.Iban ||
                    this.Iban != null &&
                    this.Iban.Equals(other.Iban)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Number != null)
                    hash = hash * 59 + this.Number.GetHashCode();
                if (this.EncoderId != null)
                    hash = hash * 59 + this.EncoderId.GetHashCode();
                if (this.CheckNumber != null)
                    hash = hash * 59 + this.CheckNumber.GetHashCode();
                if (this.CheckImageReferenceNumber != null)
                    hash = hash * 59 + this.CheckImageReferenceNumber.GetHashCode();
                if (this.Iban != null)
                    hash = hash * 59 + this.Iban.GetHashCode();
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
