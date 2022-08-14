


namespace BetfairNG.Data
{
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumMemberConverter))]
    public enum PersistenceType
    {
        LAPSE,				// lapse the order at turn-in-play
        PERSIST,			// put the order into the auction (SP) at turn-in-play
        MARKET_ON_CLOSE,	// put the order into the auction (SP) at turn-in-play
    }
}