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
    /// TransOrder
    /// </summary>
    [DataContract]
        public partial class TransOrder :  IEquatable<TransOrder>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransOrder" /> class.
        /// </summary>
        /// <param name="authorizationCode">authorizationCode.</param>
        /// <param name="avsResponseCode">avsResponseCode.</param>
        /// <param name="currencyCode">currencyCode.</param>
        /// <param name="customData">customData.</param>
        /// <param name="cvvResponseCode">cvvResponseCode.</param>
        /// <param name="externalBatchIdentifier">externalBatchIdentifier.</param>
        /// <param name="externalGroupIdentifier">externalGroupIdentifier.</param>
        /// <param name="externalIdentifier">externalIdentifier.</param>
        /// <param name="internalResultCode">internalResultCode.</param>
        /// <param name="isoResponseCode">isoResponseCode.</param>
        /// <param name="orderSummary">orderSummary.</param>
        /// <param name="otherAmount">otherAmount.</param>
        /// <param name="taxAmount">taxAmount.</param>
        /// <param name="tipAmount">tipAmount.</param>
        /// <param name="totalAmount">totalAmount.</param>
        /// <param name="transactionDateTime">transactionDateTime.</param>
        /// <param name="transactionIdentifier">transactionIdentifier.</param>
        /// <param name="transactionType">transactionType.</param>
        public TransOrder(string authorizationCode = default(string), string avsResponseCode = default(string), string currencyCode = default(string), string customData = default(string), string cvvResponseCode = default(string), string externalBatchIdentifier = default(string), string externalGroupIdentifier = default(string), string externalIdentifier = default(string), string internalResultCode = default(string), string isoResponseCode = default(string), Order orderSummary = default(Order), double? otherAmount = default(double?), double? taxAmount = default(double?), double? tipAmount = default(double?), double? totalAmount = default(double?), DateTime? transactionDateTime = default(DateTime?), Guid? transactionIdentifier = default(Guid?), int? transactionType = default(int?))
        {
            this.AuthorizationCode = authorizationCode;
            this.AvsResponseCode = avsResponseCode;
            this.CurrencyCode = currencyCode;
            this.CustomData = customData;
            this.CvvResponseCode = cvvResponseCode;
            this.ExternalBatchIdentifier = externalBatchIdentifier;
            this.ExternalGroupIdentifier = externalGroupIdentifier;
            this.ExternalIdentifier = externalIdentifier;
            this.InternalResultCode = internalResultCode;
            this.IsoResponseCode = isoResponseCode;
            this.OrderSummary = orderSummary;
            this.OtherAmount = otherAmount;
            this.TaxAmount = taxAmount;
            this.TipAmount = tipAmount;
            this.TotalAmount = totalAmount;
            this.TransactionDateTime = transactionDateTime;
            this.TransactionIdentifier = transactionIdentifier;
            this.TransactionType = transactionType;
        }
        
        /// <summary>
        /// Gets or Sets AuthorizationCode
        /// </summary>
        [DataMember(Name="AuthorizationCode", EmitDefaultValue=false)]
        public string AuthorizationCode { get; set; }

        /// <summary>
        /// Gets or Sets AvsResponseCode
        /// </summary>
        [DataMember(Name="AvsResponseCode", EmitDefaultValue=false)]
        public string AvsResponseCode { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name="CurrencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets CustomData
        /// </summary>
        [DataMember(Name="CustomData", EmitDefaultValue=false)]
        public string CustomData { get; set; }

        /// <summary>
        /// Gets or Sets CvvResponseCode
        /// </summary>
        [DataMember(Name="CvvResponseCode", EmitDefaultValue=false)]
        public string CvvResponseCode { get; set; }

        /// <summary>
        /// Gets or Sets ExternalBatchIdentifier
        /// </summary>
        [DataMember(Name="ExternalBatchIdentifier", EmitDefaultValue=false)]
        public string ExternalBatchIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets ExternalGroupIdentifier
        /// </summary>
        [DataMember(Name="ExternalGroupIdentifier", EmitDefaultValue=false)]
        public string ExternalGroupIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets ExternalIdentifier
        /// </summary>
        [DataMember(Name="ExternalIdentifier", EmitDefaultValue=false)]
        public string ExternalIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets InternalResultCode
        /// </summary>
        [DataMember(Name="InternalResultCode", EmitDefaultValue=false)]
        public string InternalResultCode { get; set; }

        /// <summary>
        /// Gets or Sets IsoResponseCode
        /// </summary>
        [DataMember(Name="IsoResponseCode", EmitDefaultValue=false)]
        public string IsoResponseCode { get; set; }

        /// <summary>
        /// Gets or Sets OrderSummary
        /// </summary>
        [DataMember(Name="OrderSummary", EmitDefaultValue=false)]
        public Order OrderSummary { get; set; }

        /// <summary>
        /// Gets or Sets OtherAmount
        /// </summary>
        [DataMember(Name="OtherAmount", EmitDefaultValue=false)]
        public double? OtherAmount { get; set; }

        /// <summary>
        /// Gets or Sets TaxAmount
        /// </summary>
        [DataMember(Name="TaxAmount", EmitDefaultValue=false)]
        public double? TaxAmount { get; set; }

        /// <summary>
        /// Gets or Sets TipAmount
        /// </summary>
        [DataMember(Name="TipAmount", EmitDefaultValue=false)]
        public double? TipAmount { get; set; }

        /// <summary>
        /// Gets or Sets TotalAmount
        /// </summary>
        [DataMember(Name="TotalAmount", EmitDefaultValue=false)]
        public double? TotalAmount { get; set; }

        /// <summary>
        /// Gets or Sets TransactionDateTime
        /// </summary>
        [DataMember(Name="TransactionDateTime", EmitDefaultValue=false)]
        public DateTime? TransactionDateTime { get; set; }

        /// <summary>
        /// Gets or Sets TransactionIdentifier
        /// </summary>
        [DataMember(Name="TransactionIdentifier", EmitDefaultValue=false)]
        public Guid? TransactionIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets TransactionType
        /// </summary>
        [DataMember(Name="TransactionType", EmitDefaultValue=false)]
        public int? TransactionType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransOrder {\n");
            sb.Append("  AuthorizationCode: ").Append(AuthorizationCode).Append("\n");
            sb.Append("  AvsResponseCode: ").Append(AvsResponseCode).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  CustomData: ").Append(CustomData).Append("\n");
            sb.Append("  CvvResponseCode: ").Append(CvvResponseCode).Append("\n");
            sb.Append("  ExternalBatchIdentifier: ").Append(ExternalBatchIdentifier).Append("\n");
            sb.Append("  ExternalGroupIdentifier: ").Append(ExternalGroupIdentifier).Append("\n");
            sb.Append("  ExternalIdentifier: ").Append(ExternalIdentifier).Append("\n");
            sb.Append("  InternalResultCode: ").Append(InternalResultCode).Append("\n");
            sb.Append("  IsoResponseCode: ").Append(IsoResponseCode).Append("\n");
            sb.Append("  OrderSummary: ").Append(OrderSummary).Append("\n");
            sb.Append("  OtherAmount: ").Append(OtherAmount).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  TipAmount: ").Append(TipAmount).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  TransactionDateTime: ").Append(TransactionDateTime).Append("\n");
            sb.Append("  TransactionIdentifier: ").Append(TransactionIdentifier).Append("\n");
            sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
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
            return this.Equals(input as TransOrder);
        }

        /// <summary>
        /// Returns true if TransOrder instances are equal
        /// </summary>
        /// <param name="input">Instance of TransOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransOrder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthorizationCode == input.AuthorizationCode ||
                    (this.AuthorizationCode != null &&
                    this.AuthorizationCode.Equals(input.AuthorizationCode))
                ) && 
                (
                    this.AvsResponseCode == input.AvsResponseCode ||
                    (this.AvsResponseCode != null &&
                    this.AvsResponseCode.Equals(input.AvsResponseCode))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.CustomData == input.CustomData ||
                    (this.CustomData != null &&
                    this.CustomData.Equals(input.CustomData))
                ) && 
                (
                    this.CvvResponseCode == input.CvvResponseCode ||
                    (this.CvvResponseCode != null &&
                    this.CvvResponseCode.Equals(input.CvvResponseCode))
                ) && 
                (
                    this.ExternalBatchIdentifier == input.ExternalBatchIdentifier ||
                    (this.ExternalBatchIdentifier != null &&
                    this.ExternalBatchIdentifier.Equals(input.ExternalBatchIdentifier))
                ) && 
                (
                    this.ExternalGroupIdentifier == input.ExternalGroupIdentifier ||
                    (this.ExternalGroupIdentifier != null &&
                    this.ExternalGroupIdentifier.Equals(input.ExternalGroupIdentifier))
                ) && 
                (
                    this.ExternalIdentifier == input.ExternalIdentifier ||
                    (this.ExternalIdentifier != null &&
                    this.ExternalIdentifier.Equals(input.ExternalIdentifier))
                ) && 
                (
                    this.InternalResultCode == input.InternalResultCode ||
                    (this.InternalResultCode != null &&
                    this.InternalResultCode.Equals(input.InternalResultCode))
                ) && 
                (
                    this.IsoResponseCode == input.IsoResponseCode ||
                    (this.IsoResponseCode != null &&
                    this.IsoResponseCode.Equals(input.IsoResponseCode))
                ) && 
                (
                    this.OrderSummary == input.OrderSummary ||
                    (this.OrderSummary != null &&
                    this.OrderSummary.Equals(input.OrderSummary))
                ) && 
                (
                    this.OtherAmount == input.OtherAmount ||
                    (this.OtherAmount != null &&
                    this.OtherAmount.Equals(input.OtherAmount))
                ) && 
                (
                    this.TaxAmount == input.TaxAmount ||
                    (this.TaxAmount != null &&
                    this.TaxAmount.Equals(input.TaxAmount))
                ) && 
                (
                    this.TipAmount == input.TipAmount ||
                    (this.TipAmount != null &&
                    this.TipAmount.Equals(input.TipAmount))
                ) && 
                (
                    this.TotalAmount == input.TotalAmount ||
                    (this.TotalAmount != null &&
                    this.TotalAmount.Equals(input.TotalAmount))
                ) && 
                (
                    this.TransactionDateTime == input.TransactionDateTime ||
                    (this.TransactionDateTime != null &&
                    this.TransactionDateTime.Equals(input.TransactionDateTime))
                ) && 
                (
                    this.TransactionIdentifier == input.TransactionIdentifier ||
                    (this.TransactionIdentifier != null &&
                    this.TransactionIdentifier.Equals(input.TransactionIdentifier))
                ) && 
                (
                    this.TransactionType == input.TransactionType ||
                    (this.TransactionType != null &&
                    this.TransactionType.Equals(input.TransactionType))
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
                if (this.AuthorizationCode != null)
                    hashCode = hashCode * 59 + this.AuthorizationCode.GetHashCode();
                if (this.AvsResponseCode != null)
                    hashCode = hashCode * 59 + this.AvsResponseCode.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.CustomData != null)
                    hashCode = hashCode * 59 + this.CustomData.GetHashCode();
                if (this.CvvResponseCode != null)
                    hashCode = hashCode * 59 + this.CvvResponseCode.GetHashCode();
                if (this.ExternalBatchIdentifier != null)
                    hashCode = hashCode * 59 + this.ExternalBatchIdentifier.GetHashCode();
                if (this.ExternalGroupIdentifier != null)
                    hashCode = hashCode * 59 + this.ExternalGroupIdentifier.GetHashCode();
                if (this.ExternalIdentifier != null)
                    hashCode = hashCode * 59 + this.ExternalIdentifier.GetHashCode();
                if (this.InternalResultCode != null)
                    hashCode = hashCode * 59 + this.InternalResultCode.GetHashCode();
                if (this.IsoResponseCode != null)
                    hashCode = hashCode * 59 + this.IsoResponseCode.GetHashCode();
                if (this.OrderSummary != null)
                    hashCode = hashCode * 59 + this.OrderSummary.GetHashCode();
                if (this.OtherAmount != null)
                    hashCode = hashCode * 59 + this.OtherAmount.GetHashCode();
                if (this.TaxAmount != null)
                    hashCode = hashCode * 59 + this.TaxAmount.GetHashCode();
                if (this.TipAmount != null)
                    hashCode = hashCode * 59 + this.TipAmount.GetHashCode();
                if (this.TotalAmount != null)
                    hashCode = hashCode * 59 + this.TotalAmount.GetHashCode();
                if (this.TransactionDateTime != null)
                    hashCode = hashCode * 59 + this.TransactionDateTime.GetHashCode();
                if (this.TransactionIdentifier != null)
                    hashCode = hashCode * 59 + this.TransactionIdentifier.GetHashCode();
                if (this.TransactionType != null)
                    hashCode = hashCode * 59 + this.TransactionType.GetHashCode();
                return hashCode;
            }
        }
    }
}
