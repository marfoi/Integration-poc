using NUnit.Framework;
using System;
using System.Collections.Specialized;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using SelfCarePortal.Test.Entities;

namespace SelfCarePortal.Test
{
    [TestFixture]
    public class AzureAdUserTests
    {
        [Test]
        public void GetToken_should_not_return_null()
        {
            // Act
            LoginResult deserializedObject = GetToken();

            // Assert
            Assert.IsNotNull(deserializedObject.AccessToken);
        }

        [Test]
        public void Get_users_should_not_return_null()
        {
            const string userMethod = "users";

            // Arrange   
            LoginResult deserializedTokenObject = GetToken();
            Uri executingUrl = Helpers.UriHelper.GetMethodPath(AppSettings.AzureAD.BaseUrl, AppSettings.AzureAD.Domain,
                null, userMethod, null, AppSettings.AzureAD.ApiVersion16);

            ListDictionary requestHeaders = new ListDictionary {
                { "Authorization", "Bearer " + deserializedTokenObject.AccessToken },
                { "Content-Type", AppSettings.AzureAD.ContentType},
            };

            // Act
            string httpGetResult = FetchData.HttpGet(executingUrl, requestHeaders).Result;
            UserResult deserializedObject = JsonConvert.DeserializeObject<UserResult>(httpGetResult);

            // Assert
            Assert.IsNotNull(deserializedObject.Users);
        }

        [Test]
        public void Get_single_user_by_id_should_not_return_null()
        {
            // Arrange
            const string userMethod = "users";

            LoginResult deserializedTokenObject = GetToken();

            Uri executingUrl = Helpers.UriHelper.GetMethodPath(AppSettings.AzureAD.BaseUrl, AppSettings.AzureAD.Domain,
              null, userMethod, AppSettings.AzureAD.DummyUser, AppSettings.AzureAD.ApiVersion16);

            ListDictionary requestHeaders = new ListDictionary {
                { "Authorization", "Bearer " + deserializedTokenObject.AccessToken },
                { "Content-Type", AppSettings.AzureAD.ContentType },
            };

            // Act
            string httpGetResult = FetchData.HttpGet(executingUrl, requestHeaders).Result;
            User deserializedUserObject = JsonConvert.DeserializeObject<User>(httpGetResult);

            // Assert
            Assert.IsNotNull(deserializedUserObject);
        }

        private static LoginResult GetToken()
        {
            const string tokenMethod = "token";

            var executingUrlForToken = Helpers.UriHelper.GetMethodPath(AppSettings.AzureAD.LoginUrl, AppSettings.AzureAD.Domain,
                AppSettings.AzureAD.Protocol, tokenMethod, null, AppSettings.AzureAD.ApiVersion10);

            JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };

            var requestTokenHeaders = new ListDictionary {
                { "ContentLength", "180" },
                { "Expect", "100-continue" },
                { "Connection", "Keep-Alive" }
            };

            var requestTokenContent = string.Concat(
                "grant_type=" + AppSettings.AzureAD.GrantType,
                "&resource=" + AppSettings.AzureAD.BaseUrl,
                "&client_id=" + AppSettings.AzureAD.ClientId,
                "&client_secret=" + AppSettings.AzureAD.ClientSecret
            );

            var stringTokenContent = new StringContent(requestTokenContent, Encoding.UTF8, AppSettings.AzureAD.MediaType);

            // Act
            var httpPostResult = FetchData.HttpPost(executingUrlForToken, requestTokenHeaders, stringTokenContent).Result;
            LoginResult deserializedTokenObject = JsonConvert.DeserializeObject<LoginResult>(httpPostResult, jsonSerializerSettings);

            return deserializedTokenObject;
        }
    }
}
