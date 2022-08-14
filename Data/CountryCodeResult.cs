

namespace BetfairNG.Data
{
    public class CountryCodeResult
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "countryCode")]
        [System.Text.Json.Serialization.JsonPropertyName("countryCode")]
        public string CountryCode { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "marketCount")]
        [System.Text.Json.Serialization.JsonPropertyName("marketCount")]
        public int MarketCount { get; set; }
    }
}