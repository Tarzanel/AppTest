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
    /// Credit or Debit Source Card Data
    /// </summary>
    [DataContract]
        public partial class Source :  IEquatable<Source>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Source" /> class.
        /// </summary>
        /// <param name="cardPresent">Whether or not the source card was present.  If this is true, the card is present. (required).</param>
        /// <param name="cardEmvFallback">Whether or not the card data present is for an EMV fallback (required).</param>
        /// <param name="manualEntry">ManualEntry payment mode (required).</param>
        /// <param name="debit">Set to true if this is Debit.  False indicates Credit. (required).</param>
        /// <param name="accountType">CP: \&quot;01\&quot; &#x3D; Checking, \&quot;02\&quot; &#x3D; Savings  ECOM: \&quot;01\&quot; &#x3D; Not Applicable, \&quot;02\&quot; &#x3D; Credit \&quot;03\&quot; &#x3D; Debit.</param>
        /// <param name="contactless">Whether or not the source was delivered via contactless (e.g. NFC) technology (required).</param>
        /// <param name="cardPan">Card primary account number.</param>
        /// <param name="maskedPan">Card masked primary account number. Required for routing. (required).</param>
        /// <param name="cardCvv">Card verification code.</param>
        /// <param name="cardExpiration">Card expiration date YYMMDD.</param>
        /// <param name="token">Token.</param>
        /// <param name="tokenType">Token type.</param>
        /// <param name="cardTrack1Data">Card track 1 data.</param>
        /// <param name="cardTrack2Data">Card track 2 data.</param>
        /// <param name="cardTrack3Data">Card track 3 data.</param>
        /// <param name="cardTrackData">Card track data (ambiguous as to track separation).</param>
        /// <param name="encryptedCardTrack1Data">Encrypted card track 1 data.</param>
        /// <param name="encryptedCardTrack2Data">Encrypted card track 2 data.</param>
        /// <param name="encryptedCardTrack3Data">Encrypted card track 3 data.</param>
        /// <param name="encryptedCardTrackData">Encrypted card track data (ambiguous as to track separation).</param>
        /// <param name="ksn">KSN.</param>
        /// <param name="encryptedPinBlock">Encrypted PIN block.</param>
        /// <param name="pinBlockKsn">PIN block KSN.</param>
        /// <param name="cardEmvData">Card EMV TLV data.</param>
        /// <param name="cardholderName">Cardholder name.</param>
        public Source(bool? cardPresent = default(bool?), bool? cardEmvFallback = default(bool?), bool? manualEntry = default(bool?), bool? debit = default(bool?), string accountType = default(string), bool? contactless = default(bool?), string cardPan = default(string), string maskedPan = default(string), string cardCvv = default(string), string cardExpiration = default(string), string token = default(string), string tokenType = default(string), string cardTrack1Data = default(string), string cardTrack2Data = default(string), string cardTrack3Data = default(string), string cardTrackData = default(string), string encryptedCardTrack1Data = default(string), string encryptedCardTrack2Data = default(string), string encryptedCardTrack3Data = default(string), string encryptedCardTrackData = default(string), string ksn = default(string), string encryptedPinBlock = default(string), string pinBlockKsn = default(string), string cardEmvData = default(string), string cardholderName = default(string))
        {
            // to ensure "cardPresent" is required (not null)
            if (cardPresent == null)
            {
                throw new InvalidDataException("cardPresent is a required property for Source and cannot be null");
            }
            else
            {
                this.CardPresent = cardPresent;
            }
            // to ensure "cardEmvFallback" is required (not null)
            if (cardEmvFallback == null)
            {
                throw new InvalidDataException("cardEmvFallback is a required property for Source and cannot be null");
            }
            else
            {
                this.CardEmvFallback = cardEmvFallback;
            }
            // to ensure "manualEntry" is required (not null)
            if (manualEntry == null)
            {
                throw new InvalidDataException("manualEntry is a required property for Source and cannot be null");
            }
            else
            {
                this.ManualEntry = manualEntry;
            }
            // to ensure "debit" is required (not null)
            if (debit == null)
            {
                throw new InvalidDataException("debit is a required property for Source and cannot be null");
            }
            else
            {
                this.Debit = debit;
            }
            // to ensure "contactless" is required (not null)
            if (contactless == null)
            {
                throw new InvalidDataException("contactless is a required property for Source and cannot be null");
            }
            else
            {
                this.Contactless = contactless;
            }
            // to ensure "maskedPan" is required (not null)
            if (maskedPan == null)
            {
                throw new InvalidDataException("maskedPan is a required property for Source and cannot be null");
            }
            else
            {
                this.MaskedPan = maskedPan;
            }
            this.AccountType = accountType;
            this.CardPan = cardPan;
            this.CardCvv = cardCvv;
            this.CardExpiration = cardExpiration;
            this.Token = token;
            this.TokenType = tokenType;
            this.CardTrack1Data = cardTrack1Data;
            this.CardTrack2Data = cardTrack2Data;
            this.CardTrack3Data = cardTrack3Data;
            this.CardTrackData = cardTrackData;
            this.EncryptedCardTrack1Data = encryptedCardTrack1Data;
            this.EncryptedCardTrack2Data = encryptedCardTrack2Data;
            this.EncryptedCardTrack3Data = encryptedCardTrack3Data;
            this.EncryptedCardTrackData = encryptedCardTrackData;
            this.Ksn = ksn;
            this.EncryptedPinBlock = encryptedPinBlock;
            this.PinBlockKsn = pinBlockKsn;
            this.CardEmvData = cardEmvData;
            this.CardholderName = cardholderName;
        }
        
        /// <summary>
        /// Whether or not the source card was present.  If this is true, the card is present.
        /// </summary>
        /// <value>Whether or not the source card was present.  If this is true, the card is present.</value>
        [DataMember(Name="CardPresent", EmitDefaultValue=false)]
        public bool? CardPresent { get; set; }

        /// <summary>
        /// Whether or not the card data present is for an EMV fallback
        /// </summary>
        /// <value>Whether or not the card data present is for an EMV fallback</value>
        [DataMember(Name="CardEmvFallback", EmitDefaultValue=false)]
        public bool? CardEmvFallback { get; set; }

        /// <summary>
        /// ManualEntry payment mode
        /// </summary>
        /// <value>ManualEntry payment mode</value>
        [DataMember(Name="ManualEntry", EmitDefaultValue=false)]
        public bool? ManualEntry { get; set; }

        /// <summary>
        /// Set to true if this is Debit.  False indicates Credit.
        /// </summary>
        /// <value>Set to true if this is Debit.  False indicates Credit.</value>
        [DataMember(Name="Debit", EmitDefaultValue=false)]
        public bool? Debit { get; set; }

        /// <summary>
        /// CP: \&quot;01\&quot; &#x3D; Checking, \&quot;02\&quot; &#x3D; Savings  ECOM: \&quot;01\&quot; &#x3D; Not Applicable, \&quot;02\&quot; &#x3D; Credit \&quot;03\&quot; &#x3D; Debit
        /// </summary>
        /// <value>CP: \&quot;01\&quot; &#x3D; Checking, \&quot;02\&quot; &#x3D; Savings  ECOM: \&quot;01\&quot; &#x3D; Not Applicable, \&quot;02\&quot; &#x3D; Credit \&quot;03\&quot; &#x3D; Debit</value>
        [DataMember(Name="AccountType", EmitDefaultValue=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// Whether or not the source was delivered via contactless (e.g. NFC) technology
        /// </summary>
        /// <value>Whether or not the source was delivered via contactless (e.g. NFC) technology</value>
        [DataMember(Name="Contactless", EmitDefaultValue=false)]
        public bool? Contactless { get; set; }

        /// <summary>
        /// Card primary account number
        /// </summary>
        /// <value>Card primary account number</value>
        [DataMember(Name="CardPan", EmitDefaultValue=false)]
        public string CardPan { get; set; }

        /// <summary>
        /// Card masked primary account number. Required for routing.
        /// </summary>
        /// <value>Card masked primary account number. Required for routing.</value>
        [DataMember(Name="MaskedPan", EmitDefaultValue=false)]
        public string MaskedPan { get; set; }

        /// <summary>
        /// Card verification code
        /// </summary>
        /// <value>Card verification code</value>
        [DataMember(Name="CardCvv", EmitDefaultValue=false)]
        public string CardCvv { get; set; }

        /// <summary>
        /// Card expiration date YYMMDD
        /// </summary>
        /// <value>Card expiration date YYMMDD</value>
        [DataMember(Name="CardExpiration", EmitDefaultValue=false)]
        public string CardExpiration { get; set; }

        /// <summary>
        /// Token
        /// </summary>
        /// <value>Token</value>
        [DataMember(Name="Token", EmitDefaultValue=false)]
        public string Token { get; set; }

        /// <summary>
        /// Token type
        /// </summary>
        /// <value>Token type</value>
        [DataMember(Name="TokenType", EmitDefaultValue=false)]
        public string TokenType { get; set; }

        /// <summary>
        /// Card track 1 data
        /// </summary>
        /// <value>Card track 1 data</value>
        [DataMember(Name="CardTrack1Data", EmitDefaultValue=false)]
        public string CardTrack1Data { get; set; }

        /// <summary>
        /// Card track 2 data
        /// </summary>
        /// <value>Card track 2 data</value>
        [DataMember(Name="CardTrack2Data", EmitDefaultValue=false)]
        public string CardTrack2Data { get; set; }

        /// <summary>
        /// Card track 3 data
        /// </summary>
        /// <value>Card track 3 data</value>
        [DataMember(Name="CardTrack3Data", EmitDefaultValue=false)]
        public string CardTrack3Data { get; set; }

        /// <summary>
        /// Card track data (ambiguous as to track separation)
        /// </summary>
        /// <value>Card track data (ambiguous as to track separation)</value>
        [DataMember(Name="CardTrackData", EmitDefaultValue=false)]
        public string CardTrackData { get; set; }

        /// <summary>
        /// Encrypted card track 1 data
        /// </summary>
        /// <value>Encrypted card track 1 data</value>
        [DataMember(Name="EncryptedCardTrack1Data", EmitDefaultValue=false)]
        public string EncryptedCardTrack1Data { get; set; }

        /// <summary>
        /// Encrypted card track 2 data
        /// </summary>
        /// <value>Encrypted card track 2 data</value>
        [DataMember(Name="EncryptedCardTrack2Data", EmitDefaultValue=false)]
        public string EncryptedCardTrack2Data { get; set; }

        /// <summary>
        /// Encrypted card track 3 data
        /// </summary>
        /// <value>Encrypted card track 3 data</value>
        [DataMember(Name="EncryptedCardTrack3Data", EmitDefaultValue=false)]
        public string EncryptedCardTrack3Data { get; set; }

        /// <summary>
        /// Encrypted card track data (ambiguous as to track separation)
        /// </summary>
        /// <value>Encrypted card track data (ambiguous as to track separation)</value>
        [DataMember(Name="EncryptedCardTrackData", EmitDefaultValue=false)]
        public string EncryptedCardTrackData { get; set; }

        /// <summary>
        /// KSN
        /// </summary>
        /// <value>KSN</value>
        [DataMember(Name="Ksn", EmitDefaultValue=false)]
        public string Ksn { get; set; }

        /// <summary>
        /// Encrypted PIN block
        /// </summary>
        /// <value>Encrypted PIN block</value>
        [DataMember(Name="EncryptedPinBlock", EmitDefaultValue=false)]
        public string EncryptedPinBlock { get; set; }

        /// <summary>
        /// PIN block KSN
        /// </summary>
        /// <value>PIN block KSN</value>
        [DataMember(Name="PinBlockKsn", EmitDefaultValue=false)]
        public string PinBlockKsn { get; set; }

        /// <summary>
        /// Card EMV TLV data
        /// </summary>
        /// <value>Card EMV TLV data</value>
        [DataMember(Name="CardEmvData", EmitDefaultValue=false)]
        public string CardEmvData { get; set; }

        /// <summary>
        /// Cardholder name
        /// </summary>
        /// <value>Cardholder name</value>
        [DataMember(Name="CardholderName", EmitDefaultValue=false)]
        public string CardholderName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Source {\n");
            sb.Append("  CardPresent: ").Append(CardPresent).Append("\n");
            sb.Append("  CardEmvFallback: ").Append(CardEmvFallback).Append("\n");
            sb.Append("  ManualEntry: ").Append(ManualEntry).Append("\n");
            sb.Append("  Debit: ").Append(Debit).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  Contactless: ").Append(Contactless).Append("\n");
            sb.Append("  CardPan: ").Append(CardPan).Append("\n");
            sb.Append("  MaskedPan: ").Append(MaskedPan).Append("\n");
            sb.Append("  CardCvv: ").Append(CardCvv).Append("\n");
            sb.Append("  CardExpiration: ").Append(CardExpiration).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
            sb.Append("  CardTrack1Data: ").Append(CardTrack1Data).Append("\n");
            sb.Append("  CardTrack2Data: ").Append(CardTrack2Data).Append("\n");
            sb.Append("  CardTrack3Data: ").Append(CardTrack3Data).Append("\n");
            sb.Append("  CardTrackData: ").Append(CardTrackData).Append("\n");
            sb.Append("  EncryptedCardTrack1Data: ").Append(EncryptedCardTrack1Data).Append("\n");
            sb.Append("  EncryptedCardTrack2Data: ").Append(EncryptedCardTrack2Data).Append("\n");
            sb.Append("  EncryptedCardTrack3Data: ").Append(EncryptedCardTrack3Data).Append("\n");
            sb.Append("  EncryptedCardTrackData: ").Append(EncryptedCardTrackData).Append("\n");
            sb.Append("  Ksn: ").Append(Ksn).Append("\n");
            sb.Append("  EncryptedPinBlock: ").Append(EncryptedPinBlock).Append("\n");
            sb.Append("  PinBlockKsn: ").Append(PinBlockKsn).Append("\n");
            sb.Append("  CardEmvData: ").Append(CardEmvData).Append("\n");
            sb.Append("  CardholderName: ").Append(CardholderName).Append("\n");
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
            return this.Equals(input as Source);
        }

        /// <summary>
        /// Returns true if Source instances are equal
        /// </summary>
        /// <param name="input">Instance of Source to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Source input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CardPresent == input.CardPresent ||
                    (this.CardPresent != null &&
                    this.CardPresent.Equals(input.CardPresent))
                ) && 
                (
                    this.CardEmvFallback == input.CardEmvFallback ||
                    (this.CardEmvFallback != null &&
                    this.CardEmvFallback.Equals(input.CardEmvFallback))
                ) && 
                (
                    this.ManualEntry == input.ManualEntry ||
                    (this.ManualEntry != null &&
                    this.ManualEntry.Equals(input.ManualEntry))
                ) && 
                (
                    this.Debit == input.Debit ||
                    (this.Debit != null &&
                    this.Debit.Equals(input.Debit))
                ) && 
                (
                    this.AccountType == input.AccountType ||
                    (this.AccountType != null &&
                    this.AccountType.Equals(input.AccountType))
                ) && 
                (
                    this.Contactless == input.Contactless ||
                    (this.Contactless != null &&
                    this.Contactless.Equals(input.Contactless))
                ) && 
                (
                    this.CardPan == input.CardPan ||
                    (this.CardPan != null &&
                    this.CardPan.Equals(input.CardPan))
                ) && 
                (
                    this.MaskedPan == input.MaskedPan ||
                    (this.MaskedPan != null &&
                    this.MaskedPan.Equals(input.MaskedPan))
                ) && 
                (
                    this.CardCvv == input.CardCvv ||
                    (this.CardCvv != null &&
                    this.CardCvv.Equals(input.CardCvv))
                ) && 
                (
                    this.CardExpiration == input.CardExpiration ||
                    (this.CardExpiration != null &&
                    this.CardExpiration.Equals(input.CardExpiration))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.TokenType == input.TokenType ||
                    (this.TokenType != null &&
                    this.TokenType.Equals(input.TokenType))
                ) && 
                (
                    this.CardTrack1Data == input.CardTrack1Data ||
                    (this.CardTrack1Data != null &&
                    this.CardTrack1Data.Equals(input.CardTrack1Data))
                ) && 
                (
                    this.CardTrack2Data == input.CardTrack2Data ||
                    (this.CardTrack2Data != null &&
                    this.CardTrack2Data.Equals(input.CardTrack2Data))
                ) && 
                (
                    this.CardTrack3Data == input.CardTrack3Data ||
                    (this.CardTrack3Data != null &&
                    this.CardTrack3Data.Equals(input.CardTrack3Data))
                ) && 
                (
                    this.CardTrackData == input.CardTrackData ||
                    (this.CardTrackData != null &&
                    this.CardTrackData.Equals(input.CardTrackData))
                ) && 
                (
                    this.EncryptedCardTrack1Data == input.EncryptedCardTrack1Data ||
                    (this.EncryptedCardTrack1Data != null &&
                    this.EncryptedCardTrack1Data.Equals(input.EncryptedCardTrack1Data))
                ) && 
                (
                    this.EncryptedCardTrack2Data == input.EncryptedCardTrack2Data ||
                    (this.EncryptedCardTrack2Data != null &&
                    this.EncryptedCardTrack2Data.Equals(input.EncryptedCardTrack2Data))
                ) && 
                (
                    this.EncryptedCardTrack3Data == input.EncryptedCardTrack3Data ||
                    (this.EncryptedCardTrack3Data != null &&
                    this.EncryptedCardTrack3Data.Equals(input.EncryptedCardTrack3Data))
                ) && 
                (
                    this.EncryptedCardTrackData == input.EncryptedCardTrackData ||
                    (this.EncryptedCardTrackData != null &&
                    this.EncryptedCardTrackData.Equals(input.EncryptedCardTrackData))
                ) && 
                (
                    this.Ksn == input.Ksn ||
                    (this.Ksn != null &&
                    this.Ksn.Equals(input.Ksn))
                ) && 
                (
                    this.EncryptedPinBlock == input.EncryptedPinBlock ||
                    (this.EncryptedPinBlock != null &&
                    this.EncryptedPinBlock.Equals(input.EncryptedPinBlock))
                ) && 
                (
                    this.PinBlockKsn == input.PinBlockKsn ||
                    (this.PinBlockKsn != null &&
                    this.PinBlockKsn.Equals(input.PinBlockKsn))
                ) && 
                (
                    this.CardEmvData == input.CardEmvData ||
                    (this.CardEmvData != null &&
                    this.CardEmvData.Equals(input.CardEmvData))
                ) && 
                (
                    this.CardholderName == input.CardholderName ||
                    (this.CardholderName != null &&
                    this.CardholderName.Equals(input.CardholderName))
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
                if (this.CardPresent != null)
                    hashCode = hashCode * 59 + this.CardPresent.GetHashCode();
                if (this.CardEmvFallback != null)
                    hashCode = hashCode * 59 + this.CardEmvFallback.GetHashCode();
                if (this.ManualEntry != null)
                    hashCode = hashCode * 59 + this.ManualEntry.GetHashCode();
                if (this.Debit != null)
                    hashCode = hashCode * 59 + this.Debit.GetHashCode();
                if (this.AccountType != null)
                    hashCode = hashCode * 59 + this.AccountType.GetHashCode();
                if (this.Contactless != null)
                    hashCode = hashCode * 59 + this.Contactless.GetHashCode();
                if (this.CardPan != null)
                    hashCode = hashCode * 59 + this.CardPan.GetHashCode();
                if (this.MaskedPan != null)
                    hashCode = hashCode * 59 + this.MaskedPan.GetHashCode();
                if (this.CardCvv != null)
                    hashCode = hashCode * 59 + this.CardCvv.GetHashCode();
                if (this.CardExpiration != null)
                    hashCode = hashCode * 59 + this.CardExpiration.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.TokenType != null)
                    hashCode = hashCode * 59 + this.TokenType.GetHashCode();
                if (this.CardTrack1Data != null)
                    hashCode = hashCode * 59 + this.CardTrack1Data.GetHashCode();
                if (this.CardTrack2Data != null)
                    hashCode = hashCode * 59 + this.CardTrack2Data.GetHashCode();
                if (this.CardTrack3Data != null)
                    hashCode = hashCode * 59 + this.CardTrack3Data.GetHashCode();
                if (this.CardTrackData != null)
                    hashCode = hashCode * 59 + this.CardTrackData.GetHashCode();
                if (this.EncryptedCardTrack1Data != null)
                    hashCode = hashCode * 59 + this.EncryptedCardTrack1Data.GetHashCode();
                if (this.EncryptedCardTrack2Data != null)
                    hashCode = hashCode * 59 + this.EncryptedCardTrack2Data.GetHashCode();
                if (this.EncryptedCardTrack3Data != null)
                    hashCode = hashCode * 59 + this.EncryptedCardTrack3Data.GetHashCode();
                if (this.EncryptedCardTrackData != null)
                    hashCode = hashCode * 59 + this.EncryptedCardTrackData.GetHashCode();
                if (this.Ksn != null)
                    hashCode = hashCode * 59 + this.Ksn.GetHashCode();
                if (this.EncryptedPinBlock != null)
                    hashCode = hashCode * 59 + this.EncryptedPinBlock.GetHashCode();
                if (this.PinBlockKsn != null)
                    hashCode = hashCode * 59 + this.PinBlockKsn.GetHashCode();
                if (this.CardEmvData != null)
                    hashCode = hashCode * 59 + this.CardEmvData.GetHashCode();
                if (this.CardholderName != null)
                    hashCode = hashCode * 59 + this.CardholderName.GetHashCode();
                return hashCode;
            }
        }
    }
}
