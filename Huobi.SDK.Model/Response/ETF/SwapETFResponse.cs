using System.Text.Json.Serialization;

namespace Huobi.SDK.Model.Response.ETF
{
    /// <summary>
    /// SwapIn and SwapOut response
    /// </summary>
    public class SwapETFResponse
    {
        /// <summary>
        /// Status code
        /// </summary>
        public int code;

        /// <summary>
        /// Whether the response success or not
        /// </summary>
        public bool success;

        /// <summary>
        /// Error message (if any)
        /// </summary>
        
        public string message;

        /// <summary>
        /// Response body
        /// </summary>
        
        public object data;
    }
}
