
using System;
using System.Collections.Generic;
using System.Text;

namespace BetfairNG.Data
{
    public class Runner
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "adjustmentFactor")]
        [System.Text.Json.Serialization.JsonPropertyName("adjustmentFactor")]
        public double? AdjustmentFactor { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "ex")]
        [System.Text.Json.Serialization.JsonPropertyName("ex")]
        public ExchangePrices ExchangePrices { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "handicap")]
        [System.Text.Json.Serialization.JsonPropertyName("handicap")]
        public double? Handicap { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "lastPriceTraded")]
        [System.Text.Json.Serialization.JsonPropertyName("lastPriceTraded")]
        public double? LastPriceTraded { get; set; }

        public MarketBook MarketBook { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "matches")]
        [System.Text.Json.Serialization.JsonPropertyName("matches")]
        public List<Match> Matches { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "orders")]
        [System.Text.Json.Serialization.JsonPropertyName("orders")]
        public List<Order> Orders { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "removalDate")]
        [System.Text.Json.Serialization.JsonPropertyName("removalDate")]
        public DateTime? RemovalDate { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "selectionId")]
        [System.Text.Json.Serialization.JsonPropertyName("selectionId")]
        public long SelectionId { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "sp")]
        [System.Text.Json.Serialization.JsonPropertyName("sp")]
        public StartingPrices StartingPrices { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public RunnerStatus Status { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "totalMatched")]
        [System.Text.Json.Serialization.JsonPropertyName("totalMatched")]
        public double TotalMatched { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder().AppendFormat("SelectionId={0}", SelectionId)
                        .AppendFormat(" : Handicap={0}", Handicap)
                        .AppendFormat(" : Status={0}", Status)
                        .AppendFormat(" : AdjustmentFactor={0}", AdjustmentFactor)
                        .AppendFormat(" : LastPriceTraded={0}", LastPriceTraded)
                        .AppendFormat(" : TotalMatched={0}", TotalMatched)
                        .AppendFormat(" : RemovalDate={0}", RemovalDate);

            if (StartingPrices != null)
            {
                sb.AppendFormat(": {0}", StartingPrices);
            }

            if (ExchangePrices != null)
            {
                sb.AppendFormat(": {0}", ExchangePrices);
            }

            if (Orders != null && Orders.Count > 0)
            {
                int idx = 0;
                foreach (var order in Orders)
                {
                    sb.AppendFormat(" : Order[{0}]={1}", idx++, order);
                }
            }

            if (Matches != null && Matches.Count > 0)
            {
                int idx = 0;
                foreach (var match in Matches)
                {
                    sb.AppendFormat(" : Match[{0}]={1}", idx++, match);
                }
            }

            return sb.ToString();
        }
    }
}