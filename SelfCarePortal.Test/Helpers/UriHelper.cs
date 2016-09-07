using System;
using System.Web;

namespace SelfCarePortal.Test.Helpers
{
    public static class UriHelper
    {
        public static Uri GetMethodPath(string baseServiceUrl, string apiDomainName, string protocol = "", string method = "", string subMethod = "", string query = "")
        {
            if (string.IsNullOrEmpty(baseServiceUrl)) throw new ArgumentNullException(nameof(baseServiceUrl));

            if (string.IsNullOrEmpty(apiDomainName)) throw new ArgumentNullException(nameof(apiDomainName));

            var path = string.Empty;
            if (!string.IsNullOrEmpty(protocol)) path = "/" + HttpUtility.UrlEncode(protocol);

            if (!string.IsNullOrEmpty(method)) path += "/" + HttpUtility.UrlEncode(method);

            if (!string.IsNullOrEmpty(subMethod)) path += "/" + HttpUtility.UrlEncode(subMethod);

            if (!string.IsNullOrEmpty(query)) path += "?" + HttpUtility.UrlDecode(query);

            var methodPath = new Uri(apiDomainName + path, UriKind.Relative);
            return new Uri(new Uri(baseServiceUrl), methodPath);
        }
      
    }
}
