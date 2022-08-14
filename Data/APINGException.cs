
using System.Runtime.Serialization;

namespace BetfairNG.Data
{
    public class APINGException : System.Exception
    {
        protected APINGException(SerializationInfo info, StreamingContext context)
        {
            this.ErrorDetails = info.GetString("errorDetails");
            this.ErrorCode = info.GetString("errorCode");
            this.RequestUUID = info.GetString("requestUUID");
        }

        [Newtonsoft.Json.JsonProperty(PropertyName = "errorCode")]
        [System.Text.Json.Serialization.JsonPropertyName("errorCode")]
        public string ErrorCode { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "errorDetails")]
        [System.Text.Json.Serialization.JsonPropertyName("errorDetails")]
        public string ErrorDetails { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "requestUUID")]
        [System.Text.Json.Serialization.JsonPropertyName("requestUUID")]
        public string RequestUUID { get; set; }
    }
}