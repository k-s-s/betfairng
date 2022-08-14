

namespace BetfairNG.Data
{
    public class AccountFundsResponse
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "availableToBetBalance")]
        [System.Text.Json.Serialization.JsonPropertyName("availableToBetBalance")]
        public double AvailableToBetBalance { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "discountRate")]
        [System.Text.Json.Serialization.JsonPropertyName("discountRate")]
        public double DiscountRate { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "exposure")]
        [System.Text.Json.Serialization.JsonPropertyName("exposure")]
        public double Exposure { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "exposureLimit")]
        [System.Text.Json.Serialization.JsonPropertyName("exposureLimit")]
        public double ExposureLimit { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "pointsBalance")]
        [System.Text.Json.Serialization.JsonPropertyName("pointsBalance")]
        public double PointsBalance { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "retainedCommission")]
        [System.Text.Json.Serialization.JsonPropertyName("retainedCommission")]
        public double RetainedCommission { get; set; }
    }
}