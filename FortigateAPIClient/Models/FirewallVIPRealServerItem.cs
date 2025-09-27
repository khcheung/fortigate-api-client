using System.Text.Json.Serialization;

namespace FortigateAPIClient.Models
{
    public class FirewallVIPRealServerItem
    {
        [JsonPropertyName("id")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int id { get; set; }
        [JsonPropertyName("q_origin_key")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int q_origin_key { get; set; }
        [JsonPropertyName("type")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string type { get; set; } = string.Empty;
        [JsonPropertyName("address")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string address { get; set; } = string.Empty;
        [JsonPropertyName("ip")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string ip { get; set; } = string.Empty;
        [JsonPropertyName("port")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int port { get; set; }
        [JsonPropertyName("status")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string status { get; set; } = string.Empty;
        [JsonPropertyName("weight")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int weight { get; set; }
        [JsonPropertyName("holddowninterval")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int holddowninterval { get; set; }
        [JsonPropertyName("healthcheck")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string healthcheck { get; set; } = string.Empty;
        [JsonPropertyName("httphost")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string httphost { get; set; } = string.Empty;
        [JsonPropertyName("translate-host")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string translatehost { get; set; } = string.Empty;
        [JsonPropertyName("maxconnections")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int maxconnections { get; set; }
        [JsonPropertyName("monitor")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] monitor { get; set; }
        [JsonPropertyName("clientip")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string clientip { get; set; } = string.Empty;
    }

}
