
using System.Text;

namespace BetfairNG.Data
{
    public class MarketOnCloseOrder
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "liability")]
        [System.Text.Json.Serialization.JsonPropertyName("liability")]
        public double Liability { get; set; }

        public override string ToString()
        {
            return new StringBuilder()
                        .AppendFormat("liability={0}", Liability)
                        .ToString();
        }
    }
}