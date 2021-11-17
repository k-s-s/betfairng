﻿using Newtonsoft.Json;

namespace BetfairNG.Data
{
    public class UpdateInstruction
    {
        [JsonProperty(PropertyName = "betId")]
        public string BetId { get; set; }

        [JsonProperty(PropertyName = "newPersistenceType")]
        public PersistenceType NewPersistenceType { get; set; }
    }
}