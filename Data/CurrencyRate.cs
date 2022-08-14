

namespace BetfairNG.Data
{
    public class CurrencyRate
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "currencyCode")]
        [System.Text.Json.Serialization.JsonPropertyName("currencyCode")]
        public string CurrencyCode { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "rate")]
        [System.Text.Json.Serialization.JsonPropertyName("rate")]
        public double Rate { get; set; }
    }
}