

namespace BetfairNG.Data
{
    public class ExBestOffersOverrides
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "bestPricesDepth")]
        [System.Text.Json.Serialization.JsonPropertyName("bestPricesDepth")]
        public int BestPricesDepth { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "rollupLiabilityFactor")]
        [System.Text.Json.Serialization.JsonPropertyName("rollupLiabilityFactor")]
        public int RollUpLiabilityFactor { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "rollupLiabilityThreshold")]
        [System.Text.Json.Serialization.JsonPropertyName("rollupLiabilityThreshold")]
        public double RollUpLiabilityThreshold { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "rollupLimit")]
        [System.Text.Json.Serialization.JsonPropertyName("rollupLimit")]
        public int RollUpLimit { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "rollupModel")]
        [System.Text.Json.Serialization.JsonPropertyName("rollupModel")]
        public RollUpModel RollUpModel { get; set; }
    }
}