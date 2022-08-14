


namespace BetfairNG.Data
{
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumMemberConverter))]
    public enum MarketProjection
    {
        COMPETITION,
        EVENT,
        EVENT_TYPE,
        MARKET_DESCRIPTION,
        MARKET_START_TIME,
        RUNNER_DESCRIPTION,
        RUNNER_METADATA
    }
}