using System.Text.Json.Serialization;

namespace Huobi.SDK.Model.Response.Common
{
    /// <summary>
    /// GetSymbols response
    /// </summary>
    public class GetSymbolsResponse
    {
        /// <summary>
        /// Response status
        /// </summary>
        public string status;

        /// <summary>
        /// Response body
        /// </summary>
        public Symbol[] data;

        /// <summary>
        /// Trading symbol
        /// </summary>
        public class Symbol
        {
            /// <summary>
            /// Base currency in a trading symbol
            /// </summary>
            [JsonPropertyName("base-currency")]
            public string baseCurrency;

            /// <summary>
            /// Quote currency in a trading symbol
            /// </summary>
            [JsonPropertyName("quote-currency")]
            public string quoteCurrency;

            /// <summary>
            /// Quote currency precision when quote price(decimal places)
            /// </summary>
            [JsonPropertyName("price-precision")]
            public int pricePrecision;

            /// <summary>
            /// Base currency precision when quote amount(decimal places)
            /// </summary>
            [JsonPropertyName("amount-precision")]
            public int amountPrecision;

            /// <summary>
            /// Trading section
            /// Possible values: [main，innovation]
            /// </summary>
            [JsonPropertyName("symbol-partition")]
            public string symbolPartition;

            /// <summary>
            /// Trading symbol
            /// </summary>
            [JsonPropertyName("symbol")]
            public string symbol;

            /// <summary>
            /// The status of the symbol；Allowable values: [online，offline,suspend].
            /// "online" - Listed, available for trading,
            /// "offline" - de-listed, not available for trading，
            /// "suspend"-suspended for trading
            /// </summary>
            [JsonPropertyName("state")]
            public string state;

            /// <summary>
            /// Precision of value in quote currency (value = price * amount)
            /// </summary>
            [JsonPropertyName("value-precision")]
            public int valuePrecision;

            /// <summary>
            /// Minimum order amount of limit order in base currency
            /// </summary>
            [JsonPropertyName("limit-order-min-order-amt")]
            public double limitOrderMinOrderAmt;

            /// <summary>
            /// Max order amount of limit order in base currency
            /// </summary>
            [JsonPropertyName("limit-order-max-order-amt")]
            public double limitOrderMaxOrderAmt;

            /// <summary>
            /// Minimum order amount of sell-market order in base currency 
            /// </summary>
            [JsonPropertyName("sell-market-min-order-amt")]
            public double sellMarketMinOrderAmt;

            /// <summary>
            /// Max order amount of sell-market order in base currency 
            /// </summary>
            [JsonPropertyName("sell-market-max-order-amt")]
            public double sellMarketMaxOrderAmt;

            /// <summary>
            /// Max order value of buy-market order in quote currency
            /// </summary>
            [JsonPropertyName("buy-market-max-order-value")]
            public double buyMarketMaxOrderValue;

            /// <summary>
            /// Minimum order value of limit order and buy-market order in quote currency
            /// </summary>
            [JsonPropertyName("min-order-value")]
            public double minOrderValue;

            /// <summary>
            /// Max order value of limit order and buy-market order in USDT
            /// </summary>
            [JsonPropertyName("max-order-value")]
            public double maxOrderValue;

            /// <summary>
            /// The applicable leverage ratio
            /// </summary>
            [JsonPropertyName("leverage-ratio")]
            public double leverageRatio;

            /// <summary>
            /// Underlying ETP code (only valid for ETP symbols)
            /// </summary>
            public string underlying;

            /// <summary>
            /// Position charge rate (only valid for ETP symbols)
            /// </summary>
            [JsonPropertyName("mgmt-fee-rate")]
            public double mgmtFeeRate;

            /// <summary>
            /// Position charging time (in GMT+8, in format HH:MM:SS, only valid for ETP symbols)
            /// </summary>
            [JsonPropertyName("charge-time")]
            public string chargeTime;

            /// <summary>
            /// Regular position rebalance time (in GMT+8, in format HH:MM:SS, only valid for ETP symbols)
            /// </summary>
            [JsonPropertyName("rebal-time")]
            public string rebalTime;

            /// <summary>
            /// The threshold which triggers adhoc position rebalance (evaluated by actual leverage ratio, only valid for ETP symbols)
            /// </summary>
            [JsonPropertyName("rebal-threshold")]
            public double rebalThreshold;

            /// <summary>
            /// Initial NAV (only valid for ETP symbols)
            /// </summary>
            [JsonPropertyName("init-nav")]
            public double initNav;

            /// <summary>
            /// API trading enabled or not (possible value: enabled, disabled)
            /// </summary>
            [JsonPropertyName("api-trading")]
            public string apiTrading;
        }
    }
}
