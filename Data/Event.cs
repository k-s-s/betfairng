
using System;
using System.Text;

namespace BetfairNG.Data
{
    public class Event
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "countryCode")]
        [System.Text.Json.Serialization.JsonPropertyName("countryCode")]
        public string CountryCode { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "openDate")]
        [System.Text.Json.Serialization.JsonPropertyName("openDate")]
        public DateTime? OpenDate { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "timezone")]
        [System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string Timezone { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "venue")]
        [System.Text.Json.Serialization.JsonPropertyName("venue")]
        public string Venue { get; set; }

        public override string ToString()
        {
            return new StringBuilder().AppendFormat("{0}", "Event")
                        .AppendFormat(" : Id={0}", Id)
                        .AppendFormat(" : Name={0}", Name)
                        .AppendFormat(" : CountryCode={0}", CountryCode)
                        .AppendFormat(" : Venue={0}", Venue)
                        .AppendFormat(" : Timezone={0}", Timezone)
                        .AppendFormat(" : OpenDate={0}", OpenDate)
                        .ToString();
        }
    }
}