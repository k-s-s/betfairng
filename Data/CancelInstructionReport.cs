
using System;

namespace BetfairNG.Data
{
    public class CancelInstructionReport
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "cancelledDate")]
        [System.Text.Json.Serialization.JsonPropertyName("cancelledDate")]
        public DateTime CancelledDate { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "errorCode")]
        [System.Text.Json.Serialization.JsonPropertyName("errorCode")]
        public InstructionReportErrorCode ErrorCode { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "instruction")]
        [System.Text.Json.Serialization.JsonPropertyName("instruction")]
        public CancelInstruction Instruction { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "sizeCancelled")]
        [System.Text.Json.Serialization.JsonPropertyName("sizeCancelled")]
        public double SizeCancelled { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public InstructionReportStatus Status { get; set; }
    }
}