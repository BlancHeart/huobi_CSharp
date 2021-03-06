﻿using System.Text.Json.Serialization;

namespace Huobi.SDK.Model.Response.Margin
{
    /// <summary>
    /// GetIsolatedLoanInfo response
    /// </summary>
    public class GetIsolatedLoanInfoResponse
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
        
        public LoanInfo[] data;

        /// <summary>
        /// Loan info
        /// </summary>
        public class LoanInfo
        {
            /// <summary>
            /// Trading symbol
            /// </summary>
            public string symbol;

            /// <summary>
            /// Currency list
            /// </summary>
            public Currency[] currencies;

            /// <summary>
            /// Currency detail
            /// </summary>
            public class Currency
            {
                /// <summary>
                /// Currency name
                /// </summary>
                public string currency;

                /// <summary>
                /// Interest rate
                /// </summary>
                [JsonPropertyName("interest-rate")]
                public string interestRate;

                /// <summary>
                /// Minimal loanable amount
                /// </summary>
                [JsonPropertyName("min-loan-amt")]
                public string minLoadAmt;

                /// <summary>
                /// Maximum loanable amount
                /// </summary>
                [JsonPropertyName("max-loan-amt")]
                public string maxLoanAmt;

                /// <summary>
                /// Remaining loanable amount
                /// </summary>
                [JsonPropertyName("loanable-amt")]
                public string loanableAmt;

                /// <summary>
                /// Actual interest rate
                /// </summary>
                [JsonPropertyName("actual-rate")]
                public string ActualRate;
            }
        }
    }
}
