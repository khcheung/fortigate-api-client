using System.Text.Json.Serialization;

namespace FortigateAPIClient.Models
{
    public class RouterGateway
    {
        [JsonPropertyName("success")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public bool Success { get; set; }
        [JsonPropertyName("network")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string Network { get; set; } = String.Empty;
        [JsonPropertyName("gateway")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string Gateway { get; set; } = String.Empty;
        [JsonPropertyName("interface")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string Interface { get; set; } = String.Empty;
    }

}
