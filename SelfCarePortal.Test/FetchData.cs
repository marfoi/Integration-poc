using System;
using System.Collections;
using System.Collections.Specialized;
using System.Threading.Tasks;
using System.Net.Http;

namespace SelfCarePortal.Test
{
    public class FetchData
    {
        public static async Task<string> HttpPost(Uri executingUri, ListDictionary requestHeaders, HttpContent content)
        {
            try
            {
                using (var httpClientHandler = new HttpClientHandler { UseCookies = false })
                {
                    using (var httpClient = new HttpClient(httpClientHandler))
                    {
                        CreateDefaultRequestHeaders(requestHeaders, httpClient);

                        var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, executingUri) { Content = content };
                        var httpResponseMessage = httpClient.SendAsync(httpRequestMessage).Result;
                        var result = await httpResponseMessage.Content.ReadAsStringAsync();

                        return result;
                    }
                }
            }

            catch (Exception ex)
            {
                //Todo: log4net will be implemented here
                throw;
            }
        }

        public static async Task<string> HttpGet(Uri executingUri, ListDictionary requestHeaders)
        {
            try
            {
                using (var httpClientHandler = new HttpClientHandler { UseCookies = false })
                {
                    using (var httpClient = new HttpClient(httpClientHandler))
                    {
                        CreateDefaultRequestHeaders(requestHeaders, httpClient);

                        var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, executingUri);
                        var httpResponseMessage = httpClient.SendAsync(httpRequestMessage).Result;
                        var result = await httpResponseMessage.Content.ReadAsStringAsync();

                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                //Todo: log4net will be implemented here
                throw;
            }
        }

        private static void CreateDefaultRequestHeaders(ListDictionary requestHeaders, HttpClient httpClient, string contentType = null)
        {
            if (requestHeaders != null && requestHeaders.Count > 0)
            {
                foreach (DictionaryEntry entry in requestHeaders)
                {
                    httpClient.DefaultRequestHeaders.TryAddWithoutValidation(entry.Key.ToString(), entry.Value.ToString());
                }
            }

            if (!string.IsNullOrEmpty(contentType))
            {
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", contentType);
            }
        }
    }
}
