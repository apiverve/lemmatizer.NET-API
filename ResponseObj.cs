using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Lemmas data
    /// </summary>
    public class Lemmas
    {
        [JsonProperty("cat")]
        public int Cat { get; set; }

        [JsonProperty("ran")]
        public int Ran { get; set; }

        [JsonProperty("door")]
        public int Door { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("found")]
        public int Found { get; set; }

        [JsonProperty("lemmas")]
        public Lemmas Lemmas { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
