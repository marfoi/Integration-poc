using System;
using System.Collections.Specialized;
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
            ListDictionary requestHeaders = new ListDictionary {{ "X-Api-Key", AppSettings.NewRelic.ApiKey }};

            //Act
            string httpGetResult = FetchData.HttpGet(executingUrl, requestHeaders).Result;
            ApplicationResponse deserializedObject = JsonConvert.DeserializeObject<ApplicationResponse>(httpGetResult);

            // Assert
            Assert.IsNotNull(deserializedObject.Applications);
            
        }
    }
}
