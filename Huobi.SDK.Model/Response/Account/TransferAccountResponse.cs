using System.Text.Json.Serialization;

namespace Huobi.SDK.Model.Response.Account
{
    public class TransferAccountResponse
    {
        public string status;

        [JsonPropertyName("err-code")]
        public string errCode;

        [JsonPropertyName("err-msg")]
        public string errMessage;

        public TransferResponse data;

        public class TransferResponse
        {
            [JsonPropertyName("transact-id")]
            public int transactId;

            [JsonPropertyName("transact-time")]
            public long transactTime;
        }
    }
}
