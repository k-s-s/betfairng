using Newtonsoft.Json;
using System.IO;

namespace BetfairNG
{
    public static class JsonConvertExtensions
    {
        public static void Export(this JsonRequest request, TextWriter writer)
        {
            var json = JsonConvertNg.Serialize<JsonRequest>(request);
            writer.Write(json);
        }

        public static JsonResponse<T> Import<T>(TextReader reader)
        {
            var jsonResponse = reader.ReadToEnd();
            return JsonConvertNg.Deserialize<JsonResponse<T>>(jsonResponse);
        }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class JsonRequest
    {
        public JsonRequest()
        {
            JsonRpc = "2.0";
        }

        [JsonProperty(PropertyName = "id")]
        public object Id { get; set; }

        [JsonProperty(PropertyName = "jsonrpc", NullValueHandling = NullValueHandling.Ignore)]
        public string JsonRpc { get; set; }

        [JsonProperty(PropertyName = "method")]
        public string Method { get; set; }

        [JsonProperty(PropertyName = "params")]
        public object Params { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class JsonResponse<T>
    {
        [JsonProperty(PropertyName = "error", NullValueHandling = NullValueHandling.Ignore)]
        public Data.Exceptions.Exception Error { get; set; }

        [JsonIgnore]
        public bool HasError
        {
            get { return Error != null; }
        }

        [JsonProperty(PropertyName = "id")]
        public object Id { get; set; }

        [JsonProperty(PropertyName = "jsonrpc", NullValueHandling = NullValueHandling.Ignore)]
        public string JsonRpc { get; set; }

        [JsonProperty(PropertyName = "result", NullValueHandling = NullValueHandling.Ignore)]
        public T Result { get; set; }
    }
}