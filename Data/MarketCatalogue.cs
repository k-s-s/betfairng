
using System;
using System.Collections.Generic;
using System.Text;

namespace BetfairNG.Data
{
    public class MarketCatalogue
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "competition")]
        [System.Text.Json.Serialization.JsonPropertyName("competition")]
        public Competition Competition { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public MarketDescription Description { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "event")]
        [System.Text.Json.Serialization.JsonPropertyName("event")]
        public Event Event { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "eventType")]
        [System.Text.Json.Serialization.JsonPropertyName("eventType")]
        public EventType EventType { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "isMarketDataDelayed")]
        [System.Text.Json.Serialization.JsonPropertyName("isMarketDataDelayed")]
        public bool IsMarketDataDelayed { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "marketId")]
        [System.Text.Json.Serialization.JsonPropertyName("marketId")]
        public string MarketId { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "marketName")]
        [System.Text.Json.Serialization.JsonPropertyName("marketName")]
        public string MarketName { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "marketStartTime")]
        [System.Text.Json.Serialization.JsonPropertyName("marketStartTime")]
        public DateTime MarketStartTime { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "runners")]
        [System.Text.Json.Serialization.JsonPropertyName("runners")]
        public List<RunnerCatalog> Runners { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "totalMatched")]
        [System.Text.Json.Serialization.JsonPropertyName("totalMatched")]
        public double TotalMatched { get; set; }

        public override string ToString()
        {
            // well, don't bother displaying event/event type/competition
            var sb = new StringBuilder().AppendFormat("{0}", "MarketCatalogue")
                        .AppendFormat(" : Market={0}[{1}]", MarketId, MarketName)
                        .AppendFormat(" : IsMarketDataDelayed={0}", IsMarketDataDelayed);

            if (Description != null)
            {
                sb.AppendFormat(" : {0}", Description);
            }

            if (Runners != null && Runners.Count > 0)
            {
                int idx = 0;
                foreach (var runner in Runners)
                {
                    sb.AppendFormat(" : Runner[{0}]={1}", idx++, runner);
                }
            }

            return sb.ToString();
        }
    }
}