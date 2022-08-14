
using System;

namespace BetfairNG.Data
{
    public class CurrentOrderSummary
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "averagePriceMatched")]
        [System.Text.Json.Serialization.JsonPropertyName("averagePriceMatched")]
        public double AveragePriceMatched { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "betId")]
        [System.Text.Json.Serialization.JsonPropertyName("betId")]
        public string BetId { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "bspLiability")]
        [System.Text.Json.Serialization.JsonPropertyName("bspLiability")]
        public double BspLiability { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "handicap")]
        [System.Text.Json.Serialization.JsonPropertyName("handicap")]
        public double Handicap { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "marketId")]
        [System.Text.Json.Serialization.JsonPropertyName("marketId")]
        public string MarketId { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "matchedDate")]
        [System.Text.Json.Serialization.JsonPropertyName("matchedDate")]
        public DateTime MatchedDate { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "orderType")]
        [System.Text.Json.Serialization.JsonPropertyName("orderType")]
        public OrderType OrderType { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "persistenceType")]
        [System.Text.Json.Serialization.JsonPropertyName("persistenceType")]
        public PersistenceType PersistenceType { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "placedDate")]
        [System.Text.Json.Serialization.JsonPropertyName("placedDate")]
        public DateTime PlacedDate { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "priceSize")]
        [System.Text.Json.Serialization.JsonPropertyName("priceSize")]
        public PriceSize PriceSize { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "regulatorAuthCode")]
        [System.Text.Json.Serialization.JsonPropertyName("regulatorAuthCode")]
        public string RegulatorAuthCode { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "regulatorCode")]
        [System.Text.Json.Serialization.JsonPropertyName("regulatorCode")]
        public string RegulatorCode { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "selectionId")]
        [System.Text.Json.Serialization.JsonPropertyName("selectionId")]
        public long SelectionId { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "side")]
        [System.Text.Json.Serialization.JsonPropertyName("side")]
        public Side Side { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "sizeCancelled")]
        [System.Text.Json.Serialization.JsonPropertyName("sizeCancelled")]
        public double SizeCancelled { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "sizeLapsed")]
        [System.Text.Json.Serialization.JsonPropertyName("sizeLapsed")]
        public double SizeLapsed { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "sizeMatched")]
        [System.Text.Json.Serialization.JsonPropertyName("sizeMatched")]
        public double SizeMatched { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "sizeRemaining")]
        [System.Text.Json.Serialization.JsonPropertyName("sizeRemaining")]
        public double SizeRemaining { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "sizeVoided")]
        [System.Text.Json.Serialization.JsonPropertyName("sizeVoided")]
        public double SizeVoided { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public OrderStatus Status { get; set; }
    }
}