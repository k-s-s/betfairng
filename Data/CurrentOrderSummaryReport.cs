
using System.Collections.Generic;

namespace BetfairNG.Data
{
    public class CurrentOrderSummaryReport
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "currentOrders")]
        [System.Text.Json.Serialization.JsonPropertyName("currentOrders")]
        public IList<CurrentOrderSummary> CurrentOrders { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "moreAvailable")]
        [System.Text.Json.Serialization.JsonPropertyName("moreAvailable")]
        public bool MoreAvailable { get; set; }
    }
}