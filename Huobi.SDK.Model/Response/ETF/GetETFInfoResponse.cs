using System.Text.Json.Serialization;

namespace Huobi.SDK.Model.Response.ETF
{
    /// <summary>
    /// GetETFInfo response
    /// </summary>
    public class GetETFInfoResponse
    {
        /// <summary>
        /// Status code
        /// </summary>
        public int code;

        /// <summary>
        /// Whether the response success or not
        /// </summary>
        public bool success;

        /// <summary>
        /// Error message (if any)
        /// </summary>
        
        public string message;

        /// <summary>
        /// Response body
        /// </summary>
        public ETFInfo data;

        /// <summary>
        /// ETF info
        /// </summary>
        public class ETFInfo
        {
            /// <summary>
            /// ETF name
            /// </summary>
            [JsonPropertyName("etf_name")]
            public string etfName;

            /// <summary>
            /// status of the ETF
            /// Possible values: Normal(1), Rebalancing Start(2), Creation and Redemption Suspended(3), Creation Suspended(4), Redemption Suspended(5)
            /// </summary>
            [JsonPropertyName("etf_status")]
            public int etfStatus;

            /// <summary>
            /// Creation fee rate
            /// </summary>
            [JsonPropertyName("purchase_fee_rate")]
            public double purchaseFeeRate;

            /// <summary>
            /// Max creation amounts per request
            /// </summary>
            [JsonPropertyName("purchase_max_amount")]
            public int purchaseMaxAmount;

            /// <summary>
            /// Minimum creation amounts per request
            /// </summary>
            [JsonPropertyName("purchase_min_amount")]
            public int purchaseMinAmount;

            /// <summary>
            /// Redemption fee rate
            /// </summary>
            [JsonPropertyName("redemption_fee_rate")]
            public double redemptionFeeRate;

            /// <summary>
            /// Max redemption amounts per request
            /// </summary>
            [JsonPropertyName("redemption_max_amount")]
            public int redemptionMaxAmount;

            /// <summary>
            /// Minimum redemption amounts per request
            /// </summary>
            [JsonPropertyName("redemption_min_amount")]
            public int redemptionMinAmount;

            /// <summary>
            /// ETF constitution array
            /// </summary>
            [JsonPropertyName("unit_price")]
            public Price[] unitPrice;

            /// <summary>
            /// ETF constitution
            /// </summary>
            public class Price
            {
                /// <summary>
                /// Currency
                /// </summary>
                public string currency;

                /// <summary>
                /// Amount
                /// </summary>
                public double amount;
            }
        }
    }
}
