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
    /// TmsSensitivePrivileges
    /// </summary>
    [DataContract]
    public partial class TmsSensitivePrivileges :  IEquatable<TmsSensitivePrivileges>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TmsSensitivePrivileges" /> class.
        /// </summary>
        /// <param name="CardNumberMaskingFormat">Indicates which digits of the card number will be unmasked.  Possible Values:    - &#39;FIRST_6_LAST_4&#39;   - &#39;LAST_4&#39;   - &#39;MASKED&#39; .</param>
        public TmsSensitivePrivileges(string CardNumberMaskingFormat = default(string))
        {
            this.CardNumberMaskingFormat = CardNumberMaskingFormat;
        }
        
        /// <summary>
        /// Indicates which digits of the card number will be unmasked.  Possible Values:    - &#39;FIRST_6_LAST_4&#39;   - &#39;LAST_4&#39;   - &#39;MASKED&#39; 
        /// </summary>
        /// <value>Indicates which digits of the card number will be unmasked.  Possible Values:    - &#39;FIRST_6_LAST_4&#39;   - &#39;LAST_4&#39;   - &#39;MASKED&#39; </value>
        [DataMember(Name="cardNumberMaskingFormat", EmitDefaultValue=false)]
        public string CardNumberMaskingFormat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TmsSensitivePrivileges {\n");
            if (CardNumberMaskingFormat != null) sb.Append("  CardNumberMaskingFormat: ").Append(CardNumberMaskingFormat).Append("\n");
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
            return this.Equals(obj as TmsSensitivePrivileges);
        }

        /// <summary>
        /// Returns true if TmsSensitivePrivileges instances are equal
        /// </summary>
        /// <param name="other">Instance of TmsSensitivePrivileges to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TmsSensitivePrivileges other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CardNumberMaskingFormat == other.CardNumberMaskingFormat ||
                    this.CardNumberMaskingFormat != null &&
                    this.CardNumberMaskingFormat.Equals(other.CardNumberMaskingFormat)
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
                if (this.CardNumberMaskingFormat != null)
                    hash = hash * 59 + this.CardNumberMaskingFormat.GetHashCode();
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
