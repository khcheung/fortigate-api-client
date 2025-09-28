using System.Text.Json.Serialization;

namespace FortigateAPIClient.Models
{
    public class SystemInterface
    {
        [JsonPropertyName("id")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string id { get; set; } = String.Empty;
        [JsonPropertyName("name")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string name { get; set; } = String.Empty;
        [JsonPropertyName("alias")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string alias { get; set; } = String.Empty;
        [JsonPropertyName("mac")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string mac { get; set; } = String.Empty;
        [JsonPropertyName("ip")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string ip { get; set; } = String.Empty;
        [JsonPropertyName("mask")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int mask { get; set; }
        [JsonPropertyName("link")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public bool link { get; set; }
        [JsonPropertyName("speed")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public float speed { get; set; }
        [JsonPropertyName("duplex")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int duplex { get; set; }
        [JsonPropertyName("tx_packets")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public decimal? tx_packets { get; set; }
        [JsonPropertyName("rx_packets")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public decimal? rx_packets { get; set; }
        [JsonPropertyName("tx_bytes")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public decimal? tx_bytes { get; set; }
        [JsonPropertyName("rx_bytes")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public decimal? rx_bytes { get; set; }
        [JsonPropertyName("tx_errors")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public decimal? tx_errors { get; set; }
        [JsonPropertyName("rx_errors")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public decimal? rx_errors { get; set; }
    }
}
