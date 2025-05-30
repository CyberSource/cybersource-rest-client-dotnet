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
    /// SAConfig
    /// </summary>
    [DataContract]
    public partial class SAConfig :  IEquatable<SAConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SAConfig" /> class.
        /// </summary>
        /// <param name="ParentProfileId">You can group Secure Acceptance profiles under parent profiles. By changing the parent profile, you can update all profiles underneath that parent. Specify the Parent Profile ID here..</param>
        /// <param name="ContactInformation">ContactInformation.</param>
        /// <param name="Notifications">Notifications.</param>
        /// <param name="Service">Service.</param>
        /// <param name="PaymentMethods">PaymentMethods.</param>
        /// <param name="Checkout">Checkout.</param>
        /// <param name="PaymentTypes">PaymentTypes.</param>
        public SAConfig(string ParentProfileId = default(string), SAConfigContactInformation ContactInformation = default(SAConfigContactInformation), SAConfigNotifications Notifications = default(SAConfigNotifications), SAConfigService Service = default(SAConfigService), SAConfigPaymentMethods PaymentMethods = default(SAConfigPaymentMethods), SAConfigCheckout Checkout = default(SAConfigCheckout), SAConfigPaymentTypes PaymentTypes = default(SAConfigPaymentTypes))
        {
            this.ParentProfileId = ParentProfileId;
            this.ContactInformation = ContactInformation;
            this.Notifications = Notifications;
            this.Service = Service;
            this.PaymentMethods = PaymentMethods;
            this.Checkout = Checkout;
            this.PaymentTypes = PaymentTypes;
        }
        
        /// <summary>
        /// You can group Secure Acceptance profiles under parent profiles. By changing the parent profile, you can update all profiles underneath that parent. Specify the Parent Profile ID here.
        /// </summary>
        /// <value>You can group Secure Acceptance profiles under parent profiles. By changing the parent profile, you can update all profiles underneath that parent. Specify the Parent Profile ID here.</value>
        [DataMember(Name="parentProfileId", EmitDefaultValue=false)]
        public string ParentProfileId { get; set; }

        /// <summary>
        /// Gets or Sets ContactInformation
        /// </summary>
        [DataMember(Name="contactInformation", EmitDefaultValue=false)]
        public SAConfigContactInformation ContactInformation { get; set; }

        /// <summary>
        /// Gets or Sets Notifications
        /// </summary>
        [DataMember(Name="notifications", EmitDefaultValue=false)]
        public SAConfigNotifications Notifications { get; set; }

        /// <summary>
        /// Gets or Sets Service
        /// </summary>
        [DataMember(Name="service", EmitDefaultValue=false)]
        public SAConfigService Service { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethods
        /// </summary>
        [DataMember(Name="paymentMethods", EmitDefaultValue=false)]
        public SAConfigPaymentMethods PaymentMethods { get; set; }

        /// <summary>
        /// Gets or Sets Checkout
        /// </summary>
        [DataMember(Name="checkout", EmitDefaultValue=false)]
        public SAConfigCheckout Checkout { get; set; }

        /// <summary>
        /// Gets or Sets PaymentTypes
        /// </summary>
        [DataMember(Name="paymentTypes", EmitDefaultValue=false)]
        public SAConfigPaymentTypes PaymentTypes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SAConfig {\n");
            if (ParentProfileId != null) sb.Append("  ParentProfileId: ").Append(ParentProfileId).Append("\n");
            if (ContactInformation != null) sb.Append("  ContactInformation: ").Append(ContactInformation).Append("\n");
            if (Notifications != null) sb.Append("  Notifications: ").Append(Notifications).Append("\n");
            if (Service != null) sb.Append("  Service: ").Append(Service).Append("\n");
            if (PaymentMethods != null) sb.Append("  PaymentMethods: ").Append(PaymentMethods).Append("\n");
            if (Checkout != null) sb.Append("  Checkout: ").Append(Checkout).Append("\n");
            if (PaymentTypes != null) sb.Append("  PaymentTypes: ").Append(PaymentTypes).Append("\n");
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
            return this.Equals(obj as SAConfig);
        }

        /// <summary>
        /// Returns true if SAConfig instances are equal
        /// </summary>
        /// <param name="other">Instance of SAConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SAConfig other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ParentProfileId == other.ParentProfileId ||
                    this.ParentProfileId != null &&
                    this.ParentProfileId.Equals(other.ParentProfileId)
                ) && 
                (
                    this.ContactInformation == other.ContactInformation ||
                    this.ContactInformation != null &&
                    this.ContactInformation.Equals(other.ContactInformation)
                ) && 
                (
                    this.Notifications == other.Notifications ||
                    this.Notifications != null &&
                    this.Notifications.Equals(other.Notifications)
                ) && 
                (
                    this.Service == other.Service ||
                    this.Service != null &&
                    this.Service.Equals(other.Service)
                ) && 
                (
                    this.PaymentMethods == other.PaymentMethods ||
                    this.PaymentMethods != null &&
                    this.PaymentMethods.Equals(other.PaymentMethods)
                ) && 
                (
                    this.Checkout == other.Checkout ||
                    this.Checkout != null &&
                    this.Checkout.Equals(other.Checkout)
                ) && 
                (
                    this.PaymentTypes == other.PaymentTypes ||
                    this.PaymentTypes != null &&
                    this.PaymentTypes.Equals(other.PaymentTypes)
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
                if (this.ParentProfileId != null)
                    hash = hash * 59 + this.ParentProfileId.GetHashCode();
                if (this.ContactInformation != null)
                    hash = hash * 59 + this.ContactInformation.GetHashCode();
                if (this.Notifications != null)
                    hash = hash * 59 + this.Notifications.GetHashCode();
                if (this.Service != null)
                    hash = hash * 59 + this.Service.GetHashCode();
                if (this.PaymentMethods != null)
                    hash = hash * 59 + this.PaymentMethods.GetHashCode();
                if (this.Checkout != null)
                    hash = hash * 59 + this.Checkout.GetHashCode();
                if (this.PaymentTypes != null)
                    hash = hash * 59 + this.PaymentTypes.GetHashCode();
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
