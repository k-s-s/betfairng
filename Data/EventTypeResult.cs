
using System.Text;

namespace BetfairNG.Data
{
    public class EventTypeResult
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "eventType")]
        [System.Text.Json.Serialization.JsonPropertyName("eventType")]
        public EventType EventType { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "marketCount")]
        [System.Text.Json.Serialization.JsonPropertyName("marketCount")]
        public int MarketCount { get; set; }

        public override string ToString()
        {
            return new StringBuilder().AppendFormat("{0}", "EventTypeResult")
                        .AppendFormat(" : {0}", EventType)
                        .AppendFormat(" : MarketCount={0}", MarketCount)
                        .ToString();
        }
    }
}