using System.Text.Json.Serialization;

namespace Huobi.SDK.Model.Request.Account
{
    public class TransferAccountRequest
    {
        [JsonPropertyName("from-user")]
        public long fromUser;

        [JsonPropertyName("from-account-type")]
        public string fromAccountType;

        [JsonPropertyName("from-account")]
        public long fromAccount;

        [JsonPropertyName("to-user")]
        public long toUser;

        [JsonPropertyName("to-account-type")]
        public string toAccountType;

        [JsonPropertyName("to-account")]
        public long toAccount;

        public string currency;

        public string amount;
    }
}
