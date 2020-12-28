using System.Text.Json.Serialization;

namespace Huobi.SDK.Model.Response.Account
{
    /// <summary>
    /// GetAccountHistory response
    /// </summary>
    public class GetAccountHistoryResponse
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
        
        public History[] data;

        /// <summary>
        /// Account history
        /// </summary>
        public class History
        {
            /// <summary>
            /// Account id
            /// </summary>
            [JsonPropertyName("account-id")]
            public long accountId;

            /// <summary>
            /// Currency name
            /// </summary>
            public string currency;

            /// <summary>
            /// Amount change (positive value if income, negative value if outcome)
            /// </summary>
            [JsonPropertyName("transact-amt")]
            public string transactAmt;

            /// <summary>
            /// Amount change types
            /// Possible values: [trade,etf, transact-fee, deduction, transfer, credit, liquidation,
            ///     interest, deposit-withdraw, withdraw-fee, exchange, other-types]
            /// </summary>
            [JsonPropertyName("transact-type")]
            public string transactType;

            /// <summary>
            /// Available balance
            /// </summary>
            [JsonPropertyName("avail-balance")]
            public string availableBalance;

            /// <summary>
            /// Account balance
            /// </summary>
            [JsonPropertyName("acct-balance")]
            public string accountBalance;

            /// <summary>
            /// Transaction time (database time)
            /// </summary>
            [JsonPropertyName("transact-time")]
            public long transactTime;

            /// <summary>
            /// Unique record ID in the database
            /// </summary>
            [JsonPropertyName("record-id")]
            public string recordId;
        }

        /// <summary>
        /// First record ID in next page (only valid if exceeded page size)
        /// </summary>
        [JsonPropertyName("next-id")]
        public long nextId;
    }
}
