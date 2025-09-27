using System.Text.Json.Serialization;

namespace FortigateAPIClient.Models
{
    public class FirewallPolicyInterface
    {
        [JsonPropertyName("datasource")] public string datasource { get; set; } = String.Empty;
        [JsonPropertyName("name")] public string name { get; set; } = String.Empty;
        [JsonPropertyName("q_origin_key")] public string q_origin_key { get; set; } = String.Empty;
    }

}
