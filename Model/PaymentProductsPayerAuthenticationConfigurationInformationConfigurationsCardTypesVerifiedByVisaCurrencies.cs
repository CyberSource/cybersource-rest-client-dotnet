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
    /// PaymentProductsPayerAuthenticationConfigurationInformationConfigurationsCardTypesVerifiedByVisaCurrencies
    /// </summary>
    [DataContract]
    public partial class PaymentProductsPayerAuthenticationConfigurationInformationConfigurationsCardTypesVerifiedByVisaCurrencies :  IEquatable<PaymentProductsPayerAuthenticationConfigurationInformationConfigurationsCardTypesVerifiedByVisaCurrencies>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentProductsPayerAuthenticationConfigurationInformationConfigurationsCardTypesVerifiedByVisaCurrencies" /> class.
        /// </summary>
        /// <param name="CurrencyCodes">CurrencyCodes.</param>
        /// <param name="AcquirerId">The Acquirer ID value, often referred to as the Acquirer BIN, is specific to an Acquirer. The value is created by Cardinal in their system and the Acquirer may not know that the Acquirer ID is different from their Acquiring BIN. It is most often the Acquiring BIN + \&quot;-1000\&quot; but the trailing character can be different. **Note** We will need to double check with Cardinal before setting up the Portfolio Template in production. .</param>
        /// <param name="ProcessorMerchantId">Processor Merchant ID is the Merchant ID assigned by your acquiring bank. This Merchant ID should also be used by your bank to register your account to the card scheme Directory Server for processing Payer Authentication services. .</param>
        public PaymentProductsPayerAuthenticationConfigurationInformationConfigurationsCardTypesVerifiedByVisaCurrencies(List<string> CurrencyCodes = default(List<string>), string AcquirerId = default(string), string ProcessorMerchantId = default(string))
        {
            this.CurrencyCodes = CurrencyCodes;
            this.AcquirerId = AcquirerId;
            this.ProcessorMerchantId = ProcessorMerchantId;
        }
        
        /// <summary>
        /// Gets or Sets CurrencyCodes
        /// </summary>
        [DataMember(Name="currencyCodes", EmitDefaultValue=false)]
        public List<string> CurrencyCodes { get; set; }

        /// <summary>
        /// The Acquirer ID value, often referred to as the Acquirer BIN, is specific to an Acquirer. The value is created by Cardinal in their system and the Acquirer may not know that the Acquirer ID is different from their Acquiring BIN. It is most often the Acquiring BIN + \&quot;-1000\&quot; but the trailing character can be different. **Note** We will need to double check with Cardinal before setting up the Portfolio Template in production. 
        /// </summary>
        /// <value>The Acquirer ID value, often referred to as the Acquirer BIN, is specific to an Acquirer. The value is created by Cardinal in their system and the Acquirer may not know that the Acquirer ID is different from their Acquiring BIN. It is most often the Acquiring BIN + \&quot;-1000\&quot; but the trailing character can be different. **Note** We will need to double check with Cardinal before setting up the Portfolio Template in production. </value>
        [DataMember(Name="acquirerId", EmitDefaultValue=false)]
        public string AcquirerId { get; set; }

        /// <summary>
        /// Processor Merchant ID is the Merchant ID assigned by your acquiring bank. This Merchant ID should also be used by your bank to register your account to the card scheme Directory Server for processing Payer Authentication services. 
        /// </summary>
        /// <value>Processor Merchant ID is the Merchant ID assigned by your acquiring bank. This Merchant ID should also be used by your bank to register your account to the card scheme Directory Server for processing Payer Authentication services. </value>
        [DataMember(Name="processorMerchantId", EmitDefaultValue=false)]
        public string ProcessorMerchantId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentProductsPayerAuthenticationConfigurationInformationConfigurationsCardTypesVerifiedByVisaCurrencies {\n");
            sb.Append("  CurrencyCodes: ").Append(CurrencyCodes).Append("\n");
            sb.Append("  AcquirerId: ").Append(AcquirerId).Append("\n");
            sb.Append("  ProcessorMerchantId: ").Append(ProcessorMerchantId).Append("\n");
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
            return this.Equals(obj as PaymentProductsPayerAuthenticationConfigurationInformationConfigurationsCardTypesVerifiedByVisaCurrencies);
        }

        /// <summary>
        /// Returns true if PaymentProductsPayerAuthenticationConfigurationInformationConfigurationsCardTypesVerifiedByVisaCurrencies instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentProductsPayerAuthenticationConfigurationInformationConfigurationsCardTypesVerifiedByVisaCurrencies to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentProductsPayerAuthenticationConfigurationInformationConfigurationsCardTypesVerifiedByVisaCurrencies other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CurrencyCodes == other.CurrencyCodes ||
                    this.CurrencyCodes != null &&
                    this.CurrencyCodes.SequenceEqual(other.CurrencyCodes)
                ) && 
                (
                    this.AcquirerId == other.AcquirerId ||
                    this.AcquirerId != null &&
                    this.AcquirerId.Equals(other.AcquirerId)
                ) && 
                (
                    this.ProcessorMerchantId == other.ProcessorMerchantId ||
                    this.ProcessorMerchantId != null &&
                    this.ProcessorMerchantId.Equals(other.ProcessorMerchantId)
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
                if (this.CurrencyCodes != null)
                    hash = hash * 59 + this.CurrencyCodes.GetHashCode();
                if (this.AcquirerId != null)
                    hash = hash * 59 + this.AcquirerId.GetHashCode();
                if (this.ProcessorMerchantId != null)
                    hash = hash * 59 + this.ProcessorMerchantId.GetHashCode();
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
            // AcquirerId (string) pattern
            Regex regexAcquirerId = new Regex(@"^[a-zA-Z0-9]{6,20}$", RegexOptions.CultureInvariant);
            if (false == regexAcquirerId.Match(this.AcquirerId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AcquirerId, must match a pattern of " + regexAcquirerId, new [] { "AcquirerId" });
            }

            // ProcessorMerchantId (string) pattern
            Regex regexProcessorMerchantId = new Regex(@"^[a-zA-Z0-9]{6,35}$", RegexOptions.CultureInvariant);
            if (false == regexProcessorMerchantId.Match(this.ProcessorMerchantId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProcessorMerchantId, must match a pattern of " + regexProcessorMerchantId, new [] { "ProcessorMerchantId" });
            }

            yield break;
        }
    }

}