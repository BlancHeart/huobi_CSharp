using System.Text.Json.Serialization;

namespace Huobi.SDK.Model.Request.Order
{
    public class PlaceOrderRequest
    {
        [JsonPropertyName("account-id")]
        public string AccountId;

        public string symbol;

        public string type;

        public string amount;

        public string price;

        public string source;

        [JsonPropertyName("client-order-id")]
        public string ClientOrderId;

        [JsonPropertyName("stop-price")]
        public string StopPrice;

        [JsonPropertyName("operator")]
        public string Operator;
    }
}
