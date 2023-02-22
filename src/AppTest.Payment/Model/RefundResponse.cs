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
    /// Refund response
    /// </summary>
    [DataContract]
        public partial class RefundResponse :  IEquatable<RefundResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundResponse" /> class.
        /// </summary>
        /// <param name="originalTrxnIdentifier">Transaction Identifier of the original transaction (transaction being refunded).</param>
        /// <param name="transactionType">Auth &#x3D; 1, Sale &#x3D; 2, Capture &#x3D; 3, Void &#x3D; 4, Refund &#x3D; 5, Credit &#x3D; 6.</param>
        /// <param name="approved">Whether or not the authorization was approved.</param>
        /// <param name="authorizationCode">Authorization code.</param>
        /// <param name="transactionIdentifier">Transaction identifier.</param>
        /// <param name="totalAmount">Approved total amount.</param>
        /// <param name="currencyCode">Currency code.</param>
        /// <param name="rRN">Retrieval Reference Number.</param>
        /// <param name="hostRRN">Host Retrieval Reference Number.</param>
        /// <param name="cardBrand">Brand of the card used.</param>
        /// <param name="cardSuffix">Suffix of the card used.</param>
        /// <param name="isoResponseCode">Standard ISO response code.</param>
        /// <param name="emvIssuerAuthenticationData">Issuer authentication data for EMV purposes; used with the EMV card.</param>
        /// <param name="emvIssuerScripts">Issuer scripts for EMV purposes; executed against the EMV card.</param>
        /// <param name="emvResponseCode">Authorization Response Code in response EMV data.</param>
        /// <param name="responseMessage">Response message.</param>
        /// <param name="riskManagement">riskManagement.</param>
        /// <param name="customData">Custom response data.</param>
        /// <param name="host">Host response data.</param>
        /// <param name="panToken">PowerTranz Token for the Pan.</param>
        /// <param name="externalIdentifier">External identifier for the transaction.</param>
        /// <param name="orderIdentifier">OrderIdentifier mirrored from request.</param>
        /// <param name="errors">Errors.</param>
        /// <param name="redirectData">HTML redirect data required for various integration types.</param>
        /// <param name="spiToken">Single use integration token.</param>
        /// <param name="billingAddress">billingAddress.</param>
        public RefundResponse(string originalTrxnIdentifier = default(string), int? transactionType = default(int?), bool? approved = default(bool?), string authorizationCode = default(string), string transactionIdentifier = default(string), double? totalAmount = default(double?), string currencyCode = default(string), string rRN = default(string), string hostRRN = default(string), string cardBrand = default(string), string cardSuffix = default(string), string isoResponseCode = default(string), string emvIssuerAuthenticationData = default(string), string emvIssuerScripts = default(string), string emvResponseCode = default(string), string responseMessage = default(string), RiskManagementResponse riskManagement = default(RiskManagementResponse), Object customData = default(Object), Object host = default(Object), string panToken = default(string), string externalIdentifier = default(string), string orderIdentifier = default(string), List<Error> errors = default(List<Error>), string redirectData = default(string), string spiToken = default(string), Address billingAddress = default(Address))
        {
            this.OriginalTrxnIdentifier = originalTrxnIdentifier;
            this.TransactionType = transactionType;
            this.Approved = approved;
            this.AuthorizationCode = authorizationCode;
            this.TransactionIdentifier = transactionIdentifier;
            this.TotalAmount = totalAmount;
            this.CurrencyCode = currencyCode;
            this.RRN = rRN;
            this.HostRRN = hostRRN;
            this.CardBrand = cardBrand;
            this.CardSuffix = cardSuffix;
            this.IsoResponseCode = isoResponseCode;
            this.EmvIssuerAuthenticationData = emvIssuerAuthenticationData;
            this.EmvIssuerScripts = emvIssuerScripts;
            this.EmvResponseCode = emvResponseCode;
            this.ResponseMessage = responseMessage;
            this.RiskManagement = riskManagement;
            this.CustomData = customData;
            this.Host = host;
            this.PanToken = panToken;
            this.ExternalIdentifier = externalIdentifier;
            this.OrderIdentifier = orderIdentifier;
            this.Errors = errors;
            this.RedirectData = redirectData;
            this.SpiToken = spiToken;
            this.BillingAddress = billingAddress;
        }
        
        /// <summary>
        /// Transaction Identifier of the original transaction (transaction being refunded)
        /// </summary>
        /// <value>Transaction Identifier of the original transaction (transaction being refunded)</value>
        [DataMember(Name="OriginalTrxnIdentifier", EmitDefaultValue=false)]
        public string OriginalTrxnIdentifier { get; set; }

        /// <summary>
        /// Auth &#x3D; 1, Sale &#x3D; 2, Capture &#x3D; 3, Void &#x3D; 4, Refund &#x3D; 5, Credit &#x3D; 6
        /// </summary>
        /// <value>Auth &#x3D; 1, Sale &#x3D; 2, Capture &#x3D; 3, Void &#x3D; 4, Refund &#x3D; 5, Credit &#x3D; 6</value>
        [DataMember(Name="TransactionType", EmitDefaultValue=false)]
        public int? TransactionType { get; set; }

        /// <summary>
        /// Whether or not the authorization was approved
        /// </summary>
        /// <value>Whether or not the authorization was approved</value>
        [DataMember(Name="Approved", EmitDefaultValue=false)]
        public bool? Approved { get; set; }

        /// <summary>
        /// Authorization code
        /// </summary>
        /// <value>Authorization code</value>
        [DataMember(Name="AuthorizationCode", EmitDefaultValue=false)]
        public string AuthorizationCode { get; set; }

        /// <summary>
        /// Transaction identifier
        /// </summary>
        /// <value>Transaction identifier</value>
        [DataMember(Name="TransactionIdentifier", EmitDefaultValue=false)]
        public string TransactionIdentifier { get; set; }

        /// <summary>
        /// Approved total amount
        /// </summary>
        /// <value>Approved total amount</value>
        [DataMember(Name="TotalAmount", EmitDefaultValue=false)]
        public double? TotalAmount { get; set; }

        /// <summary>
        /// Currency code
        /// </summary>
        /// <value>Currency code</value>
        [DataMember(Name="CurrencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Retrieval Reference Number
        /// </summary>
        /// <value>Retrieval Reference Number</value>
        [DataMember(Name="RRN", EmitDefaultValue=false)]
        public string RRN { get; set; }

        /// <summary>
        /// Host Retrieval Reference Number
        /// </summary>
        /// <value>Host Retrieval Reference Number</value>
        [DataMember(Name="HostRRN", EmitDefaultValue=false)]
        public string HostRRN { get; set; }

        /// <summary>
        /// Brand of the card used
        /// </summary>
        /// <value>Brand of the card used</value>
        [DataMember(Name="CardBrand", EmitDefaultValue=false)]
        public string CardBrand { get; set; }

        /// <summary>
        /// Suffix of the card used
        /// </summary>
        /// <value>Suffix of the card used</value>
        [DataMember(Name="CardSuffix", EmitDefaultValue=false)]
        public string CardSuffix { get; set; }

        /// <summary>
        /// Standard ISO response code
        /// </summary>
        /// <value>Standard ISO response code</value>
        [DataMember(Name="IsoResponseCode", EmitDefaultValue=false)]
        public string IsoResponseCode { get; set; }

        /// <summary>
        /// Issuer authentication data for EMV purposes; used with the EMV card
        /// </summary>
        /// <value>Issuer authentication data for EMV purposes; used with the EMV card</value>
        [DataMember(Name="EmvIssuerAuthenticationData", EmitDefaultValue=false)]
        public string EmvIssuerAuthenticationData { get; set; }

        /// <summary>
        /// Issuer scripts for EMV purposes; executed against the EMV card
        /// </summary>
        /// <value>Issuer scripts for EMV purposes; executed against the EMV card</value>
        [DataMember(Name="EmvIssuerScripts", EmitDefaultValue=false)]
        public string EmvIssuerScripts { get; set; }

        /// <summary>
        /// Authorization Response Code in response EMV data
        /// </summary>
        /// <value>Authorization Response Code in response EMV data</value>
        [DataMember(Name="EmvResponseCode", EmitDefaultValue=false)]
        public string EmvResponseCode { get; set; }

        /// <summary>
        /// Response message
        /// </summary>
        /// <value>Response message</value>
        [DataMember(Name="ResponseMessage", EmitDefaultValue=false)]
        public string ResponseMessage { get; set; }

        /// <summary>
        /// Gets or Sets RiskManagement
        /// </summary>
        [DataMember(Name="RiskManagement", EmitDefaultValue=false)]
        public RiskManagementResponse RiskManagement { get; set; }

        /// <summary>
        /// Custom response data
        /// </summary>
        /// <value>Custom response data</value>
        [DataMember(Name="CustomData", EmitDefaultValue=false)]
        public Object CustomData { get; set; }

        /// <summary>
        /// Host response data
        /// </summary>
        /// <value>Host response data</value>
        [DataMember(Name="Host", EmitDefaultValue=false)]
        public Object Host { get; set; }

        /// <summary>
        /// PowerTranz Token for the Pan
        /// </summary>
        /// <value>PowerTranz Token for the Pan</value>
        [DataMember(Name="PanToken", EmitDefaultValue=false)]
        public string PanToken { get; set; }

        /// <summary>
        /// External identifier for the transaction
        /// </summary>
        /// <value>External identifier for the transaction</value>
        [DataMember(Name="ExternalIdentifier", EmitDefaultValue=false)]
        public string ExternalIdentifier { get; set; }

        /// <summary>
        /// OrderIdentifier mirrored from request
        /// </summary>
        /// <value>OrderIdentifier mirrored from request</value>
        [DataMember(Name="OrderIdentifier", EmitDefaultValue=false)]
        public string OrderIdentifier { get; set; }

        /// <summary>
        /// Errors
        /// </summary>
        /// <value>Errors</value>
        [DataMember(Name="Errors", EmitDefaultValue=false)]
        public List<Error> Errors { get; set; }

        /// <summary>
        /// HTML redirect data required for various integration types
        /// </summary>
        /// <value>HTML redirect data required for various integration types</value>
        [DataMember(Name="RedirectData", EmitDefaultValue=false)]
        public string RedirectData { get; set; }

        /// <summary>
        /// Single use integration token
        /// </summary>
        /// <value>Single use integration token</value>
        [DataMember(Name="SpiToken", EmitDefaultValue=false)]
        public string SpiToken { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name="BillingAddress", EmitDefaultValue=false)]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RefundResponse {\n");
            sb.Append("  OriginalTrxnIdentifier: ").Append(OriginalTrxnIdentifier).Append("\n");
            sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
            sb.Append("  Approved: ").Append(Approved).Append("\n");
            sb.Append("  AuthorizationCode: ").Append(AuthorizationCode).Append("\n");
            sb.Append("  TransactionIdentifier: ").Append(TransactionIdentifier).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  RRN: ").Append(RRN).Append("\n");
            sb.Append("  HostRRN: ").Append(HostRRN).Append("\n");
            sb.Append("  CardBrand: ").Append(CardBrand).Append("\n");
            sb.Append("  CardSuffix: ").Append(CardSuffix).Append("\n");
            sb.Append("  IsoResponseCode: ").Append(IsoResponseCode).Append("\n");
            sb.Append("  EmvIssuerAuthenticationData: ").Append(EmvIssuerAuthenticationData).Append("\n");
            sb.Append("  EmvIssuerScripts: ").Append(EmvIssuerScripts).Append("\n");
            sb.Append("  EmvResponseCode: ").Append(EmvResponseCode).Append("\n");
            sb.Append("  ResponseMessage: ").Append(ResponseMessage).Append("\n");
            sb.Append("  RiskManagement: ").Append(RiskManagement).Append("\n");
            sb.Append("  CustomData: ").Append(CustomData).Append("\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  PanToken: ").Append(PanToken).Append("\n");
            sb.Append("  ExternalIdentifier: ").Append(ExternalIdentifier).Append("\n");
            sb.Append("  OrderIdentifier: ").Append(OrderIdentifier).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  RedirectData: ").Append(RedirectData).Append("\n");
            sb.Append("  SpiToken: ").Append(SpiToken).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
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
            return this.Equals(input as RefundResponse);
        }

        /// <summary>
        /// Returns true if RefundResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RefundResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RefundResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OriginalTrxnIdentifier == input.OriginalTrxnIdentifier ||
                    (this.OriginalTrxnIdentifier != null &&
                    this.OriginalTrxnIdentifier.Equals(input.OriginalTrxnIdentifier))
                ) && 
                (
                    this.TransactionType == input.TransactionType ||
                    (this.TransactionType != null &&
                    this.TransactionType.Equals(input.TransactionType))
                ) && 
                (
                    this.Approved == input.Approved ||
                    (this.Approved != null &&
                    this.Approved.Equals(input.Approved))
                ) && 
                (
                    this.AuthorizationCode == input.AuthorizationCode ||
                    (this.AuthorizationCode != null &&
                    this.AuthorizationCode.Equals(input.AuthorizationCode))
                ) && 
                (
                    this.TransactionIdentifier == input.TransactionIdentifier ||
                    (this.TransactionIdentifier != null &&
                    this.TransactionIdentifier.Equals(input.TransactionIdentifier))
                ) && 
                (
                    this.TotalAmount == input.TotalAmount ||
                    (this.TotalAmount != null &&
                    this.TotalAmount.Equals(input.TotalAmount))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.RRN == input.RRN ||
                    (this.RRN != null &&
                    this.RRN.Equals(input.RRN))
                ) && 
                (
                    this.HostRRN == input.HostRRN ||
                    (this.HostRRN != null &&
                    this.HostRRN.Equals(input.HostRRN))
                ) && 
                (
                    this.CardBrand == input.CardBrand ||
                    (this.CardBrand != null &&
                    this.CardBrand.Equals(input.CardBrand))
                ) && 
                (
                    this.CardSuffix == input.CardSuffix ||
                    (this.CardSuffix != null &&
                    this.CardSuffix.Equals(input.CardSuffix))
                ) && 
                (
                    this.IsoResponseCode == input.IsoResponseCode ||
                    (this.IsoResponseCode != null &&
                    this.IsoResponseCode.Equals(input.IsoResponseCode))
                ) && 
                (
                    this.EmvIssuerAuthenticationData == input.EmvIssuerAuthenticationData ||
                    (this.EmvIssuerAuthenticationData != null &&
                    this.EmvIssuerAuthenticationData.Equals(input.EmvIssuerAuthenticationData))
                ) && 
                (
                    this.EmvIssuerScripts == input.EmvIssuerScripts ||
                    (this.EmvIssuerScripts != null &&
                    this.EmvIssuerScripts.Equals(input.EmvIssuerScripts))
                ) && 
                (
                    this.EmvResponseCode == input.EmvResponseCode ||
                    (this.EmvResponseCode != null &&
                    this.EmvResponseCode.Equals(input.EmvResponseCode))
                ) && 
                (
                    this.ResponseMessage == input.ResponseMessage ||
                    (this.ResponseMessage != null &&
                    this.ResponseMessage.Equals(input.ResponseMessage))
                ) && 
                (
                    this.RiskManagement == input.RiskManagement ||
                    (this.RiskManagement != null &&
                    this.RiskManagement.Equals(input.RiskManagement))
                ) && 
                (
                    this.CustomData == input.CustomData ||
                    (this.CustomData != null &&
                    this.CustomData.Equals(input.CustomData))
                ) && 
                (
                    this.Host == input.Host ||
                    (this.Host != null &&
                    this.Host.Equals(input.Host))
                ) && 
                (
                    this.PanToken == input.PanToken ||
                    (this.PanToken != null &&
                    this.PanToken.Equals(input.PanToken))
                ) && 
                (
                    this.ExternalIdentifier == input.ExternalIdentifier ||
                    (this.ExternalIdentifier != null &&
                    this.ExternalIdentifier.Equals(input.ExternalIdentifier))
                ) && 
                (
                    this.OrderIdentifier == input.OrderIdentifier ||
                    (this.OrderIdentifier != null &&
                    this.OrderIdentifier.Equals(input.OrderIdentifier))
                ) && 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    input.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
                ) && 
                (
                    this.RedirectData == input.RedirectData ||
                    (this.RedirectData != null &&
                    this.RedirectData.Equals(input.RedirectData))
                ) && 
                (
                    this.SpiToken == input.SpiToken ||
                    (this.SpiToken != null &&
                    this.SpiToken.Equals(input.SpiToken))
                ) && 
                (
                    this.BillingAddress == input.BillingAddress ||
                    (this.BillingAddress != null &&
                    this.BillingAddress.Equals(input.BillingAddress))
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
                if (this.OriginalTrxnIdentifier != null)
                    hashCode = hashCode * 59 + this.OriginalTrxnIdentifier.GetHashCode();
                if (this.TransactionType != null)
                    hashCode = hashCode * 59 + this.TransactionType.GetHashCode();
                if (this.Approved != null)
                    hashCode = hashCode * 59 + this.Approved.GetHashCode();
                if (this.AuthorizationCode != null)
                    hashCode = hashCode * 59 + this.AuthorizationCode.GetHashCode();
                if (this.TransactionIdentifier != null)
                    hashCode = hashCode * 59 + this.TransactionIdentifier.GetHashCode();
                if (this.TotalAmount != null)
                    hashCode = hashCode * 59 + this.TotalAmount.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.RRN != null)
                    hashCode = hashCode * 59 + this.RRN.GetHashCode();
                if (this.HostRRN != null)
                    hashCode = hashCode * 59 + this.HostRRN.GetHashCode();
                if (this.CardBrand != null)
                    hashCode = hashCode * 59 + this.CardBrand.GetHashCode();
                if (this.CardSuffix != null)
                    hashCode = hashCode * 59 + this.CardSuffix.GetHashCode();
                if (this.IsoResponseCode != null)
                    hashCode = hashCode * 59 + this.IsoResponseCode.GetHashCode();
                if (this.EmvIssuerAuthenticationData != null)
                    hashCode = hashCode * 59 + this.EmvIssuerAuthenticationData.GetHashCode();
                if (this.EmvIssuerScripts != null)
                    hashCode = hashCode * 59 + this.EmvIssuerScripts.GetHashCode();
                if (this.EmvResponseCode != null)
                    hashCode = hashCode * 59 + this.EmvResponseCode.GetHashCode();
                if (this.ResponseMessage != null)
                    hashCode = hashCode * 59 + this.ResponseMessage.GetHashCode();
                if (this.RiskManagement != null)
                    hashCode = hashCode * 59 + this.RiskManagement.GetHashCode();
                if (this.CustomData != null)
                    hashCode = hashCode * 59 + this.CustomData.GetHashCode();
                if (this.Host != null)
                    hashCode = hashCode * 59 + this.Host.GetHashCode();
                if (this.PanToken != null)
                    hashCode = hashCode * 59 + this.PanToken.GetHashCode();
                if (this.ExternalIdentifier != null)
                    hashCode = hashCode * 59 + this.ExternalIdentifier.GetHashCode();
                if (this.OrderIdentifier != null)
                    hashCode = hashCode * 59 + this.OrderIdentifier.GetHashCode();
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
                if (this.RedirectData != null)
                    hashCode = hashCode * 59 + this.RedirectData.GetHashCode();
                if (this.SpiToken != null)
                    hashCode = hashCode * 59 + this.SpiToken.GetHashCode();
                if (this.BillingAddress != null)
                    hashCode = hashCode * 59 + this.BillingAddress.GetHashCode();
                return hashCode;
            }
        }
    }
}
