
using System;
using System.Text;

namespace BetfairNG.Data
{
    public class Order
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "avgPriceMatched")]
        [System.Text.Json.Serialization.JsonPropertyName("avgPriceMatched")]
        public double? AvgPriceMatched { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "betId")]
        [System.Text.Json.Serialization.JsonPropertyName("betId")]
        public string BetId { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "bspLiability")]
        [System.Text.Json.Serialization.JsonPropertyName("bspLiability")]
        public double? BspLiability { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "orderType")]
        [System.Text.Json.Serialization.JsonPropertyName("orderType")]
        public OrderType OrderType { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "persistenceType")]
        [System.Text.Json.Serialization.JsonPropertyName("persistenceType")]
        public PersistenceType PersistenceType { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "placedDate")]
        [System.Text.Json.Serialization.JsonPropertyName("placedDate")]
        public DateTime? PlacedDate { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "price")]
        [System.Text.Json.Serialization.JsonPropertyName("price")]
        public double Price { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "side")]
        [System.Text.Json.Serialization.JsonPropertyName("side")]
        public Side Side { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "size")]
        [System.Text.Json.Serialization.JsonPropertyName("size")]
        public double Size { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "sizeCancelled")]
        [System.Text.Json.Serialization.JsonPropertyName("sizeCancelled")]
        public double? SizeCancelled { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "sizeLapsed")]
        [System.Text.Json.Serialization.JsonPropertyName("sizeLapsed")]
        public double? SizeLapsed { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "sizeMatched")]
        [System.Text.Json.Serialization.JsonPropertyName("sizeMatched")]
        public double? SizeMatched { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "sizeRemaining")]
        [System.Text.Json.Serialization.JsonPropertyName("sizeRemaining")]
        public double? SizeRemaining { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "sizeVoided")]
        [System.Text.Json.Serialization.JsonPropertyName("sizeVoided")]
        public double? SizeVoided { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return new StringBuilder().AppendFormat("BetId={0}", BetId)

                        .AppendFormat(" : OrderType={0}", OrderType)
                        .AppendFormat(" : OrderStatus={0}", Status)
                        .AppendFormat(" : PersistenceType={0}", PersistenceType)
                        .AppendFormat(" : Side={0}", Side)
                        .AppendFormat(" : Size@Price={0}@{1}", SizeRemaining, Price)	// instead of simply Size
                        .AppendFormat(" : BspLiability={0}", BspLiability)

                        .AppendFormat(" : PlacedDate={0}", PlacedDate)
                        .AppendFormat(" : AvgPriceMatched={0}", AvgPriceMatched)

                        .AppendFormat(" : SizeMatched={0}", SizeMatched)
                        .AppendFormat(" : SizeRemaining={0}", SizeRemaining)
                        .AppendFormat(" : SizeLapsed={0}", SizeLapsed)
                        .AppendFormat(" : SizeCancelled={0}", SizeCancelled)
                        .AppendFormat(" : SizeVoided={0}", SizeVoided)

                        .ToString();
        }
    }
}