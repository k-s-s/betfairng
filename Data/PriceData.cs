using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BetfairNG.Data
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PriceData
    {
        SP_AVAILABLE,
        SP_TRADED,
        EX_BEST_OFFERS,
        EX_ALL_OFFERS,
        EX_TRADED,
    }
}