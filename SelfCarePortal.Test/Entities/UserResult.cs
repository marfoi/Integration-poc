using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SelfCarePortal.Test.Entities
{
    public class UserResult
    {
        [JsonProperty("odata.metadata")]
        public string OdataMetadata { get; set; }

        [JsonProperty("value")]
        public IList<User> Users { get; set; }
    }

    public class User
    {
        [JsonProperty("odata.type")]
        public string OdataType { get; set; }

        [JsonProperty("objectType")]
        public string ObjectType { get; set; }

        [JsonProperty("objectId")]
        public string ObjectId { get; set; }

        [JsonProperty("deletionTimestamp")]
        public string DeletionTimestamp { get; set; }

        [JsonProperty("accountEnabled")]
        public bool AccountEnabled { get; set; }

        [JsonProperty("signInNames")]
        public IList<string> SignInNames { get; set; }

        [JsonProperty("assignedLicenses")]
        public IList<string> AssignedLicenses { get; set; }

        [JsonProperty("assignedPlans")]
        public IList<string> AssignedPlans { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("creationType")]
        public string CreationType { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("dirSyncEnabled")]
        public string DirSyncEnabled { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("facsimileTelephoneNumber")]
        public string FaCsimileTelephoneNumber { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("immutableId")]
        public string ImmutableId { get; set; }

        [JsonProperty("isCompromised")]
        public string IsCompromised { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("lastDirSyncTime")]
        public string LastDirSyncTime { get; set; }

        [JsonProperty("mail")]
        public string Mail { get; set; }

        [JsonProperty("mailNickname")]
        public string MailNickname { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("onPremisesSecurityIdentifier")]
        public string OnPremisesSecurityIdentifier { get; set; }

        [JsonProperty("otherMails")]
        public IList<string> OtherMails { get; set; }

        [JsonProperty("passwordPolicies")]
        public string PasswordPolicies { get; set; }

        [JsonProperty("passwordProfile")]
        public string PasswordProfile { get; set; }

        [JsonProperty("physicalDeliveryOfficeName")]
        public string PhysicalDeliveryOfficeName { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("preferredLanguage")]
        public string PreferredLanguage { get; set; }

        [JsonProperty("provisionedPlans")]
        public IList<string> ProvisionedPlans { get; set; }

        [JsonProperty("provisioningErrors")]
        public IList<string> ProvisioningErrors { get; set; }

        [JsonProperty("proxyAddresses")]
        public IList<string> ProxyAddresses { get; set; }

        [JsonProperty("refreshTokensValidFromDateTime")]
        public DateTime? RefreshTokensValidFromDateTime { get; set; }

        [JsonProperty("sipProxyAddress")]
        public string SipProxyAddress { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("streetAddress")]
        public string StreetAddress { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("telephoneNumber")]
        public string TelephoneNumber { get; set; }

        [JsonProperty("usageLocation")]
        public string UsageLocation { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }

        [JsonProperty("userType")]
        public string UserType { get; set; }
    }
}
