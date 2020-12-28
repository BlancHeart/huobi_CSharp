using System.Text.Json.Serialization;

namespace Huobi.SDK.Model.Response.Order
{
    /// <summary>
    /// PlaceOrder response
    /// </summary>
    public class PlaceOrderResponse
    {
        /// <summary>
        /// Response status
        /// </summary>
        public string status;

        /// <summary>
        /// Order id
        /// </summary>
        
        public string data;

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
