


namespace BetfairNG.Data
{
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumMemberConverter))]
    public enum ResponseCode
    {
        OK,
        NO_NEW_UPDATES,
        NO_LIVE_DATA_AVAILABLE,
        SERVICE_UNAVAILABLE,
        UNEXPECTED_ERROR,
        LIVE_DATA_TEMPORARILY_UNAVAILABLE,
    }
}