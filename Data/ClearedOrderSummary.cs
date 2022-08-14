
using System;

namespace BetfairNG.Data
{
    public class ClearedOrderSummary
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "betCount")]
        [System.Text.Json.Serialization.JsonPropertyName("betCount")]
        public int BetCount { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "betId")]
        [System.Text.Json.Serialization.JsonPropertyName("betId")]
        public string BetId { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "betOutcome")]
        [System.Text.Json.Serialization.JsonPropertyName("betOutcome")]
        public string BetOutcome { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "commission")]
        [System.Text.Json.Serialization.JsonPropertyName("commission")]
        public double Commission { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "customerStrategyRef")]
        [System.Text.Json.Serialization.JsonPropertyName("customerStrategyRef")]
        public string CustomerStrategyRef { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "eventId")]
        [System.Text.Json.Serialization.JsonPropertyName("eventId")]
        public string EventType { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "eventTypeId")]
        [System.Text.Json.Serialization.JsonPropertyName("eventTypeId")]
        public string EventTypeId { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "handicap")]
        [System.Text.Json.Serialization.JsonPropertyName("handicap")]
        public double Handicap { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "itemDescription")]
        [System.Text.Json.Serialization.JsonPropertyName("itemDescription")]
        public ItemDescription ItemDescription { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "lastMatchedDate")]
        [System.Text.Json.Serialization.JsonPropertyName("lastMatchedDate")]
        public DateTime LastMatchedDate { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "marketId")]
        [System.Text.Json.Serialization.JsonPropertyName("marketId")]
        public string MarketId { get; set; }

        // TODO:// could be a bug in doco -- should be OrderType enum?
        [Newtonsoft.Json.JsonProperty(PropertyName = "orderType")]
        [System.Text.Json.Serialization.JsonPropertyName("orderType")]
        public string OrderType { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "persistenceType")]
        [System.Text.Json.Serialization.JsonPropertyName("persistenceType")]
        public PersistenceType PersistenceType { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "placedDate")]
        [System.Text.Json.Serialization.JsonPropertyName("placedDate")]
        public DateTime PlacedDate { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "priceRequested")]
        [System.Text.Json.Serialization.JsonPropertyName("priceRequested")]
        public double Price { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "priceMatched")]
        [System.Text.Json.Serialization.JsonPropertyName("priceMatched")]
        public double PriceMatched { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "priceReduced")]
        [System.Text.Json.Serialization.JsonPropertyName("priceReduced")]
        public bool PriceReduced { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "profit")]
        [System.Text.Json.Serialization.JsonPropertyName("profit")]
        public double Profit { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "selectionId")]
        [System.Text.Json.Serialization.JsonPropertyName("selectionId")]
        public long SelectionId { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "settledDate")]
        [System.Text.Json.Serialization.JsonPropertyName("settledDate")]
        public DateTime SettledDate { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "side")]
        [System.Text.Json.Serialization.JsonPropertyName("side")]
        public Side Side { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "sizeCancelled")]
        [System.Text.Json.Serialization.JsonPropertyName("sizeCancelled")]
        public double SizeCancelled { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "sizeSettled")]
        [System.Text.Json.Serialization.JsonPropertyName("sizeSettled")]
        public double SizeSettled { get; set; }
    }
}