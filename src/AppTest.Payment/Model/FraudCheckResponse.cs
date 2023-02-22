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
    /// FraudControl response
    /// </summary>
    [DataContract]
        public partial class FraudCheckResponse :  IEquatable<FraudCheckResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FraudCheckResponse" /> class.
        /// </summary>
        /// <param name="fcProvider">Fraud Control Provider name.</param>
        /// <param name="responseCode">PowerTranz FraudCheck ResponseCode.</param>
        /// <param name="fcResponseCode">Fraud Control Provider Response Code.</param>
        /// <param name="fcResponseMessage">Fraud Control Provider Response Message.</param>
        /// <param name="fcReasonCode">Fraud Control Provider Reason Code.</param>
        /// <param name="fcScore">Fraud Control Provider Score.</param>
        /// <param name="fcDetails">Fraud Control Provider custom response data.</param>
        /// <param name="fcTransId">Fraud Control Provider transaction Id.</param>
        public FraudCheckResponse(string fcProvider = default(string), string responseCode = default(string), string fcResponseCode = default(string), string fcResponseMessage = default(string), string fcReasonCode = default(string), string fcScore = default(string), Object fcDetails = default(Object), string fcTransId = default(string))
        {
            this.FcProvider = fcProvider;
            this.ResponseCode = responseCode;
            this.FcResponseCode = fcResponseCode;
            this.FcResponseMessage = fcResponseMessage;
            this.FcReasonCode = fcReasonCode;
            this.FcScore = fcScore;
            this.FcDetails = fcDetails;
            this.FcTransId = fcTransId;
        }
        
        /// <summary>
        /// Fraud Control Provider name
        /// </summary>
        /// <value>Fraud Control Provider name</value>
        [DataMember(Name="FcProvider", EmitDefaultValue=false)]
        public string FcProvider { get; set; }

        /// <summary>
        /// PowerTranz FraudCheck ResponseCode
        /// </summary>
        /// <value>PowerTranz FraudCheck ResponseCode</value>
        [DataMember(Name="ResponseCode", EmitDefaultValue=false)]
        public string ResponseCode { get; set; }

        /// <summary>
        /// Fraud Control Provider Response Code
        /// </summary>
        /// <value>Fraud Control Provider Response Code</value>
        [DataMember(Name="FcResponseCode", EmitDefaultValue=false)]
        public string FcResponseCode { get; set; }

        /// <summary>
        /// Fraud Control Provider Response Message
        /// </summary>
        /// <value>Fraud Control Provider Response Message</value>
        [DataMember(Name="FcResponseMessage", EmitDefaultValue=false)]
        public string FcResponseMessage { get; set; }

        /// <summary>
        /// Fraud Control Provider Reason Code
        /// </summary>
        /// <value>Fraud Control Provider Reason Code</value>
        [DataMember(Name="FcReasonCode", EmitDefaultValue=false)]
        public string FcReasonCode { get; set; }

        /// <summary>
        /// Fraud Control Provider Score
        /// </summary>
        /// <value>Fraud Control Provider Score</value>
        [DataMember(Name="FcScore", EmitDefaultValue=false)]
        public string FcScore { get; set; }

        /// <summary>
        /// Fraud Control Provider custom response data
        /// </summary>
        /// <value>Fraud Control Provider custom response data</value>
        [DataMember(Name="FcDetails", EmitDefaultValue=false)]
        public Object FcDetails { get; set; }

        /// <summary>
        /// Fraud Control Provider transaction Id
        /// </summary>
        /// <value>Fraud Control Provider transaction Id</value>
        [DataMember(Name="FcTransId", EmitDefaultValue=false)]
        public string FcTransId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FraudCheckResponse {\n");
            sb.Append("  FcProvider: ").Append(FcProvider).Append("\n");
            sb.Append("  ResponseCode: ").Append(ResponseCode).Append("\n");
            sb.Append("  FcResponseCode: ").Append(FcResponseCode).Append("\n");
            sb.Append("  FcResponseMessage: ").Append(FcResponseMessage).Append("\n");
            sb.Append("  FcReasonCode: ").Append(FcReasonCode).Append("\n");
            sb.Append("  FcScore: ").Append(FcScore).Append("\n");
            sb.Append("  FcDetails: ").Append(FcDetails).Append("\n");
            sb.Append("  FcTransId: ").Append(FcTransId).Append("\n");
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
            return this.Equals(input as FraudCheckResponse);
        }

        /// <summary>
        /// Returns true if FraudCheckResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of FraudCheckResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FraudCheckResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FcProvider == input.FcProvider ||
                    (this.FcProvider != null &&
                    this.FcProvider.Equals(input.FcProvider))
                ) && 
                (
                    this.ResponseCode == input.ResponseCode ||
                    (this.ResponseCode != null &&
                    this.ResponseCode.Equals(input.ResponseCode))
                ) && 
                (
                    this.FcResponseCode == input.FcResponseCode ||
                    (this.FcResponseCode != null &&
                    this.FcResponseCode.Equals(input.FcResponseCode))
                ) && 
                (
                    this.FcResponseMessage == input.FcResponseMessage ||
                    (this.FcResponseMessage != null &&
                    this.FcResponseMessage.Equals(input.FcResponseMessage))
                ) && 
                (
                    this.FcReasonCode == input.FcReasonCode ||
                    (this.FcReasonCode != null &&
                    this.FcReasonCode.Equals(input.FcReasonCode))
                ) && 
                (
                    this.FcScore == input.FcScore ||
                    (this.FcScore != null &&
                    this.FcScore.Equals(input.FcScore))
                ) && 
                (
                    this.FcDetails == input.FcDetails ||
                    (this.FcDetails != null &&
                    this.FcDetails.Equals(input.FcDetails))
                ) && 
                (
                    this.FcTransId == input.FcTransId ||
                    (this.FcTransId != null &&
                    this.FcTransId.Equals(input.FcTransId))
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
                if (this.FcProvider != null)
                    hashCode = hashCode * 59 + this.FcProvider.GetHashCode();
                if (this.ResponseCode != null)
                    hashCode = hashCode * 59 + this.ResponseCode.GetHashCode();
                if (this.FcResponseCode != null)
                    hashCode = hashCode * 59 + this.FcResponseCode.GetHashCode();
                if (this.FcResponseMessage != null)
                    hashCode = hashCode * 59 + this.FcResponseMessage.GetHashCode();
                if (this.FcReasonCode != null)
                    hashCode = hashCode * 59 + this.FcReasonCode.GetHashCode();
                if (this.FcScore != null)
                    hashCode = hashCode * 59 + this.FcScore.GetHashCode();
                if (this.FcDetails != null)
                    hashCode = hashCode * 59 + this.FcDetails.GetHashCode();
                if (this.FcTransId != null)
                    hashCode = hashCode * 59 + this.FcTransId.GetHashCode();
                return hashCode;
            }
        }
    }
}
