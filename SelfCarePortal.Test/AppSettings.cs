namespace SelfCarePortal.Test
{
    //Todo: This file will be used to get these settings from config files
    public static class AppSettings
    {
        public static class AzureAD
        {
            public const string BaseUrl = "https://graph.windows.net";
            public const string LoginUrl = "https://login.windows.net";
            public const string DummyUser = "";
            public const string Domain = "";
            public const string ClientId = "";
            public const string ClientSecret = "";
            public const string ClientSecretEncoded = "";

            public const string GrantType = "client_credentials";
            public const string Protocol = "oauth2"; 
            public const string ContentType = "application/json";
            public const string ApiVersion10 = "api-version=1.0";
            public const string ApiVersion16 = "api-version=1.6";
            public const string MediaType = "application/x-www-form-urlencoded";
        }

        public static class NewRelic
        {
            public const string BaseUrl = "https://api.newrelic.com/";
            public const string DummyApplication = "";
            public const string ApiKey = "";
            public const string Version = "v2";
            public const string ApplicationPath = "applications.json";

        }
    }
}
