

namespace BetfairNG.Data
{
    public class UpdateInstructionReport
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "errorCode")]
        [System.Text.Json.Serialization.JsonPropertyName("errorCode")]
        public InstructionReportErrorCode ErrorCode { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "instruction")]
        [System.Text.Json.Serialization.JsonPropertyName("instruction")]
        public UpdateInstruction Instruction { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public InstructionReportStatus Status { get; set; }
    }
}