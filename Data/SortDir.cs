﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BetfairNG.Data
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SortDir
    {
        EARLIEST_TO_LATEST,
        LATEST_TO_EARLIEST
    }
}