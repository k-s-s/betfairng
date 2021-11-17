﻿using Newtonsoft.Json;

namespace BetfairNG.Data
{
    public class RunnerProfitAndLoss
    {
        [JsonProperty(PropertyName = "ifLose")]
        public double IfLose { get; set; }

        [JsonProperty(PropertyName = "ifWin")]
        public double IfWin { get; set; }

        [JsonProperty(PropertyName = "selectionId")]
        public long SelectionId { get; set; }
    }
}