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
    /// PtsV2PaymentsRefundPost201ResponseClientReferenceInformation
    /// </summary>
    [DataContract]
    public partial class PtsV2PaymentsRefundPost201ResponseClientReferenceInformation :  IEquatable<PtsV2PaymentsRefundPost201ResponseClientReferenceInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PaymentsRefundPost201ResponseClientReferenceInformation" /> class.
        /// </summary>
        /// <param name="Code">Merchant-generated order reference or tracking number. It is recommended that you send a unique value for each transaction so that you can perform meaningful searches for the transaction.  #### Used by **Authorization** Required field.  #### PIN Debit Requests for PIN debit reversals need to use the same merchant reference number that was used in the transaction that is being reversed.  Required field for all PIN Debit requests (purchase, credit, and reversal).  #### FDC Nashville Global Certain circumstances can cause the processor to truncate this value to 15 or 17 characters for Level II and Level III processing, which can cause a discrepancy between the value you submit and the value included in some processor reports. .</param>
        /// <param name="SubmitLocalDateTime">Date and time at your physical location.  Format: &#x60;YYYYMMDDhhmmss&#x60;, where YYYY &#x3D; year, MM &#x3D; month, DD &#x3D; day, hh &#x3D; hour, mm &#x3D; minutes ss &#x3D; seconds  #### PIN Debit Optional field for PIN Debit purchase and credit requests. .</param>
        /// <param name="OwnerMerchantId">Merchant ID that was used to create the subscription or customer profile for which the service was requested.  If your CyberSource account is enabled for Recurring Billing, this field is returned only if you are using subscription sharing and if your merchant ID is in the same merchant ID pool as the owner merchant ID.  If your CyberSource account is enabled for Payment Tokenization, this field is returned only if you are using profile sharing and if your merchant ID is in the same merchant ID pool as the owner merchant ID. .</param>
        /// <param name="ReturnReconciliationId">A new ID which is created for refund.</param>
        public PtsV2PaymentsRefundPost201ResponseClientReferenceInformation(string Code = default(string), string SubmitLocalDateTime = default(string), string OwnerMerchantId = default(string), string ReturnReconciliationId = default(string))
        {
            this.Code = Code;
            this.SubmitLocalDateTime = SubmitLocalDateTime;
            this.OwnerMerchantId = OwnerMerchantId;
            this.ReturnReconciliationId = ReturnReconciliationId;
        }
        
        /// <summary>
        /// Merchant-generated order reference or tracking number. It is recommended that you send a unique value for each transaction so that you can perform meaningful searches for the transaction.  #### Used by **Authorization** Required field.  #### PIN Debit Requests for PIN debit reversals need to use the same merchant reference number that was used in the transaction that is being reversed.  Required field for all PIN Debit requests (purchase, credit, and reversal).  #### FDC Nashville Global Certain circumstances can cause the processor to truncate this value to 15 or 17 characters for Level II and Level III processing, which can cause a discrepancy between the value you submit and the value included in some processor reports. 
        /// </summary>
        /// <value>Merchant-generated order reference or tracking number. It is recommended that you send a unique value for each transaction so that you can perform meaningful searches for the transaction.  #### Used by **Authorization** Required field.  #### PIN Debit Requests for PIN debit reversals need to use the same merchant reference number that was used in the transaction that is being reversed.  Required field for all PIN Debit requests (purchase, credit, and reversal).  #### FDC Nashville Global Certain circumstances can cause the processor to truncate this value to 15 or 17 characters for Level II and Level III processing, which can cause a discrepancy between the value you submit and the value included in some processor reports. </value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Date and time at your physical location.  Format: &#x60;YYYYMMDDhhmmss&#x60;, where YYYY &#x3D; year, MM &#x3D; month, DD &#x3D; day, hh &#x3D; hour, mm &#x3D; minutes ss &#x3D; seconds  #### PIN Debit Optional field for PIN Debit purchase and credit requests. 
        /// </summary>
        /// <value>Date and time at your physical location.  Format: &#x60;YYYYMMDDhhmmss&#x60;, where YYYY &#x3D; year, MM &#x3D; month, DD &#x3D; day, hh &#x3D; hour, mm &#x3D; minutes ss &#x3D; seconds  #### PIN Debit Optional field for PIN Debit purchase and credit requests. </value>
        [DataMember(Name="submitLocalDateTime", EmitDefaultValue=false)]
        public string SubmitLocalDateTime { get; set; }

        /// <summary>
        /// Merchant ID that was used to create the subscription or customer profile for which the service was requested.  If your CyberSource account is enabled for Recurring Billing, this field is returned only if you are using subscription sharing and if your merchant ID is in the same merchant ID pool as the owner merchant ID.  If your CyberSource account is enabled for Payment Tokenization, this field is returned only if you are using profile sharing and if your merchant ID is in the same merchant ID pool as the owner merchant ID. 
        /// </summary>
        /// <value>Merchant ID that was used to create the subscription or customer profile for which the service was requested.  If your CyberSource account is enabled for Recurring Billing, this field is returned only if you are using subscription sharing and if your merchant ID is in the same merchant ID pool as the owner merchant ID.  If your CyberSource account is enabled for Payment Tokenization, this field is returned only if you are using profile sharing and if your merchant ID is in the same merchant ID pool as the owner merchant ID. </value>
        [DataMember(Name="ownerMerchantId", EmitDefaultValue=false)]
        public string OwnerMerchantId { get; set; }

        /// <summary>
        /// A new ID which is created for refund
        /// </summary>
        /// <value>A new ID which is created for refund</value>
        [DataMember(Name="returnReconciliationId", EmitDefaultValue=false)]
        public string ReturnReconciliationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PaymentsRefundPost201ResponseClientReferenceInformation {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  SubmitLocalDateTime: ").Append(SubmitLocalDateTime).Append("\n");
            sb.Append("  OwnerMerchantId: ").Append(OwnerMerchantId).Append("\n");
            sb.Append("  ReturnReconciliationId: ").Append(ReturnReconciliationId).Append("\n");
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
            return this.Equals(obj as PtsV2PaymentsRefundPost201ResponseClientReferenceInformation);
        }

        /// <summary>
        /// Returns true if PtsV2PaymentsRefundPost201ResponseClientReferenceInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PaymentsRefundPost201ResponseClientReferenceInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PaymentsRefundPost201ResponseClientReferenceInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.SubmitLocalDateTime == other.SubmitLocalDateTime ||
                    this.SubmitLocalDateTime != null &&
                    this.SubmitLocalDateTime.Equals(other.SubmitLocalDateTime)
                ) && 
                (
                    this.OwnerMerchantId == other.OwnerMerchantId ||
                    this.OwnerMerchantId != null &&
                    this.OwnerMerchantId.Equals(other.OwnerMerchantId)
                ) && 
                (
                    this.ReturnReconciliationId == other.ReturnReconciliationId ||
                    this.ReturnReconciliationId != null &&
                    this.ReturnReconciliationId.Equals(other.ReturnReconciliationId)
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
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this.SubmitLocalDateTime != null)
                    hash = hash * 59 + this.SubmitLocalDateTime.GetHashCode();
                if (this.OwnerMerchantId != null)
                    hash = hash * 59 + this.OwnerMerchantId.GetHashCode();
                if (this.ReturnReconciliationId != null)
                    hash = hash * 59 + this.ReturnReconciliationId.GetHashCode();
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