

namespace BetfairNG.Data
{
    public class MarketTypeResult
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "marketCount")]
        [System.Text.Json.Serialization.JsonPropertyName("marketCount")]
        public int MarketCount { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "marketType")]
        [System.Text.Json.Serialization.JsonPropertyName("marketType")]
        public string MarketType { get; set; }
    }
}