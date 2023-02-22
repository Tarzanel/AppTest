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
    /// Recurring parameters
    /// </summary>
    [DataContract]
        public partial class RecurringRequestData :  IEquatable<RecurringRequestData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecurringRequestData" /> class.
        /// </summary>
        /// <param name="startDate">Recurring start date YYYYMMDD.</param>
        /// <param name="frequency">Recurring frequency D,W,F,M,B,Q,Y.</param>
        /// <param name="expiryDate">Recurring expiry date YYYYMMDD.</param>
        public RecurringRequestData(string startDate = default(string), string frequency = default(string), string expiryDate = default(string))
        {
            this.StartDate = startDate;
            this.Frequency = frequency;
            this.ExpiryDate = expiryDate;
        }
        
        /// <summary>
        /// Recurring start date YYYYMMDD
        /// </summary>
        /// <value>Recurring start date YYYYMMDD</value>
        [DataMember(Name="StartDate", EmitDefaultValue=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// Recurring frequency D,W,F,M,B,Q,Y
        /// </summary>
        /// <value>Recurring frequency D,W,F,M,B,Q,Y</value>
        [DataMember(Name="Frequency", EmitDefaultValue=false)]
        public string Frequency { get; set; }

        /// <summary>
        /// Recurring expiry date YYYYMMDD
        /// </summary>
        /// <value>Recurring expiry date YYYYMMDD</value>
        [DataMember(Name="ExpiryDate", EmitDefaultValue=false)]
        public string ExpiryDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecurringRequestData {\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
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
            return this.Equals(input as RecurringRequestData);
        }

        /// <summary>
        /// Returns true if RecurringRequestData instances are equal
        /// </summary>
        /// <param name="input">Instance of RecurringRequestData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecurringRequestData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.Frequency == input.Frequency ||
                    (this.Frequency != null &&
                    this.Frequency.Equals(input.Frequency))
                ) && 
                (
                    this.ExpiryDate == input.ExpiryDate ||
                    (this.ExpiryDate != null &&
                    this.ExpiryDate.Equals(input.ExpiryDate))
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
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.Frequency != null)
                    hashCode = hashCode * 59 + this.Frequency.GetHashCode();
                if (this.ExpiryDate != null)
                    hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
                return hashCode;
            }
        }
    }
}
