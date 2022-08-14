
using System;

namespace BetfairNG.Data
{
    public class ItemDescription
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "eachWayDivisor")]
        [System.Text.Json.Serialization.JsonPropertyName("eachWayDivisor")]
        public double EachWayDivisor { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "eventDesc")]
        [System.Text.Json.Serialization.JsonPropertyName("eventDesc")]
        public string EventDesc { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "eventTypeDesc")]
        [System.Text.Json.Serialization.JsonPropertyName("eventTypeDesc")]
        public string EventTypeDesc { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "marketDesc")]
        [System.Text.Json.Serialization.JsonPropertyName("marketDesc")]
        public string MarketDesc { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "marketStartTime")]
        [System.Text.Json.Serialization.JsonPropertyName("marketStartTime")]
        public DateTime MarketStartTime { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "marketType")]
        [System.Text.Json.Serialization.JsonPropertyName("marketType")]
        public string MarketType { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "numberOfWinners")]
        [System.Text.Json.Serialization.JsonPropertyName("numberOfWinners")]
        public int NumberOfWinners { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "runnerDesc")]
        [System.Text.Json.Serialization.JsonPropertyName("runnerDesc")]
        public string RunnerDesc { get; set; }
    }
}