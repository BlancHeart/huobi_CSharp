using System.Text.Json.Serialization;

namespace Huobi.SDK.Model.Request.Wallet
{
    public class WithdrawRequest
    {
        public string address;

        public string amount;

        public string currency;

        public string fee;

        public string chain;

        public string addrTag;
    }
}
