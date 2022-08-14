


namespace BetfairNG.Data
{
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumMemberConverter))]
    public enum MatchProjection
    {
        NO_ROLLUP, ROLLED_UP_BY_PRICE, ROLLED_UP_BY_AVG_PRICE
    }
}