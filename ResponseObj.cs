using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class lemmas
{
    [JsonProperty("cat")]
    public int cat { get; set; }

    [JsonProperty("ran")]
    public int ran { get; set; }

    [JsonProperty("door")]
    public int door { get; set; }

}

public class data
{
    [JsonProperty("found")]
    public int found { get; set; }

    [JsonProperty("lemmas")]
    public lemmas lemmas { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
