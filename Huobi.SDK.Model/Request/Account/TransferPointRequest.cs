using System.Text.Json.Serialization;

namespace Huobi.SDK.Model.Request.Account
{
    public class TransferPointRequest
    {
        public string fromUid;

        public string toUid;

        public long groupId;

        public string amount;
    }
}
