
using System.Collections.Generic;

namespace BetfairNG.Data
{
    public class PriceProjection
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "exBestOffersOverrides")]
        [System.Text.Json.Serialization.JsonPropertyName("exBestOffersOverrides")]
        public ExBestOffersOverrides ExBestOffersOverrides { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "priceData")]
        [System.Text.Json.Serialization.JsonPropertyName("priceData")]
        public ISet<PriceData> PriceData { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "rolloverStakes")]
        [System.Text.Json.Serialization.JsonPropertyName("rolloverStakes")]
        public bool? RolloverStakes { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "virtualise")]
        [System.Text.Json.Serialization.JsonPropertyName("virtualise")]
        public bool? Virtualise { get; set; }
    }
}