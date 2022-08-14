

namespace BetfairNG.Data
{
    public class RunnerId
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "handicap")]
        [System.Text.Json.Serialization.JsonPropertyName("handicap")]
        public double Handicap { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "marketId")]
        [System.Text.Json.Serialization.JsonPropertyName("marketId")]
        public string MarketId { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "selectionId")]
        [System.Text.Json.Serialization.JsonPropertyName("selectionId")]
        public long SelectionId { get; set; }
    }
}