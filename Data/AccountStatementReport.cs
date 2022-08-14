
using System.Collections.Generic;

namespace BetfairNG.Data
{
    public class AccountStatementReport
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "accountStatement")]
        [System.Text.Json.Serialization.JsonPropertyName("accountStatement")]
        public IList<StatementItem> AccountStatement { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "moreAvailable")]
        [System.Text.Json.Serialization.JsonPropertyName("moreAvailable")]
        public bool MoreAvailable { get; set; }
    }
}