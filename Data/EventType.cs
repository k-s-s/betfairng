
using System.Text;

namespace BetfairNG.Data
{
    public class EventType
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

        public override string ToString()
        {
            return new StringBuilder().AppendFormat("{0}", "EventType")
                        .AppendFormat(" : Id={0}", Id)
                        .AppendFormat(" : Name={0}", Name)
                        .ToString();
        }
    }
}