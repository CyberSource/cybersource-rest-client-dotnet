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
    /// UpdateWebhookRequest
    /// </summary>
    [DataContract]
    public partial class UpdateWebhookRequest :  IEquatable<UpdateWebhookRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWebhookRequest" /> class.
        /// </summary>
        /// <param name="Name">Client friendly webhook name..</param>
        /// <param name="Description">Client friendly webhook description.\\.</param>
        /// <param name="OrganizationId">Organization Id..</param>
        /// <param name="ProductId">The product you are receiving a webhook for..</param>
        /// <param name="EventTypes">Array of the different events for a given product id..</param>
        /// <param name="WebhookUrl">The client&#39;s endpoint (URL) to receive webhooks..</param>
        /// <param name="HealthCheckUrl">The client&#39;s health check endpoint (URL). This should be as close as possible to the actual webhookUrl..</param>
        /// <param name="Status">Webhook status. (default to &quot;INACTIVE&quot;).</param>
        /// <param name="NotificationScope">NotificationScope.</param>
        /// <param name="RetryPolicy">RetryPolicy.</param>
        /// <param name="SecurityPolicy">SecurityPolicy.</param>
        /// <param name="AdditionalAttributes">Additional, free form configuration data..</param>
        public UpdateWebhookRequest(string Name = default(string), string Description = default(string), string OrganizationId = default(string), string ProductId = default(string), List<string> EventTypes = default(List<string>), string WebhookUrl = default(string), string HealthCheckUrl = default(string), string Status = "INACTIVE", Notificationsubscriptionsv1webhooksNotificationScope NotificationScope = default(Notificationsubscriptionsv1webhooksNotificationScope), Notificationsubscriptionsv1webhooksRetryPolicy RetryPolicy = default(Notificationsubscriptionsv1webhooksRetryPolicy), Notificationsubscriptionsv1webhooksSecurityPolicy SecurityPolicy = default(Notificationsubscriptionsv1webhooksSecurityPolicy), List<Dictionary<string, string>> AdditionalAttributes = default(List<Dictionary<string, string>>))
        {
            this.Name = Name;
            this.Description = Description;
            this.OrganizationId = OrganizationId;
            this.ProductId = ProductId;
            this.EventTypes = EventTypes;
            this.WebhookUrl = WebhookUrl;
            this.HealthCheckUrl = HealthCheckUrl;
            // use default value if no "Status" provided
            if (Status == null)
            {
                this.Status = "INACTIVE";
            }
            else
            {
                this.Status = Status;
            }
            this.NotificationScope = NotificationScope;
            this.RetryPolicy = RetryPolicy;
            this.SecurityPolicy = SecurityPolicy;
            this.AdditionalAttributes = AdditionalAttributes;
        }
        
        /// <summary>
        /// Client friendly webhook name.
        /// </summary>
        /// <value>Client friendly webhook name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Client friendly webhook description.\\
        /// </summary>
        /// <value>Client friendly webhook description.\\</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Organization Id.
        /// </summary>
        /// <value>Organization Id.</value>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// The product you are receiving a webhook for.
        /// </summary>
        /// <value>The product you are receiving a webhook for.</value>
        [DataMember(Name="productId", EmitDefaultValue=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// Array of the different events for a given product id.
        /// </summary>
        /// <value>Array of the different events for a given product id.</value>
        [DataMember(Name="eventTypes", EmitDefaultValue=false)]
        public List<string> EventTypes { get; set; }

        /// <summary>
        /// The client&#39;s endpoint (URL) to receive webhooks.
        /// </summary>
        /// <value>The client&#39;s endpoint (URL) to receive webhooks.</value>
        [DataMember(Name="webhookUrl", EmitDefaultValue=false)]
        public string WebhookUrl { get; set; }

        /// <summary>
        /// The client&#39;s health check endpoint (URL). This should be as close as possible to the actual webhookUrl.
        /// </summary>
        /// <value>The client&#39;s health check endpoint (URL). This should be as close as possible to the actual webhookUrl.</value>
        [DataMember(Name="healthCheckUrl", EmitDefaultValue=false)]
        public string HealthCheckUrl { get; set; }

        /// <summary>
        /// Webhook status.
        /// </summary>
        /// <value>Webhook status.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets NotificationScope
        /// </summary>
        [DataMember(Name="notificationScope", EmitDefaultValue=false)]
        public Notificationsubscriptionsv1webhooksNotificationScope NotificationScope { get; set; }

        /// <summary>
        /// Gets or Sets RetryPolicy
        /// </summary>
        [DataMember(Name="retryPolicy", EmitDefaultValue=false)]
        public Notificationsubscriptionsv1webhooksRetryPolicy RetryPolicy { get; set; }

        /// <summary>
        /// Gets or Sets SecurityPolicy
        /// </summary>
        [DataMember(Name="securityPolicy", EmitDefaultValue=false)]
        public Notificationsubscriptionsv1webhooksSecurityPolicy SecurityPolicy { get; set; }

        /// <summary>
        /// Additional, free form configuration data.
        /// </summary>
        /// <value>Additional, free form configuration data.</value>
        [DataMember(Name="additionalAttributes", EmitDefaultValue=false)]
        public List<Dictionary<string, string>> AdditionalAttributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateWebhookRequest {\n");
            if (Name != null) sb.Append("  Name: ").Append(Name).Append("\n");
            if (Description != null) sb.Append("  Description: ").Append(Description).Append("\n");
            if (OrganizationId != null) sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            if (ProductId != null) sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            if (EventTypes != null) sb.Append("  EventTypes: ").Append(EventTypes).Append("\n");
            if (WebhookUrl != null) sb.Append("  WebhookUrl: ").Append(WebhookUrl).Append("\n");
            if (HealthCheckUrl != null) sb.Append("  HealthCheckUrl: ").Append(HealthCheckUrl).Append("\n");
            if (Status != null) sb.Append("  Status: ").Append(Status).Append("\n");
            if (NotificationScope != null) sb.Append("  NotificationScope: ").Append(NotificationScope).Append("\n");
            if (RetryPolicy != null) sb.Append("  RetryPolicy: ").Append(RetryPolicy).Append("\n");
            if (SecurityPolicy != null) sb.Append("  SecurityPolicy: ").Append(SecurityPolicy).Append("\n");
            if (AdditionalAttributes != null) sb.Append("  AdditionalAttributes: ").Append(AdditionalAttributes).Append("\n");
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
            return this.Equals(obj as UpdateWebhookRequest);
        }

        /// <summary>
        /// Returns true if UpdateWebhookRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateWebhookRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateWebhookRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.OrganizationId == other.OrganizationId ||
                    this.OrganizationId != null &&
                    this.OrganizationId.Equals(other.OrganizationId)
                ) && 
                (
                    this.ProductId == other.ProductId ||
                    this.ProductId != null &&
                    this.ProductId.Equals(other.ProductId)
                ) && 
                (
                    this.EventTypes == other.EventTypes ||
                    this.EventTypes != null &&
                    this.EventTypes.SequenceEqual(other.EventTypes)
                ) && 
                (
                    this.WebhookUrl == other.WebhookUrl ||
                    this.WebhookUrl != null &&
                    this.WebhookUrl.Equals(other.WebhookUrl)
                ) && 
                (
                    this.HealthCheckUrl == other.HealthCheckUrl ||
                    this.HealthCheckUrl != null &&
                    this.HealthCheckUrl.Equals(other.HealthCheckUrl)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.NotificationScope == other.NotificationScope ||
                    this.NotificationScope != null &&
                    this.NotificationScope.Equals(other.NotificationScope)
                ) && 
                (
                    this.RetryPolicy == other.RetryPolicy ||
                    this.RetryPolicy != null &&
                    this.RetryPolicy.Equals(other.RetryPolicy)
                ) && 
                (
                    this.SecurityPolicy == other.SecurityPolicy ||
                    this.SecurityPolicy != null &&
                    this.SecurityPolicy.Equals(other.SecurityPolicy)
                ) && 
                (
                    this.AdditionalAttributes == other.AdditionalAttributes ||
                    this.AdditionalAttributes != null &&
                    this.AdditionalAttributes.SequenceEqual(other.AdditionalAttributes)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.OrganizationId != null)
                    hash = hash * 59 + this.OrganizationId.GetHashCode();
                if (this.ProductId != null)
                    hash = hash * 59 + this.ProductId.GetHashCode();
                if (this.EventTypes != null)
                    hash = hash * 59 + this.EventTypes.GetHashCode();
                if (this.WebhookUrl != null)
                    hash = hash * 59 + this.WebhookUrl.GetHashCode();
                if (this.HealthCheckUrl != null)
                    hash = hash * 59 + this.HealthCheckUrl.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.NotificationScope != null)
                    hash = hash * 59 + this.NotificationScope.GetHashCode();
                if (this.RetryPolicy != null)
                    hash = hash * 59 + this.RetryPolicy.GetHashCode();
                if (this.SecurityPolicy != null)
                    hash = hash * 59 + this.SecurityPolicy.GetHashCode();
                if (this.AdditionalAttributes != null)
                    hash = hash * 59 + this.AdditionalAttributes.GetHashCode();
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
