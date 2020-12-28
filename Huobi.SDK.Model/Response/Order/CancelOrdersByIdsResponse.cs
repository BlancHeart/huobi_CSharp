using System.Text.Json.Serialization;

namespace Huobi.SDK.Model.Response.Order
{
    /// <summary>
    /// CancelOrdersByIds response
    /// </summary>
    public class CancelOrdersByIdsResponse
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
            /// Cancelled order list
            /// </summary>
            public string[] success;

            /// <summary>
            /// Failed order list
            /// </summary>
            public FailedOrder[] failed;

            public class FailedOrder
            {
                /// <summary>
                /// Order id
                /// </summary>
                [JsonPropertyName("order-id")]
                public string orderId;

                /// <summary>
                /// Client order id
                /// </summary>
                [JsonPropertyName("client-order-id")]
                public string clientOrderId;

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
            }
        }
    }
}
