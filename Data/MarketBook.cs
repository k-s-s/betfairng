
using System;
using System.Collections.Generic;

namespace BetfairNG.Data
{
    public class MarketBook
    {
        public MarketBook()
        {
            this.Created = DateTime.Now;
        }

        [Newtonsoft.Json.JsonProperty(PropertyName = "betDelay")]
        [System.Text.Json.Serialization.JsonPropertyName("betDelay")]
        public int BetDelay { get; set; }

        public DateTime Created { get; set; }

        public int DbId { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "bspReconciled")]
        [System.Text.Json.Serialization.JsonPropertyName("bspReconciled")]
        public bool IsBspReconciled { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "complete")]
        [System.Text.Json.Serialization.JsonPropertyName("complete")]
        public bool IsComplete { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "crossMatching")]
        [System.Text.Json.Serialization.JsonPropertyName("crossMatching")]
        public bool IsCrossMatching { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "inplay")]
        [System.Text.Json.Serialization.JsonPropertyName("inplay")]
        public bool IsInplay { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "isMarketDataDelayed")]
        [System.Text.Json.Serialization.JsonPropertyName("isMarketDataDelayed")]
        public bool IsMarketDataDelayed { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "runnersVoidable")]
        [System.Text.Json.Serialization.JsonPropertyName("runnersVoidable")]
        public bool IsRunnersVoidable { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "lastMatchTime")]
        [System.Text.Json.Serialization.JsonPropertyName("lastMatchTime")]
        public DateTime? LastMatchTime { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "marketId")]
        [System.Text.Json.Serialization.JsonPropertyName("marketId")]
        public string MarketId { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "numberOfActiveRunners")]
        [System.Text.Json.Serialization.JsonPropertyName("numberOfActiveRunners")]
        public int NumberOfActiveRunners { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "numberOfRunners")]
        [System.Text.Json.Serialization.JsonPropertyName("numberOfRunners")]
        public int NumberOfRunners { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "numberOfWinners")]
        [System.Text.Json.Serialization.JsonPropertyName("numberOfWinners")]
        public int NumberOfWinners { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "runners")]
        [System.Text.Json.Serialization.JsonPropertyName("runners")]
        public List<Runner> Runners { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public MarketStatus Status { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "totalAvailable")]
        [System.Text.Json.Serialization.JsonPropertyName("totalAvailable")]
        public double TotalAvailable { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "totalMatched")]
        [System.Text.Json.Serialization.JsonPropertyName("totalMatched")]
        public double TotalMatched { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "version")]
        [System.Text.Json.Serialization.JsonPropertyName("version")]
        public long Version { get; set; }
    }
}