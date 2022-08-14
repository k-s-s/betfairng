
using System.Collections.Generic;

namespace BetfairNG.Data
{
    public class MarketFilter
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "bspOnly")]
        [System.Text.Json.Serialization.JsonPropertyName("bspOnly")]
        public bool? BspOnly { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "competitionIds")]
        [System.Text.Json.Serialization.JsonPropertyName("competitionIds")]
        public ISet<string> CompetitionIds { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "eventIds")]
        [System.Text.Json.Serialization.JsonPropertyName("eventIds")]
        public ISet<string> EventIds { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "eventTypeIds")]
        [System.Text.Json.Serialization.JsonPropertyName("eventTypeIds")]
        public ISet<string> EventTypeIds { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "exchangeIds")]
        [System.Text.Json.Serialization.JsonPropertyName("exchangeIds")]
        public ISet<string> ExchangeIds { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "inPlayOnly")]
        [System.Text.Json.Serialization.JsonPropertyName("inPlayOnly")]
        public bool? InPlayOnly { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "marketBettingTypes")]
        [System.Text.Json.Serialization.JsonPropertyName("marketBettingTypes")]
        public ISet<MarketBettingType> MarketBettingTypes { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "marketCountries")]
        [System.Text.Json.Serialization.JsonPropertyName("marketCountries")]
        public ISet<string> MarketCountries { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "marketIds")]
        [System.Text.Json.Serialization.JsonPropertyName("marketIds")]
        public ISet<string> MarketIds { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "marketStartTime")]
        [System.Text.Json.Serialization.JsonPropertyName("marketStartTime")]
        public TimeRange MarketStartTime { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "marketTypeCodes")]
        [System.Text.Json.Serialization.JsonPropertyName("marketTypeCodes")]
        public ISet<string> MarketTypeCodes { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "textQuery")]
        [System.Text.Json.Serialization.JsonPropertyName("textQuery")]
        public string TextQuery { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "turnInPlayEnabled")]
        [System.Text.Json.Serialization.JsonPropertyName("turnInPlayEnabled")]
        public bool? TurnInPlayEnabled { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "venues")]
        [System.Text.Json.Serialization.JsonPropertyName("venues")]
        public ISet<string> Venues { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "withOrders")]
        [System.Text.Json.Serialization.JsonPropertyName("withOrders")]
        public ISet<OrderStatus> WithOrders { get; set; }
    }
}