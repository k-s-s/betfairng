

namespace BetfairNG.Data
{
    public class UpdateInstruction
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "betId")]
        [System.Text.Json.Serialization.JsonPropertyName("betId")]
        public string BetId { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "newPersistenceType")]
        [System.Text.Json.Serialization.JsonPropertyName("newPersistenceType")]
        public PersistenceType NewPersistenceType { get; set; }
    }
}