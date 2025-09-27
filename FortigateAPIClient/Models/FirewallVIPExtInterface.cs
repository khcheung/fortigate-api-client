using System.Text.Json.Serialization;

namespace FortigateAPIClient.Models
{
    public class FirewallVIPExtInterface
    {
        [JsonPropertyName("q_origin_key")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string q_origin_key { get; set; } = null!;
        [JsonPropertyName("name")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string name { get; set; } = null!;
        [JsonPropertyName("datasource")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string datasource { get; set; } =null!;
    }

}
