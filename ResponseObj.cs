using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class lemmas
{
    [JsonProperty("quick")]
    public int quick { get; set; }

    [JsonProperty("brown")]
    public int brown { get; set; }

    [JsonProperty("fox")]
    public int fox { get; set; }

    [JsonProperty("jump")]
    public int jump { get; set; }

    [JsonProperty("over")]
    public int over { get; set; }

    [JsonProperty("lazi")]
    public int lazi { get; set; }

    [JsonProperty("dog")]
    public int dog { get; set; }

    [JsonProperty("and")]
    public int and { get; set; }

    [JsonProperty("other")]
    public int other { get; set; }

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

}

}
