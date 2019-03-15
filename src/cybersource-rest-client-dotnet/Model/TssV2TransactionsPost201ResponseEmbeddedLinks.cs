/* 
 * CyberSource Flex API
 *
 * Simple PAN tokenization service
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace CyberSource.Model
{
    /// <summary>
    /// TssV2TransactionsPost201ResponseEmbeddedLinks
    /// </summary>
    [DataContract]
    public partial class TssV2TransactionsPost201ResponseEmbeddedLinks :  IEquatable<TssV2TransactionsPost201ResponseEmbeddedLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TssV2TransactionsPost201ResponseEmbeddedLinks" /> class.
        /// </summary>
        /// <param name="TransactionDetail">TransactionDetail.</param>
        public TssV2TransactionsPost201ResponseEmbeddedLinks(PtsV2PaymentsPost201ResponseLinksSelf TransactionDetail = default(PtsV2PaymentsPost201ResponseLinksSelf))
        {
            this.TransactionDetail = TransactionDetail;
        }
        
        /// <summary>
        /// Gets or Sets TransactionDetail
        /// </summary>
        [DataMember(Name="transactionDetail", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseLinksSelf TransactionDetail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TssV2TransactionsPost201ResponseEmbeddedLinks {\n");
            sb.Append("  TransactionDetail: ").Append(TransactionDetail).Append("\n");
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
            return this.Equals(obj as TssV2TransactionsPost201ResponseEmbeddedLinks);
        }

        /// <summary>
        /// Returns true if TssV2TransactionsPost201ResponseEmbeddedLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of TssV2TransactionsPost201ResponseEmbeddedLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TssV2TransactionsPost201ResponseEmbeddedLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TransactionDetail == other.TransactionDetail ||
                    this.TransactionDetail != null &&
                    this.TransactionDetail.Equals(other.TransactionDetail)
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
                if (this.TransactionDetail != null)
                    hash = hash * 59 + this.TransactionDetail.GetHashCode();
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