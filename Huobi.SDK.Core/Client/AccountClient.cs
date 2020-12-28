using System.Net.Http;
using System.Threading.Tasks;
using Huobi.SDK.Core.RequestBuilder;
using Huobi.SDK.Model.Request.Account;
using Huobi.SDK.Model.Response.Account;
using Huobi.SDK.Model.Response.Transfer;

namespace Huobi.SDK.Core.Client
{
    /// <summary>
    /// Responsible to operate account
    /// </summary>
    public class AccountClient : BaseClient
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
        public AccountClient(string accessKey, string secretKey, HttpClient httpClient = null, string host = DEFAULT_HOST) : base(httpClient)
        {
            _urlBuilder = new PrivateUrlBuilder(accessKey, secretKey, host);
        }

        /// <summary>
        /// Returns a list of accounts owned by this API user
        /// </summary>
        /// <returns>GetAccountInfoResponse</returns>
        public async Task<GetAccountInfoResponse> GetAccountInfoAsync()
        {
            string url = _urlBuilder.Build(GET_METHOD, "/v1/account/accounts");

            return await _httpRequestClient.GetAsync<GetAccountInfoResponse>(url);
        }

        /// <summary>
        /// Returns the balance of an account specified by account id
        /// </summary>
        /// <param name="accountId">account id</param>
        /// <returns>GetAccountBalanceResponse</returns>
        public async Task<GetAccountBalanceResponse> GetAccountBalanceAsync(string accountId)
        {
            string url = _urlBuilder.Build(GET_METHOD, $"/v1/account/accounts/{accountId}/balance");

            return await _httpRequestClient.GetAsync<GetAccountBalanceResponse>(url);
        }

        /// <summary>
        /// Returns the balance of an account specified by account id
        /// </summary>
        /// <param name="accountType">The type of this account</param>
        /// <param name="valuationCurrency">The valuation according to the certain fiat currency</param>
        /// <param name="subUid">Sub User's UID.</param>
        /// <returns>GetAccountAssetValuationResponse</returns>
        public async Task<GetAccountAssetValuationResponse> GetAccountAssetValuationAsync(string accountType, string valuationCurrency = "BTC", long subUid = 0)
        {
            var request = new GetRequest()
                .AddParam("accountType", accountType);

            if (!string.IsNullOrEmpty(valuationCurrency))
            {
                request.AddParam("valuationCurrency", valuationCurrency);
            }
            if (subUid != 0)
            {
                request.AddParam("subUid", subUid.ToString());
            }

            string url = _urlBuilder.Build(GET_METHOD, $"/v2/account/asset-valuation", request);

            return await _httpRequestClient.GetAsync<GetAccountAssetValuationResponse>(url);
        }

        /// <summary>
        /// Parent user and sub user transfer asset between accounts.
        /// </summary>
        /// <param name="request">TransferAccountRequest</param>
        /// <returns>TransferAccountResponse</returns>
        public async Task<TransferAccountResponse> TransferAccountAsync(TransferAccountRequest request)
        {
            string url = _urlBuilder.Build(POST_METHOD, "/v1/account/transfer");

            return await _httpRequestClient.PostAsync<TransferAccountResponse>(url, JsonSerializerEx.Serialize(request));
        }

        /// <summary>
        /// Returns the amount changes of specified user's account
        /// </summary>
        /// <param name="request"></param>
        /// <returns>GetAccountHistoryResponse</returns>
        public async Task<GetAccountHistoryResponse> GetAccountHistoryAsync(GetRequest request)
        {
            string url = _urlBuilder.Build(GET_METHOD, "/v1/account/history", request);

            return await _httpRequestClient.GetAsync<GetAccountHistoryResponse>(url);
        }

        /// <summary>
        /// Returns the amount changes of specified user's account
        /// </summary>
        /// <param name="request"></param>
        /// <returns>GetAccountHistoryResponse</returns>
        public async Task<GetAccountLedgerResponse> GetAccountLedgerAsync(GetRequest request)
        {
            string url = _urlBuilder.Build(GET_METHOD, "/v2/account/ledger", request);

            return await _httpRequestClient.GetAsync<GetAccountLedgerResponse>(url);
        }

        /// <summary>
        /// Transfer fund from spot account to futrue contract account.
        /// </summary>
        /// <param name="currency">Currency name</param>
        /// <param name="amount">Amount of fund to transfer	</param>
        /// <returns>TransferResponse</returns>
        public async Task<TransferResponse> TransferFromSpotToFutureAsync(string currency, decimal amount)
        {
            return await TransferSpotAndFutureAsync(currency, amount, "pro-to-futures");
        }

        /// <summary>
        /// Transfer fund from future contract account spot account.
        /// </summary>
        /// <param name="currency">Currency name</param>
        /// <param name="amount">Amount of fund to transfer</param>
        /// <returns>TransferResponse</returns>
        public async Task<TransferResponse> TransferFromFutureToSpotAsync(string currency, decimal amount)
        {
            return await TransferSpotAndFutureAsync(currency, amount, "futures-to-pro");
        }

        /// <summary>
        /// transfer fund between spot account and future contract account
        /// </summary>
        /// <param name="currency">Currency name</param>
        /// <param name="amount">Amount of fund to transfer</param>
        /// <param name="type">Type of the transfer, possible values: [futures-to-pro, pro-to-futures]</param>
        /// <returns>TransferResponse</returns>
        private async Task<TransferResponse> TransferSpotAndFutureAsync(string currency, decimal amount, string type)
        {
            string url = _urlBuilder.Build(POST_METHOD, "/v1/futures/transfer");

            string content = $"{{ \"currency\": \"{currency}\", \"amount\":\"{amount}\", \"type\":\"{type}\" }}";

            return await _httpRequestClient.PostAsync<TransferResponse>(url, content);
        }

        /// <summary>
        /// Returns the point balance of specified user
        /// </summary>
        /// <param name="subUid"></param>
        /// <returns>GetPointBalanceResponse</returns>
        public async Task<GetPointBalanceResponse> GetPointBalanceAsync(string subUid = null)
        {
            GetRequest request = null;

            if (!string.IsNullOrEmpty(subUid))
            {
                request = new GetRequest();
                request.AddParam("subUid", subUid);
            }

            string url = _urlBuilder.Build(GET_METHOD, "/v2/point/account", request);

            return await _httpRequestClient.GetAsync<GetPointBalanceResponse>(url);
        }

        /// <summary>
        /// transfer point between parent user and sub user
        /// </summary>
        /// <param name="request"></param>
        /// <returns>TransferResponse</returns>
        public async Task<TransferPointResponse> TransferPointAsync(TransferPointRequest request)
        {
            string url = _urlBuilder.Build(POST_METHOD, "/v2/point/transfer");

            return await _httpRequestClient.PostAsync<TransferPointResponse>(url, JsonSerializerEx.Serialize(request));
        }
    }
}
