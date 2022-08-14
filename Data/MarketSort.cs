


namespace BetfairNG.Data
{
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumMemberConverter))]
    public enum MarketSort
    {
        MINIMUM_TRADED, MAXIMUM_TRADED, MINIMUM_AVAILABLE, MAXIMUM_AVAILABLE, FIRST_TO_START, LAST_TO_START,
    }
}