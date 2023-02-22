using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = AppTest.Payment.Client.SwaggerDateConverter;

namespace AppTest.Payment.Model
{
    /// <summary>
    /// RiskManagementResponse Model
    /// </summary>
    [DataContract]
        public partial class RiskManagementResponse :  IEquatable<RiskManagementResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RiskManagementResponse" /> class.
        /// </summary>
        /// <param name="avsResponseCode">AVS response code.</param>
        /// <param name="cvvResponseCode">CVC response code.</param>
        /// <param name="threeDSecure">threeDSecure.</param>
        /// <param name="fraudCheck">fraudCheck.</param>
        public RiskManagementResponse(string avsResponseCode = default(string), string cvvResponseCode = default(string), ThreeDSecureResponse threeDSecure = default(ThreeDSecureResponse), FraudCheckResponse fraudCheck = default(FraudCheckResponse))
        {
            this.AvsResponseCode = avsResponseCode;
            this.CvvResponseCode = cvvResponseCode;
            this.ThreeDSecure = threeDSecure;
            this.FraudCheck = fraudCheck;
        }
        
        /// <summary>
        /// AVS response code
        /// </summary>
        /// <value>AVS response code</value>
        [DataMember(Name="AvsResponseCode", EmitDefaultValue=false)]
        public string AvsResponseCode { get; set; }

        /// <summary>
        /// CVC response code
        /// </summary>
        /// <value>CVC response code</value>
        [DataMember(Name="CvvResponseCode", EmitDefaultValue=false)]
        public string CvvResponseCode { get; set; }

        /// <summary>
        /// Gets or Sets ThreeDSecure
        /// </summary>
        [DataMember(Name="ThreeDSecure", EmitDefaultValue=false)]
        public ThreeDSecureResponse ThreeDSecure { get; set; }

        /// <summary>
        /// Gets or Sets FraudCheck
        /// </summary>
        [DataMember(Name="FraudCheck", EmitDefaultValue=false)]
        public FraudCheckResponse FraudCheck { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RiskManagementResponse {\n");
            sb.Append("  AvsResponseCode: ").Append(AvsResponseCode).Append("\n");
            sb.Append("  CvvResponseCode: ").Append(CvvResponseCode).Append("\n");
            sb.Append("  ThreeDSecure: ").Append(ThreeDSecure).Append("\n");
            sb.Append("  FraudCheck: ").Append(FraudCheck).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RiskManagementResponse);
        }

        /// <summary>
        /// Returns true if RiskManagementResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RiskManagementResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RiskManagementResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AvsResponseCode == input.AvsResponseCode ||
                    (this.AvsResponseCode != null &&
                    this.AvsResponseCode.Equals(input.AvsResponseCode))
                ) && 
                (
                    this.CvvResponseCode == input.CvvResponseCode ||
                    (this.CvvResponseCode != null &&
                    this.CvvResponseCode.Equals(input.CvvResponseCode))
                ) && 
                (
                    this.ThreeDSecure == input.ThreeDSecure ||
                    (this.ThreeDSecure != null &&
                    this.ThreeDSecure.Equals(input.ThreeDSecure))
                ) && 
                (
                    this.FraudCheck == input.FraudCheck ||
                    (this.FraudCheck != null &&
                    this.FraudCheck.Equals(input.FraudCheck))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AvsResponseCode != null)
                    hashCode = hashCode * 59 + this.AvsResponseCode.GetHashCode();
                if (this.CvvResponseCode != null)
                    hashCode = hashCode * 59 + this.CvvResponseCode.GetHashCode();
                if (this.ThreeDSecure != null)
                    hashCode = hashCode * 59 + this.ThreeDSecure.GetHashCode();
                if (this.FraudCheck != null)
                    hashCode = hashCode * 59 + this.FraudCheck.GetHashCode();
                return hashCode;
            }
        }
    }
}
