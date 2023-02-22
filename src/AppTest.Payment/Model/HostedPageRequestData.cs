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
    /// Hosted Page parameters
    /// </summary>
    [DataContract]
        public partial class HostedPageRequestData :  IEquatable<HostedPageRequestData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HostedPageRequestData" /> class.
        /// </summary>
        /// <param name="pageSet">Hosted page set name.</param>
        /// <param name="pageName">Hosted page name.</param>
        public HostedPageRequestData(string pageSet = default(string), string pageName = default(string))
        {
            this.PageSet = pageSet;
            this.PageName = pageName;
        }
        
        /// <summary>
        /// Hosted page set name
        /// </summary>
        /// <value>Hosted page set name</value>
        [DataMember(Name="PageSet", EmitDefaultValue=false)]
        public string PageSet { get; set; }

        /// <summary>
        /// Hosted page name
        /// </summary>
        /// <value>Hosted page name</value>
        [DataMember(Name="PageName", EmitDefaultValue=false)]
        public string PageName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HostedPageRequestData {\n");
            sb.Append("  PageSet: ").Append(PageSet).Append("\n");
            sb.Append("  PageName: ").Append(PageName).Append("\n");
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
            return this.Equals(input as HostedPageRequestData);
        }

        /// <summary>
        /// Returns true if HostedPageRequestData instances are equal
        /// </summary>
        /// <param name="input">Instance of HostedPageRequestData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HostedPageRequestData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PageSet == input.PageSet ||
                    (this.PageSet != null &&
                    this.PageSet.Equals(input.PageSet))
                ) && 
                (
                    this.PageName == input.PageName ||
                    (this.PageName != null &&
                    this.PageName.Equals(input.PageName))
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
                if (this.PageSet != null)
                    hashCode = hashCode * 59 + this.PageSet.GetHashCode();
                if (this.PageName != null)
                    hashCode = hashCode * 59 + this.PageName.GetHashCode();
                return hashCode;
            }
        }
    }
}
