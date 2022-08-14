
using System.Text;

namespace BetfairNG.Data
{
    public class PlaceInstruction
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "handicap")]
        [System.Text.Json.Serialization.JsonPropertyName("handicap")]
        public double? Handicap { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "limitOnCloseOrder")]
        [System.Text.Json.Serialization.JsonPropertyName("limitOnCloseOrder")]
        public LimitOnCloseOrder LimitOnCloseOrder { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "limitOrder")]
        [System.Text.Json.Serialization.JsonPropertyName("limitOrder")]
        public LimitOrder LimitOrder { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "marketOnCloseOrder")]
        [System.Text.Json.Serialization.JsonPropertyName("marketOnCloseOrder")]
        public MarketOnCloseOrder MarketOnCloseOrder { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "orderType")]
        [System.Text.Json.Serialization.JsonPropertyName("orderType")]
        public OrderType OrderType { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "selectionId")]
        [System.Text.Json.Serialization.JsonPropertyName("selectionId")]
        public long SelectionId { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "side")]
        [System.Text.Json.Serialization.JsonPropertyName("side")]
        public Side Side { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder()
                .AppendFormat("OrderType={0}", OrderType)
                .AppendFormat(" : SelectionId={0}", SelectionId)
                .AppendFormat(" : Handicap={0}", Handicap)
                .AppendFormat(" : Side={0}", Side);

            switch (OrderType)
            {
                case OrderType.LIMIT:
                    sb.AppendFormat(" : LimitOrder={0}", LimitOrder);
                    break;

                case OrderType.LIMIT_ON_CLOSE:
                    sb.AppendFormat(" : LimitOnCloseOrder={0}", LimitOnCloseOrder);
                    break;

                case OrderType.MARKET_ON_CLOSE:
                    sb.AppendFormat(" : MarketOnCloseOrder={0}", MarketOnCloseOrder);
                    break;
            }

            return sb.ToString();
        }
    }
}