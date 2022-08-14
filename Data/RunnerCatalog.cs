
using System.Collections.Generic;
using System.Text;

namespace BetfairNG.Data
{
    public class RunnerCatalog
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "handicap")]
        [System.Text.Json.Serialization.JsonPropertyName("handicap")]
        public double Handicap { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "metadata")]
        [System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "runnerName")]
        [System.Text.Json.Serialization.JsonPropertyName("runnerName")]
        public string RunnerName { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "selectionId")]
        [System.Text.Json.Serialization.JsonPropertyName("selectionId")]
        public long SelectionId { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "sortPriority")]
        [System.Text.Json.Serialization.JsonPropertyName("sortPriority")]
        public int SortPriority { get; set; }

        public override string ToString()
        {
            return new StringBuilder().AppendFormat("{0}", "RunnerDescription")
                        .AppendFormat(" : SelectionId={0}", SelectionId)
                        .AppendFormat(" : runnerName={0}", RunnerName)
                        .AppendFormat(" : Handicap={0}", Handicap)
                        .AppendFormat(" : Metadata={0}", Metadata)
                        .ToString();
        }
    }
}