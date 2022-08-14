

namespace BetfairNG.Data
{
    public class TransferResponse
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "transactionId")]
        [System.Text.Json.Serialization.JsonPropertyName("transactionId")]
        public string TransactionId { get; set; }
    }
}