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

namespace AppTest.Payment.Model;

/// <summary>
/// AccountInfoRequestData
/// </summary>
[DataContract]
    public partial class AccountInfoRequestData :  IEquatable<AccountInfoRequestData>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AccountInfoRequestData" /> class.
    /// </summary>
    /// <param name="accountAgeIndicator">accountAgeIndicator.</param>
    /// <param name="accountChangeDate">accountChangeDate.</param>
    /// <param name="accountChangeIndicator">accountChangeIndicator.</param>
    /// <param name="accountDate">accountDate.</param>
    /// <param name="accountPasswordChangeDate">accountPasswordChangeDate.</param>
    /// <param name="accountPasswordChangeIndicator">accountPasswordChangeIndicator.</param>
    /// <param name="accountPurchaseCount">accountPurchaseCount.</param>
    /// <param name="accountProvisioningAttempts">accountProvisioningAttempts.</param>
    /// <param name="accountDayTransactions">accountDayTransactions.</param>
    /// <param name="accountYearTransactions">accountYearTransactions.</param>
    /// <param name="paymentAccountAge">paymentAccountAge.</param>
    /// <param name="paymentAccountAgeIndicator">paymentAccountAgeIndicator.</param>
    /// <param name="shipAddressUsageDate">shipAddressUsageDate.</param>
    /// <param name="shipAddressUsageIndicator">shipAddressUsageIndicator.</param>
    /// <param name="shipNameIndicator">shipNameIndicator.</param>
    /// <param name="suspiciousAccountActivity">suspiciousAccountActivity.</param>
    public AccountInfoRequestData(string accountAgeIndicator = default(string), string accountChangeDate = default(string), string accountChangeIndicator = default(string), string accountDate = default(string), string accountPasswordChangeDate = default(string), string accountPasswordChangeIndicator = default(string), string accountPurchaseCount = default(string), string accountProvisioningAttempts = default(string), string accountDayTransactions = default(string), string accountYearTransactions = default(string), string paymentAccountAge = default(string), string paymentAccountAgeIndicator = default(string), string shipAddressUsageDate = default(string), string shipAddressUsageIndicator = default(string), string shipNameIndicator = default(string), string suspiciousAccountActivity = default(string))
    {
        this.AccountAgeIndicator = accountAgeIndicator;
        this.AccountChangeDate = accountChangeDate;
        this.AccountChangeIndicator = accountChangeIndicator;
        this.AccountDate = accountDate;
        this.AccountPasswordChangeDate = accountPasswordChangeDate;
        this.AccountPasswordChangeIndicator = accountPasswordChangeIndicator;
        this.AccountPurchaseCount = accountPurchaseCount;
        this.AccountProvisioningAttempts = accountProvisioningAttempts;
        this.AccountDayTransactions = accountDayTransactions;
        this.AccountYearTransactions = accountYearTransactions;
        this.PaymentAccountAge = paymentAccountAge;
        this.PaymentAccountAgeIndicator = paymentAccountAgeIndicator;
        this.ShipAddressUsageDate = shipAddressUsageDate;
        this.ShipAddressUsageIndicator = shipAddressUsageIndicator;
        this.ShipNameIndicator = shipNameIndicator;
        this.SuspiciousAccountActivity = suspiciousAccountActivity;
    }
    
    /// <summary>
    /// Gets or Sets AccountAgeIndicator
    /// </summary>
    [DataMember(Name="AccountAgeIndicator", EmitDefaultValue=false)]
    public string AccountAgeIndicator { get; set; }

    /// <summary>
    /// Gets or Sets AccountChangeDate
    /// </summary>
    [DataMember(Name="AccountChangeDate", EmitDefaultValue=false)]
    public string AccountChangeDate { get; set; }

    /// <summary>
    /// Gets or Sets AccountChangeIndicator
    /// </summary>
    [DataMember(Name="AccountChangeIndicator", EmitDefaultValue=false)]
    public string AccountChangeIndicator { get; set; }

    /// <summary>
    /// Gets or Sets AccountDate
    /// </summary>
    [DataMember(Name="AccountDate", EmitDefaultValue=false)]
    public string AccountDate { get; set; }

    /// <summary>
    /// Gets or Sets AccountPasswordChangeDate
    /// </summary>
    [DataMember(Name="AccountPasswordChangeDate", EmitDefaultValue=false)]
    public string AccountPasswordChangeDate { get; set; }

    /// <summary>
    /// Gets or Sets AccountPasswordChangeIndicator
    /// </summary>
    [DataMember(Name="AccountPasswordChangeIndicator", EmitDefaultValue=false)]
    public string AccountPasswordChangeIndicator { get; set; }

    /// <summary>
    /// Gets or Sets AccountPurchaseCount
    /// </summary>
    [DataMember(Name="AccountPurchaseCount", EmitDefaultValue=false)]
    public string AccountPurchaseCount { get; set; }

    /// <summary>
    /// Gets or Sets AccountProvisioningAttempts
    /// </summary>
    [DataMember(Name="AccountProvisioningAttempts", EmitDefaultValue=false)]
    public string AccountProvisioningAttempts { get; set; }

    /// <summary>
    /// Gets or Sets AccountDayTransactions
    /// </summary>
    [DataMember(Name="AccountDayTransactions", EmitDefaultValue=false)]
    public string AccountDayTransactions { get; set; }

    /// <summary>
    /// Gets or Sets AccountYearTransactions
    /// </summary>
    [DataMember(Name="AccountYearTransactions", EmitDefaultValue=false)]
    public string AccountYearTransactions { get; set; }

    /// <summary>
    /// Gets or Sets PaymentAccountAge
    /// </summary>
    [DataMember(Name="PaymentAccountAge", EmitDefaultValue=false)]
    public string PaymentAccountAge { get; set; }

    /// <summary>
    /// Gets or Sets PaymentAccountAgeIndicator
    /// </summary>
    [DataMember(Name="PaymentAccountAgeIndicator", EmitDefaultValue=false)]
    public string PaymentAccountAgeIndicator { get; set; }

    /// <summary>
    /// Gets or Sets ShipAddressUsageDate
    /// </summary>
    [DataMember(Name="ShipAddressUsageDate", EmitDefaultValue=false)]
    public string ShipAddressUsageDate { get; set; }

    /// <summary>
    /// Gets or Sets ShipAddressUsageIndicator
    /// </summary>
    [DataMember(Name="ShipAddressUsageIndicator", EmitDefaultValue=false)]
    public string ShipAddressUsageIndicator { get; set; }

    /// <summary>
    /// Gets or Sets ShipNameIndicator
    /// </summary>
    [DataMember(Name="ShipNameIndicator", EmitDefaultValue=false)]
    public string ShipNameIndicator { get; set; }

    /// <summary>
    /// Gets or Sets SuspiciousAccountActivity
    /// </summary>
    [DataMember(Name="SuspiciousAccountActivity", EmitDefaultValue=false)]
    public string SuspiciousAccountActivity { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AccountInfoRequestData {\n");
        sb.Append("  AccountAgeIndicator: ").Append(AccountAgeIndicator).Append("\n");
        sb.Append("  AccountChangeDate: ").Append(AccountChangeDate).Append("\n");
        sb.Append("  AccountChangeIndicator: ").Append(AccountChangeIndicator).Append("\n");
        sb.Append("  AccountDate: ").Append(AccountDate).Append("\n");
        sb.Append("  AccountPasswordChangeDate: ").Append(AccountPasswordChangeDate).Append("\n");
        sb.Append("  AccountPasswordChangeIndicator: ").Append(AccountPasswordChangeIndicator).Append("\n");
        sb.Append("  AccountPurchaseCount: ").Append(AccountPurchaseCount).Append("\n");
        sb.Append("  AccountProvisioningAttempts: ").Append(AccountProvisioningAttempts).Append("\n");
        sb.Append("  AccountDayTransactions: ").Append(AccountDayTransactions).Append("\n");
        sb.Append("  AccountYearTransactions: ").Append(AccountYearTransactions).Append("\n");
        sb.Append("  PaymentAccountAge: ").Append(PaymentAccountAge).Append("\n");
        sb.Append("  PaymentAccountAgeIndicator: ").Append(PaymentAccountAgeIndicator).Append("\n");
        sb.Append("  ShipAddressUsageDate: ").Append(ShipAddressUsageDate).Append("\n");
        sb.Append("  ShipAddressUsageIndicator: ").Append(ShipAddressUsageIndicator).Append("\n");
        sb.Append("  ShipNameIndicator: ").Append(ShipNameIndicator).Append("\n");
        sb.Append("  SuspiciousAccountActivity: ").Append(SuspiciousAccountActivity).Append("\n");
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
        return this.Equals(input as AccountInfoRequestData);
    }

    /// <summary>
    /// Returns true if AccountInfoRequestData instances are equal
    /// </summary>
    /// <param name="input">Instance of AccountInfoRequestData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AccountInfoRequestData input)
    {
        if (input == null)
            return false;

        return 
            (
                this.AccountAgeIndicator == input.AccountAgeIndicator ||
                (this.AccountAgeIndicator != null &&
                this.AccountAgeIndicator.Equals(input.AccountAgeIndicator))
            ) && 
            (
                this.AccountChangeDate == input.AccountChangeDate ||
                (this.AccountChangeDate != null &&
                this.AccountChangeDate.Equals(input.AccountChangeDate))
            ) && 
            (
                this.AccountChangeIndicator == input.AccountChangeIndicator ||
                (this.AccountChangeIndicator != null &&
                this.AccountChangeIndicator.Equals(input.AccountChangeIndicator))
            ) && 
            (
                this.AccountDate == input.AccountDate ||
                (this.AccountDate != null &&
                this.AccountDate.Equals(input.AccountDate))
            ) && 
            (
                this.AccountPasswordChangeDate == input.AccountPasswordChangeDate ||
                (this.AccountPasswordChangeDate != null &&
                this.AccountPasswordChangeDate.Equals(input.AccountPasswordChangeDate))
            ) && 
            (
                this.AccountPasswordChangeIndicator == input.AccountPasswordChangeIndicator ||
                (this.AccountPasswordChangeIndicator != null &&
                this.AccountPasswordChangeIndicator.Equals(input.AccountPasswordChangeIndicator))
            ) && 
            (
                this.AccountPurchaseCount == input.AccountPurchaseCount ||
                (this.AccountPurchaseCount != null &&
                this.AccountPurchaseCount.Equals(input.AccountPurchaseCount))
            ) && 
            (
                this.AccountProvisioningAttempts == input.AccountProvisioningAttempts ||
                (this.AccountProvisioningAttempts != null &&
                this.AccountProvisioningAttempts.Equals(input.AccountProvisioningAttempts))
            ) && 
            (
                this.AccountDayTransactions == input.AccountDayTransactions ||
                (this.AccountDayTransactions != null &&
                this.AccountDayTransactions.Equals(input.AccountDayTransactions))
            ) && 
            (
                this.AccountYearTransactions == input.AccountYearTransactions ||
                (this.AccountYearTransactions != null &&
                this.AccountYearTransactions.Equals(input.AccountYearTransactions))
            ) && 
            (
                this.PaymentAccountAge == input.PaymentAccountAge ||
                (this.PaymentAccountAge != null &&
                this.PaymentAccountAge.Equals(input.PaymentAccountAge))
            ) && 
            (
                this.PaymentAccountAgeIndicator == input.PaymentAccountAgeIndicator ||
                (this.PaymentAccountAgeIndicator != null &&
                this.PaymentAccountAgeIndicator.Equals(input.PaymentAccountAgeIndicator))
            ) && 
            (
                this.ShipAddressUsageDate == input.ShipAddressUsageDate ||
                (this.ShipAddressUsageDate != null &&
                this.ShipAddressUsageDate.Equals(input.ShipAddressUsageDate))
            ) && 
            (
                this.ShipAddressUsageIndicator == input.ShipAddressUsageIndicator ||
                (this.ShipAddressUsageIndicator != null &&
                this.ShipAddressUsageIndicator.Equals(input.ShipAddressUsageIndicator))
            ) && 
            (
                this.ShipNameIndicator == input.ShipNameIndicator ||
                (this.ShipNameIndicator != null &&
                this.ShipNameIndicator.Equals(input.ShipNameIndicator))
            ) && 
            (
                this.SuspiciousAccountActivity == input.SuspiciousAccountActivity ||
                (this.SuspiciousAccountActivity != null &&
                this.SuspiciousAccountActivity.Equals(input.SuspiciousAccountActivity))
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
            if (this.AccountAgeIndicator != null)
                hashCode = hashCode * 59 + this.AccountAgeIndicator.GetHashCode();
            if (this.AccountChangeDate != null)
                hashCode = hashCode * 59 + this.AccountChangeDate.GetHashCode();
            if (this.AccountChangeIndicator != null)
                hashCode = hashCode * 59 + this.AccountChangeIndicator.GetHashCode();
            if (this.AccountDate != null)
                hashCode = hashCode * 59 + this.AccountDate.GetHashCode();
            if (this.AccountPasswordChangeDate != null)
                hashCode = hashCode * 59 + this.AccountPasswordChangeDate.GetHashCode();
            if (this.AccountPasswordChangeIndicator != null)
                hashCode = hashCode * 59 + this.AccountPasswordChangeIndicator.GetHashCode();
            if (this.AccountPurchaseCount != null)
                hashCode = hashCode * 59 + this.AccountPurchaseCount.GetHashCode();
            if (this.AccountProvisioningAttempts != null)
                hashCode = hashCode * 59 + this.AccountProvisioningAttempts.GetHashCode();
            if (this.AccountDayTransactions != null)
                hashCode = hashCode * 59 + this.AccountDayTransactions.GetHashCode();
            if (this.AccountYearTransactions != null)
                hashCode = hashCode * 59 + this.AccountYearTransactions.GetHashCode();
            if (this.PaymentAccountAge != null)
                hashCode = hashCode * 59 + this.PaymentAccountAge.GetHashCode();
            if (this.PaymentAccountAgeIndicator != null)
                hashCode = hashCode * 59 + this.PaymentAccountAgeIndicator.GetHashCode();
            if (this.ShipAddressUsageDate != null)
                hashCode = hashCode * 59 + this.ShipAddressUsageDate.GetHashCode();
            if (this.ShipAddressUsageIndicator != null)
                hashCode = hashCode * 59 + this.ShipAddressUsageIndicator.GetHashCode();
            if (this.ShipNameIndicator != null)
                hashCode = hashCode * 59 + this.ShipNameIndicator.GetHashCode();
            if (this.SuspiciousAccountActivity != null)
                hashCode = hashCode * 59 + this.SuspiciousAccountActivity.GetHashCode();
            return hashCode;
        }
    }
}
