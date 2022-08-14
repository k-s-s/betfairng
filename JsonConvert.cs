
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

    public class JsonRequest
    {
        public JsonRequest()
        {
            JsonRpc = "2.0";
        }

        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public object Id { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "jsonrpc", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.Text.Json.Serialization.JsonPropertyName("jsonrpc")]
        public string JsonRpc { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "method")]
        [System.Text.Json.Serialization.JsonPropertyName("method")]
        public string Method { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "params")]
        [System.Text.Json.Serialization.JsonPropertyName("params")]
        public object Params { get; set; }
    }

    public class JsonResponse<T>
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "error", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Data.Exceptions.Exception Error { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public bool HasError
        {
            get { return Error != null; }
        }

        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public object Id { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "jsonrpc", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.Text.Json.Serialization.JsonPropertyName("jsonrpc")]
        public string JsonRpc { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "result", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public T Result { get; set; }
    }
}