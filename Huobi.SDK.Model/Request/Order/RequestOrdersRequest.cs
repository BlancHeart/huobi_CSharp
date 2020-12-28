using System.Text.Json.Serialization;

namespace Huobi.SDK.Model.Request.Order
{
    public class RequestOrdersRequest
    {
        public string op { get { return "req"; } }

        public string topic { get { return "orders.list"; } }

        public string cid;

        [JsonPropertyName("account-id")]
        public int AccountId;

        public string symbol;

        public string types;

        public string states;

        [JsonPropertyName("start-date")]
        public string StartDate;

        [JsonPropertyName("end-date")]
        public string EndDate;

        public string from;

        public string direct;

        public string size;
    }
}
