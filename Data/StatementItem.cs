﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BetfairNG.Data
{
    public class StatementItem
    {
        [JsonProperty(PropertyName = "amount")]
        public double Amount { get; set; }

        [JsonProperty(PropertyName = "balance")]
        public double Balance { get; set; }

        [JsonProperty(PropertyName = "itemClass")]
        public ItemClass ItemClass { get; set; }

        [JsonProperty(PropertyName = "itemClassData")]
        public IDictionary<string, string> ItemClassData { get; set; }

        [JsonProperty(PropertyName = "itemDate")]
        public DateTime ItemDate { get; set; }

        [JsonProperty(PropertyName = "legacyData")]
        public StatementLegacyData LegacyData { get; set; }

        [JsonProperty(PropertyName = "refId")]
        public string RefId { get; set; }
    }
}