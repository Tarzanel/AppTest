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
    /// Browser Info
    /// </summary>
    [DataContract]
        public partial class BrowserInfoData :  IEquatable<BrowserInfoData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserInfoData" /> class.
        /// </summary>
        /// <param name="acceptHeader">acceptHeader.</param>
        /// <param name="language">language.</param>
        /// <param name="screenHeight">screenHeight.</param>
        /// <param name="screenWidth">screenWidth.</param>
        /// <param name="timeZone">timeZone.</param>
        /// <param name="userAgent">userAgent.</param>
        /// <param name="iP">iP.</param>
        /// <param name="javaEnabled">javaEnabled.</param>
        /// <param name="javascriptEnabled">javascriptEnabled.</param>
        /// <param name="colorDepth">colorDepth.</param>
        public BrowserInfoData(string acceptHeader = default(string), string language = default(string), string screenHeight = default(string), string screenWidth = default(string), string timeZone = default(string), string userAgent = default(string), string iP = default(string), bool? javaEnabled = default(bool?), bool? javascriptEnabled = default(bool?), string colorDepth = default(string))
        {
            this.AcceptHeader = acceptHeader;
            this.Language = language;
            this.ScreenHeight = screenHeight;
            this.ScreenWidth = screenWidth;
            this.TimeZone = timeZone;
            this.UserAgent = userAgent;
            this.IP = iP;
            this.JavaEnabled = javaEnabled;
            this.JavascriptEnabled = javascriptEnabled;
            this.ColorDepth = colorDepth;
        }
        
        /// <summary>
        /// Gets or Sets AcceptHeader
        /// </summary>
        [DataMember(Name="AcceptHeader", EmitDefaultValue=false)]
        public string AcceptHeader { get; set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="Language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// Gets or Sets ScreenHeight
        /// </summary>
        [DataMember(Name="ScreenHeight", EmitDefaultValue=false)]
        public string ScreenHeight { get; set; }

        /// <summary>
        /// Gets or Sets ScreenWidth
        /// </summary>
        [DataMember(Name="ScreenWidth", EmitDefaultValue=false)]
        public string ScreenWidth { get; set; }

        /// <summary>
        /// Gets or Sets TimeZone
        /// </summary>
        [DataMember(Name="TimeZone", EmitDefaultValue=false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// Gets or Sets UserAgent
        /// </summary>
        [DataMember(Name="UserAgent", EmitDefaultValue=false)]
        public string UserAgent { get; set; }

        /// <summary>
        /// Gets or Sets IP
        /// </summary>
        [DataMember(Name="IP", EmitDefaultValue=false)]
        public string IP { get; set; }

        /// <summary>
        /// Gets or Sets JavaEnabled
        /// </summary>
        [DataMember(Name="JavaEnabled", EmitDefaultValue=false)]
        public bool? JavaEnabled { get; set; }

        /// <summary>
        /// Gets or Sets JavascriptEnabled
        /// </summary>
        [DataMember(Name="JavascriptEnabled", EmitDefaultValue=false)]
        public bool? JavascriptEnabled { get; set; }

        /// <summary>
        /// Gets or Sets ColorDepth
        /// </summary>
        [DataMember(Name="ColorDepth", EmitDefaultValue=false)]
        public string ColorDepth { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrowserInfoData {\n");
            sb.Append("  AcceptHeader: ").Append(AcceptHeader).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  ScreenHeight: ").Append(ScreenHeight).Append("\n");
            sb.Append("  ScreenWidth: ").Append(ScreenWidth).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  UserAgent: ").Append(UserAgent).Append("\n");
            sb.Append("  IP: ").Append(IP).Append("\n");
            sb.Append("  JavaEnabled: ").Append(JavaEnabled).Append("\n");
            sb.Append("  JavascriptEnabled: ").Append(JavascriptEnabled).Append("\n");
            sb.Append("  ColorDepth: ").Append(ColorDepth).Append("\n");
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
            return this.Equals(input as BrowserInfoData);
        }

        /// <summary>
        /// Returns true if BrowserInfoData instances are equal
        /// </summary>
        /// <param name="input">Instance of BrowserInfoData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrowserInfoData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AcceptHeader == input.AcceptHeader ||
                    (this.AcceptHeader != null &&
                    this.AcceptHeader.Equals(input.AcceptHeader))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.ScreenHeight == input.ScreenHeight ||
                    (this.ScreenHeight != null &&
                    this.ScreenHeight.Equals(input.ScreenHeight))
                ) && 
                (
                    this.ScreenWidth == input.ScreenWidth ||
                    (this.ScreenWidth != null &&
                    this.ScreenWidth.Equals(input.ScreenWidth))
                ) && 
                (
                    this.TimeZone == input.TimeZone ||
                    (this.TimeZone != null &&
                    this.TimeZone.Equals(input.TimeZone))
                ) && 
                (
                    this.UserAgent == input.UserAgent ||
                    (this.UserAgent != null &&
                    this.UserAgent.Equals(input.UserAgent))
                ) && 
                (
                    this.IP == input.IP ||
                    (this.IP != null &&
                    this.IP.Equals(input.IP))
                ) && 
                (
                    this.JavaEnabled == input.JavaEnabled ||
                    (this.JavaEnabled != null &&
                    this.JavaEnabled.Equals(input.JavaEnabled))
                ) && 
                (
                    this.JavascriptEnabled == input.JavascriptEnabled ||
                    (this.JavascriptEnabled != null &&
                    this.JavascriptEnabled.Equals(input.JavascriptEnabled))
                ) && 
                (
                    this.ColorDepth == input.ColorDepth ||
                    (this.ColorDepth != null &&
                    this.ColorDepth.Equals(input.ColorDepth))
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
                if (this.AcceptHeader != null)
                    hashCode = hashCode * 59 + this.AcceptHeader.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.ScreenHeight != null)
                    hashCode = hashCode * 59 + this.ScreenHeight.GetHashCode();
                if (this.ScreenWidth != null)
                    hashCode = hashCode * 59 + this.ScreenWidth.GetHashCode();
                if (this.TimeZone != null)
                    hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                if (this.UserAgent != null)
                    hashCode = hashCode * 59 + this.UserAgent.GetHashCode();
                if (this.IP != null)
                    hashCode = hashCode * 59 + this.IP.GetHashCode();
                if (this.JavaEnabled != null)
                    hashCode = hashCode * 59 + this.JavaEnabled.GetHashCode();
                if (this.JavascriptEnabled != null)
                    hashCode = hashCode * 59 + this.JavascriptEnabled.GetHashCode();
                if (this.ColorDepth != null)
                    hashCode = hashCode * 59 + this.ColorDepth.GetHashCode();
                return hashCode;
            }
        }
    }
}
