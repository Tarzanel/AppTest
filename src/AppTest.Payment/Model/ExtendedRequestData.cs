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
    /// Extended request data
    /// </summary>
    [DataContract]
        public partial class ExtendedRequestData :  IEquatable<ExtendedRequestData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedRequestData" /> class.
        /// </summary>
        /// <param name="secondaryAddress">secondaryAddress.</param>
        /// <param name="customData">General custom data.</param>
        /// <param name="level2CustomData">Level 2 custom data.</param>
        /// <param name="level3CustomData">Level 3 custom data.</param>
        /// <param name="threeDSecure">threeDSecure.</param>
        /// <param name="recurring">recurring.</param>
        /// <param name="browserInfo">browserInfo.</param>
        /// <param name="merchantResponseUrl">Url to redirect the cardholder to when then the transaction is complete.</param>
        /// <param name="hostedPage">hostedPage.</param>
        public ExtendedRequestData(Address secondaryAddress = default(Address), Object customData = default(Object), Object level2CustomData = default(Object), Object level3CustomData = default(Object), ThreeDSecureRequestData threeDSecure = default(ThreeDSecureRequestData), RecurringRequestData recurring = default(RecurringRequestData), BrowserInfoData browserInfo = default(BrowserInfoData), string merchantResponseUrl = default(string), HostedPageRequestData hostedPage = default(HostedPageRequestData))
        {
            this.SecondaryAddress = secondaryAddress;
            this.CustomData = customData;
            this.Level2CustomData = level2CustomData;
            this.Level3CustomData = level3CustomData;
            this.ThreeDSecure = threeDSecure;
            this.Recurring = recurring;
            this.BrowserInfo = browserInfo;
            this.MerchantResponseUrl = merchantResponseUrl;
            this.HostedPage = hostedPage;
        }
        
        /// <summary>
        /// Gets or Sets SecondaryAddress
        /// </summary>
        [DataMember(Name="SecondaryAddress", EmitDefaultValue=false)]
        public Address SecondaryAddress { get; set; }

        /// <summary>
        /// General custom data
        /// </summary>
        /// <value>General custom data</value>
        [DataMember(Name="CustomData", EmitDefaultValue=false)]
        public Object CustomData { get; set; }

        /// <summary>
        /// Level 2 custom data
        /// </summary>
        /// <value>Level 2 custom data</value>
        [DataMember(Name="Level2CustomData", EmitDefaultValue=false)]
        public Object Level2CustomData { get; set; }

        /// <summary>
        /// Level 3 custom data
        /// </summary>
        /// <value>Level 3 custom data</value>
        [DataMember(Name="Level3CustomData", EmitDefaultValue=false)]
        public Object Level3CustomData { get; set; }

        /// <summary>
        /// Gets or Sets ThreeDSecure
        /// </summary>
        [DataMember(Name="ThreeDSecure", EmitDefaultValue=false)]
        public ThreeDSecureRequestData ThreeDSecure { get; set; }

        /// <summary>
        /// Gets or Sets Recurring
        /// </summary>
        [DataMember(Name="Recurring", EmitDefaultValue=false)]
        public RecurringRequestData Recurring { get; set; }

        /// <summary>
        /// Gets or Sets BrowserInfo
        /// </summary>
        [DataMember(Name="BrowserInfo", EmitDefaultValue=false)]
        public BrowserInfoData BrowserInfo { get; set; }

        /// <summary>
        /// Url to redirect the cardholder to when then the transaction is complete
        /// </summary>
        /// <value>Url to redirect the cardholder to when then the transaction is complete</value>
        [DataMember(Name="MerchantResponseUrl", EmitDefaultValue=false)]
        public string MerchantResponseUrl { get; set; }

        /// <summary>
        /// Gets or Sets HostedPage
        /// </summary>
        [DataMember(Name="HostedPage", EmitDefaultValue=false)]
        public HostedPageRequestData HostedPage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtendedRequestData {\n");
            sb.Append("  SecondaryAddress: ").Append(SecondaryAddress).Append("\n");
            sb.Append("  CustomData: ").Append(CustomData).Append("\n");
            sb.Append("  Level2CustomData: ").Append(Level2CustomData).Append("\n");
            sb.Append("  Level3CustomData: ").Append(Level3CustomData).Append("\n");
            sb.Append("  ThreeDSecure: ").Append(ThreeDSecure).Append("\n");
            sb.Append("  Recurring: ").Append(Recurring).Append("\n");
            sb.Append("  BrowserInfo: ").Append(BrowserInfo).Append("\n");
            sb.Append("  MerchantResponseUrl: ").Append(MerchantResponseUrl).Append("\n");
            sb.Append("  HostedPage: ").Append(HostedPage).Append("\n");
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
            return this.Equals(input as ExtendedRequestData);
        }

        /// <summary>
        /// Returns true if ExtendedRequestData instances are equal
        /// </summary>
        /// <param name="input">Instance of ExtendedRequestData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtendedRequestData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SecondaryAddress == input.SecondaryAddress ||
                    (this.SecondaryAddress != null &&
                    this.SecondaryAddress.Equals(input.SecondaryAddress))
                ) && 
                (
                    this.CustomData == input.CustomData ||
                    (this.CustomData != null &&
                    this.CustomData.Equals(input.CustomData))
                ) && 
                (
                    this.Level2CustomData == input.Level2CustomData ||
                    (this.Level2CustomData != null &&
                    this.Level2CustomData.Equals(input.Level2CustomData))
                ) && 
                (
                    this.Level3CustomData == input.Level3CustomData ||
                    (this.Level3CustomData != null &&
                    this.Level3CustomData.Equals(input.Level3CustomData))
                ) && 
                (
                    this.ThreeDSecure == input.ThreeDSecure ||
                    (this.ThreeDSecure != null &&
                    this.ThreeDSecure.Equals(input.ThreeDSecure))
                ) && 
                (
                    this.Recurring == input.Recurring ||
                    (this.Recurring != null &&
                    this.Recurring.Equals(input.Recurring))
                ) && 
                (
                    this.BrowserInfo == input.BrowserInfo ||
                    (this.BrowserInfo != null &&
                    this.BrowserInfo.Equals(input.BrowserInfo))
                ) && 
                (
                    this.MerchantResponseUrl == input.MerchantResponseUrl ||
                    (this.MerchantResponseUrl != null &&
                    this.MerchantResponseUrl.Equals(input.MerchantResponseUrl))
                ) && 
                (
                    this.HostedPage == input.HostedPage ||
                    (this.HostedPage != null &&
                    this.HostedPage.Equals(input.HostedPage))
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
                if (this.SecondaryAddress != null)
                    hashCode = hashCode * 59 + this.SecondaryAddress.GetHashCode();
                if (this.CustomData != null)
                    hashCode = hashCode * 59 + this.CustomData.GetHashCode();
                if (this.Level2CustomData != null)
                    hashCode = hashCode * 59 + this.Level2CustomData.GetHashCode();
                if (this.Level3CustomData != null)
                    hashCode = hashCode * 59 + this.Level3CustomData.GetHashCode();
                if (this.ThreeDSecure != null)
                    hashCode = hashCode * 59 + this.ThreeDSecure.GetHashCode();
                if (this.Recurring != null)
                    hashCode = hashCode * 59 + this.Recurring.GetHashCode();
                if (this.BrowserInfo != null)
                    hashCode = hashCode * 59 + this.BrowserInfo.GetHashCode();
                if (this.MerchantResponseUrl != null)
                    hashCode = hashCode * 59 + this.MerchantResponseUrl.GetHashCode();
                if (this.HostedPage != null)
                    hashCode = hashCode * 59 + this.HostedPage.GetHashCode();
                return hashCode;
            }
        }
    }
}
