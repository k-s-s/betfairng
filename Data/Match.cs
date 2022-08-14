
using System;
using System.Text;

namespace BetfairNG.Data
{
    public class Match
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "betId")]
        [System.Text.Json.Serialization.JsonPropertyName("betId")]
        public string BetId { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "matchDate")]
        [System.Text.Json.Serialization.JsonPropertyName("matchDate")]
        public DateTime MatchDate { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "price")]
        [System.Text.Json.Serialization.JsonPropertyName("price")]
        public double Price { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "side")]
        [System.Text.Json.Serialization.JsonPropertyName("side")]
        public Side Side { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "size")]
        [System.Text.Json.Serialization.JsonPropertyName("size")]
        public double Size { get; set; }

        public override string ToString()
        {
            return new StringBuilder()
                        .AppendFormat(" : BetId={0}", BetId)
                        .AppendFormat(" : Side={0}", Side)
                        .AppendFormat(" : Size@Price={0}@{1}", Size, Price)
                        .AppendFormat(" : MatchDate={0}", MatchDate)
                        .ToString();
        }
    }
}