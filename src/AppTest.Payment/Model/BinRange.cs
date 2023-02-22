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
    /// Cardtype Bin Ranges
    /// </summary>
    [DataContract]
        public partial class BinRange :  IEquatable<BinRange>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BinRange" /> class.
        /// </summary>
        /// <param name="cardTypeId">CardType Id.</param>
        /// <param name="cardBrand">Card brand (Visa, Mastercard,etc.).</param>
        /// <param name="rangeStart">Bin range start value.</param>
        /// <param name="rangeEnd">Bin range end value.</param>
        /// <param name="localDebit">Indicates whether the card is Local Debit.</param>
        public BinRange(int? cardTypeId = default(int?), string cardBrand = default(string), string rangeStart = default(string), string rangeEnd = default(string), bool? localDebit = default(bool?))
        {
            this.CardTypeId = cardTypeId;
            this.CardBrand = cardBrand;
            this.RangeStart = rangeStart;
            this.RangeEnd = rangeEnd;
            this.LocalDebit = localDebit;
        }
        
        /// <summary>
        /// CardType Id
        /// </summary>
        /// <value>CardType Id</value>
        [DataMember(Name="CardTypeId", EmitDefaultValue=false)]
        public int? CardTypeId { get; set; }

        /// <summary>
        /// Card brand (Visa, Mastercard,etc.)
        /// </summary>
        /// <value>Card brand (Visa, Mastercard,etc.)</value>
        [DataMember(Name="CardBrand", EmitDefaultValue=false)]
        public string CardBrand { get; set; }

        /// <summary>
        /// Bin range start value
        /// </summary>
        /// <value>Bin range start value</value>
        [DataMember(Name="RangeStart", EmitDefaultValue=false)]
        public string RangeStart { get; set; }

        /// <summary>
        /// Bin range end value
        /// </summary>
        /// <value>Bin range end value</value>
        [DataMember(Name="RangeEnd", EmitDefaultValue=false)]
        public string RangeEnd { get; set; }

        /// <summary>
        /// Indicates whether the card is Local Debit
        /// </summary>
        /// <value>Indicates whether the card is Local Debit</value>
        [DataMember(Name="LocalDebit", EmitDefaultValue=false)]
        public bool? LocalDebit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BinRange {\n");
            sb.Append("  CardTypeId: ").Append(CardTypeId).Append("\n");
            sb.Append("  CardBrand: ").Append(CardBrand).Append("\n");
            sb.Append("  RangeStart: ").Append(RangeStart).Append("\n");
            sb.Append("  RangeEnd: ").Append(RangeEnd).Append("\n");
            sb.Append("  LocalDebit: ").Append(LocalDebit).Append("\n");
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
            return this.Equals(input as BinRange);
        }

        /// <summary>
        /// Returns true if BinRange instances are equal
        /// </summary>
        /// <param name="input">Instance of BinRange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BinRange input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CardTypeId == input.CardTypeId ||
                    (this.CardTypeId != null &&
                    this.CardTypeId.Equals(input.CardTypeId))
                ) && 
                (
                    this.CardBrand == input.CardBrand ||
                    (this.CardBrand != null &&
                    this.CardBrand.Equals(input.CardBrand))
                ) && 
                (
                    this.RangeStart == input.RangeStart ||
                    (this.RangeStart != null &&
                    this.RangeStart.Equals(input.RangeStart))
                ) && 
                (
                    this.RangeEnd == input.RangeEnd ||
                    (this.RangeEnd != null &&
                    this.RangeEnd.Equals(input.RangeEnd))
                ) && 
                (
                    this.LocalDebit == input.LocalDebit ||
                    (this.LocalDebit != null &&
                    this.LocalDebit.Equals(input.LocalDebit))
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
                if (this.CardTypeId != null)
                    hashCode = hashCode * 59 + this.CardTypeId.GetHashCode();
                if (this.CardBrand != null)
                    hashCode = hashCode * 59 + this.CardBrand.GetHashCode();
                if (this.RangeStart != null)
                    hashCode = hashCode * 59 + this.RangeStart.GetHashCode();
                if (this.RangeEnd != null)
                    hashCode = hashCode * 59 + this.RangeEnd.GetHashCode();
                if (this.LocalDebit != null)
                    hashCode = hashCode * 59 + this.LocalDebit.GetHashCode();
                return hashCode;
            }
        }
    }
}
