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
    /// Capture request
    /// </summary>
    [DataContract]
        public partial class CaptureRequest :  IEquatable<CaptureRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CaptureRequest" /> class.
        /// </summary>
        /// <param name="transactionIdentifier">Transaction identifier (required).</param>
        /// <param name="totalAmount">Total amount to authorize (required).</param>
        /// <param name="tipAmount">Tip amount.</param>
        /// <param name="taxAmount">Tax amount.</param>
        /// <param name="otherAmount">CashBackAmount or other amount.</param>
        /// <param name="externalIdentifier">External identifier for the transaction.</param>
        /// <param name="externalGroupIdentifier">Optional external group identifier.</param>
        public CaptureRequest(string transactionIdentifier = default(string), double? totalAmount = default(double?), double? tipAmount = default(double?), double? taxAmount = default(double?), double? otherAmount = default(double?), string externalIdentifier = default(string), string externalGroupIdentifier = default(string))
        {
            // to ensure "transactionIdentifier" is required (not null)
            if (transactionIdentifier == null)
            {
                throw new InvalidDataException("transactionIdentifier is a required property for CaptureRequest and cannot be null");
            }
            else
            {
                this.TransactionIdentifier = transactionIdentifier;
            }
            // to ensure "totalAmount" is required (not null)
            if (totalAmount == null)
            {
                throw new InvalidDataException("totalAmount is a required property for CaptureRequest and cannot be null");
            }
            else
            {
                this.TotalAmount = totalAmount;
            }
            this.TipAmount = tipAmount;
            this.TaxAmount = taxAmount;
            this.OtherAmount = otherAmount;
            this.ExternalIdentifier = externalIdentifier;
            this.ExternalGroupIdentifier = externalGroupIdentifier;
        }
        
        /// <summary>
        /// Transaction identifier
        /// </summary>
        /// <value>Transaction identifier</value>
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
        /// External identifier for the transaction
        /// </summary>
        /// <value>External identifier for the transaction</value>
        [DataMember(Name="ExternalIdentifier", EmitDefaultValue=false)]
        public string ExternalIdentifier { get; set; }

        /// <summary>
        /// Optional external group identifier
        /// </summary>
        /// <value>Optional external group identifier</value>
        [DataMember(Name="ExternalGroupIdentifier", EmitDefaultValue=false)]
        public string ExternalGroupIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CaptureRequest {\n");
            sb.Append("  TransactionIdentifier: ").Append(TransactionIdentifier).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  TipAmount: ").Append(TipAmount).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  OtherAmount: ").Append(OtherAmount).Append("\n");
            sb.Append("  ExternalIdentifier: ").Append(ExternalIdentifier).Append("\n");
            sb.Append("  ExternalGroupIdentifier: ").Append(ExternalGroupIdentifier).Append("\n");
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
            return this.Equals(input as CaptureRequest);
        }

        /// <summary>
        /// Returns true if CaptureRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CaptureRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CaptureRequest input)
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
                    this.ExternalIdentifier == input.ExternalIdentifier ||
                    (this.ExternalIdentifier != null &&
                    this.ExternalIdentifier.Equals(input.ExternalIdentifier))
                ) && 
                (
                    this.ExternalGroupIdentifier == input.ExternalGroupIdentifier ||
                    (this.ExternalGroupIdentifier != null &&
                    this.ExternalGroupIdentifier.Equals(input.ExternalGroupIdentifier))
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
                if (this.ExternalIdentifier != null)
                    hashCode = hashCode * 59 + this.ExternalIdentifier.GetHashCode();
                if (this.ExternalGroupIdentifier != null)
                    hashCode = hashCode * 59 + this.ExternalGroupIdentifier.GetHashCode();
                return hashCode;
            }
        }
    }
}
