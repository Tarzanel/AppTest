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
    /// Sale request
    /// </summary>
    [DataContract]
        public partial class SaleRequest :  IEquatable<SaleRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SaleRequest" /> class.
        /// </summary>
        /// <param name="transactionIdentifier">Transaction identifier. String representation of a GUID..</param>
        /// <param name="totalAmount">Total amount to authorize (required).</param>
        /// <param name="tipAmount">Tip amount.</param>
        /// <param name="taxAmount">Tax amount.</param>
        /// <param name="otherAmount">CashBackAmount or other amount.</param>
        /// <param name="currencyCode">Currency code (required).</param>
        /// <param name="localTime">Local time at transaction initiation hhmmss.</param>
        /// <param name="localDate">Local date at transaction initiation YYYYMMDD.</param>
        /// <param name="addressVerification">If true, an AVS check will be peformed.</param>
        /// <param name="threeDSecure">If true, perform 3DSecure processing with the transaction if present.</param>
        /// <param name="binCheck">If true, a BIN Check is performed with the transaction.</param>
        /// <param name="fraudCheck">If true, Fraud Check will be performed with the transaction.</param>
        /// <param name="recurringInitial">If true, this is the first transaction in a recurring series.</param>
        /// <param name="recurring">If true, this transaction is part of a recurring series.</param>
        /// <param name="cardOnFile">If true, this transaction is a Card-on-file transaction.</param>
        /// <param name="accountVerification">If true, perform an account verification.</param>
        /// <param name="source">source (required).</param>
        /// <param name="terminalId">TerminalId.</param>
        /// <param name="terminalCode">Terminal model.</param>
        /// <param name="terminalSerialNumber">Terminal serial.</param>
        /// <param name="externalIdentifier">External identifier for the transaction.</param>
        /// <param name="externalBatchIdentifier">External identifier for the transaction&#x27;s batch.</param>
        /// <param name="externalGroupIdentifier">Optional external group identifier.</param>
        /// <param name="orderIdentifier">Order identifier.</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="shippingAddress">shippingAddress.</param>
        /// <param name="addressMatch">Indicates whether ShippingAddress is the same as BillingAddress (default to false).</param>
        /// <param name="extendedData">extendedData.</param>
        public SaleRequest(string transactionIdentifier = default(string), double? totalAmount = default(double?), double? tipAmount = default(double?), double? taxAmount = default(double?), double? otherAmount = default(double?), string currencyCode = default(string), string localTime = default(string), string localDate = default(string), bool? addressVerification = default(bool?), bool? threeDSecure = default(bool?), bool? binCheck = default(bool?), bool? fraudCheck = default(bool?), bool? recurringInitial = default(bool?), bool? recurring = default(bool?), bool? cardOnFile = default(bool?), bool? accountVerification = default(bool?), Source source = default(Source), string terminalId = default(string), string terminalCode = default(string), string terminalSerialNumber = default(string), string externalIdentifier = default(string), string externalBatchIdentifier = default(string), string externalGroupIdentifier = default(string), string orderIdentifier = default(string), Address billingAddress = default(Address), Address shippingAddress = default(Address), bool? addressMatch = false, ExtendedRequestData extendedData = default(ExtendedRequestData))
        {
            // to ensure "totalAmount" is required (not null)
            if (totalAmount == null)
            {
                throw new InvalidDataException("totalAmount is a required property for SaleRequest and cannot be null");
            }
            else
            {
                this.TotalAmount = totalAmount;
            }
            // to ensure "currencyCode" is required (not null)
            if (currencyCode == null)
            {
                throw new InvalidDataException("currencyCode is a required property for SaleRequest and cannot be null");
            }
            else
            {
                this.CurrencyCode = currencyCode;
            }
            // to ensure "source" is required (not null)
            if (source == null)
            {
                throw new InvalidDataException("source is a required property for SaleRequest and cannot be null");
            }
            else
            {
                this.Source = source;
            }
            this.TransactionIdentifier = transactionIdentifier;
            this.TipAmount = tipAmount;
            this.TaxAmount = taxAmount;
            this.OtherAmount = otherAmount;
            this.LocalTime = localTime;
            this.LocalDate = localDate;
            this.AddressVerification = addressVerification;
            this.ThreeDSecure = threeDSecure;
            this.BinCheck = binCheck;
            this.FraudCheck = fraudCheck;
            this.RecurringInitial = recurringInitial;
            this.Recurring = recurring;
            this.CardOnFile = cardOnFile;
            this.AccountVerification = accountVerification;
            this.TerminalId = terminalId;
            this.TerminalCode = terminalCode;
            this.TerminalSerialNumber = terminalSerialNumber;
            this.ExternalIdentifier = externalIdentifier;
            this.ExternalBatchIdentifier = externalBatchIdentifier;
            this.ExternalGroupIdentifier = externalGroupIdentifier;
            this.OrderIdentifier = orderIdentifier;
            this.BillingAddress = billingAddress;
            this.ShippingAddress = shippingAddress;
            // use default value if no "addressMatch" provided
            if (addressMatch == null)
            {
                this.AddressMatch = false;
            }
            else
            {
                this.AddressMatch = addressMatch;
            }
            this.ExtendedData = extendedData;
        }
        
        /// <summary>
        /// Transaction identifier. String representation of a GUID.
        /// </summary>
        /// <value>Transaction identifier. String representation of a GUID.</value>
        [DataMember(Name="TransactionIdentifier", EmitDefaultValue=false)]
        public string TransactionIdentifier { get; set; }

        /// <summary>
        /// Total amount to authorize
        /// </summary>
        /// <value>Total amount to authorize</value>
        [DataMember(Name="TotalAmount", EmitDefaultValue=false)]
        public double? TotalAmount { get; set; }

        /// <summary>
        /// Tip amount
        /// </summary>
        /// <value>Tip amount</value>
        [DataMember(Name="TipAmount", EmitDefaultValue=false)]
        public double? TipAmount { get; set; }

        /// <summary>
        /// Tax amount
        /// </summary>
        /// <value>Tax amount</value>
        [DataMember(Name="TaxAmount", EmitDefaultValue=false)]
        public double? TaxAmount { get; set; }

        /// <summary>
        /// CashBackAmount or other amount
        /// </summary>
        /// <value>CashBackAmount or other amount</value>
        [DataMember(Name="OtherAmount", EmitDefaultValue=false)]
        public double? OtherAmount { get; set; }

        /// <summary>
        /// Currency code
        /// </summary>
        /// <value>Currency code</value>
        [DataMember(Name="CurrencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Local time at transaction initiation hhmmss
        /// </summary>
        /// <value>Local time at transaction initiation hhmmss</value>
        [DataMember(Name="LocalTime", EmitDefaultValue=false)]
        public string LocalTime { get; set; }

        /// <summary>
        /// Local date at transaction initiation YYYYMMDD
        /// </summary>
        /// <value>Local date at transaction initiation YYYYMMDD</value>
        [DataMember(Name="LocalDate", EmitDefaultValue=false)]
        public string LocalDate { get; set; }

        /// <summary>
        /// If true, an AVS check will be peformed
        /// </summary>
        /// <value>If true, an AVS check will be peformed</value>
        [DataMember(Name="AddressVerification", EmitDefaultValue=false)]
        public bool? AddressVerification { get; set; }

        /// <summary>
        /// If true, perform 3DSecure processing with the transaction if present
        /// </summary>
        /// <value>If true, perform 3DSecure processing with the transaction if present</value>
        [DataMember(Name="ThreeDSecure", EmitDefaultValue=false)]
        public bool? ThreeDSecure { get; set; }

        /// <summary>
        /// If true, a BIN Check is performed with the transaction
        /// </summary>
        /// <value>If true, a BIN Check is performed with the transaction</value>
        [DataMember(Name="BinCheck", EmitDefaultValue=false)]
        public bool? BinCheck { get; set; }

        /// <summary>
        /// If true, Fraud Check will be performed with the transaction
        /// </summary>
        /// <value>If true, Fraud Check will be performed with the transaction</value>
        [DataMember(Name="FraudCheck", EmitDefaultValue=false)]
        public bool? FraudCheck { get; set; }

        /// <summary>
        /// If true, this is the first transaction in a recurring series
        /// </summary>
        /// <value>If true, this is the first transaction in a recurring series</value>
        [DataMember(Name="RecurringInitial", EmitDefaultValue=false)]
        public bool? RecurringInitial { get; set; }

        /// <summary>
        /// If true, this transaction is part of a recurring series
        /// </summary>
        /// <value>If true, this transaction is part of a recurring series</value>
        [DataMember(Name="Recurring", EmitDefaultValue=false)]
        public bool? Recurring { get; set; }

        /// <summary>
        /// If true, this transaction is a Card-on-file transaction
        /// </summary>
        /// <value>If true, this transaction is a Card-on-file transaction</value>
        [DataMember(Name="CardOnFile", EmitDefaultValue=false)]
        public bool? CardOnFile { get; set; }

        /// <summary>
        /// If true, perform an account verification
        /// </summary>
        /// <value>If true, perform an account verification</value>
        [DataMember(Name="AccountVerification", EmitDefaultValue=false)]
        public bool? AccountVerification { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="Source", EmitDefaultValue=false)]
        public Source Source { get; set; }

        /// <summary>
        /// TerminalId
        /// </summary>
        /// <value>TerminalId</value>
        [DataMember(Name="TerminalId", EmitDefaultValue=false)]
        public string TerminalId { get; set; }

        /// <summary>
        /// Terminal model
        /// </summary>
        /// <value>Terminal model</value>
        [DataMember(Name="TerminalCode", EmitDefaultValue=false)]
        public string TerminalCode { get; set; }

        /// <summary>
        /// Terminal serial
        /// </summary>
        /// <value>Terminal serial</value>
        [DataMember(Name="TerminalSerialNumber", EmitDefaultValue=false)]
        public string TerminalSerialNumber { get; set; }

        /// <summary>
        /// External identifier for the transaction
        /// </summary>
        /// <value>External identifier for the transaction</value>
        [DataMember(Name="ExternalIdentifier", EmitDefaultValue=false)]
        public string ExternalIdentifier { get; set; }

        /// <summary>
        /// External identifier for the transaction&#x27;s batch
        /// </summary>
        /// <value>External identifier for the transaction&#x27;s batch</value>
        [DataMember(Name="ExternalBatchIdentifier", EmitDefaultValue=false)]
        public string ExternalBatchIdentifier { get; set; }

        /// <summary>
        /// Optional external group identifier
        /// </summary>
        /// <value>Optional external group identifier</value>
        [DataMember(Name="ExternalGroupIdentifier", EmitDefaultValue=false)]
        public string ExternalGroupIdentifier { get; set; }

        /// <summary>
        /// Order identifier
        /// </summary>
        /// <value>Order identifier</value>
        [DataMember(Name="OrderIdentifier", EmitDefaultValue=false)]
        public string OrderIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name="BillingAddress", EmitDefaultValue=false)]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Gets or Sets ShippingAddress
        /// </summary>
        [DataMember(Name="ShippingAddress", EmitDefaultValue=false)]
        public Address ShippingAddress { get; set; }

        /// <summary>
        /// Indicates whether ShippingAddress is the same as BillingAddress
        /// </summary>
        /// <value>Indicates whether ShippingAddress is the same as BillingAddress</value>
        [DataMember(Name="AddressMatch", EmitDefaultValue=false)]
        public bool? AddressMatch { get; set; }

        /// <summary>
        /// Gets or Sets ExtendedData
        /// </summary>
        [DataMember(Name="ExtendedData", EmitDefaultValue=false)]
        public ExtendedRequestData ExtendedData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SaleRequest {\n");
            sb.Append("  TransactionIdentifier: ").Append(TransactionIdentifier).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  TipAmount: ").Append(TipAmount).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  OtherAmount: ").Append(OtherAmount).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  LocalTime: ").Append(LocalTime).Append("\n");
            sb.Append("  LocalDate: ").Append(LocalDate).Append("\n");
            sb.Append("  AddressVerification: ").Append(AddressVerification).Append("\n");
            sb.Append("  ThreeDSecure: ").Append(ThreeDSecure).Append("\n");
            sb.Append("  BinCheck: ").Append(BinCheck).Append("\n");
            sb.Append("  FraudCheck: ").Append(FraudCheck).Append("\n");
            sb.Append("  RecurringInitial: ").Append(RecurringInitial).Append("\n");
            sb.Append("  Recurring: ").Append(Recurring).Append("\n");
            sb.Append("  CardOnFile: ").Append(CardOnFile).Append("\n");
            sb.Append("  AccountVerification: ").Append(AccountVerification).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  TerminalId: ").Append(TerminalId).Append("\n");
            sb.Append("  TerminalCode: ").Append(TerminalCode).Append("\n");
            sb.Append("  TerminalSerialNumber: ").Append(TerminalSerialNumber).Append("\n");
            sb.Append("  ExternalIdentifier: ").Append(ExternalIdentifier).Append("\n");
            sb.Append("  ExternalBatchIdentifier: ").Append(ExternalBatchIdentifier).Append("\n");
            sb.Append("  ExternalGroupIdentifier: ").Append(ExternalGroupIdentifier).Append("\n");
            sb.Append("  OrderIdentifier: ").Append(OrderIdentifier).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
            sb.Append("  AddressMatch: ").Append(AddressMatch).Append("\n");
            sb.Append("  ExtendedData: ").Append(ExtendedData).Append("\n");
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
            return this.Equals(input as SaleRequest);
        }

        /// <summary>
        /// Returns true if SaleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SaleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SaleRequest input)
        {
            if (input == null)
                return false;

            return 
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
                    this.TipAmount == input.TipAmount ||
                    (this.TipAmount != null &&
                    this.TipAmount.Equals(input.TipAmount))
                ) && 
                (
                    this.TaxAmount == input.TaxAmount ||
                    (this.TaxAmount != null &&
                    this.TaxAmount.Equals(input.TaxAmount))
                ) && 
                (
                    this.OtherAmount == input.OtherAmount ||
                    (this.OtherAmount != null &&
                    this.OtherAmount.Equals(input.OtherAmount))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.LocalTime == input.LocalTime ||
                    (this.LocalTime != null &&
                    this.LocalTime.Equals(input.LocalTime))
                ) && 
                (
                    this.LocalDate == input.LocalDate ||
                    (this.LocalDate != null &&
                    this.LocalDate.Equals(input.LocalDate))
                ) && 
                (
                    this.AddressVerification == input.AddressVerification ||
                    (this.AddressVerification != null &&
                    this.AddressVerification.Equals(input.AddressVerification))
                ) && 
                (
                    this.ThreeDSecure == input.ThreeDSecure ||
                    (this.ThreeDSecure != null &&
                    this.ThreeDSecure.Equals(input.ThreeDSecure))
                ) && 
                (
                    this.BinCheck == input.BinCheck ||
                    (this.BinCheck != null &&
                    this.BinCheck.Equals(input.BinCheck))
                ) && 
                (
                    this.FraudCheck == input.FraudCheck ||
                    (this.FraudCheck != null &&
                    this.FraudCheck.Equals(input.FraudCheck))
                ) && 
                (
                    this.RecurringInitial == input.RecurringInitial ||
                    (this.RecurringInitial != null &&
                    this.RecurringInitial.Equals(input.RecurringInitial))
                ) && 
                (
                    this.Recurring == input.Recurring ||
                    (this.Recurring != null &&
                    this.Recurring.Equals(input.Recurring))
                ) && 
                (
                    this.CardOnFile == input.CardOnFile ||
                    (this.CardOnFile != null &&
                    this.CardOnFile.Equals(input.CardOnFile))
                ) && 
                (
                    this.AccountVerification == input.AccountVerification ||
                    (this.AccountVerification != null &&
                    this.AccountVerification.Equals(input.AccountVerification))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.TerminalId == input.TerminalId ||
                    (this.TerminalId != null &&
                    this.TerminalId.Equals(input.TerminalId))
                ) && 
                (
                    this.TerminalCode == input.TerminalCode ||
                    (this.TerminalCode != null &&
                    this.TerminalCode.Equals(input.TerminalCode))
                ) && 
                (
                    this.TerminalSerialNumber == input.TerminalSerialNumber ||
                    (this.TerminalSerialNumber != null &&
                    this.TerminalSerialNumber.Equals(input.TerminalSerialNumber))
                ) && 
                (
                    this.ExternalIdentifier == input.ExternalIdentifier ||
                    (this.ExternalIdentifier != null &&
                    this.ExternalIdentifier.Equals(input.ExternalIdentifier))
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
                    this.OrderIdentifier == input.OrderIdentifier ||
                    (this.OrderIdentifier != null &&
                    this.OrderIdentifier.Equals(input.OrderIdentifier))
                ) && 
                (
                    this.BillingAddress == input.BillingAddress ||
                    (this.BillingAddress != null &&
                    this.BillingAddress.Equals(input.BillingAddress))
                ) && 
                (
                    this.ShippingAddress == input.ShippingAddress ||
                    (this.ShippingAddress != null &&
                    this.ShippingAddress.Equals(input.ShippingAddress))
                ) && 
                (
                    this.AddressMatch == input.AddressMatch ||
                    (this.AddressMatch != null &&
                    this.AddressMatch.Equals(input.AddressMatch))
                ) && 
                (
                    this.ExtendedData == input.ExtendedData ||
                    (this.ExtendedData != null &&
                    this.ExtendedData.Equals(input.ExtendedData))
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
                if (this.TransactionIdentifier != null)
                    hashCode = hashCode * 59 + this.TransactionIdentifier.GetHashCode();
                if (this.TotalAmount != null)
                    hashCode = hashCode * 59 + this.TotalAmount.GetHashCode();
                if (this.TipAmount != null)
                    hashCode = hashCode * 59 + this.TipAmount.GetHashCode();
                if (this.TaxAmount != null)
                    hashCode = hashCode * 59 + this.TaxAmount.GetHashCode();
                if (this.OtherAmount != null)
                    hashCode = hashCode * 59 + this.OtherAmount.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.LocalTime != null)
                    hashCode = hashCode * 59 + this.LocalTime.GetHashCode();
                if (this.LocalDate != null)
                    hashCode = hashCode * 59 + this.LocalDate.GetHashCode();
                if (this.AddressVerification != null)
                    hashCode = hashCode * 59 + this.AddressVerification.GetHashCode();
                if (this.ThreeDSecure != null)
                    hashCode = hashCode * 59 + this.ThreeDSecure.GetHashCode();
                if (this.BinCheck != null)
                    hashCode = hashCode * 59 + this.BinCheck.GetHashCode();
                if (this.FraudCheck != null)
                    hashCode = hashCode * 59 + this.FraudCheck.GetHashCode();
                if (this.RecurringInitial != null)
                    hashCode = hashCode * 59 + this.RecurringInitial.GetHashCode();
                if (this.Recurring != null)
                    hashCode = hashCode * 59 + this.Recurring.GetHashCode();
                if (this.CardOnFile != null)
                    hashCode = hashCode * 59 + this.CardOnFile.GetHashCode();
                if (this.AccountVerification != null)
                    hashCode = hashCode * 59 + this.AccountVerification.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.TerminalId != null)
                    hashCode = hashCode * 59 + this.TerminalId.GetHashCode();
                if (this.TerminalCode != null)
                    hashCode = hashCode * 59 + this.TerminalCode.GetHashCode();
                if (this.TerminalSerialNumber != null)
                    hashCode = hashCode * 59 + this.TerminalSerialNumber.GetHashCode();
                if (this.ExternalIdentifier != null)
                    hashCode = hashCode * 59 + this.ExternalIdentifier.GetHashCode();
                if (this.ExternalBatchIdentifier != null)
                    hashCode = hashCode * 59 + this.ExternalBatchIdentifier.GetHashCode();
                if (this.ExternalGroupIdentifier != null)
                    hashCode = hashCode * 59 + this.ExternalGroupIdentifier.GetHashCode();
                if (this.OrderIdentifier != null)
                    hashCode = hashCode * 59 + this.OrderIdentifier.GetHashCode();
                if (this.BillingAddress != null)
                    hashCode = hashCode * 59 + this.BillingAddress.GetHashCode();
                if (this.ShippingAddress != null)
                    hashCode = hashCode * 59 + this.ShippingAddress.GetHashCode();
                if (this.AddressMatch != null)
                    hashCode = hashCode * 59 + this.AddressMatch.GetHashCode();
                if (this.ExtendedData != null)
                    hashCode = hashCode * 59 + this.ExtendedData.GetHashCode();
                return hashCode;
            }
        }
    }
}
