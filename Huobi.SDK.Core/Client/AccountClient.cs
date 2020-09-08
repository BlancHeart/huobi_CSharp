﻿using System.Threading.Tasks;
using Huobi.SDK.Core.RequestBuilder;
using Huobi.SDK.Model.Request.Account;
using Huobi.SDK.Model.Response.Account;
using Huobi.SDK.Model.Response.Transfer;

namespace Huobi.SDK.Core.Client
{
    /// <summary>
    /// Responsible to operate account
    /// </summary>
    public class AccountClient
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
        public AccountClient(string accessKey, string secretKey, string host = DEFAULT_HOST)
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

            return await HttpRequest.GetAsync<GetAccountInfoResponse>(url);
        }

        /// <summary>
        /// Returns the balance of an account specified by account id
        /// </summary>
        /// <param name="accountId">account id</param>
        /// <returns>GetAccountBalanceResponse</returns>
        public async Task<GetAccountBalanceResponse> GetAccountBalanceAsync(string accountId)
        {
            string url = _urlBuilder.Build(GET_METHOD, $"/v1/account/accounts/{accountId}/balance");

            return await HttpRequest.GetAsync<GetAccountBalanceResponse>(url);
        }

        /// <summary>
        /// Parent user and sub user transfer asset between accounts.
        /// </summary>
        /// <param name="request">TransferAccountRequest</param>
        /// <returns>TransferAccountResponse</returns>
        public async Task<TransferAccountResponse> TransferAccountAsync(TransferAccountRequest request)
        {
            string url = _urlBuilder.Build(POST_METHOD, "/v1/account/transfer");

            return await HttpRequest.PostAsync<TransferAccountResponse>(url, request.ToJson());
        }

        /// <summary>
        /// Returns the amount changes of specified user's account
        /// </summary>
        /// <param name="request"></param>
        /// <returns>GetAccountHistoryResponse</returns>
        public async Task<GetAccountHistoryResponse> GetAccountHistoryAsync(GetRequest request)
        {
            string url = _urlBuilder.Build(GET_METHOD, "/v1/account/history", request);

            return await HttpRequest.GetAsync<GetAccountHistoryResponse>(url);
        }

        /// <summary>
        /// Returns the amount changes of specified user's account
        /// </summary>
        /// <param name="request"></param>
        /// <returns>GetAccountHistoryResponse</returns>
        public async Task<GetAccountLedgerResponse> GetAccountLedgerAsync(GetRequest request)
        {
            string url = _urlBuilder.Build(GET_METHOD, "/v2/account/ledger", request);

            return await HttpRequest.GetAsync<GetAccountLedgerResponse>(url);
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

            return await HttpRequest.PostAsync<TransferResponse>(url, content);
        }
    }
}
