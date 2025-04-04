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
    /// Accountupdaterv1batchesIncluded
    /// </summary>
    [DataContract]
    public partial class Accountupdaterv1batchesIncluded :  IEquatable<Accountupdaterv1batchesIncluded>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Accountupdaterv1batchesIncluded" /> class.
        /// </summary>
        /// <param name="Tokens">Tokens.</param>
        public Accountupdaterv1batchesIncluded(List<Accountupdaterv1batchesIncludedTokens> Tokens = default(List<Accountupdaterv1batchesIncludedTokens>))
        {
            this.Tokens = Tokens;
        }
        
        /// <summary>
        /// Gets or Sets Tokens
        /// </summary>
        [DataMember(Name="tokens", EmitDefaultValue=false)]
        public List<Accountupdaterv1batchesIncludedTokens> Tokens { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Accountupdaterv1batchesIncluded {\n");
            if (Tokens != null) sb.Append("  Tokens: ").Append(Tokens).Append("\n");
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
            return this.Equals(obj as Accountupdaterv1batchesIncluded);
        }

        /// <summary>
        /// Returns true if Accountupdaterv1batchesIncluded instances are equal
        /// </summary>
        /// <param name="other">Instance of Accountupdaterv1batchesIncluded to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Accountupdaterv1batchesIncluded other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Tokens == other.Tokens ||
                    this.Tokens != null &&
                    this.Tokens.SequenceEqual(other.Tokens)
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
                if (this.Tokens != null)
                    hash = hash * 59 + this.Tokens.GetHashCode();
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
