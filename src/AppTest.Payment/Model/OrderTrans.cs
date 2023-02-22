using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AppTest.Payment.Model
{
    /// <summary>
    /// OrderTrans
    /// </summary>
    [DataContract]
        public partial class OrderTrans :  IEquatable<OrderTrans>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderTrans" /> class.
        /// </summary>
        /// <param name="captureCount">captureCount.</param>
        /// <param name="creditCount">creditCount.</param>
        /// <param name="currencyCode">currencyCode.</param>
        /// <param name="lastCaptureDateTime">lastCaptureDateTime.</param>
        /// <param name="lastCreditDateTime">lastCreditDateTime.</param>
        /// <param name="orderIdentifier">orderIdentifier.</param>
        /// <param name="originalTrxnDateTime">originalTrxnDateTime.</param>
        /// <param name="originalTrxnIdentifier">originalTrxnIdentifier.</param>
        /// <param name="settledAmount">settledAmount.</param>
        /// <param name="totalCaptureAmount">totalCaptureAmount.</param>
        /// <param name="totalCreditAmount">totalCreditAmount.</param>
        /// <param name="transactions">transactions.</param>
        /// <param name="voidDateTime">voidDateTime.</param>
        public OrderTrans(int? captureCount = default(int?), int? creditCount = default(int?), string currencyCode = default(string), DateTime? lastCaptureDateTime = default(DateTime?), DateTime? lastCreditDateTime = default(DateTime?), string orderIdentifier = default(string), DateTime? originalTrxnDateTime = default(DateTime?), Guid? originalTrxnIdentifier = default(Guid?), double? settledAmount = default(double?), double? totalCaptureAmount = default(double?), double? totalCreditAmount = default(double?), List<Transaction> transactions = default(List<Transaction>), DateTime? voidDateTime = default(DateTime?))
        {
            this.CaptureCount = captureCount;
            this.CreditCount = creditCount;
            this.CurrencyCode = currencyCode;
            this.LastCaptureDateTime = lastCaptureDateTime;
            this.LastCreditDateTime = lastCreditDateTime;
            this.OrderIdentifier = orderIdentifier;
            this.OriginalTrxnDateTime = originalTrxnDateTime;
            this.OriginalTrxnIdentifier = originalTrxnIdentifier;
            this.SettledAmount = settledAmount;
            this.TotalCaptureAmount = totalCaptureAmount;
            this.TotalCreditAmount = totalCreditAmount;
            this.Transactions = transactions;
            this.VoidDateTime = voidDateTime;
        }
        
        /// <summary>
        /// Gets or Sets CaptureCount
        /// </summary>
        [DataMember(Name="CaptureCount", EmitDefaultValue=false)]
        public int? CaptureCount { get; set; }

        /// <summary>
        /// Gets or Sets CreditCount
        /// </summary>
        [DataMember(Name="CreditCount", EmitDefaultValue=false)]
        public int? CreditCount { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name="CurrencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets LastCaptureDateTime
        /// </summary>
        [DataMember(Name="LastCaptureDateTime", EmitDefaultValue=false)]
        public DateTime? LastCaptureDateTime { get; set; }

        /// <summary>
        /// Gets or Sets LastCreditDateTime
        /// </summary>
        [DataMember(Name="LastCreditDateTime", EmitDefaultValue=false)]
        public DateTime? LastCreditDateTime { get; set; }

        /// <summary>
        /// Gets or Sets OrderIdentifier
        /// </summary>
        [DataMember(Name="OrderIdentifier", EmitDefaultValue=false)]
        public string OrderIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets OriginalTrxnDateTime
        /// </summary>
        [DataMember(Name="OriginalTrxnDateTime", EmitDefaultValue=false)]
        public DateTime? OriginalTrxnDateTime { get; set; }

        /// <summary>
        /// Gets or Sets OriginalTrxnIdentifier
        /// </summary>
        [DataMember(Name="OriginalTrxnIdentifier", EmitDefaultValue=false)]
        public Guid? OriginalTrxnIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets SettledAmount
        /// </summary>
        [DataMember(Name="SettledAmount", EmitDefaultValue=false)]
        public double? SettledAmount { get; set; }

        /// <summary>
        /// Gets or Sets TotalCaptureAmount
        /// </summary>
        [DataMember(Name="TotalCaptureAmount", EmitDefaultValue=false)]
        public double? TotalCaptureAmount { get; set; }

        /// <summary>
        /// Gets or Sets TotalCreditAmount
        /// </summary>
        [DataMember(Name="TotalCreditAmount", EmitDefaultValue=false)]
        public double? TotalCreditAmount { get; set; }

        /// <summary>
        /// Gets or Sets Transactions
        /// </summary>
        [DataMember(Name="Transactions", EmitDefaultValue=false)]
        public List<Transaction> Transactions { get; set; }

        /// <summary>
        /// Gets or Sets VoidDateTime
        /// </summary>
        [DataMember(Name="VoidDateTime", EmitDefaultValue=false)]
        public DateTime? VoidDateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderTrans {\n");
            sb.Append("  CaptureCount: ").Append(CaptureCount).Append("\n");
            sb.Append("  CreditCount: ").Append(CreditCount).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  LastCaptureDateTime: ").Append(LastCaptureDateTime).Append("\n");
            sb.Append("  LastCreditDateTime: ").Append(LastCreditDateTime).Append("\n");
            sb.Append("  OrderIdentifier: ").Append(OrderIdentifier).Append("\n");
            sb.Append("  OriginalTrxnDateTime: ").Append(OriginalTrxnDateTime).Append("\n");
            sb.Append("  OriginalTrxnIdentifier: ").Append(OriginalTrxnIdentifier).Append("\n");
            sb.Append("  SettledAmount: ").Append(SettledAmount).Append("\n");
            sb.Append("  TotalCaptureAmount: ").Append(TotalCaptureAmount).Append("\n");
            sb.Append("  TotalCreditAmount: ").Append(TotalCreditAmount).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
            sb.Append("  VoidDateTime: ").Append(VoidDateTime).Append("\n");
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
            return this.Equals(input as OrderTrans);
        }

        /// <summary>
        /// Returns true if OrderTrans instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderTrans to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderTrans input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CaptureCount == input.CaptureCount ||
                    (this.CaptureCount != null &&
                    this.CaptureCount.Equals(input.CaptureCount))
                ) && 
                (
                    this.CreditCount == input.CreditCount ||
                    (this.CreditCount != null &&
                    this.CreditCount.Equals(input.CreditCount))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.LastCaptureDateTime == input.LastCaptureDateTime ||
                    (this.LastCaptureDateTime != null &&
                    this.LastCaptureDateTime.Equals(input.LastCaptureDateTime))
                ) && 
                (
                    this.LastCreditDateTime == input.LastCreditDateTime ||
                    (this.LastCreditDateTime != null &&
                    this.LastCreditDateTime.Equals(input.LastCreditDateTime))
                ) && 
                (
                    this.OrderIdentifier == input.OrderIdentifier ||
                    (this.OrderIdentifier != null &&
                    this.OrderIdentifier.Equals(input.OrderIdentifier))
                ) && 
                (
                    this.OriginalTrxnDateTime == input.OriginalTrxnDateTime ||
                    (this.OriginalTrxnDateTime != null &&
                    this.OriginalTrxnDateTime.Equals(input.OriginalTrxnDateTime))
                ) && 
                (
                    this.OriginalTrxnIdentifier == input.OriginalTrxnIdentifier ||
                    (this.OriginalTrxnIdentifier != null &&
                    this.OriginalTrxnIdentifier.Equals(input.OriginalTrxnIdentifier))
                ) && 
                (
                    this.SettledAmount == input.SettledAmount ||
                    (this.SettledAmount != null &&
                    this.SettledAmount.Equals(input.SettledAmount))
                ) && 
                (
                    this.TotalCaptureAmount == input.TotalCaptureAmount ||
                    (this.TotalCaptureAmount != null &&
                    this.TotalCaptureAmount.Equals(input.TotalCaptureAmount))
                ) && 
                (
                    this.TotalCreditAmount == input.TotalCreditAmount ||
                    (this.TotalCreditAmount != null &&
                    this.TotalCreditAmount.Equals(input.TotalCreditAmount))
                ) && 
                (
                    this.Transactions == input.Transactions ||
                    this.Transactions != null &&
                    input.Transactions != null &&
                    this.Transactions.SequenceEqual(input.Transactions)
                ) && 
                (
                    this.VoidDateTime == input.VoidDateTime ||
                    (this.VoidDateTime != null &&
                    this.VoidDateTime.Equals(input.VoidDateTime))
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
                if (this.CaptureCount != null)
                    hashCode = hashCode * 59 + this.CaptureCount.GetHashCode();
                if (this.CreditCount != null)
                    hashCode = hashCode * 59 + this.CreditCount.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.LastCaptureDateTime != null)
                    hashCode = hashCode * 59 + this.LastCaptureDateTime.GetHashCode();
                if (this.LastCreditDateTime != null)
                    hashCode = hashCode * 59 + this.LastCreditDateTime.GetHashCode();
                if (this.OrderIdentifier != null)
                    hashCode = hashCode * 59 + this.OrderIdentifier.GetHashCode();
                if (this.OriginalTrxnDateTime != null)
                    hashCode = hashCode * 59 + this.OriginalTrxnDateTime.GetHashCode();
                if (this.OriginalTrxnIdentifier != null)
                    hashCode = hashCode * 59 + this.OriginalTrxnIdentifier.GetHashCode();
                if (this.SettledAmount != null)
                    hashCode = hashCode * 59 + this.SettledAmount.GetHashCode();
                if (this.TotalCaptureAmount != null)
                    hashCode = hashCode * 59 + this.TotalCaptureAmount.GetHashCode();
                if (this.TotalCreditAmount != null)
                    hashCode = hashCode * 59 + this.TotalCreditAmount.GetHashCode();
                if (this.Transactions != null)
                    hashCode = hashCode * 59 + this.Transactions.GetHashCode();
                if (this.VoidDateTime != null)
                    hashCode = hashCode * 59 + this.VoidDateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
