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
    /// 3DS Response Model
    /// </summary>
    [DataContract]
        public partial class ThreeDSecureResponse :  IEquatable<ThreeDSecureResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDSecureResponse" /> class.
        /// </summary>
        /// <param name="eci">ECI Indicator.</param>
        /// <param name="cavv">CAVV Value.</param>
        /// <param name="xid">3DS Transaction Id.</param>
        /// <param name="authenticationStatus">Authentication Status.</param>
        /// <param name="statusReason">Authentication Status Reason.</param>
        /// <param name="redirectData">3DS redirect form data.</param>
        /// <param name="authenticateUrl">3DS redirect url for the Authentication.</param>
        /// <param name="cardEnrolled">3DS1 Card enrolled flag.</param>
        /// <param name="protocolVersion">3DS Protocol version.</param>
        /// <param name="fingerprintIndicator">Fingerprint Indicator.</param>
        /// <param name="dsTransId">3DS Directory Server Transaction Id.</param>
        /// <param name="responseCode">IsoResponseCode from 3DS portion of an Auth/Sale with 3DS.</param>
        /// <param name="cardholderInfo">Information for the Cardholder from the ACS.</param>
        public ThreeDSecureResponse(string eci = default(string), string cavv = default(string), string xid = default(string), string authenticationStatus = default(string), string statusReason = default(string), string redirectData = default(string), string authenticateUrl = default(string), string cardEnrolled = default(string), string protocolVersion = default(string), string fingerprintIndicator = default(string), string dsTransId = default(string), string responseCode = default(string), string cardholderInfo = default(string))
        {
            this.Eci = eci;
            this.Cavv = cavv;
            this.Xid = xid;
            this.AuthenticationStatus = authenticationStatus;
            this.StatusReason = statusReason;
            this.RedirectData = redirectData;
            this.AuthenticateUrl = authenticateUrl;
            this.CardEnrolled = cardEnrolled;
            this.ProtocolVersion = protocolVersion;
            this.FingerprintIndicator = fingerprintIndicator;
            this.DsTransId = dsTransId;
            this.ResponseCode = responseCode;
            this.CardholderInfo = cardholderInfo;
        }
        
        /// <summary>
        /// ECI Indicator
        /// </summary>
        /// <value>ECI Indicator</value>
        [DataMember(Name="Eci", EmitDefaultValue=false)]
        public string Eci { get; set; }

        /// <summary>
        /// CAVV Value
        /// </summary>
        /// <value>CAVV Value</value>
        [DataMember(Name="Cavv", EmitDefaultValue=false)]
        public string Cavv { get; set; }

        /// <summary>
        /// 3DS Transaction Id
        /// </summary>
        /// <value>3DS Transaction Id</value>
        [DataMember(Name="Xid", EmitDefaultValue=false)]
        public string Xid { get; set; }

        /// <summary>
        /// Authentication Status
        /// </summary>
        /// <value>Authentication Status</value>
        [DataMember(Name="AuthenticationStatus", EmitDefaultValue=false)]
        public string AuthenticationStatus { get; set; }

        /// <summary>
        /// Authentication Status Reason
        /// </summary>
        /// <value>Authentication Status Reason</value>
        [DataMember(Name="StatusReason", EmitDefaultValue=false)]
        public string StatusReason { get; set; }

        /// <summary>
        /// 3DS redirect form data
        /// </summary>
        /// <value>3DS redirect form data</value>
        [DataMember(Name="RedirectData", EmitDefaultValue=false)]
        public string RedirectData { get; set; }

        /// <summary>
        /// 3DS redirect url for the Authentication
        /// </summary>
        /// <value>3DS redirect url for the Authentication</value>
        [DataMember(Name="AuthenticateUrl", EmitDefaultValue=false)]
        public string AuthenticateUrl { get; set; }

        /// <summary>
        /// 3DS1 Card enrolled flag
        /// </summary>
        /// <value>3DS1 Card enrolled flag</value>
        [DataMember(Name="CardEnrolled", EmitDefaultValue=false)]
        public string CardEnrolled { get; set; }

        /// <summary>
        /// 3DS Protocol version
        /// </summary>
        /// <value>3DS Protocol version</value>
        [DataMember(Name="ProtocolVersion", EmitDefaultValue=false)]
        public string ProtocolVersion { get; set; }

        /// <summary>
        /// Fingerprint Indicator
        /// </summary>
        /// <value>Fingerprint Indicator</value>
        [DataMember(Name="FingerprintIndicator", EmitDefaultValue=false)]
        public string FingerprintIndicator { get; set; }

        /// <summary>
        /// 3DS Directory Server Transaction Id
        /// </summary>
        /// <value>3DS Directory Server Transaction Id</value>
        [DataMember(Name="DsTransId", EmitDefaultValue=false)]
        public string DsTransId { get; set; }

        /// <summary>
        /// IsoResponseCode from 3DS portion of an Auth/Sale with 3DS
        /// </summary>
        /// <value>IsoResponseCode from 3DS portion of an Auth/Sale with 3DS</value>
        [DataMember(Name="ResponseCode", EmitDefaultValue=false)]
        public string ResponseCode { get; set; }

        /// <summary>
        /// Information for the Cardholder from the ACS
        /// </summary>
        /// <value>Information for the Cardholder from the ACS</value>
        [DataMember(Name="CardholderInfo", EmitDefaultValue=false)]
        public string CardholderInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThreeDSecureResponse {\n");
            sb.Append("  Eci: ").Append(Eci).Append("\n");
            sb.Append("  Cavv: ").Append(Cavv).Append("\n");
            sb.Append("  Xid: ").Append(Xid).Append("\n");
            sb.Append("  AuthenticationStatus: ").Append(AuthenticationStatus).Append("\n");
            sb.Append("  StatusReason: ").Append(StatusReason).Append("\n");
            sb.Append("  RedirectData: ").Append(RedirectData).Append("\n");
            sb.Append("  AuthenticateUrl: ").Append(AuthenticateUrl).Append("\n");
            sb.Append("  CardEnrolled: ").Append(CardEnrolled).Append("\n");
            sb.Append("  ProtocolVersion: ").Append(ProtocolVersion).Append("\n");
            sb.Append("  FingerprintIndicator: ").Append(FingerprintIndicator).Append("\n");
            sb.Append("  DsTransId: ").Append(DsTransId).Append("\n");
            sb.Append("  ResponseCode: ").Append(ResponseCode).Append("\n");
            sb.Append("  CardholderInfo: ").Append(CardholderInfo).Append("\n");
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
            return this.Equals(input as ThreeDSecureResponse);
        }

        /// <summary>
        /// Returns true if ThreeDSecureResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ThreeDSecureResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThreeDSecureResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Eci == input.Eci ||
                    (this.Eci != null &&
                    this.Eci.Equals(input.Eci))
                ) && 
                (
                    this.Cavv == input.Cavv ||
                    (this.Cavv != null &&
                    this.Cavv.Equals(input.Cavv))
                ) && 
                (
                    this.Xid == input.Xid ||
                    (this.Xid != null &&
                    this.Xid.Equals(input.Xid))
                ) && 
                (
                    this.AuthenticationStatus == input.AuthenticationStatus ||
                    (this.AuthenticationStatus != null &&
                    this.AuthenticationStatus.Equals(input.AuthenticationStatus))
                ) && 
                (
                    this.StatusReason == input.StatusReason ||
                    (this.StatusReason != null &&
                    this.StatusReason.Equals(input.StatusReason))
                ) && 
                (
                    this.RedirectData == input.RedirectData ||
                    (this.RedirectData != null &&
                    this.RedirectData.Equals(input.RedirectData))
                ) && 
                (
                    this.AuthenticateUrl == input.AuthenticateUrl ||
                    (this.AuthenticateUrl != null &&
                    this.AuthenticateUrl.Equals(input.AuthenticateUrl))
                ) && 
                (
                    this.CardEnrolled == input.CardEnrolled ||
                    (this.CardEnrolled != null &&
                    this.CardEnrolled.Equals(input.CardEnrolled))
                ) && 
                (
                    this.ProtocolVersion == input.ProtocolVersion ||
                    (this.ProtocolVersion != null &&
                    this.ProtocolVersion.Equals(input.ProtocolVersion))
                ) && 
                (
                    this.FingerprintIndicator == input.FingerprintIndicator ||
                    (this.FingerprintIndicator != null &&
                    this.FingerprintIndicator.Equals(input.FingerprintIndicator))
                ) && 
                (
                    this.DsTransId == input.DsTransId ||
                    (this.DsTransId != null &&
                    this.DsTransId.Equals(input.DsTransId))
                ) && 
                (
                    this.ResponseCode == input.ResponseCode ||
                    (this.ResponseCode != null &&
                    this.ResponseCode.Equals(input.ResponseCode))
                ) && 
                (
                    this.CardholderInfo == input.CardholderInfo ||
                    (this.CardholderInfo != null &&
                    this.CardholderInfo.Equals(input.CardholderInfo))
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
                if (this.Eci != null)
                    hashCode = hashCode * 59 + this.Eci.GetHashCode();
                if (this.Cavv != null)
                    hashCode = hashCode * 59 + this.Cavv.GetHashCode();
                if (this.Xid != null)
                    hashCode = hashCode * 59 + this.Xid.GetHashCode();
                if (this.AuthenticationStatus != null)
                    hashCode = hashCode * 59 + this.AuthenticationStatus.GetHashCode();
                if (this.StatusReason != null)
                    hashCode = hashCode * 59 + this.StatusReason.GetHashCode();
                if (this.RedirectData != null)
                    hashCode = hashCode * 59 + this.RedirectData.GetHashCode();
                if (this.AuthenticateUrl != null)
                    hashCode = hashCode * 59 + this.AuthenticateUrl.GetHashCode();
                if (this.CardEnrolled != null)
                    hashCode = hashCode * 59 + this.CardEnrolled.GetHashCode();
                if (this.ProtocolVersion != null)
                    hashCode = hashCode * 59 + this.ProtocolVersion.GetHashCode();
                if (this.FingerprintIndicator != null)
                    hashCode = hashCode * 59 + this.FingerprintIndicator.GetHashCode();
                if (this.DsTransId != null)
                    hashCode = hashCode * 59 + this.DsTransId.GetHashCode();
                if (this.ResponseCode != null)
                    hashCode = hashCode * 59 + this.ResponseCode.GetHashCode();
                if (this.CardholderInfo != null)
                    hashCode = hashCode * 59 + this.CardholderInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
