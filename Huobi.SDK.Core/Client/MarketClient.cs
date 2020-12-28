using System.Threading.Tasks;
using Huobi.SDK.Core.RequestBuilder;
using Huobi.SDK.Model.Response.Order;
using Huobi.SDK.Model.Response.Market;
using System.Net.Http;

namespace Huobi.SDK.Core.Client
{
    /// <summary>
    /// Responsible to get market information
    /// </summary>
    public class MarketClient : BaseClient
    {
        private const string DEFAULT_HOST = "api.huobi.pro";

        private PublicUrlBuilder _urlBuilder;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="host">the host that the client connects to</param>
        public MarketClient(HttpClient httpClient = null, string host = DEFAULT_HOST) : base(httpClient)
        {
            _urlBuilder = new PublicUrlBuilder(host);
        }

        /// <summary>
        /// Retrieves all klines in a specific range.
        /// </summary>
        /// <param name="request"></param>
        /// <returns>GetCandlestickResponse</returns>
        public async Task<GetCandlestickResponse> GetCandlestickAsync(GetRequest request)
        {
            string url = _urlBuilder.Build("/market/history/kline", request);

            return await _httpRequestClient.GetAsync<GetCandlestickResponse>(url);
        }

        /// <summary>
        /// Retrieves the latest ticker with some important 24h aggregated market data.
        /// </summary>
        /// <param name="symbol">Trading symbol</param>
        /// <returns>GetLast24hCandlestickAskBidResponse</returns>
        public async Task<GetLast24hCandlestickAskBidResponse> GetLast24hCandlestickAskBidAsync(string symbol)
        {
            string url = _urlBuilder.Build($"/market/detail/merged?symbol={symbol}");

            return await _httpRequestClient.GetAsync<GetLast24hCandlestickAskBidResponse>(url);
        }

        /// <summary>
        /// Retrieve the latest tickers for all supported pairs.
        /// </summary>
        /// <returns>GetLast24hCandlestickResponse</returns>
        public async Task<GetAllSymbolsLast24hCandlesticksAskBidResponse> GetAllSymbolsLast24hCandlesticksAskBidAsync()
        {
            string url = _urlBuilder.Build("/market/tickers");

            return await _httpRequestClient.GetAsync<GetAllSymbolsLast24hCandlesticksAskBidResponse>(url);
        }

        /// <summary>
        /// Retrieves the current order book of a specific pair
        /// </summary>
        /// <param name="request"></param>
        /// <returns>GetDepthResponse</returns>
        public async Task<GetDepthResponse> GetDepthAsync(GetRequest request)
        {
            string url = _urlBuilder.Build("/market/depth", request);

            return await _httpRequestClient.GetAsync<GetDepthResponse>(url);
        }

        /// <summary>
        /// Retrieves the latest trade with its price, volume, and direction.
        /// </summary>
        /// <param name="symbol">Trading symbol</param>
        /// <returns>GetLastTradeResponse</returns>
        public async Task<GetLastTradeResponse> GetLastTradeAsync(string symbol)
        {
            string url = _urlBuilder.Build($"/market/trade?symbol={symbol}");

            return await _httpRequestClient.GetAsync<GetLastTradeResponse>(url);
        }

        /// <summary>
        /// Retrieves the most recent trades with their price, volume, and direction.
        /// </summary>
        /// <param name="symbol">Trading symbol</param>
        /// <param name="size">The number of data returns</param>
        /// <returns>GetLastTradesResponse</returns>
        public async Task<GetLastTradesResponse> GetLastTradesAsync(string symbol, int size)
        {
            string url = _urlBuilder.Build($"/market/history/trade?symbol={symbol}&size={size}");

            return await _httpRequestClient.GetAsync<GetLastTradesResponse>(url);
        }

        /// <summary>
        /// Retrieves the summary of trading in the market for the last 24 hours.
        /// </summary>
        /// <param name="symbol">Trading symbol</param>
        /// <returns>GetLast24hCandlestickResponse</returns>
        public async Task<GetLast24hCandlestickResponse> GetLast24hCandlestickAsync(string symbol)
        {
            string url = _urlBuilder.Build($"/market/detail?symbol={symbol}");

            return await _httpRequestClient.GetAsync<GetLast24hCandlestickResponse>(url);
        }
    }
}
