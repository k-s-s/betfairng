
using System.Text;

namespace BetfairNG.Data
{
    public class PriceSize
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "price")]
        [System.Text.Json.Serialization.JsonPropertyName("price")]
        public double Price { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "size")]
        [System.Text.Json.Serialization.JsonPropertyName("size")]
        public double Size { get; set; }

        public override string ToString()
        {
            return new StringBuilder().AppendFormat("{0}@{1}", Size, Price)
                        .ToString();
        }
    }
}