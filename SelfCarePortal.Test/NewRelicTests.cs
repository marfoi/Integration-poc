using System;
using System.Collections.Specialized;
using System.Linq;
using Newtonsoft.Json;
using NUnit.Framework;
using SelfCarePortal.Test.Entities;

namespace SelfCarePortal.Test
{
    [TestFixture]
    public class NewRelicTests
    {
        [Test]
        public void Get_applications_should_not_return_null()
        {
            //Arrange
            Uri executingUrl = Helpers.UriHelper.GetMethodPath(AppSettings.NewRelic.BaseUrl, AppSettings.NewRelic.Version, AppSettings.NewRelic.ApplicationPath);
            ListDictionary requestHeaders = new ListDictionary { { "X-Api-Key", AppSettings.NewRelic.ApiKey } };

            //Act
            string httpGetResult = FetchData.HttpGet(executingUrl, requestHeaders).Result;
            ApplicationResponse deserializedObject = JsonConvert.DeserializeObject<ApplicationResponse>(httpGetResult);

            // Assert
            Assert.IsNotNull(deserializedObject.Applications);
        }

        [Test]
        public void Get_application_by_id_should_not_return_null()
        {
            var method = "applications";

            //Arrange
            Uri executingUrl = Helpers.UriHelper.GetMethodPath(AppSettings.NewRelic.BaseUrl, AppSettings.NewRelic.Version, method, AppSettings.NewRelic.DummyApplication);
            ListDictionary requestHeaders = new ListDictionary { { "X-Api-Key", AppSettings.NewRelic.ApiKey } };

            //Act
            string httpGetResult = FetchData.HttpGet(executingUrl, requestHeaders).Result;
            ApplicationResponse deserializedObject = JsonConvert.DeserializeObject<ApplicationResponse>(httpGetResult);

            // Assert
            Assert.IsNotNull(deserializedObject.Application);

        }

        [Test]
        public void Get_site_by_id_health_status_should_be_gray_when_application_is_down()
        {
            var method = "applications";
            var expectedValueWhenApplicationHasError = "gray";

            //Arrange
            Uri executingUrl = Helpers.UriHelper.GetMethodPath(AppSettings.NewRelic.BaseUrl, AppSettings.NewRelic.Version, method, AppSettings.NewRelic.DummyApplication);
            ListDictionary requestHeaders = new ListDictionary { { "X-Api-Key", AppSettings.NewRelic.ApiKey } };

            //Act
            string httpGetResult = FetchData.HttpGet(executingUrl, requestHeaders).Result;
            ApplicationResponse deserializedObject = JsonConvert.DeserializeObject<ApplicationResponse>(httpGetResult);

            // Assert
            Assert.AreEqual(expectedValueWhenApplicationHasError, deserializedObject.Application.HealthStatus);

        }
    }
}
