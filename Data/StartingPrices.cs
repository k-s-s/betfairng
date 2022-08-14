
using System.Collections.Generic;
using System.Text;

namespace BetfairNG.Data
{
    public class StartingPrices
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "actualSP")]
        [System.Text.Json.Serialization.JsonPropertyName("actualSP")]
        public double ActualSP { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "backStakeTaken")]
        [System.Text.Json.Serialization.JsonPropertyName("backStakeTaken")]
        public List<PriceSize> BackStakeTaken { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "farPrice")]
        [System.Text.Json.Serialization.JsonPropertyName("farPrice")]
        public double FarPrice { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "layLiabilityTaken")]
        [System.Text.Json.Serialization.JsonPropertyName("layLiabilityTaken")]
        public List<PriceSize> LayLiabilityTaken { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "nearPrice")]
        [System.Text.Json.Serialization.JsonPropertyName("nearPrice")]
        public double NearPrice { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder().AppendFormat("{0}", "StartingPrices")
                        .AppendFormat(" : NearPrice={0}", NearPrice)
                        .AppendFormat(" : FarPrice={0}", FarPrice)
                        .AppendFormat(" : ActualSP={0}", ActualSP);

            if (BackStakeTaken != null && BackStakeTaken.Count > 0)
            {
                int idx = 0;
                foreach (var backStake in BackStakeTaken)
                {
                    sb.AppendFormat(" : BackStake[{0}]={1}", idx++, backStake);
                }
            }

            if (LayLiabilityTaken != null && LayLiabilityTaken.Count > 0)
            {
                int idx = 0;
                foreach (var layLiability in LayLiabilityTaken)
                {
                    sb.AppendFormat(" : LayLiability{0}]={1}", idx++, layLiability);
                }
            }

            return sb.ToString();
        }
    }
}