

namespace BetfairNG.Data
{
    public class ReplaceInstruction
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "betId")]
        [System.Text.Json.Serialization.JsonPropertyName("betId")]
        public string BetId { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "newPrice")]
        [System.Text.Json.Serialization.JsonPropertyName("newPrice")]
        public double NewPrice { get; set; }
    }
}