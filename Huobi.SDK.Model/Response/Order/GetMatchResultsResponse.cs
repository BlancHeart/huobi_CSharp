using System.Text.Json.Serialization;

namespace Huobi.SDK.Model.Response.Order
{
    /// <summary>
    /// GetMatchResults response
    /// </summary>
    public class GetMatchResultsResponse
    {
        /// <summary>
        /// Response status
        /// </summary>
        public string status;

        /// <summary>
        /// Error code
        /// </summary>
        [JsonPropertyName("err-code")]
        public string errorCode;

        /// <summary>
        /// Error message
        /// </summary>
        [JsonPropertyName("err-msg")]
        public string errorMessage;

        /// <summary>
        /// Response body
        /// </summary>
        
        public MatchResult[] data;

        /// <summary>
        /// Match result of an order
        /// </summary>
        public class MatchResult
        {
            /// <summary>
            /// Internal id
            /// </summary>
            public long id;

            /// <summary>
            /// Order id of this order
            /// </summary>
            [JsonPropertyName("order-id")]
            public long orderId;

            /// <summary>
            /// Match id of this match
            /// </summary>
            [JsonPropertyName("match-id")]
            public long matchId;

            /// <summary>
            /// Unique trade id (NEW)
            /// </summary>
            [JsonPropertyName("trade-id")]
            public long tradeId;

            /// <summary>
            /// Trading symbol
            /// </summary>
            public string symbol;

            /// <summary>
            /// The limit price of limit order
            /// </summary>
            
            public string price;

            /// <summary>
            /// The timestamp in milliseconds when the match and fill is done
            /// </summary>
            [JsonPropertyName("created-at")]
            public long createdAt;

            /// <summary>
            /// The order type
            /// Possible values: [buy-market, sell-market, buy-limit, sell-limit,
            ///         buy-ioc, sell-ioc, buy-limit-maker, sell-limit-maker,
            ///         buy-stop-limit, sell-stop-limit, buy-limit-fok, sell-limit-fok,
            ///         buy-stop-limit-fok, sell-stop-limit-fok]
            /// </summary>
            public string type;

            /// <summary>
            /// The amount which has been filled
            /// </summary>
            [JsonPropertyName("filled-amount")]
            public string filledAmount;
            
            /// <summary>
            /// Transaction fee paid so far
            /// </summary>
            [JsonPropertyName("filled-fees")]
            public string filledFees;

            /// <summary>
            /// Currency of transaction fee or transaction fee rebate
            /// </summary>
            [JsonPropertyName("fee-currency")]
            public string feeCurrency;

            /// <summary>
            /// The source where the order was triggered
            /// Possible values: [sys, web, api, app]
            /// </summary>
            public string source;

            /// <summary>
            /// The role in the transaction
            /// Possible values: [taker, maker]
            /// </summary>
            public string role;

            /// <summary>
            /// Deduction amount (unit: in ht or hbpoint)
            /// </summary>
            [JsonPropertyName("filled-points")]
            public string filledPoints;

            /// <summary>
            /// Deduction type. if blank, the transaction fee is based on original currency; if showing value as "ht", the transaction fee is deducted by HT; if showing value as "hbpoint", the transaction fee is deducted by HB point.
            /// </summary>
            [JsonPropertyName("fee-deduct-currency")]
            public string feeDeductCurrency;
        }
    }
}
