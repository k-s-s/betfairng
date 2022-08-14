
using System;
using System.Collections.Generic;

namespace BetfairNG.Data
{
    public class StatementItem
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public double Amount { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "balance")]
        [System.Text.Json.Serialization.JsonPropertyName("balance")]
        public double Balance { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "itemClass")]
        [System.Text.Json.Serialization.JsonPropertyName("itemClass")]
        public ItemClass ItemClass { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "itemClassData")]
        [System.Text.Json.Serialization.JsonPropertyName("itemClassData")]
        public IDictionary<string, string> ItemClassData { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "itemDate")]
        [System.Text.Json.Serialization.JsonPropertyName("itemDate")]
        public DateTime ItemDate { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "legacyData")]
        [System.Text.Json.Serialization.JsonPropertyName("legacyData")]
        public StatementLegacyData LegacyData { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "refId")]
        [System.Text.Json.Serialization.JsonPropertyName("refId")]
        public string RefId { get; set; }
    }
}