


namespace BetfairNG.Data
{
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumMemberConverter))]
    public enum PriceData
    {
        SP_AVAILABLE,
        SP_TRADED,
        EX_BEST_OFFERS,
        EX_ALL_OFFERS,
        EX_TRADED,
    }
}