using System.Text.Json.Serialization;

namespace FortigateAPIClient.Models
{
    public class FirewallPolicyInterface
    {
        [JsonPropertyName("datasource")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string datasource { get; set; } = String.Empty;
        [JsonPropertyName("name")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string name { get; set; } = String.Empty;
        [JsonPropertyName("q_origin_key")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string q_origin_key { get; set; } = String.Empty;
    }

}
