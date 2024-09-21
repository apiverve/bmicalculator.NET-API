using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("height")]
    public string height { get; set; }

    [JsonProperty("weight")]
    public string weight { get; set; }

    [JsonProperty("bmi")]
    public double bmi { get; set; }

    [JsonProperty("risk")]
    public string risk { get; set; }

    [JsonProperty("summary")]
    public string summary { get; set; }

    [JsonProperty("recommendation")]
    public string recommendation { get; set; }

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
