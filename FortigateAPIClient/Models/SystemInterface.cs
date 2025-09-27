using System.Text.Json.Serialization;

namespace FortigateAPIClient.Models
{
    public class SystemInterface
    {
        [JsonPropertyName("id")] public string id { get; set; } = String.Empty;
        [JsonPropertyName("name")] public string name { get; set; } = String.Empty;
        [JsonPropertyName("alias")] public string alias { get; set; } = String.Empty;
        [JsonPropertyName("mac")] public string mac { get; set; } = String.Empty;
        [JsonPropertyName("ip")] public string ip { get; set; } = String.Empty;
        [JsonPropertyName("mask")] public int mask { get; set; }
        [JsonPropertyName("link")] public bool link { get; set; }
        [JsonPropertyName("speed")] public float speed { get; set; }
        [JsonPropertyName("duplex")] public int duplex { get; set; }
        [JsonPropertyName("tx_packets")] public int tx_packets { get; set; }
        [JsonPropertyName("rx_packets")] public int rx_packets { get; set; }
        [JsonPropertyName("tx_bytes")] public int tx_bytes { get; set; }
        [JsonPropertyName("rx_bytes")] public int rx_bytes { get; set; }
        [JsonPropertyName("tx_errors")] public int tx_errors { get; set; }
        [JsonPropertyName("rx_errors")] public int rx_errors { get; set; }
    }
}
