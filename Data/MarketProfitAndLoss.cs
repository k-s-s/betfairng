
using System.Collections.Generic;

namespace BetfairNG.Data
{
    public class MarketProfitAndLoss
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "commissionApplied")]
        [System.Text.Json.Serialization.JsonPropertyName("commissionApplied")]
        public double CommissionApplied { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "marketId")]
        [System.Text.Json.Serialization.JsonPropertyName("marketId")]
        public string MarketId { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "profitAndLosses")]
        [System.Text.Json.Serialization.JsonPropertyName("profitAndLosses")]
        public List<RunnerProfitAndLoss> ProfitAndLosses { get; set; }
    }
}