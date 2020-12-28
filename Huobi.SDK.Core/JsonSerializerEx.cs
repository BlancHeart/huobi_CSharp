using System.Text.Json;

namespace Huobi.SDK.Core
{
    public static class JsonSerializerEx
    {
        private static readonly JsonSerializerOptions _defaultOptions = new JsonSerializerOptions()
        {
            IncludeFields = true,
            //IgnoreNullValues = true
        };

        public static string Serialize(this object o)
        {
            return JsonSerializer.Serialize(o, _defaultOptions);
        }

        public static T Deserialize<T>(this string json)
        {
            return JsonSerializer.Deserialize<T>(json, _defaultOptions);
        }

        public static string Serialize(this object o, JsonSerializerOptions options)
        {
            return JsonSerializer.Serialize(o, options);
        }

        public static T Deserialize<T>(this string json, JsonSerializerOptions options)
        {
            return JsonSerializer.Deserialize<T>(json, options);
        }
    }
}
