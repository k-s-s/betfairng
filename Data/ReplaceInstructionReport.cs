﻿using Newtonsoft.Json;

namespace BetfairNG.Data
{
    public class ReplaceInstructionReport
    {
        [JsonProperty(PropertyName = "cancelInstructionReport")]
        public CancelInstructionReport CancelInstructionReport { get; set; }

        [JsonProperty(PropertyName = "errorCode")]
        public InstructionReportErrorCode ErrorCode { get; set; }

        [JsonProperty(PropertyName = "placeInstructionReport")]
        public PlaceInstructionReport PlaceInstructionReport { get; set; }

        [JsonProperty(PropertyName = "status")]
        public InstructionReportStatus Status { get; set; }
    }
}