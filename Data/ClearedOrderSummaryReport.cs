
using System.Collections.Generic;

namespace BetfairNG.Data
{
    public class ClearedOrderSummaryReport
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "clearedOrders")]
        [System.Text.Json.Serialization.JsonPropertyName("clearedOrders")]
        public IList<ClearedOrderSummary> ClearedOrders { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "moreAvailable")]
        [System.Text.Json.Serialization.JsonPropertyName("moreAvailable")]
        public bool MoreAvailable { get; set; }
    }
}