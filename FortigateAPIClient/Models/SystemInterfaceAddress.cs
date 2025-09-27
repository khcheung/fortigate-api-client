using System.Text.Json.Serialization;

namespace FortigateAPIClient.Models
{
    public class SystemInterfaceAddress
    {
        [JsonPropertyName("ip")] public string ip { get; set; } = String.Empty;
        [JsonPropertyName("netmask")] public string netmask { get; set; } = String.Empty;
        [JsonPropertyName("cidr_netmask")] public int cidr_netmask { get; set; }
    }


}
