
using System;
using System.Text;

namespace BetfairNG.Data
{
    public class PlaceInstructionReport
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "averagePriceMatched")]
        [System.Text.Json.Serialization.JsonPropertyName("averagePriceMatched")]
        public double? AveragePriceMatched { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "betId")]
        [System.Text.Json.Serialization.JsonPropertyName("betId")]
        public string BetId { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "errorCode")]
        [System.Text.Json.Serialization.JsonPropertyName("errorCode")]
        public InstructionReportErrorCode ErrorCode { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "instruction")]
        [System.Text.Json.Serialization.JsonPropertyName("instruction")]
        public PlaceInstruction Instruction { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "placedDate")]
        [System.Text.Json.Serialization.JsonPropertyName("placedDate")]
        public DateTime? PlacedDate { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "sizeMatched")]
        [System.Text.Json.Serialization.JsonPropertyName("sizeMatched")]
        public double? SizeMatched { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public InstructionReportStatus Status { get; set; }

        public override string ToString()
        {
            return new StringBuilder()
                        .AppendFormat("Status={0}", Status)
                        .AppendFormat(" : ErrorCode={0}", ErrorCode)
                        .AppendFormat(" : Instruction={{{0}}}", Instruction)
                        .AppendFormat(" : BetId={0}", BetId)
                        .AppendFormat(" : PlacedDate={0}", PlacedDate)
                        .AppendFormat(" : AveragePriceMatched={0}", AveragePriceMatched)
                        .AppendFormat(" : SizeMatched={0}", SizeMatched)
                        .ToString();
        }
    }
}