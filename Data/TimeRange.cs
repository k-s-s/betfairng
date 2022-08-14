
using System;
using System.Text;

namespace BetfairNG.Data
{
    public class TimeRange
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "from")]
        [System.Text.Json.Serialization.JsonPropertyName("from")]
        public DateTime From { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "to")]
        [System.Text.Json.Serialization.JsonPropertyName("to")]
        public DateTime To { get; set; }

        public override string ToString()
        {
            return new StringBuilder().AppendFormat("{0}", "TimeRange")
                        .AppendFormat(" : From={0}", From)
                        .AppendFormat(" : To={0}", To)
                        .ToString();
        }
    }
}