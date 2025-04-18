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
    /// This object is only needed when you are requesting both payment and DM services at same time.
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsRiskInformation :  IEquatable<Ptsv2paymentsRiskInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsRiskInformation" /> class.
        /// </summary>
        /// <param name="Profile">Profile.</param>
        /// <param name="EventType">Specifies one of the following types of events: - login - account_creation - account_update For regular payment transactions, do not send this field. .</param>
        /// <param name="BuyerHistory">BuyerHistory.</param>
        /// <param name="AuxiliaryData">AuxiliaryData.</param>
        public Ptsv2paymentsRiskInformation(Ptsv2paymentsRiskInformationProfile Profile = default(Ptsv2paymentsRiskInformationProfile), string EventType = default(string), Ptsv2paymentsRiskInformationBuyerHistory BuyerHistory = default(Ptsv2paymentsRiskInformationBuyerHistory), List<Ptsv2paymentsRiskInformationAuxiliaryData> AuxiliaryData = default(List<Ptsv2paymentsRiskInformationAuxiliaryData>))
        {
            this.Profile = Profile;
            this.EventType = EventType;
            this.BuyerHistory = BuyerHistory;
            this.AuxiliaryData = AuxiliaryData;
        }
        
        /// <summary>
        /// Gets or Sets Profile
        /// </summary>
        [DataMember(Name="profile", EmitDefaultValue=false)]
        public Ptsv2paymentsRiskInformationProfile Profile { get; set; }

        /// <summary>
        /// Specifies one of the following types of events: - login - account_creation - account_update For regular payment transactions, do not send this field. 
        /// </summary>
        /// <value>Specifies one of the following types of events: - login - account_creation - account_update For regular payment transactions, do not send this field. </value>
        [DataMember(Name="eventType", EmitDefaultValue=false)]
        public string EventType { get; set; }

        /// <summary>
        /// Gets or Sets BuyerHistory
        /// </summary>
        [DataMember(Name="buyerHistory", EmitDefaultValue=false)]
        public Ptsv2paymentsRiskInformationBuyerHistory BuyerHistory { get; set; }

        /// <summary>
        /// Gets or Sets AuxiliaryData
        /// </summary>
        [DataMember(Name="auxiliaryData", EmitDefaultValue=false)]
        public List<Ptsv2paymentsRiskInformationAuxiliaryData> AuxiliaryData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsRiskInformation {\n");
            if (Profile != null) sb.Append("  Profile: ").Append(Profile).Append("\n");
            if (EventType != null) sb.Append("  EventType: ").Append(EventType).Append("\n");
            if (BuyerHistory != null) sb.Append("  BuyerHistory: ").Append(BuyerHistory).Append("\n");
            if (AuxiliaryData != null) sb.Append("  AuxiliaryData: ").Append(AuxiliaryData).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsRiskInformation);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsRiskInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsRiskInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsRiskInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Profile == other.Profile ||
                    this.Profile != null &&
                    this.Profile.Equals(other.Profile)
                ) && 
                (
                    this.EventType == other.EventType ||
                    this.EventType != null &&
                    this.EventType.Equals(other.EventType)
                ) && 
                (
                    this.BuyerHistory == other.BuyerHistory ||
                    this.BuyerHistory != null &&
                    this.BuyerHistory.Equals(other.BuyerHistory)
                ) && 
                (
                    this.AuxiliaryData == other.AuxiliaryData ||
                    this.AuxiliaryData != null &&
                    this.AuxiliaryData.SequenceEqual(other.AuxiliaryData)
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
                if (this.Profile != null)
                    hash = hash * 59 + this.Profile.GetHashCode();
                if (this.EventType != null)
                    hash = hash * 59 + this.EventType.GetHashCode();
                if (this.BuyerHistory != null)
                    hash = hash * 59 + this.BuyerHistory.GetHashCode();
                if (this.AuxiliaryData != null)
                    hash = hash * 59 + this.AuxiliaryData.GetHashCode();
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
