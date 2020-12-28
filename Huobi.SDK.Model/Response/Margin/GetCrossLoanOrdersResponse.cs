using System;
using System.Text.Json.Serialization;

namespace Huobi.SDK.Model.Response.Margin
{
    /// <summary>
    /// GetCrossLoanOrders response
    /// </summary>
    public class GetCrossLoanOrdersResponse
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
            
            public LoanOrder[] data;

        /// <summary>
        /// Loan info
        /// </summary>
        public class LoanOrder
        {
            /// <summary>
            /// Order id
            /// </summary>
            public long id;

            /// <summary>
            /// Account id
            /// </summary>
            [JsonPropertyName("account-id")]
            public long accountId;

            /// <summary>
            /// User id
            /// </summary>
            [JsonPropertyName("user-id")]
            public long userId;
            
            /// <summary>
            /// The currency in the loan
            /// </summary>
            public string currency;

            /// <summary>
            /// Point deduction amount
            /// </summary>
            [JsonPropertyName("filled-points")]
            public string FilledPoints;

            /// <summary>
            /// HT deduction amount
            /// </summary>
            [JsonPropertyName("filled-ht")]
            public string FilledHt;

            /// <summary>
            /// The timestamp in milliseconds when the order was created
            /// </summary>
            [JsonPropertyName("created-at")]
            public long createdAt;

            /// <summary>
            /// The timestamp in milliseconds when the last accure happened
            /// </summary>
            [JsonPropertyName("accrued-at")]
            public long accruedAt;

            /// <summary>
            /// The amount of the origin loan
            /// </summary>
            [JsonPropertyName("loan-amount")]
            public string loanAmount;

            /// <summary>
            /// The amount of the loan left
            /// </summary>
            [JsonPropertyName("loan-balance")]
            public string loanBalance;

            /// <summary>
            /// The loan interest rate
            /// </summary>
            [JsonPropertyName("interest-rate")]
            public string interestRate;

            /// <summary>
            /// The accumulated loan interest
            /// </summary>
            [JsonPropertyName("interest-amount")]
            public string interestAmount;

            /// <summary>
            /// The amount of loan interest left
            /// </summary>
            [JsonPropertyName("interest-balance")]
            public string interestBalance;

            /// <summary>
            /// Loan state
            /// Possible values: [created, accrual, cleared, invalid]
            /// </summary>
            [JsonPropertyName("state")]
            public string state;
        }
    }
}
