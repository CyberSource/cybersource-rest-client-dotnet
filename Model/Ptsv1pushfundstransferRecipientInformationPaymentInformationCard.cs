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
    /// Ptsv1pushfundstransferRecipientInformationPaymentInformationCard
    /// </summary>
    [DataContract]
    public partial class Ptsv1pushfundstransferRecipientInformationPaymentInformationCard :  IEquatable<Ptsv1pushfundstransferRecipientInformationPaymentInformationCard>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv1pushfundstransferRecipientInformationPaymentInformationCard" /> class.
        /// </summary>
        /// <param name="Type">- &#x60;001&#x60;: Visa - &#x60;002&#x60;: Mastercard, Eurocard, which is a European regional brand of Mastercard. - &#x60;033&#x60;: Visa Electron - &#x60;024&#x60;: Maestro - &#x60;042&#x60;: Maestro International .</param>
        /// <param name="SecurityCode">3-digit value that indicates the cardCvv2Value. Values can be 0-9. .</param>
        /// <param name="Number">The customer&#39;s payment card number, also known as the Primary Account Number (PAN).  Conditional: this field is required if not using tokens. .</param>
        /// <param name="ExpirationMonth">Two-digit month in which the payment card expires.  Format: MM.  Valid values: 01 through 12. Leading 0 is required. .</param>
        /// <param name="ExpirationYear">Four-digit year in which the payment card expires.  Format: YYYY. .</param>
        /// <param name="Customer">Customer.</param>
        /// <param name="PaymentInstrument">PaymentInstrument.</param>
        /// <param name="InstrumentIdentifier">InstrumentIdentifier.</param>
        public Ptsv1pushfundstransferRecipientInformationPaymentInformationCard(string Type = default(string), string SecurityCode = default(string), string Number = default(string), string ExpirationMonth = default(string), string ExpirationYear = default(string), Ptsv1pushfundstransferRecipientInformationPaymentInformationCardCustomer Customer = default(Ptsv1pushfundstransferRecipientInformationPaymentInformationCardCustomer), Ptsv1pushfundstransferRecipientInformationPaymentInformationCardPaymentInstrument PaymentInstrument = default(Ptsv1pushfundstransferRecipientInformationPaymentInformationCardPaymentInstrument), Ptsv1pushfundstransferRecipientInformationPaymentInformationCardInstrumentIdentifier InstrumentIdentifier = default(Ptsv1pushfundstransferRecipientInformationPaymentInformationCardInstrumentIdentifier))
        {
            this.Type = Type;
            this.SecurityCode = SecurityCode;
            this.Number = Number;
            this.ExpirationMonth = ExpirationMonth;
            this.ExpirationYear = ExpirationYear;
            this.Customer = Customer;
            this.PaymentInstrument = PaymentInstrument;
            this.InstrumentIdentifier = InstrumentIdentifier;
        }
        
        /// <summary>
        /// - &#x60;001&#x60;: Visa - &#x60;002&#x60;: Mastercard, Eurocard, which is a European regional brand of Mastercard. - &#x60;033&#x60;: Visa Electron - &#x60;024&#x60;: Maestro - &#x60;042&#x60;: Maestro International 
        /// </summary>
        /// <value>- &#x60;001&#x60;: Visa - &#x60;002&#x60;: Mastercard, Eurocard, which is a European regional brand of Mastercard. - &#x60;033&#x60;: Visa Electron - &#x60;024&#x60;: Maestro - &#x60;042&#x60;: Maestro International </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// 3-digit value that indicates the cardCvv2Value. Values can be 0-9. 
        /// </summary>
        /// <value>3-digit value that indicates the cardCvv2Value. Values can be 0-9. </value>
        [DataMember(Name="securityCode", EmitDefaultValue=false)]
        public string SecurityCode { get; set; }

        /// <summary>
        /// The customer&#39;s payment card number, also known as the Primary Account Number (PAN).  Conditional: this field is required if not using tokens. 
        /// </summary>
        /// <value>The customer&#39;s payment card number, also known as the Primary Account Number (PAN).  Conditional: this field is required if not using tokens. </value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }

        /// <summary>
        /// Two-digit month in which the payment card expires.  Format: MM.  Valid values: 01 through 12. Leading 0 is required. 
        /// </summary>
        /// <value>Two-digit month in which the payment card expires.  Format: MM.  Valid values: 01 through 12. Leading 0 is required. </value>
        [DataMember(Name="expirationMonth", EmitDefaultValue=false)]
        public string ExpirationMonth { get; set; }

        /// <summary>
        /// Four-digit year in which the payment card expires.  Format: YYYY. 
        /// </summary>
        /// <value>Four-digit year in which the payment card expires.  Format: YYYY. </value>
        [DataMember(Name="expirationYear", EmitDefaultValue=false)]
        public string ExpirationYear { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name="customer", EmitDefaultValue=false)]
        public Ptsv1pushfundstransferRecipientInformationPaymentInformationCardCustomer Customer { get; set; }

        /// <summary>
        /// Gets or Sets PaymentInstrument
        /// </summary>
        [DataMember(Name="paymentInstrument", EmitDefaultValue=false)]
        public Ptsv1pushfundstransferRecipientInformationPaymentInformationCardPaymentInstrument PaymentInstrument { get; set; }

        /// <summary>
        /// Gets or Sets InstrumentIdentifier
        /// </summary>
        [DataMember(Name="instrumentIdentifier", EmitDefaultValue=false)]
        public Ptsv1pushfundstransferRecipientInformationPaymentInformationCardInstrumentIdentifier InstrumentIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv1pushfundstransferRecipientInformationPaymentInformationCard {\n");
            if (Type != null) sb.Append("  Type: ").Append(Type).Append("\n");
            if (SecurityCode != null) sb.Append("  SecurityCode: ").Append(SecurityCode).Append("\n");
            if (Number != null) sb.Append("  Number: ").Append(Number).Append("\n");
            if (ExpirationMonth != null) sb.Append("  ExpirationMonth: ").Append(ExpirationMonth).Append("\n");
            if (ExpirationYear != null) sb.Append("  ExpirationYear: ").Append(ExpirationYear).Append("\n");
            if (Customer != null) sb.Append("  Customer: ").Append(Customer).Append("\n");
            if (PaymentInstrument != null) sb.Append("  PaymentInstrument: ").Append(PaymentInstrument).Append("\n");
            if (InstrumentIdentifier != null) sb.Append("  InstrumentIdentifier: ").Append(InstrumentIdentifier).Append("\n");
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
            return this.Equals(obj as Ptsv1pushfundstransferRecipientInformationPaymentInformationCard);
        }

        /// <summary>
        /// Returns true if Ptsv1pushfundstransferRecipientInformationPaymentInformationCard instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv1pushfundstransferRecipientInformationPaymentInformationCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv1pushfundstransferRecipientInformationPaymentInformationCard other)
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
                    this.SecurityCode == other.SecurityCode ||
                    this.SecurityCode != null &&
                    this.SecurityCode.Equals(other.SecurityCode)
                ) && 
                (
                    this.Number == other.Number ||
                    this.Number != null &&
                    this.Number.Equals(other.Number)
                ) && 
                (
                    this.ExpirationMonth == other.ExpirationMonth ||
                    this.ExpirationMonth != null &&
                    this.ExpirationMonth.Equals(other.ExpirationMonth)
                ) && 
                (
                    this.ExpirationYear == other.ExpirationYear ||
                    this.ExpirationYear != null &&
                    this.ExpirationYear.Equals(other.ExpirationYear)
                ) && 
                (
                    this.Customer == other.Customer ||
                    this.Customer != null &&
                    this.Customer.Equals(other.Customer)
                ) && 
                (
                    this.PaymentInstrument == other.PaymentInstrument ||
                    this.PaymentInstrument != null &&
                    this.PaymentInstrument.Equals(other.PaymentInstrument)
                ) && 
                (
                    this.InstrumentIdentifier == other.InstrumentIdentifier ||
                    this.InstrumentIdentifier != null &&
                    this.InstrumentIdentifier.Equals(other.InstrumentIdentifier)
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
                if (this.SecurityCode != null)
                    hash = hash * 59 + this.SecurityCode.GetHashCode();
                if (this.Number != null)
                    hash = hash * 59 + this.Number.GetHashCode();
                if (this.ExpirationMonth != null)
                    hash = hash * 59 + this.ExpirationMonth.GetHashCode();
                if (this.ExpirationYear != null)
                    hash = hash * 59 + this.ExpirationYear.GetHashCode();
                if (this.Customer != null)
                    hash = hash * 59 + this.Customer.GetHashCode();
                if (this.PaymentInstrument != null)
                    hash = hash * 59 + this.PaymentInstrument.GetHashCode();
                if (this.InstrumentIdentifier != null)
                    hash = hash * 59 + this.InstrumentIdentifier.GetHashCode();
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
