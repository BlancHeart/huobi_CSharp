using System.Text.Json.Serialization;

namespace Huobi.SDK.Model.Response.Order
{
    /// <summary>
    /// CancelOrderByClientResponse response
    /// </summary>
    public class CancelOrderByClientResponse
    {
        /// <summary>
        /// Response status
        /// </summary>
        public string status;

        /// <summary>
        /// Cancellation status code
        /// </summary>
        
        public int data;

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
