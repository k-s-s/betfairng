


namespace BetfairNG.Data
{
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumMemberConverter))]
    public enum IncludeItem
    {
        ALL,
        DEPOSITS_WITHDRAWALS,
        EXCHANGE,
        POKER_ROOM,
    }
}