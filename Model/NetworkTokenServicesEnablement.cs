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
    /// NetworkTokenServicesEnablement
    /// </summary>
    [DataContract]
    public partial class NetworkTokenServicesEnablement :  IEquatable<NetworkTokenServicesEnablement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkTokenServicesEnablement" /> class.
        /// </summary>
        /// <param name="VisaTokenService">VisaTokenService.</param>
        /// <param name="MastercardDigitalEnablementService">MastercardDigitalEnablementService.</param>
        public NetworkTokenServicesEnablement(NetworkTokenServicesEnablementVisaTokenService VisaTokenService = default(NetworkTokenServicesEnablementVisaTokenService), NetworkTokenServicesEnablementMastercardDigitalEnablementService MastercardDigitalEnablementService = default(NetworkTokenServicesEnablementMastercardDigitalEnablementService))
        {
            this.VisaTokenService = VisaTokenService;
            this.MastercardDigitalEnablementService = MastercardDigitalEnablementService;
        }
        
        /// <summary>
        /// Gets or Sets VisaTokenService
        /// </summary>
        [DataMember(Name="visaTokenService", EmitDefaultValue=false)]
        public NetworkTokenServicesEnablementVisaTokenService VisaTokenService { get; set; }

        /// <summary>
        /// Gets or Sets MastercardDigitalEnablementService
        /// </summary>
        [DataMember(Name="mastercardDigitalEnablementService", EmitDefaultValue=false)]
        public NetworkTokenServicesEnablementMastercardDigitalEnablementService MastercardDigitalEnablementService { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NetworkTokenServicesEnablement {\n");
            if (VisaTokenService != null) sb.Append("  VisaTokenService: ").Append(VisaTokenService).Append("\n");
            if (MastercardDigitalEnablementService != null) sb.Append("  MastercardDigitalEnablementService: ").Append(MastercardDigitalEnablementService).Append("\n");
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
            return this.Equals(obj as NetworkTokenServicesEnablement);
        }

        /// <summary>
        /// Returns true if NetworkTokenServicesEnablement instances are equal
        /// </summary>
        /// <param name="other">Instance of NetworkTokenServicesEnablement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkTokenServicesEnablement other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.VisaTokenService == other.VisaTokenService ||
                    this.VisaTokenService != null &&
                    this.VisaTokenService.Equals(other.VisaTokenService)
                ) && 
                (
                    this.MastercardDigitalEnablementService == other.MastercardDigitalEnablementService ||
                    this.MastercardDigitalEnablementService != null &&
                    this.MastercardDigitalEnablementService.Equals(other.MastercardDigitalEnablementService)
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
                if (this.VisaTokenService != null)
                    hash = hash * 59 + this.VisaTokenService.GetHashCode();
                if (this.MastercardDigitalEnablementService != null)
                    hash = hash * 59 + this.MastercardDigitalEnablementService.GetHashCode();
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
