

namespace BetfairNG.Data
{
    public class CancelInstruction
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "betId")]
        [System.Text.Json.Serialization.JsonPropertyName("betId")]
        public string BetId { get; set; }

        /// <summary>
        /// https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Enums#BettingEnums-InstructionReportStatus
        /// https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-CancelInstruction see size reduction field
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sizeReduction")]
        [System.Text.Json.Serialization.JsonPropertyName("sizeReduction")]
        public double? SizeReduction { get; set; }
    }
}