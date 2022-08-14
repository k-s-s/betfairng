
using System.Text;

namespace BetfairNG.Data
{
    public class LimitOnCloseOrder
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "liability")]
        [System.Text.Json.Serialization.JsonPropertyName("liability")]
        public double Liability { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "size")]
        [System.Text.Json.Serialization.JsonPropertyName("size")]
        public double Size { get; set; }

        public override string ToString()
        {
            return new StringBuilder()
                        .AppendFormat("Size={0}", Size)
                        .AppendFormat(" : Liability={0}", Liability)
                        .ToString();
        }
    }
}