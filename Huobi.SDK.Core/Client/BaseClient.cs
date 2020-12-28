using System.Net.Http;

namespace Huobi.SDK.Core.Client
{
    public class BaseClient
    {
        protected readonly HttpRequestClient _httpRequestClient;

        public BaseClient(HttpClient httpClient = null)
        {
            _httpRequestClient = new HttpRequestClient(httpClient);
        }
    }
}