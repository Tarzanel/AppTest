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
    /// Void request
    /// </summary>
    [DataContract]
        public partial class VoidRequest :  IEquatable<VoidRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoidRequest" /> class.
        /// </summary>
        /// <param name="transactionIdentifier">Transaction identifier (required).</param>
        /// <param name="externalIdentifier">External identifier for the transaction.</param>
        /// <param name="externalGroupIdentifier">Optional external group identifier.</param>
        /// <param name="emvData">EMVData is for the 2nd Gen AC in the case of card decline reversals.</param>
        /// <param name="terminalCode">Terminal model (required).</param>
        /// <param name="terminalSerialNumber">Terminal serial number.  Required when EMV data is present..</param>
        /// <param name="autoReversal">If true, this is an autoreversal.</param>
        public VoidRequest(string transactionIdentifier = default(string), string externalIdentifier = default(string), string externalGroupIdentifier = default(string), string emvData = default(string), string terminalCode = default(string), string terminalSerialNumber = default(string), bool? autoReversal = default(bool?))
        {
            // to ensure "transactionIdentifier" is required (not null)
            if (transactionIdentifier == null)
            {
                throw new InvalidDataException("transactionIdentifier is a required property for VoidRequest and cannot be null");
            }
            else
            {
                this.TransactionIdentifier = transactionIdentifier;
            }
            // to ensure "terminalCode" is required (not null)
            if (terminalCode == null)
            {
                throw new InvalidDataException("terminalCode is a required property for VoidRequest and cannot be null");
            }
            else
            {
                this.TerminalCode = terminalCode;
            }
            this.ExternalIdentifier = externalIdentifier;
            this.ExternalGroupIdentifier = externalGroupIdentifier;
            this.EmvData = emvData;
            this.TerminalSerialNumber = terminalSerialNumber;
            this.AutoReversal = autoReversal;
        }
        
        /// <summary>
        /// Transaction identifier
        /// </summary>
        /// <value>Transaction identifier</value>
        [DataMember(Name="TransactionIdentifier", EmitDefaultValue=false)]
        public string TransactionIdentifier { get; set; }

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
        /// EMVData is for the 2nd Gen AC in the case of card decline reversals
        /// </summary>
        /// <value>EMVData is for the 2nd Gen AC in the case of card decline reversals</value>
        [DataMember(Name="EmvData", EmitDefaultValue=false)]
        public string EmvData { get; set; }

        /// <summary>
        /// Terminal model
        /// </summary>
        /// <value>Terminal model</value>
        [DataMember(Name="TerminalCode", EmitDefaultValue=false)]
        public string TerminalCode { get; set; }

        /// <summary>
        /// Terminal serial number.  Required when EMV data is present.
        /// </summary>
        /// <value>Terminal serial number.  Required when EMV data is present.</value>
        [DataMember(Name="TerminalSerialNumber", EmitDefaultValue=false)]
        public string TerminalSerialNumber { get; set; }

        /// <summary>
        /// If true, this is an autoreversal
        /// </summary>
        /// <value>If true, this is an autoreversal</value>
        [DataMember(Name="AutoReversal", EmitDefaultValue=false)]
        public bool? AutoReversal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VoidRequest {\n");
            sb.Append("  TransactionIdentifier: ").Append(TransactionIdentifier).Append("\n");
            sb.Append("  ExternalIdentifier: ").Append(ExternalIdentifier).Append("\n");
            sb.Append("  ExternalGroupIdentifier: ").Append(ExternalGroupIdentifier).Append("\n");
            sb.Append("  EmvData: ").Append(EmvData).Append("\n");
            sb.Append("  TerminalCode: ").Append(TerminalCode).Append("\n");
            sb.Append("  TerminalSerialNumber: ").Append(TerminalSerialNumber).Append("\n");
            sb.Append("  AutoReversal: ").Append(AutoReversal).Append("\n");
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
            return this.Equals(input as VoidRequest);
        }

        /// <summary>
        /// Returns true if VoidRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of VoidRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoidRequest input)
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
                    this.ExternalIdentifier == input.ExternalIdentifier ||
                    (this.ExternalIdentifier != null &&
                    this.ExternalIdentifier.Equals(input.ExternalIdentifier))
                ) && 
                (
                    this.ExternalGroupIdentifier == input.ExternalGroupIdentifier ||
                    (this.ExternalGroupIdentifier != null &&
                    this.ExternalGroupIdentifier.Equals(input.ExternalGroupIdentifier))
                ) && 
                (
                    this.EmvData == input.EmvData ||
                    (this.EmvData != null &&
                    this.EmvData.Equals(input.EmvData))
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
                    this.AutoReversal == input.AutoReversal ||
                    (this.AutoReversal != null &&
                    this.AutoReversal.Equals(input.AutoReversal))
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
                if (this.ExternalIdentifier != null)
                    hashCode = hashCode * 59 + this.ExternalIdentifier.GetHashCode();
                if (this.ExternalGroupIdentifier != null)
                    hashCode = hashCode * 59 + this.ExternalGroupIdentifier.GetHashCode();
                if (this.EmvData != null)
                    hashCode = hashCode * 59 + this.EmvData.GetHashCode();
                if (this.TerminalCode != null)
                    hashCode = hashCode * 59 + this.TerminalCode.GetHashCode();
                if (this.TerminalSerialNumber != null)
                    hashCode = hashCode * 59 + this.TerminalSerialNumber.GetHashCode();
                if (this.AutoReversal != null)
                    hashCode = hashCode * 59 + this.AutoReversal.GetHashCode();
                return hashCode;
            }
        }
    }
}
