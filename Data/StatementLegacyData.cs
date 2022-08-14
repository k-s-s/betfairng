
using System;

namespace BetfairNG.Data
{
    public class StatementLegacyData
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "avgPrice")]
        [System.Text.Json.Serialization.JsonPropertyName("avgPrice")]
        public double AveragePrice { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "betCategoryType")]
        [System.Text.Json.Serialization.JsonPropertyName("betCategoryType")]
        public string BetCategoryType { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "betSize")]
        [System.Text.Json.Serialization.JsonPropertyName("betSize")]
        public double BetSize { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "betType")]
        [System.Text.Json.Serialization.JsonPropertyName("betType")]
        public string BetType { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "commissionRate")]
        [System.Text.Json.Serialization.JsonPropertyName("commissionRate")]
        public string CommissionRate { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "eventId")]
        [System.Text.Json.Serialization.JsonPropertyName("eventId")]
        public long EventId { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "eventTypeId")]
        [System.Text.Json.Serialization.JsonPropertyName("eventTypeId")]
        public long EventTypeId { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "fullMarketName")]
        [System.Text.Json.Serialization.JsonPropertyName("fullMarketName")]
        public string FullMarketName { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "grossBetAmount")]
        [System.Text.Json.Serialization.JsonPropertyName("grossBetAmount")]
        public double GrossBetAmount { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "marketName")]
        [System.Text.Json.Serialization.JsonPropertyName("marketName")]
        public string MarketName { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "marketType")]
        [System.Text.Json.Serialization.JsonPropertyName("marketType")]
        public string MarketType { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "placedDate")]
        [System.Text.Json.Serialization.JsonPropertyName("placedDate")]
        public DateTime PlacedDate { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "selectionId")]
        [System.Text.Json.Serialization.JsonPropertyName("selectionId")]
        public long SelectionId { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "selectionName")]
        [System.Text.Json.Serialization.JsonPropertyName("selectionName")]
        public string SelectionName { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "startDate")]
        [System.Text.Json.Serialization.JsonPropertyName("startDate")]
        public DateTime StartDate { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "transactionId")]
        [System.Text.Json.Serialization.JsonPropertyName("transactionId")]
        public long TransactionId { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "transactionType")]
        [System.Text.Json.Serialization.JsonPropertyName("transactionType")]
        public string TransactionType { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "winLose")]
        [System.Text.Json.Serialization.JsonPropertyName("winLose")]
        public string WinLose { get; set; }
    }
}