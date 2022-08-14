


namespace BetfairNG.Data
{
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumMemberConverter))]
    public enum RaceStatus
    {
        DORMANT,
        DELAYED,
        PARADING,
        GOINGDOWN,
        GOINGBEHIND,
        APPROACHING,
        GOINGINTRAPS,
        HARERUNNING,
        ATTHEPOST,
        OFF,
        FINISHED,
        FINALRESULT,
        FALSESTART,
        PHOTOGRAPH,
        RESULT,
        WEIGHEDIN,
        RACEVOID,
        NORACE,
        RERUN,
        ABANDONED,
    }
}