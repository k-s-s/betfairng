
using System;
using System.Text;

namespace BetfairNG.Data
{
    public class MarketDescription
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "bettingType")]
        [System.Text.Json.Serialization.JsonPropertyName("bettingType")]
        public MarketBettingType BettingType { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "clarifications")]
        [System.Text.Json.Serialization.JsonPropertyName("clarifications")]
        public string Clarifications { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "eachWayDivisor")]
        [System.Text.Json.Serialization.JsonPropertyName("eachWayDivisor")]
        public double EachWayDivisor { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "bspMarket")]
        [System.Text.Json.Serialization.JsonPropertyName("bspMarket")]
        public bool IsBspMarket { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "discountAllowed")]
        [System.Text.Json.Serialization.JsonPropertyName("discountAllowed")]
        public bool IsDiscountAllowed { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "persistenceEnabled")]
        [System.Text.Json.Serialization.JsonPropertyName("persistenceEnabled")]
        public bool IsPersistenceEnabled { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "turnInPlayEnabled")]
        [System.Text.Json.Serialization.JsonPropertyName("turnInPlayEnabled")]
        public bool IsTurnInPlayEnabled { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "marketBaseRate")]
        [System.Text.Json.Serialization.JsonPropertyName("marketBaseRate")]
        public double MarketBaseRate { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "marketTime")]
        [System.Text.Json.Serialization.JsonPropertyName("marketTime")]
        public DateTime MarketTime { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "marketType")]
        [System.Text.Json.Serialization.JsonPropertyName("marketType")]
        public string MarketType { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "regulator")]
        [System.Text.Json.Serialization.JsonPropertyName("regulator")]
        public string Regulator { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "rules")]
        [System.Text.Json.Serialization.JsonPropertyName("rules")]
        public string Rules { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "rulesHasDate")]
        [System.Text.Json.Serialization.JsonPropertyName("rulesHasDate")]
        public bool RulesHasDate { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "settleTime")]
        [System.Text.Json.Serialization.JsonPropertyName("settleTime")]
        public DateTime? SettleTime { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "suspendTime")]
        [System.Text.Json.Serialization.JsonPropertyName("suspendTime")]
        public DateTime? SuspendTime { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "wallet")]
        [System.Text.Json.Serialization.JsonPropertyName("wallet")]
        public string Wallet { get; set; }

        public override string ToString()
        {
            return new StringBuilder().AppendFormat("{0}", "MarketDescription")
                        .AppendFormat(" : BspMarket={0}", IsBspMarket)
                        .AppendFormat(" : BettingType={0}", BettingType)
                        .AppendFormat(" : MarketType={0}", MarketType)

                        .AppendFormat(" : MarketTime={0}", MarketTime)
                        .AppendFormat(" : SuspendTime={0}", SuspendTime)
                        .AppendFormat(" : SettleTime={0}", SettleTime)
                        .AppendFormat(" : MarketBaseRate={0}", MarketBaseRate)

                        .AppendFormat(" : IsPersistenceEnabled={0}", IsPersistenceEnabled)
                        .AppendFormat(" : IsTurnInPlayEnabled={0}", IsTurnInPlayEnabled)
                        .AppendFormat(" : IsDiscountAllowed={0}", IsDiscountAllowed)

                        .AppendFormat(" : Regulator={0}", Regulator)
                        .AppendFormat(" : Rules={0}", Rules)
                        .AppendFormat(" : RulesHasDate={0}", RulesHasDate)
                        .AppendFormat(" : Clarifications={0}", Clarifications)

                        .AppendFormat(" : Wallet={0}", Wallet)
                        .ToString();
        }
    }
}