using System.Text.Json.Serialization;

namespace Huobi.SDK.Model.Request.Order
{
    public class CancelOrdersByIdsRequest
    {
        [JsonPropertyName("order-ids")]
        public string[] OrderIds;

        [JsonPropertyName("client-order-ids")]
        public string[] ClientOrderIds;
    }
}
