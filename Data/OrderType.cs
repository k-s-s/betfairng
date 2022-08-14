


namespace BetfairNG.Data
{
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumMemberConverter))]
    public enum OrderType
    {
        LIMIT,				// normal exchange limit order for immediate execution
        LIMIT_ON_CLOSE,		// limit order for the auction (SP)
        MARKET_ON_CLOSE		// market order for the auction (SP)
    }
}