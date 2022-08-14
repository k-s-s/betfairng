

namespace BetfairNG.Data
{
    public class RunnerProfitAndLoss
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "ifLose")]
        [System.Text.Json.Serialization.JsonPropertyName("ifLose")]
        public double IfLose { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "ifWin")]
        [System.Text.Json.Serialization.JsonPropertyName("ifWin")]
        public double IfWin { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "selectionId")]
        [System.Text.Json.Serialization.JsonPropertyName("selectionId")]
        public long SelectionId { get; set; }
    }
}