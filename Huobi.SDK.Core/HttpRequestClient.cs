using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Huobi.SDK.Core.Log;
using Newtonsoft.Json;

namespace Huobi.SDK.Core
{
    /// <summary>
    /// The staic class that wrap the GET and POST Http request
    /// </summary>
    public class HttpRequestClient
    {
        //public static bool LogPerformanceEnabled = false;

        public static PerformanceLogger _logger = PerformanceLogger.GetInstance();
        public HttpClient _httpClient;

        public HttpRequestClient(HttpClient httpClient = null)
        {
            _httpClient = httpClient ?? new HttpClient
            {
                Timeout = TimeSpan.FromSeconds(20)
            };
        }
        /// <summary>
        /// Send Http GET request
        /// </summary>
        /// <typeparam name="T">The response type</typeparam>
        /// <param name="url">Request url</param>
        /// <returns>The generic response type</returns>
        public async Task<T> GetAsync<T>(string url)
        {
            _logger.RquestStart("GET", url);

            string response = await _httpClient.GetStringAsync(url);

            _logger.RequestEnd();

            T t = JsonConvert.DeserializeObject<T>(response);

            return t;
        }

        /// <summary>
        /// Send Http GET request
        /// </summary>
        /// <typeparam name="T">The response type</typeparam>
        /// <param name="url">Request url</param>
        /// <returns>The generic response type</returns>
        public async Task<string> GetStringAsync(string url)
        {
            _logger.RquestStart("GET", url);

            string response = await _httpClient.GetStringAsync(url);

            _logger.RequestEnd();

            return response;
        }

        /// <summary>
        /// Send Http POST request
        /// </summary>
        /// <typeparam name="T">The response type</typeparam>
        /// <param name="url">Request url</param>
        /// <param name="body">Request body</param>
        /// <param name="mediaTyp">Meida type, default value is "application/json"</param>
        /// <returns>The response type</returns>
        public async Task<T> PostAsync<T>(string url, string body = null, string mediaTyp = "application/json")
        {
            StringContent httpContent;

            if (string.IsNullOrEmpty(body))
            {
                httpContent = null;
            }
            else
            {
                httpContent = new StringContent(body, Encoding.UTF8, mediaTyp);
            }

            _logger.RquestStart("POST", url);

            var response = await _httpClient.PostAsync(url, httpContent);

            string result = await response.Content.ReadAsStringAsync();

            _logger.RequestEnd();

            T t = JsonConvert.DeserializeObject<T>(result);

            return t;
        }
    }
}
