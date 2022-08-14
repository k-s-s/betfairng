
using System.Text;

namespace BetfairNG.Data
{
    public class CompetitionResult
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "competition")]
        [System.Text.Json.Serialization.JsonPropertyName("competition")]
        public Competition Competition { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "marketCount")]
        [System.Text.Json.Serialization.JsonPropertyName("marketCount")]
        public int MarketCount { get; set; }

        public override string ToString()
        {
            return new StringBuilder().AppendFormat("{0}", "CompetitionResult")
                        .AppendFormat(" : {0}", Competition)
                        .AppendFormat(" : MarketCount={0}", MarketCount)
                        .ToString();
        }
    }
}