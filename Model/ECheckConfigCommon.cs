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
    /// ECheckConfigCommon
    /// </summary>
    [DataContract]
    public partial class ECheckConfigCommon :  IEquatable<ECheckConfigCommon>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ECheckConfigCommon" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ECheckConfigCommon() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ECheckConfigCommon" /> class.
        /// </summary>
        /// <param name="Processors">Processors.</param>
        /// <param name="InternalOnly">InternalOnly.</param>
        /// <param name="AccountHolderName">Mandatory  Name on Merchant&#39;s Bank Account Only ASCII (Hex 20 to Hex 7E)  (required).</param>
        /// <param name="AccountType">Mandatory  Type of account for Merchant&#39;s Bank Account Possible values: - checking - savings - corporatechecking - corporatesavings  (required).</param>
        /// <param name="AccountRoutingNumber">Mandatory  Routing number for Merchant&#39;s Bank Account US Account Routing Number  (required).</param>
        /// <param name="AccountNumber">Mandatory  Account number for Merchant&#39;s Bank Account  (required).</param>
        public ECheckConfigCommon(Dictionary<string, ECheckConfigCommonProcessors> Processors = default(Dictionary<string, ECheckConfigCommonProcessors>), ECheckConfigCommonInternalOnly InternalOnly = default(ECheckConfigCommonInternalOnly), string AccountHolderName = default(string), string AccountType = default(string), string AccountRoutingNumber = default(string), string AccountNumber = default(string))
        {
            this.Processors = Processors;
            this.InternalOnly = InternalOnly;
            this.AccountHolderName = AccountHolderName;
            this.AccountType = AccountType;
            this.AccountRoutingNumber = AccountRoutingNumber;
            this.AccountNumber = AccountNumber;
        }
        
        /// <summary>
        /// Gets or Sets Processors
        /// </summary>
        [DataMember(Name="processors", EmitDefaultValue=false)]
        public Dictionary<string, ECheckConfigCommonProcessors> Processors { get; set; }

        /// <summary>
        /// Gets or Sets InternalOnly
        /// </summary>
        [DataMember(Name="internalOnly", EmitDefaultValue=false)]
        public ECheckConfigCommonInternalOnly InternalOnly { get; set; }

        /// <summary>
        /// Mandatory  Name on Merchant&#39;s Bank Account Only ASCII (Hex 20 to Hex 7E) 
        /// </summary>
        /// <value>Mandatory  Name on Merchant&#39;s Bank Account Only ASCII (Hex 20 to Hex 7E) </value>
        [DataMember(Name="accountHolderName", EmitDefaultValue=false)]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// Mandatory  Type of account for Merchant&#39;s Bank Account Possible values: - checking - savings - corporatechecking - corporatesavings 
        /// </summary>
        /// <value>Mandatory  Type of account for Merchant&#39;s Bank Account Possible values: - checking - savings - corporatechecking - corporatesavings </value>
        [DataMember(Name="accountType", EmitDefaultValue=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// Mandatory  Routing number for Merchant&#39;s Bank Account US Account Routing Number 
        /// </summary>
        /// <value>Mandatory  Routing number for Merchant&#39;s Bank Account US Account Routing Number </value>
        [DataMember(Name="accountRoutingNumber", EmitDefaultValue=false)]
        public string AccountRoutingNumber { get; set; }

        /// <summary>
        /// Mandatory  Account number for Merchant&#39;s Bank Account 
        /// </summary>
        /// <value>Mandatory  Account number for Merchant&#39;s Bank Account </value>
        [DataMember(Name="accountNumber", EmitDefaultValue=false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ECheckConfigCommon {\n");
            if (Processors != null) sb.Append("  Processors: ").Append(Processors).Append("\n");
            if (InternalOnly != null) sb.Append("  InternalOnly: ").Append(InternalOnly).Append("\n");
            if (AccountHolderName != null) sb.Append("  AccountHolderName: ").Append(AccountHolderName).Append("\n");
            if (AccountType != null) sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            if (AccountRoutingNumber != null) sb.Append("  AccountRoutingNumber: ").Append(AccountRoutingNumber).Append("\n");
            if (AccountNumber != null) sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
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
            return this.Equals(obj as ECheckConfigCommon);
        }

        /// <summary>
        /// Returns true if ECheckConfigCommon instances are equal
        /// </summary>
        /// <param name="other">Instance of ECheckConfigCommon to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ECheckConfigCommon other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Processors == other.Processors ||
                    this.Processors != null &&
                    this.Processors.SequenceEqual(other.Processors)
                ) && 
                (
                    this.InternalOnly == other.InternalOnly ||
                    this.InternalOnly != null &&
                    this.InternalOnly.Equals(other.InternalOnly)
                ) && 
                (
                    this.AccountHolderName == other.AccountHolderName ||
                    this.AccountHolderName != null &&
                    this.AccountHolderName.Equals(other.AccountHolderName)
                ) && 
                (
                    this.AccountType == other.AccountType ||
                    this.AccountType != null &&
                    this.AccountType.Equals(other.AccountType)
                ) && 
                (
                    this.AccountRoutingNumber == other.AccountRoutingNumber ||
                    this.AccountRoutingNumber != null &&
                    this.AccountRoutingNumber.Equals(other.AccountRoutingNumber)
                ) && 
                (
                    this.AccountNumber == other.AccountNumber ||
                    this.AccountNumber != null &&
                    this.AccountNumber.Equals(other.AccountNumber)
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
                if (this.Processors != null)
                    hash = hash * 59 + this.Processors.GetHashCode();
                if (this.InternalOnly != null)
                    hash = hash * 59 + this.InternalOnly.GetHashCode();
                if (this.AccountHolderName != null)
                    hash = hash * 59 + this.AccountHolderName.GetHashCode();
                if (this.AccountType != null)
                    hash = hash * 59 + this.AccountType.GetHashCode();
                if (this.AccountRoutingNumber != null)
                    hash = hash * 59 + this.AccountRoutingNumber.GetHashCode();
                if (this.AccountNumber != null)
                    hash = hash * 59 + this.AccountNumber.GetHashCode();
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
