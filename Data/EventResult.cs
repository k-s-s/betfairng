
using System.Text;

namespace BetfairNG.Data
{
    public class EventResult
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "event")]
        [System.Text.Json.Serialization.JsonPropertyName("event")]
        public Event Event { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "marketCount")]
        [System.Text.Json.Serialization.JsonPropertyName("marketCount")]
        public int MarketCount { get; set; }

        public override string ToString()
        {
            return new StringBuilder().AppendFormat("{0}", "EventResult")
                        .AppendFormat(" : {0}", Event)
                        .AppendFormat(" : MarketCount={0}", MarketCount)
                        .ToString();
        }
    }
}