using System.Text.Json.Nodes;

namespace BetfairNG.Data.Exceptions
{
    public class Exception
    {
        // exception in json-rpc format
        [Newtonsoft.Json.JsonProperty(PropertyName = "data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public JsonObject Data { get; set; }		// actual exception details

        // exception in rescript format
        [Newtonsoft.Json.JsonProperty(PropertyName = "detail")]
        [System.Text.Json.Serialization.JsonPropertyName("detail")]
        public JsonObject Detail { get; set; }		// actual exception details
    }
}