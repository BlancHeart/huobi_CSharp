using System.Text.Json.Serialization;

namespace Huobi.SDK.Model.Response.StableCoin
{
    /// <summary>
    /// ExchangeStableCoin response
    /// </summary>
    public class ExchangeStableCoinResponse
    {
        /// <summary>
        /// Response status
        /// </summary>
        public string status;

        /// <summary>
        /// Response body
        /// </summary>
        
        public Data data;

        public class Data
        {
            [JsonPropertyName("transact-id")]
            public long transactId;

            public string currency;

            public string amount;

            public string type;

            [JsonPropertyName("exchange-amount")]
            public string exchangeAmount;

            [JsonPropertyName("exchange-fee")]
            public string exchangeFee;

            public long time;
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
