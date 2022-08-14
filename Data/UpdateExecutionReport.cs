
using System.Collections.Generic;

namespace BetfairNG.Data
{
    public class UpdateExecutionReport
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "customerRef")]
        [System.Text.Json.Serialization.JsonPropertyName("customerRef")]
        public string CustomerRef { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "errorCode")]
        [System.Text.Json.Serialization.JsonPropertyName("errorCode")]
        public InstructionReportErrorCode ErrorCode { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "instructionReports")]
        [System.Text.Json.Serialization.JsonPropertyName("instructionReports")]
        public IList<UpdateInstructionReport> InstructionReports { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "marketId")]
        [System.Text.Json.Serialization.JsonPropertyName("marketId")]
        public string MarketId { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public InstructionReportStatus Status { get; set; }
    }
}