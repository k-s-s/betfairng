

namespace BetfairNG.Data
{
    public class MarketVersion
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "version")]
        [System.Text.Json.Serialization.JsonPropertyName("version")]
        public long Version { get; set; }
    }
}