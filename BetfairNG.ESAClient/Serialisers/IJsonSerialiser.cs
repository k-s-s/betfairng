using BetfairNG.ESAClient.Serialisers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace BetfairNG
{
    public static class JsonConvertNg
    {
        public static IJsonSerialiser DefaultSerialiser { get; } = new StjJsonSerialiser();
        //public static IJsonSerialiser DefaultSerialiser { get; } = new NewtonSoftJsonSerialiser();
        public static T Deserialize<T>(string json) => DefaultSerialiser.DeserialiseFromJson<T>(json);
        public static string Serialize<T>(T value) => DefaultSerialiser.SerialiseToJson(value);
    }
}

namespace BetfairNG.ESAClient.Serialisers
{
    public interface IJsonSerialiser
    {
        public T DeserialiseFromJson<T>(string json);
        public string SerialiseToJson<T>(T data);
    }
    public class NewtonSoftJsonSerialiser : IJsonSerialiser
    {
        public JsonSerializerSettings Options { get; set; }
        public NewtonSoftJsonSerialiser()
        {
            Options = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
            };
        }
        public T DeserialiseFromJson<T>(string json) => JsonConvert.DeserializeObject<T>(json);

        public string SerialiseToJson<T>(T data) => JsonConvert.SerializeObject(data);
    }
    public class StjJsonSerialiser : IJsonSerialiser
    {
        public JsonSerializerOptions Options { get; set; }
        public StjJsonSerialiser()
        {
            Options = new JsonSerializerOptions();
            Options.Converters.Add(new System.Text.Json.Serialization.JsonStringEnumMemberConverter());
            Options.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
            Options.PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase;
            //Options.Converters.Add(new System.Text.Json.Serialization.JsonMicrosoftDateTimeConverter());
        }

        public T DeserialiseFromJson<T>(string json) => System.Text.Json.JsonSerializer.Deserialize<T>(json, Options);

        public string SerialiseToJson<T>(T data) => System.Text.Json.JsonSerializer.Serialize(data, Options);
    }
    
}
