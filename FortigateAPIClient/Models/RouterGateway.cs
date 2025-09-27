using System.Text.Json.Serialization;

namespace FortigateAPIClient.Models
{
    public class RouterGateway
    {
        [JsonPropertyName("success")] public bool Success { get; set; }
        [JsonPropertyName("network")] public string Network { get; set; } = String.Empty;
        [JsonPropertyName("gateway")] public string Gateway { get; set; } = String.Empty;
        [JsonPropertyName("interface")] public string Interface { get; set; } = String.Empty;
    }

}
