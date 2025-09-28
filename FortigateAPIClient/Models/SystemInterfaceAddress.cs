using System.Text.Json.Serialization;

namespace FortigateAPIClient.Models
{
    public class SystemInterfaceAddress
    {
        [JsonPropertyName("ip")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string ip { get; set; } = String.Empty;
        [JsonPropertyName("netmask")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string netmask { get; set; } = String.Empty;
        [JsonPropertyName("cidr_netmask")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int cidr_netmask { get; set; }
    }


}
