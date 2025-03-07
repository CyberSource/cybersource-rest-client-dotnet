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
    /// PtsV2PaymentsCapturesPost201ResponseEmbeddedActionsApCapture
    /// </summary>
    [DataContract]
    public partial class PtsV2PaymentsCapturesPost201ResponseEmbeddedActionsApCapture :  IEquatable<PtsV2PaymentsCapturesPost201ResponseEmbeddedActionsApCapture>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PaymentsCapturesPost201ResponseEmbeddedActionsApCapture" /> class.
        /// </summary>
        /// <param name="Reason">The reason why the captured payment status is PENDING or DENIED. BUYER_COMPLAINT The payer initiated a dispute for this captured payment with processor. CHARGEBACK The captured funds were reversed in response to the payer disputing this captured payment with the issuer of the financial instrument used to pay for this captured payment. ECHECK The payer paid by an eCheck that has not yet cleared. INTERNATIONAL_WITHDRAWAL Visit your online account. In your Account Overview, accept and deny this payment. OTHER No additional specific reason can be provided. For more information about this captured payment, visit your account online or contact processor. PENDING_REVIEW The captured payment is pending manual review. RECEIVING_PREFERENCE_MANDATES_MANUAL_ACTION The payee has not yet set up appropriate receiving preferences for their account. For more information about how to accept or deny this payment, visit your account online. This reason is typically offered in scenarios such as when the currency of the captured payment is different from the primary holding currency of the payee. REFUNDED The captured funds were refunded. TRANSACTION_APPROVED_AWAITING_FUNDING The payer must send the funds for this captured payment. This code generally appears for manual EFTs. UNILATERAL The payee does not have a processor account. VERIFICATION_REQUIRED The payee&#39;s processor account is not verified. String with values,  &#x60;BUYER_COMPLAINT&#x60;  &#x60;CHARGEBACK&#x60;  &#x60;ECHECK&#x60;  &#x60;INTERNATIONAL_WITHDRAWAL&#x60;  &#x60;OTHER&#x60;  &#x60;PENDING_REVIEW&#x60;  &#x60;RECEIVING_PREFERENCE_MANDATES_MANUAL_ACTION&#x60;  &#x60;REFUNDED&#x60;  &#x60;TRANSACTION_APPROVED_AWAITING_FUNDING&#x60;  &#x60;UNILATERAL&#x60;  &#x60;VERIFICATION_REQUIRED&#x60; .</param>
        public PtsV2PaymentsCapturesPost201ResponseEmbeddedActionsApCapture(string Reason = default(string))
        {
            this.Reason = Reason;
        }
        
        /// <summary>
        /// The reason why the captured payment status is PENDING or DENIED. BUYER_COMPLAINT The payer initiated a dispute for this captured payment with processor. CHARGEBACK The captured funds were reversed in response to the payer disputing this captured payment with the issuer of the financial instrument used to pay for this captured payment. ECHECK The payer paid by an eCheck that has not yet cleared. INTERNATIONAL_WITHDRAWAL Visit your online account. In your Account Overview, accept and deny this payment. OTHER No additional specific reason can be provided. For more information about this captured payment, visit your account online or contact processor. PENDING_REVIEW The captured payment is pending manual review. RECEIVING_PREFERENCE_MANDATES_MANUAL_ACTION The payee has not yet set up appropriate receiving preferences for their account. For more information about how to accept or deny this payment, visit your account online. This reason is typically offered in scenarios such as when the currency of the captured payment is different from the primary holding currency of the payee. REFUNDED The captured funds were refunded. TRANSACTION_APPROVED_AWAITING_FUNDING The payer must send the funds for this captured payment. This code generally appears for manual EFTs. UNILATERAL The payee does not have a processor account. VERIFICATION_REQUIRED The payee&#39;s processor account is not verified. String with values,  &#x60;BUYER_COMPLAINT&#x60;  &#x60;CHARGEBACK&#x60;  &#x60;ECHECK&#x60;  &#x60;INTERNATIONAL_WITHDRAWAL&#x60;  &#x60;OTHER&#x60;  &#x60;PENDING_REVIEW&#x60;  &#x60;RECEIVING_PREFERENCE_MANDATES_MANUAL_ACTION&#x60;  &#x60;REFUNDED&#x60;  &#x60;TRANSACTION_APPROVED_AWAITING_FUNDING&#x60;  &#x60;UNILATERAL&#x60;  &#x60;VERIFICATION_REQUIRED&#x60; 
        /// </summary>
        /// <value>The reason why the captured payment status is PENDING or DENIED. BUYER_COMPLAINT The payer initiated a dispute for this captured payment with processor. CHARGEBACK The captured funds were reversed in response to the payer disputing this captured payment with the issuer of the financial instrument used to pay for this captured payment. ECHECK The payer paid by an eCheck that has not yet cleared. INTERNATIONAL_WITHDRAWAL Visit your online account. In your Account Overview, accept and deny this payment. OTHER No additional specific reason can be provided. For more information about this captured payment, visit your account online or contact processor. PENDING_REVIEW The captured payment is pending manual review. RECEIVING_PREFERENCE_MANDATES_MANUAL_ACTION The payee has not yet set up appropriate receiving preferences for their account. For more information about how to accept or deny this payment, visit your account online. This reason is typically offered in scenarios such as when the currency of the captured payment is different from the primary holding currency of the payee. REFUNDED The captured funds were refunded. TRANSACTION_APPROVED_AWAITING_FUNDING The payer must send the funds for this captured payment. This code generally appears for manual EFTs. UNILATERAL The payee does not have a processor account. VERIFICATION_REQUIRED The payee&#39;s processor account is not verified. String with values,  &#x60;BUYER_COMPLAINT&#x60;  &#x60;CHARGEBACK&#x60;  &#x60;ECHECK&#x60;  &#x60;INTERNATIONAL_WITHDRAWAL&#x60;  &#x60;OTHER&#x60;  &#x60;PENDING_REVIEW&#x60;  &#x60;RECEIVING_PREFERENCE_MANDATES_MANUAL_ACTION&#x60;  &#x60;REFUNDED&#x60;  &#x60;TRANSACTION_APPROVED_AWAITING_FUNDING&#x60;  &#x60;UNILATERAL&#x60;  &#x60;VERIFICATION_REQUIRED&#x60; </value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PaymentsCapturesPost201ResponseEmbeddedActionsApCapture {\n");
            if (Reason != null) sb.Append("  Reason: ").Append(Reason).Append("\n");
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
            return this.Equals(obj as PtsV2PaymentsCapturesPost201ResponseEmbeddedActionsApCapture);
        }

        /// <summary>
        /// Returns true if PtsV2PaymentsCapturesPost201ResponseEmbeddedActionsApCapture instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PaymentsCapturesPost201ResponseEmbeddedActionsApCapture to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PaymentsCapturesPost201ResponseEmbeddedActionsApCapture other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
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
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
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
