using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Huobi.SDK.Model.Response.Margin
{
    /// <summary>
    /// GetCrossMarginAccount response
    /// </summary>
    public class GetCrossMarginAccountResponse
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
        [JsonConverter(typeof(SingleOrArrayConverter<Account>))]
        public List<Account> data;

        /// <summary>
        /// Loan info
        /// </summary>
        public class Account
        {
            /// <summary>
            /// Account id
            /// </summary>
            public int id;

            /// <summary>
            /// Account type: cross-margin
            /// </summary>
            public string type;

            /// <summary>
            /// Loan state
            /// Possible values: [created, accrual, cleared, invalid]
            /// </summary>
            public string state;

            /// <summary>
            /// Sum of all account balance
            /// </summary>
            [JsonPropertyName("acct-balance-sum")]
            public string AcctBalanceSum;

            /// <summary>
            /// Sum of all debt balance
            /// </summary>
            [JsonPropertyName("debt-balance-sum")]
            public string DebtBalanceSum;

            /// <summary>
            /// The list of margin accounts and their details
            /// </summary>
            public AccountDetail[] list;

            /// <summary>
            /// Currency detail
            /// </summary>
            public class AccountDetail
            {
                /// <summary>
                /// The currency of this balance
                /// </summary>
                public string currency;

                /// <summary>
                /// The balance type
                /// </summary>
                public string type;

                /// <summary>
                /// The balance in the main currency unit
                /// </summary>
                public string balance;
            }
        }
    }
}