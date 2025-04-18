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
    /// VasV2PaymentsPost201ResponseTaxInformation
    /// </summary>
    [DataContract]
    public partial class VasV2PaymentsPost201ResponseTaxInformation :  IEquatable<VasV2PaymentsPost201ResponseTaxInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VasV2PaymentsPost201ResponseTaxInformation" /> class.
        /// </summary>
        /// <param name="CommitIndicator">Indicates whether this is a committed tax transaction. For a committed tax transaction, the status in the Tax Detail Report is \&quot;Committed.\&quot; For an uncommitted tax transaction, the status in the Tax Detail Report is \&quot;Uncommitted.\&quot; Possible values: - &#x60;true&#x60;: This is a committed tax transaction. - &#x60;false&#x60; (default): This is not a committed tax transaction.  A committed tax request is a tax service request that sets the status field in the Tax Detail Report to committed. The committed status indicates that the amount calculated by the tax service is included in the amount of a capture or credit.  Use a void service request to cancel a committed tax request or a committed refund tax request. The void transaction is included as a separate entry in the Tax Detail Report. The value of the status field is cancelled. The value of the link ID is the request ID of the committed tax request or refund tax request that was voided. You can use the value of the link ID to reconcile your orders.  Optional for U.S., Canadian, international tax, and value added taxes. For more information on Tax Detail Report features refer the [Tax Service Guide](https://developer.cybersource.com/docs/cybs/en-us/tax-calculation/developer/all/rest/tax-calculation/tax-overview.html). .</param>
        /// <param name="RefundIndicator">Indicates whether this is a refund tax transaction. For a refund tax transaction, amounts in the Tax Detail Report will be negative. Possible values: - &#x60;true&#x60;: This is a refund tax transaction. - &#x60;false&#x60; (default): This is not a refund tax transaction.  A refund tax request is a tax service request that sets the transaction type field in the Tax Detail Report to refunded and makes the reported amount negative. Tax amounts are returned as positive amounts in reply messages, but they are saved in reports as negative amounts which enables the reporting software to accurately calculate the aggregate amounts.  Optional for U.S., Canadian, international tax, and value added taxes. For more information on Tax Detail Report features refer the [Tax Service Guide](https://developer.cybersource.com/docs/cybs/en-us/tax-calculation/developer/all/rest/tax-calculation/tax-overview.html). .</param>
        public VasV2PaymentsPost201ResponseTaxInformation(bool? CommitIndicator = default(bool?), bool? RefundIndicator = default(bool?))
        {
            this.CommitIndicator = CommitIndicator;
            this.RefundIndicator = RefundIndicator;
        }
        
        /// <summary>
        /// Indicates whether this is a committed tax transaction. For a committed tax transaction, the status in the Tax Detail Report is \&quot;Committed.\&quot; For an uncommitted tax transaction, the status in the Tax Detail Report is \&quot;Uncommitted.\&quot; Possible values: - &#x60;true&#x60;: This is a committed tax transaction. - &#x60;false&#x60; (default): This is not a committed tax transaction.  A committed tax request is a tax service request that sets the status field in the Tax Detail Report to committed. The committed status indicates that the amount calculated by the tax service is included in the amount of a capture or credit.  Use a void service request to cancel a committed tax request or a committed refund tax request. The void transaction is included as a separate entry in the Tax Detail Report. The value of the status field is cancelled. The value of the link ID is the request ID of the committed tax request or refund tax request that was voided. You can use the value of the link ID to reconcile your orders.  Optional for U.S., Canadian, international tax, and value added taxes. For more information on Tax Detail Report features refer the [Tax Service Guide](https://developer.cybersource.com/docs/cybs/en-us/tax-calculation/developer/all/rest/tax-calculation/tax-overview.html). 
        /// </summary>
        /// <value>Indicates whether this is a committed tax transaction. For a committed tax transaction, the status in the Tax Detail Report is \&quot;Committed.\&quot; For an uncommitted tax transaction, the status in the Tax Detail Report is \&quot;Uncommitted.\&quot; Possible values: - &#x60;true&#x60;: This is a committed tax transaction. - &#x60;false&#x60; (default): This is not a committed tax transaction.  A committed tax request is a tax service request that sets the status field in the Tax Detail Report to committed. The committed status indicates that the amount calculated by the tax service is included in the amount of a capture or credit.  Use a void service request to cancel a committed tax request or a committed refund tax request. The void transaction is included as a separate entry in the Tax Detail Report. The value of the status field is cancelled. The value of the link ID is the request ID of the committed tax request or refund tax request that was voided. You can use the value of the link ID to reconcile your orders.  Optional for U.S., Canadian, international tax, and value added taxes. For more information on Tax Detail Report features refer the [Tax Service Guide](https://developer.cybersource.com/docs/cybs/en-us/tax-calculation/developer/all/rest/tax-calculation/tax-overview.html). </value>
        [DataMember(Name="commitIndicator", EmitDefaultValue=false)]
        public bool? CommitIndicator { get; set; }

        /// <summary>
        /// Indicates whether this is a refund tax transaction. For a refund tax transaction, amounts in the Tax Detail Report will be negative. Possible values: - &#x60;true&#x60;: This is a refund tax transaction. - &#x60;false&#x60; (default): This is not a refund tax transaction.  A refund tax request is a tax service request that sets the transaction type field in the Tax Detail Report to refunded and makes the reported amount negative. Tax amounts are returned as positive amounts in reply messages, but they are saved in reports as negative amounts which enables the reporting software to accurately calculate the aggregate amounts.  Optional for U.S., Canadian, international tax, and value added taxes. For more information on Tax Detail Report features refer the [Tax Service Guide](https://developer.cybersource.com/docs/cybs/en-us/tax-calculation/developer/all/rest/tax-calculation/tax-overview.html). 
        /// </summary>
        /// <value>Indicates whether this is a refund tax transaction. For a refund tax transaction, amounts in the Tax Detail Report will be negative. Possible values: - &#x60;true&#x60;: This is a refund tax transaction. - &#x60;false&#x60; (default): This is not a refund tax transaction.  A refund tax request is a tax service request that sets the transaction type field in the Tax Detail Report to refunded and makes the reported amount negative. Tax amounts are returned as positive amounts in reply messages, but they are saved in reports as negative amounts which enables the reporting software to accurately calculate the aggregate amounts.  Optional for U.S., Canadian, international tax, and value added taxes. For more information on Tax Detail Report features refer the [Tax Service Guide](https://developer.cybersource.com/docs/cybs/en-us/tax-calculation/developer/all/rest/tax-calculation/tax-overview.html). </value>
        [DataMember(Name="refundIndicator", EmitDefaultValue=false)]
        public bool? RefundIndicator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VasV2PaymentsPost201ResponseTaxInformation {\n");
            if (CommitIndicator != null) sb.Append("  CommitIndicator: ").Append(CommitIndicator).Append("\n");
            if (RefundIndicator != null) sb.Append("  RefundIndicator: ").Append(RefundIndicator).Append("\n");
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
            return this.Equals(obj as VasV2PaymentsPost201ResponseTaxInformation);
        }

        /// <summary>
        /// Returns true if VasV2PaymentsPost201ResponseTaxInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of VasV2PaymentsPost201ResponseTaxInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VasV2PaymentsPost201ResponseTaxInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CommitIndicator == other.CommitIndicator ||
                    this.CommitIndicator != null &&
                    this.CommitIndicator.Equals(other.CommitIndicator)
                ) && 
                (
                    this.RefundIndicator == other.RefundIndicator ||
                    this.RefundIndicator != null &&
                    this.RefundIndicator.Equals(other.RefundIndicator)
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
                if (this.CommitIndicator != null)
                    hash = hash * 59 + this.CommitIndicator.GetHashCode();
                if (this.RefundIndicator != null)
                    hash = hash * 59 + this.RefundIndicator.GetHashCode();
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
