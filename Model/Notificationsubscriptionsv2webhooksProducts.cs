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
    /// Notificationsubscriptionsv2webhooksProducts
    /// </summary>
    [DataContract]
    public partial class Notificationsubscriptionsv2webhooksProducts :  IEquatable<Notificationsubscriptionsv2webhooksProducts>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Notificationsubscriptionsv2webhooksProducts" /> class.
        /// </summary>
        /// <param name="ProductId">Product ID..</param>
        /// <param name="EventTypes">EventTypes.</param>
        public Notificationsubscriptionsv2webhooksProducts(string ProductId = default(string), List<string> EventTypes = default(List<string>))
        {
            this.ProductId = ProductId;
            this.EventTypes = EventTypes;
        }
        
        /// <summary>
        /// Product ID.
        /// </summary>
        /// <value>Product ID.</value>
        [DataMember(Name="productId", EmitDefaultValue=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// Gets or Sets EventTypes
        /// </summary>
        [DataMember(Name="eventTypes", EmitDefaultValue=false)]
        public List<string> EventTypes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Notificationsubscriptionsv2webhooksProducts {\n");
            if (ProductId != null) sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            if (EventTypes != null) sb.Append("  EventTypes: ").Append(EventTypes).Append("\n");
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
            return this.Equals(obj as Notificationsubscriptionsv2webhooksProducts);
        }

        /// <summary>
        /// Returns true if Notificationsubscriptionsv2webhooksProducts instances are equal
        /// </summary>
        /// <param name="other">Instance of Notificationsubscriptionsv2webhooksProducts to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Notificationsubscriptionsv2webhooksProducts other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ProductId == other.ProductId ||
                    this.ProductId != null &&
                    this.ProductId.Equals(other.ProductId)
                ) && 
                (
                    this.EventTypes == other.EventTypes ||
                    this.EventTypes != null &&
                    this.EventTypes.SequenceEqual(other.EventTypes)
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
                if (this.ProductId != null)
                    hash = hash * 59 + this.ProductId.GetHashCode();
                if (this.EventTypes != null)
                    hash = hash * 59 + this.EventTypes.GetHashCode();
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
