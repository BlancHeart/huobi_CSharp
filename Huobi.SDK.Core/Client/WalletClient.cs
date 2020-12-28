using System.Threading.Tasks;
using Huobi.SDK.Core.RequestBuilder;
using Huobi.SDK.Model.Response.Wallet;
using Huobi.SDK.Model.Request.Wallet;
using System.Net.Http;

namespace Huobi.SDK.Core.Client
{
    /// <summary>
    /// Responsible to operate wallet
    /// </summary>
    public class WalletClient : BaseClient
    {
        private const string GET_METHOD = "GET";
        private const string POST_METHOD = "POST";

        private const string DEFAULT_HOST = "api.huobi.pro";

        private readonly PrivateUrlBuilder _urlBuilder;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="accessKey">Access Key</param>
        /// <param name="secretKey">Secret Key</param>
        /// <param name="host">the host that the client connects to</param>
        public WalletClient(string accessKey, string secretKey, HttpClient httpClient = null, string host = DEFAULT_HOST) : base(httpClient)
        {
            _urlBuilder = new PrivateUrlBuilder(accessKey, secretKey, host);
        }

        /// <summary>
        /// Get deposit address of corresponding chain, for a specific crypto currency (except IOTA)
        /// </summary>
        /// <param name="request"></param>
        /// <returns>GetDepositAddressResponse</returns>
        public async Task<GetDepositAddressResponse> GetDepositAddressAsync(GetRequest request)
        {
            string url = _urlBuilder.Build(GET_METHOD, "/v2/account/deposit/address", request);

            return await _httpRequestClient.GetAsync<GetDepositAddressResponse>(url);
        }

        /// <summary>
        /// Query withdraw quota for currencies
        /// </summary>
        /// <param name="request"></param>
        /// <returns>GetWithdrawQuotaResponse</returns>
        public async Task<GetWithdrawQuotaResponse> GetWithdrawQuotaAsync(GetRequest request)
        {
            string url = _urlBuilder.Build(GET_METHOD, "/v2/account/withdraw/quota", request);

            return await _httpRequestClient.GetAsync<GetWithdrawQuotaResponse>(url);
        }

        /// <summary>
        /// Get withdraw address
        /// </summary>
        /// <param name="request"></param>
        /// <returns>GetDepositAddressResponse</returns>
        public async Task<GetDepositAddressResponse> GetWithdrawAddressAsync(GetRequest request)
        {
            string url = _urlBuilder.Build(GET_METHOD, "/v2/account/withdraw/address", request);

            return await _httpRequestClient.GetAsync<GetDepositAddressResponse>(url);
        }


        /// <summary>
        /// Withdraw from spot trading account to an external address.
        /// </summary>
        /// <param name="request"></param>
        /// <returns>WithdrawCurrencyResponse</returns>
        public async Task<WithdrawCurrencyResponse> WithdrawCurrencyAsync(WithdrawRequest request)
        {
            string url = _urlBuilder.Build(POST_METHOD, "/v1/dw/withdraw/api/create");

            return await _httpRequestClient.PostAsync<WithdrawCurrencyResponse>(url, request.ToJson());
        }

        /// <summary>
        /// Cancels a previously created withdraw request by its transfer id.
        /// </summary>
        /// <param name="withdrawId">The transfer id returned when create withdraw request</param>
        /// <returns>CancelWithdrawCurrencyResponse</returns>
        public async Task<CancelWithdrawCurrencyResponse> CancelWithdrawCurrencyAsync(long withdrawId)
        {
            string url = _urlBuilder.Build(POST_METHOD, $"/v1/dw/withdraw-virtual/{withdrawId}/cancel");

            return await _httpRequestClient.PostAsync<CancelWithdrawCurrencyResponse>(url);
        }

        /// <summary>
        /// Returns all existed withdraws and deposits and return their latest status.
        /// </summary>
        /// <param name="request"></param>
        /// <returns>GetDepositWithdrawHistoryResponse</returns>
        public async Task<GetDepositWithdrawHistoryResponse> GetDepositWithdrawHistoryAsync(GetRequest request)
        {
            string url = _urlBuilder.Build(GET_METHOD, "/v1/query/deposit-withdraw", request);

            return await _httpRequestClient.GetAsync<GetDepositWithdrawHistoryResponse>(url);
        }
    }
}
