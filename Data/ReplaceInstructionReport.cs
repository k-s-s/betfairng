

namespace BetfairNG.Data
{
    public class ReplaceInstructionReport
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "cancelInstructionReport")]
        [System.Text.Json.Serialization.JsonPropertyName("cancelInstructionReport")]
        public CancelInstructionReport CancelInstructionReport { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "errorCode")]
        [System.Text.Json.Serialization.JsonPropertyName("errorCode")]
        public InstructionReportErrorCode ErrorCode { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "placeInstructionReport")]
        [System.Text.Json.Serialization.JsonPropertyName("placeInstructionReport")]
        public PlaceInstructionReport PlaceInstructionReport { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public InstructionReportStatus Status { get; set; }
    }
}