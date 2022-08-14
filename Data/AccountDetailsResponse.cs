

namespace BetfairNG.Data
{
    public class AccountDetailsResponse
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "countryCode")]
        [System.Text.Json.Serialization.JsonPropertyName("countryCode")]
        public string CountryCode { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "currencyCode")]
        [System.Text.Json.Serialization.JsonPropertyName("currencyCode")]
        public string CurrencyCode { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "discountRate")]
        [System.Text.Json.Serialization.JsonPropertyName("discountRate")]
        public double DiscountRate { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "firstName")]
        [System.Text.Json.Serialization.JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "lastName")]
        [System.Text.Json.Serialization.JsonPropertyName("lastName")]
        public string LastName { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "localeCode")]
        [System.Text.Json.Serialization.JsonPropertyName("localeCode")]
        public string LocaleCode { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "pointsBalance")]
        [System.Text.Json.Serialization.JsonPropertyName("pointsBalance")]
        public int PointsBalance { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "region")]
        [System.Text.Json.Serialization.JsonPropertyName("region")]
        public string Region { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "timezone")]
        [System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string TimeZone { get; set; }
    }
}