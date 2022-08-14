using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Betfair.ESASwagger
{
    public static class Extensions
    {
        private static readonly JsonSerializerOptions _jsonOpts;

        static Extensions()
        {
            _jsonOpts = new JsonSerializerOptions();
            _jsonOpts.Converters.Add(new System.Text.Json.Serialization.JsonStringEnumMemberConverter());
            _jsonOpts.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
            _jsonOpts.PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase;
            _jsonOpts.WriteIndented = true;
        }

        public static string ToJsonStj(this object item)
        {
            return System.Text.Json.JsonSerializer.Serialize(item, _jsonOpts);
        }
    }
}
