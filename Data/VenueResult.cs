

namespace BetfairNG.Data
{
    public class VenueResult
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "marketCount")]
        [System.Text.Json.Serialization.JsonPropertyName("marketCount")]
        public int MarketCount { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "venue")]
        [System.Text.Json.Serialization.JsonPropertyName("venue")]
        public string Venue { get; set; }
    }
}