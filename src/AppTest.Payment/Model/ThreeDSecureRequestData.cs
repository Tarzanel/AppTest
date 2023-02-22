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
    /// 3DSecure parameters
    /// </summary>
    [DataContract]
        public partial class ThreeDSecureRequestData :  IEquatable<ThreeDSecureRequestData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDSecureRequestData" /> class.
        /// </summary>
        /// <param name="eci">ECI Indicator.</param>
        /// <param name="cavv">CAVV value.</param>
        /// <param name="xid">3DS Transaction Id.</param>
        /// <param name="authenticationStatus">3DS Authentication Status.</param>
        /// <param name="protocolVersion">3DS Protocol Version.</param>
        /// <param name="dSTransId">3DS DirectoryServer Transaction Id.</param>
        /// <param name="challengeWindowSize">Mandatory Challenge window size for 3DS2.  1&#x3D;250x400; 2&#x3D;390x400; 3&#x3D;500x600; 4&#x3D;600x400; 5&#x3D;100%.</param>
        /// <param name="channelIndicator">3DS2 Channel Indicator..</param>
        /// <param name="riIndicator">3DS2 3RI Indicator.  Values currently accepted: \&quot;01\&quot; &#x3D; Recurring transaction.</param>
        /// <param name="challengeIndicator">Requestor Challenge Indicator  \&quot;01\&quot;, \&quot;02\&quot;, \&quot;03\&quot;, or \&quot;04\&quot;.  Default is \&quot;01\&quot; (no preference).</param>
        /// <param name="authenticationIndicator">3DS2 Authentication Indicator (threeDSRequestorAuthenticationInd). Defaults to \&quot;01\&quot; &#x3D; Payment transaction.</param>
        /// <param name="messageCategory">3DS2 Message Category. \&quot;01\&quot; &#x3D; PA, \&quot;02\&quot; &#x3D; NPA, etc..</param>
        /// <param name="transactionType">3DS2 Transaction Type (transType). \&quot;01\&quot; &#x3D; Goods/Service, \&quot;02\&quot; &#x3D; Check Acceptance, etc..</param>
        /// <param name="accountInfo">accountInfo.</param>
        public ThreeDSecureRequestData(string eci = default(string), string cavv = default(string), string xid = default(string), string authenticationStatus = default(string), string protocolVersion = default(string), string dSTransId = default(string), int? challengeWindowSize = default(int?), string channelIndicator = default(string), string riIndicator = default(string), string challengeIndicator = default(string), string authenticationIndicator = default(string), string messageCategory = default(string), string transactionType = default(string), AccountInfoRequestData accountInfo = default(AccountInfoRequestData))
        {
            this.Eci = eci;
            this.Cavv = cavv;
            this.Xid = xid;
            this.AuthenticationStatus = authenticationStatus;
            this.ProtocolVersion = protocolVersion;
            this.DSTransId = dSTransId;
            this.ChallengeWindowSize = challengeWindowSize;
            this.ChannelIndicator = channelIndicator;
            this.RiIndicator = riIndicator;
            this.ChallengeIndicator = challengeIndicator;
            this.AuthenticationIndicator = authenticationIndicator;
            this.MessageCategory = messageCategory;
            this.TransactionType = transactionType;
            this.AccountInfo = accountInfo;
        }
        
        /// <summary>
        /// ECI Indicator
        /// </summary>
        /// <value>ECI Indicator</value>
        [DataMember(Name="Eci", EmitDefaultValue=false)]
        public string Eci { get; set; }

        /// <summary>
        /// CAVV value
        /// </summary>
        /// <value>CAVV value</value>
        [DataMember(Name="Cavv", EmitDefaultValue=false)]
        public string Cavv { get; set; }

        /// <summary>
        /// 3DS Transaction Id
        /// </summary>
        /// <value>3DS Transaction Id</value>
        [DataMember(Name="Xid", EmitDefaultValue=false)]
        public string Xid { get; set; }

        /// <summary>
        /// 3DS Authentication Status
        /// </summary>
        /// <value>3DS Authentication Status</value>
        [DataMember(Name="AuthenticationStatus", EmitDefaultValue=false)]
        public string AuthenticationStatus { get; set; }

        /// <summary>
        /// 3DS Protocol Version
        /// </summary>
        /// <value>3DS Protocol Version</value>
        [DataMember(Name="ProtocolVersion", EmitDefaultValue=false)]
        public string ProtocolVersion { get; set; }

        /// <summary>
        /// 3DS DirectoryServer Transaction Id
        /// </summary>
        /// <value>3DS DirectoryServer Transaction Id</value>
        [DataMember(Name="DSTransId", EmitDefaultValue=false)]
        public string DSTransId { get; set; }

        /// <summary>
        /// Mandatory Challenge window size for 3DS2.  1&#x3D;250x400; 2&#x3D;390x400; 3&#x3D;500x600; 4&#x3D;600x400; 5&#x3D;100%
        /// </summary>
        /// <value>Mandatory Challenge window size for 3DS2.  1&#x3D;250x400; 2&#x3D;390x400; 3&#x3D;500x600; 4&#x3D;600x400; 5&#x3D;100%</value>
        [DataMember(Name="ChallengeWindowSize", EmitDefaultValue=false)]
        public int? ChallengeWindowSize { get; set; }

        /// <summary>
        /// 3DS2 Channel Indicator.
        /// </summary>
        /// <value>3DS2 Channel Indicator.</value>
        [DataMember(Name="ChannelIndicator", EmitDefaultValue=false)]
        public string ChannelIndicator { get; set; }

        /// <summary>
        /// 3DS2 3RI Indicator.  Values currently accepted: \&quot;01\&quot; &#x3D; Recurring transaction
        /// </summary>
        /// <value>3DS2 3RI Indicator.  Values currently accepted: \&quot;01\&quot; &#x3D; Recurring transaction</value>
        [DataMember(Name="RiIndicator", EmitDefaultValue=false)]
        public string RiIndicator { get; set; }

        /// <summary>
        /// Requestor Challenge Indicator  \&quot;01\&quot;, \&quot;02\&quot;, \&quot;03\&quot;, or \&quot;04\&quot;.  Default is \&quot;01\&quot; (no preference)
        /// </summary>
        /// <value>Requestor Challenge Indicator  \&quot;01\&quot;, \&quot;02\&quot;, \&quot;03\&quot;, or \&quot;04\&quot;.  Default is \&quot;01\&quot; (no preference)</value>
        [DataMember(Name="ChallengeIndicator", EmitDefaultValue=false)]
        public string ChallengeIndicator { get; set; }

        /// <summary>
        /// 3DS2 Authentication Indicator (threeDSRequestorAuthenticationInd). Defaults to \&quot;01\&quot; &#x3D; Payment transaction
        /// </summary>
        /// <value>3DS2 Authentication Indicator (threeDSRequestorAuthenticationInd). Defaults to \&quot;01\&quot; &#x3D; Payment transaction</value>
        [DataMember(Name="AuthenticationIndicator", EmitDefaultValue=false)]
        public string AuthenticationIndicator { get; set; }

        /// <summary>
        /// 3DS2 Message Category. \&quot;01\&quot; &#x3D; PA, \&quot;02\&quot; &#x3D; NPA, etc.
        /// </summary>
        /// <value>3DS2 Message Category. \&quot;01\&quot; &#x3D; PA, \&quot;02\&quot; &#x3D; NPA, etc.</value>
        [DataMember(Name="MessageCategory", EmitDefaultValue=false)]
        public string MessageCategory { get; set; }

        /// <summary>
        /// 3DS2 Transaction Type (transType). \&quot;01\&quot; &#x3D; Goods/Service, \&quot;02\&quot; &#x3D; Check Acceptance, etc.
        /// </summary>
        /// <value>3DS2 Transaction Type (transType). \&quot;01\&quot; &#x3D; Goods/Service, \&quot;02\&quot; &#x3D; Check Acceptance, etc.</value>
        [DataMember(Name="TransactionType", EmitDefaultValue=false)]
        public string TransactionType { get; set; }

        /// <summary>
        /// Gets or Sets AccountInfo
        /// </summary>
        [DataMember(Name="AccountInfo", EmitDefaultValue=false)]
        public AccountInfoRequestData AccountInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThreeDSecureRequestData {\n");
            sb.Append("  Eci: ").Append(Eci).Append("\n");
            sb.Append("  Cavv: ").Append(Cavv).Append("\n");
            sb.Append("  Xid: ").Append(Xid).Append("\n");
            sb.Append("  AuthenticationStatus: ").Append(AuthenticationStatus).Append("\n");
            sb.Append("  ProtocolVersion: ").Append(ProtocolVersion).Append("\n");
            sb.Append("  DSTransId: ").Append(DSTransId).Append("\n");
            sb.Append("  ChallengeWindowSize: ").Append(ChallengeWindowSize).Append("\n");
            sb.Append("  ChannelIndicator: ").Append(ChannelIndicator).Append("\n");
            sb.Append("  RiIndicator: ").Append(RiIndicator).Append("\n");
            sb.Append("  ChallengeIndicator: ").Append(ChallengeIndicator).Append("\n");
            sb.Append("  AuthenticationIndicator: ").Append(AuthenticationIndicator).Append("\n");
            sb.Append("  MessageCategory: ").Append(MessageCategory).Append("\n");
            sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
            sb.Append("  AccountInfo: ").Append(AccountInfo).Append("\n");
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
            return this.Equals(input as ThreeDSecureRequestData);
        }

        /// <summary>
        /// Returns true if ThreeDSecureRequestData instances are equal
        /// </summary>
        /// <param name="input">Instance of ThreeDSecureRequestData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThreeDSecureRequestData input)
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
                    this.ProtocolVersion == input.ProtocolVersion ||
                    (this.ProtocolVersion != null &&
                    this.ProtocolVersion.Equals(input.ProtocolVersion))
                ) && 
                (
                    this.DSTransId == input.DSTransId ||
                    (this.DSTransId != null &&
                    this.DSTransId.Equals(input.DSTransId))
                ) && 
                (
                    this.ChallengeWindowSize == input.ChallengeWindowSize ||
                    (this.ChallengeWindowSize != null &&
                    this.ChallengeWindowSize.Equals(input.ChallengeWindowSize))
                ) && 
                (
                    this.ChannelIndicator == input.ChannelIndicator ||
                    (this.ChannelIndicator != null &&
                    this.ChannelIndicator.Equals(input.ChannelIndicator))
                ) && 
                (
                    this.RiIndicator == input.RiIndicator ||
                    (this.RiIndicator != null &&
                    this.RiIndicator.Equals(input.RiIndicator))
                ) && 
                (
                    this.ChallengeIndicator == input.ChallengeIndicator ||
                    (this.ChallengeIndicator != null &&
                    this.ChallengeIndicator.Equals(input.ChallengeIndicator))
                ) && 
                (
                    this.AuthenticationIndicator == input.AuthenticationIndicator ||
                    (this.AuthenticationIndicator != null &&
                    this.AuthenticationIndicator.Equals(input.AuthenticationIndicator))
                ) && 
                (
                    this.MessageCategory == input.MessageCategory ||
                    (this.MessageCategory != null &&
                    this.MessageCategory.Equals(input.MessageCategory))
                ) && 
                (
                    this.TransactionType == input.TransactionType ||
                    (this.TransactionType != null &&
                    this.TransactionType.Equals(input.TransactionType))
                ) && 
                (
                    this.AccountInfo == input.AccountInfo ||
                    (this.AccountInfo != null &&
                    this.AccountInfo.Equals(input.AccountInfo))
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
                if (this.ProtocolVersion != null)
                    hashCode = hashCode * 59 + this.ProtocolVersion.GetHashCode();
                if (this.DSTransId != null)
                    hashCode = hashCode * 59 + this.DSTransId.GetHashCode();
                if (this.ChallengeWindowSize != null)
                    hashCode = hashCode * 59 + this.ChallengeWindowSize.GetHashCode();
                if (this.ChannelIndicator != null)
                    hashCode = hashCode * 59 + this.ChannelIndicator.GetHashCode();
                if (this.RiIndicator != null)
                    hashCode = hashCode * 59 + this.RiIndicator.GetHashCode();
                if (this.ChallengeIndicator != null)
                    hashCode = hashCode * 59 + this.ChallengeIndicator.GetHashCode();
                if (this.AuthenticationIndicator != null)
                    hashCode = hashCode * 59 + this.AuthenticationIndicator.GetHashCode();
                if (this.MessageCategory != null)
                    hashCode = hashCode * 59 + this.MessageCategory.GetHashCode();
                if (this.TransactionType != null)
                    hashCode = hashCode * 59 + this.TransactionType.GetHashCode();
                if (this.AccountInfo != null)
                    hashCode = hashCode * 59 + this.AccountInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
