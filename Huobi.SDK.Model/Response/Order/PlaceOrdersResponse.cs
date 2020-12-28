using System.Text.Json.Serialization;

namespace Huobi.SDK.Model.Response.Order
{
    /// <summary>
    /// PlaceMultipleOrders response
    /// </summary>
    public class PlaceOrdersResponse
    {
        /// <summary>
        /// Response status
        /// </summary>
        public string status;

        /// <summary>
        /// Response body
        /// </summary>
        
        public PlaceOrderResult[] data;

        /// <summary>
        /// place order result
        /// </summary>
        public class PlaceOrderResult
        {
            /// <summary>
            /// The order id
            /// </summary>
            [JsonPropertyName("order-id")]
            public long orderId;

            /// <summary>
            /// The client order id (if any)
            /// </summary>
            [JsonPropertyName("client-order-id")]
            public string clientOrderId;

            /// <summary>
            /// Error code for rejected order
            /// </summary>
            [JsonPropertyName("err-code")]
            public string errorCode;

            /// <summary>
            /// Error message for rejected order
            /// </summary>
            [JsonPropertyName("err-msg")]
            public string errorMessage;
        }

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
