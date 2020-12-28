using System;
using Huobi.SDK.Core.Model;
using Huobi.SDK.Core.RequestBuilder;
using Xunit;

namespace Huobi.SDK.Core.Test.RequestBuilder
{
    public class WebSocketRequestBuilderV2Test
    {
        [Fact]
        public void Build_NullParam_Success()
        {
            var builder = new WebSocketV2RequestBuilder("access", "secret", "api.huobi.pro", "/ws/v2");

            string auth = builder.Build();

            var authReq = JsonSerializerEx.Deserialize<WebSocketAuthenticationRequestV2>(auth);

            Assert.Equal("req", authReq.action);
            Assert.Equal("auth", authReq.ch);
            Assert.Equal("api", authReq.@params.authType);
            Assert.Equal("access", authReq.@params.accessKey);
            Assert.Equal("HmacSHA256", authReq.@params.signatureMethod);
            Assert.Equal("2.1", authReq.@params.signatureVersion);
        }

        [Fact]
        public void Build_Time_Success()
        {
            var builder = new WebSocketV2RequestBuilder("access", "secret", "api.huobi.pro", "/ws/v2");

            DateTime utcTime = new DateTime(2019, 11, 21, 10, 0, 0);
            string auth = builder.Build(utcTime);

            var authReq = JsonSerializerEx.Deserialize<WebSocketAuthenticationRequestV2>(auth);

            Assert.Equal("req", authReq.action);
            Assert.Equal("auth", authReq.ch);
            Assert.Equal("api", authReq.@params.authType);
            Assert.Equal("access", authReq.@params.accessKey);
            Assert.Equal("HmacSHA256", authReq.@params.signatureMethod);
            Assert.Equal("2.1", authReq.@params.signatureVersion);
            Assert.Equal(utcTime.ToString("s"), authReq.@params.timestamp);
            Assert.Equal("1/d+cUIEh4tC0aXho86zu5QAxVzJaTe56mUiB275T0E=", authReq.@params.signature);
        }
    }
}