

namespace BetfairNG.Data
{
    public class TimeRangeResult
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "marketCount")]
        [System.Text.Json.Serialization.JsonPropertyName("marketCount")]
        public int MarketCount { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "timeRange")]
        [System.Text.Json.Serialization.JsonPropertyName("timeRange")]
        public TimeRange TimeRange { get; set; }
    }
}