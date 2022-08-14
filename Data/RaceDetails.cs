
using System;

namespace BetfairNG.Data
{
    public class RaceDetails
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastUpdated")]
        [System.Text.Json.Serialization.JsonPropertyName("lastUpdated")]
        public DateTime LastUpdated { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "meetingId")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingId")]
        public string MeetingId { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "raceId")]
        [System.Text.Json.Serialization.JsonPropertyName("raceId")]
        public string RaceId { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "raceStatus")]
        [System.Text.Json.Serialization.JsonPropertyName("raceStatus")]
        public RaceStatus RaceStatus { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "responseCode")]
        [System.Text.Json.Serialization.JsonPropertyName("responseCode")]
        public ResponseCode ResponseCode { get; set; }
    }
}