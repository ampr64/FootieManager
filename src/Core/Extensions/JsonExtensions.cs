using System;
using System.Text.Json;

namespace Domain.Extensions
{
    public static class JsonExtensions
    {
        private static readonly JsonSerializerOptions _options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        public static string ToJson(this object obj, JsonSerializerOptions options = null) =>
            JsonSerializer.Serialize(obj, obj.GetType(), options ?? _options);

        public static object FromJson(this string json, Type returnType, JsonSerializerOptions options = null) =>
            JsonSerializer.Deserialize(json, returnType, options ?? _options);

        public static T FromJson<T>(this string json, JsonSerializerOptions options = null) =>
            (T)FromJson(json, typeof(T), options);

        public static bool TryDeserialize<T>(this string json, out T result, JsonSerializerOptions options = null)
        {
            try
            {
                result = json.FromJson<T>(options);
                return true;
            }
            catch
            {
                result = default;
                return false;
            }
        }
    }
}
