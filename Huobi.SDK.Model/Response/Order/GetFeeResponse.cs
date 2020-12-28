using System;
using System.Text.Json.Serialization;

namespace Huobi.SDK.Model.Response.Order
{
    /// <summary>
    /// GetFee response
    /// </summary>
    [Obsolete]
    public class GetFeeResponse
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
        
        public Fee[] data;

        /// <summary>
        /// Match result of an order
        /// </summary>
        public class Fee
        {
            /// <summary>
            /// Trading symbol
            /// </summary>
            public string symbol;

            /// <summary>
            /// Maker fee rate
            /// </summary>
            [JsonPropertyName("maker-fee")]
            public string makerFee;

            /// <summary>
            /// Taker fee rate
            /// </summary>
            [JsonPropertyName("taker-fee")]
            public string takerFee;
        }
    }
}
