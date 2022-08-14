


namespace BetfairNG.Data
{
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumMemberConverter))]
    public enum OrderBy
    {
        BY_BET,
        BY_MARKET,
        BY_MATCH_TIME,
        BY_PLACE_TIME,
        BY_SETTLED_TIME,
        BY_VOID_TIME,
    }
}