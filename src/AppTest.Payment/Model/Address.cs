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
    /// Address
    /// </summary>
    [DataContract]
        public partial class Address :  IEquatable<Address>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        /// <param name="firstName">First Name.</param>
        /// <param name="lastName">Last Name.</param>
        /// <param name="line1">Address Line 1.</param>
        /// <param name="line2">Address Line 2.</param>
        /// <param name="city">City.</param>
        /// <param name="county">County.</param>
        /// <param name="state">State.</param>
        /// <param name="postalCode">Postal code or zip code (required).</param>
        /// <param name="countryCode">Country code - 3 digit ISO code (required).</param>
        /// <param name="emailAddress">Email Address.</param>
        /// <param name="phoneNumber">Phone Number.</param>
        /// <param name="phoneNumber2">Phone Number 2.</param>
        /// <param name="phoneNumber3">Phone Number 3.</param>
        public Address(string firstName = default(string), string lastName = default(string), string line1 = default(string), string line2 = default(string), string city = default(string), string county = default(string), string state = default(string), string postalCode = default(string), string countryCode = default(string), string emailAddress = default(string), string phoneNumber = default(string), string phoneNumber2 = default(string), string phoneNumber3 = default(string))
        {
            // to ensure "postalCode" is required (not null)
            if (postalCode == null)
            {
                throw new InvalidDataException("postalCode is a required property for Address and cannot be null");
            }
            else
            {
                this.PostalCode = postalCode;
            }
            // to ensure "countryCode" is required (not null)
            if (countryCode == null)
            {
                throw new InvalidDataException("countryCode is a required property for Address and cannot be null");
            }
            else
            {
                this.CountryCode = countryCode;
            }
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Line1 = line1;
            this.Line2 = line2;
            this.City = city;
            this.County = county;
            this.State = state;
            this.EmailAddress = emailAddress;
            this.PhoneNumber = phoneNumber;
            this.PhoneNumber2 = phoneNumber2;
            this.PhoneNumber3 = phoneNumber3;
        }
        
        /// <summary>
        /// First Name
        /// </summary>
        /// <value>First Name</value>
        [DataMember(Name="FirstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Last Name
        /// </summary>
        /// <value>Last Name</value>
        [DataMember(Name="LastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Address Line 1
        /// </summary>
        /// <value>Address Line 1</value>
        [DataMember(Name="Line1", EmitDefaultValue=false)]
        public string Line1 { get; set; }

        /// <summary>
        /// Address Line 2
        /// </summary>
        /// <value>Address Line 2</value>
        [DataMember(Name="Line2", EmitDefaultValue=false)]
        public string Line2 { get; set; }

        /// <summary>
        /// City
        /// </summary>
        /// <value>City</value>
        [DataMember(Name="City", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// County
        /// </summary>
        /// <value>County</value>
        [DataMember(Name="County", EmitDefaultValue=false)]
        public string County { get; set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="State", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Postal code or zip code
        /// </summary>
        /// <value>Postal code or zip code</value>
        [DataMember(Name="PostalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Country code - 3 digit ISO code
        /// </summary>
        /// <value>Country code - 3 digit ISO code</value>
        [DataMember(Name="CountryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Email Address
        /// </summary>
        /// <value>Email Address</value>
        [DataMember(Name="EmailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Phone Number
        /// </summary>
        /// <value>Phone Number</value>
        [DataMember(Name="PhoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Phone Number 2
        /// </summary>
        /// <value>Phone Number 2</value>
        [DataMember(Name="PhoneNumber2", EmitDefaultValue=false)]
        public string PhoneNumber2 { get; set; }

        /// <summary>
        /// Phone Number 3
        /// </summary>
        /// <value>Phone Number 3</value>
        [DataMember(Name="PhoneNumber3", EmitDefaultValue=false)]
        public string PhoneNumber3 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Address {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Line1: ").Append(Line1).Append("\n");
            sb.Append("  Line2: ").Append(Line2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  County: ").Append(County).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  PhoneNumber2: ").Append(PhoneNumber2).Append("\n");
            sb.Append("  PhoneNumber3: ").Append(PhoneNumber3).Append("\n");
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
            return this.Equals(input as Address);
        }

        /// <summary>
        /// Returns true if Address instances are equal
        /// </summary>
        /// <param name="input">Instance of Address to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Address input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.Line1 == input.Line1 ||
                    (this.Line1 != null &&
                    this.Line1.Equals(input.Line1))
                ) && 
                (
                    this.Line2 == input.Line2 ||
                    (this.Line2 != null &&
                    this.Line2.Equals(input.Line2))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.County == input.County ||
                    (this.County != null &&
                    this.County.Equals(input.County))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.PhoneNumber2 == input.PhoneNumber2 ||
                    (this.PhoneNumber2 != null &&
                    this.PhoneNumber2.Equals(input.PhoneNumber2))
                ) && 
                (
                    this.PhoneNumber3 == input.PhoneNumber3 ||
                    (this.PhoneNumber3 != null &&
                    this.PhoneNumber3.Equals(input.PhoneNumber3))
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
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.Line1 != null)
                    hashCode = hashCode * 59 + this.Line1.GetHashCode();
                if (this.Line2 != null)
                    hashCode = hashCode * 59 + this.Line2.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.County != null)
                    hashCode = hashCode * 59 + this.County.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.PhoneNumber2 != null)
                    hashCode = hashCode * 59 + this.PhoneNumber2.GetHashCode();
                if (this.PhoneNumber3 != null)
                    hashCode = hashCode * 59 + this.PhoneNumber3.GetHashCode();
                return hashCode;
            }
        }
    }
}
