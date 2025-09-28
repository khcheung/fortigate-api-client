using System.Text.Json.Serialization;

namespace FortigateAPIClient.Models
{
    public class ResponseBase<T>
    {
        [JsonPropertyName("http_method")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string http_method { get; set; } = String.Empty;
        [JsonPropertyName("size")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int? size { get; set; }
        [JsonPropertyName("limit_reached")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public bool? limit_reached { get; set; }
        [JsonPropertyName("matched_count")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int? matched_count { get; set; }
        [JsonPropertyName("next_idx")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int? next_idx { get; set; }
        [JsonPropertyName("revision")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string? revision { get; set; } = String.Empty;
        [JsonPropertyName("old_revision")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string? old_revision { get; set; } = String.Empty;
        [JsonPropertyName("revision_changed")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public bool? revision_changed { get; set; }
        [JsonPropertyName("results")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public T? results { get; set; } = default!;
        [JsonPropertyName("vdom")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string vdom { get; set; } = String.Empty;
        [JsonPropertyName("path")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string path { get; set; } = String.Empty;
        [JsonPropertyName("name")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string name { get; set; } = String.Empty;
        [JsonPropertyName("action")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string action { get; set; } = String.Empty;
        [JsonPropertyName("status")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string status { get; set; } = String.Empty;
        [JsonPropertyName("http_status")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int http_status { get; set; }
        [JsonPropertyName("serial")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string serial { get; set; } = String.Empty;
        [JsonPropertyName("version")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string version { get; set; } = String.Empty;
        [JsonPropertyName("build")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int build { get; set; }
    }

}
