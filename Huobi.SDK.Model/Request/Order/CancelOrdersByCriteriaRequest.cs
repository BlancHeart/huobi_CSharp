using System.Text.Json.Serialization;

namespace Huobi.SDK.Model.Request.Order
{
    public class CancelOrdersByCriteriaRequest
    {
        [JsonPropertyName("account-id")]
        public string AccountId;

        public string symbol;

        public string side;

        public int size;
    }
}
