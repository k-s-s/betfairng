
using System.Text;

namespace BetfairNG.Data
{
    public class LimitOrder
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "betTargetSize")]
        [System.Text.Json.Serialization.JsonPropertyName("betTargetSize")]
        public double? BetTargetSize { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "betTargetType")]
        [System.Text.Json.Serialization.JsonPropertyName("betTargetType")]
        public BetTargetType? BetTargetType { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "minFillSize")]
        [System.Text.Json.Serialization.JsonPropertyName("minFillSize")]
        public double? MinFillSize { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "persistenceType")]
        [System.Text.Json.Serialization.JsonPropertyName("persistenceType")]
        public PersistenceType PersistenceType { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "price")]
        [System.Text.Json.Serialization.JsonPropertyName("price")]
        public double Price { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "size")]
        [System.Text.Json.Serialization.JsonPropertyName("size")]
        public double Size { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "timeInForce")]
        [System.Text.Json.Serialization.JsonPropertyName("timeInForce")]
        public TimeInForce? TimeInForce { get; set; }

        public override string ToString()
        {
            return new StringBuilder()
                        .AppendFormat("Size={0}", Size)
                        .AppendFormat(" : Price={0}", Price)
                        .AppendFormat(" : PersistenceType={0}", PersistenceType)
                        .ToString();
        }
    }
}