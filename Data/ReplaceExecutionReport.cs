
using System.Collections.Generic;
using System.Text;

namespace BetfairNG.Data
{
    public class ReplaceExecutionReport
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "customerRef")]
        [System.Text.Json.Serialization.JsonPropertyName("customerRef")]
        public string CustomerRef { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "errorCode")]
        [System.Text.Json.Serialization.JsonPropertyName("errorCode")]
        public ExecutionReportErrorCode ErrorCode { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "instructionReports")]
        [System.Text.Json.Serialization.JsonPropertyName("instructionReports")]
        public IList<ReplaceInstructionReport> InstructionReports { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "marketId")]
        [System.Text.Json.Serialization.JsonPropertyName("marketId")]
        public string MarketId { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public ExecutionReportStatus Status { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder()
                        .AppendFormat("{0}", "ReplaceExecutionReport")
                        .AppendFormat(" : Status={0}", Status)
                        .AppendFormat(" : ErrorCode={0}", ErrorCode)
                        .AppendFormat(" : MarketId={0}", MarketId)
                        .AppendFormat(" : CustomerRef={0}", CustomerRef);

            if (InstructionReports != null && InstructionReports.Count > 0)
            {
                int idx = 0;
                foreach (var instructionReport in InstructionReports)
                {
                    sb.AppendFormat(" : InstructionReport[{0}]={{{1}}}", idx++, instructionReport);
                }
            }

            return sb.ToString();
        }
    }
}