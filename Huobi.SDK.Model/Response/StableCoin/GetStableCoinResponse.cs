﻿using System.Text.Json.Serialization;

namespace Huobi.SDK.Model.Response.StableCoin
{
    public class GetStableCoinResponse
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
            /// <summary>
            /// Stable coin name (PAX/USDC/TUSD)
            /// </summary>
            public string currency;

            /// <summary>
            /// Amount of stable coin to exchange
            /// </summary>
            public string amount;

            /// <summary>
            /// Type of the exchange (buy/sell)
            /// </summary>
            public string type;

            /// <summary>
            /// Amount of HUSD to exchange in or out
            /// </summary>
            public string exchangeAmount;

            /// <summary>
            /// Exchange fee (in HUSD)
            /// </summary>
            public string exchangeFee;

            /// <summary>
            /// Stable currency quoteID
            /// </summary>
            public string quoteId;

            /// <summary>
            /// Term of validity
            /// </summary>
            public string expiration;
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
