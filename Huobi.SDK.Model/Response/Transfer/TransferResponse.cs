using System.Text.Json.Serialization;

namespace Huobi.SDK.Model.Response.Transfer
{
    /// <summary>
    /// Transfer response
    /// </summary>
    public class TransferResponse
    {
        /// <summary>
        /// Response status
        /// </summary>
        public string status;

        /// <summary>
        /// Transfer id
        /// </summary>
        
        public long data;

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
