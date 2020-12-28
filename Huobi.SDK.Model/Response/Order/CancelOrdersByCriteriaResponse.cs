using System.Text.Json.Serialization;

namespace Huobi.SDK.Model.Response.Order
{
    /// <summary>
    /// CancelOrdersByCriteria response
    /// </summary>
    public class CancelOrdersByCriteriaResponse
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
        
        public Body data;

        /// <summary>
        /// Response body
        /// </summary>
        public class Body
        {
            /// <summary>
            /// The number of cancel request sent successfully
            /// </summary>
            [JsonPropertyName("success-count")]
            public int successCount;

            /// <summary>
            /// The number of cancel request failed
            /// </summary>
            [JsonPropertyName("failed-count")]
            public int failedCount;

            /// <summary>
            /// The next order id that can be cancelled
            /// </summary>
            [JsonPropertyName("next-id")]
            public int nextId;
        }
    }
}
