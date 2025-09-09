using System.Text.Json.Serialization;

namespace FortigateAPIClient.Models
{
    public class ResponseBase<T>
    {
        [JsonPropertyName("http_method")] public string http_method { get; set; } = String.Empty;
        [JsonPropertyName("size")] public int? size { get; set; }
        [JsonPropertyName("limit_reached")] public bool? limit_reached { get; set; }
        [JsonPropertyName("matched_count")] public int? matched_count { get; set; }
        [JsonPropertyName("next_idx")] public int? next_idx { get; set; }
        [JsonPropertyName("revision")] public string? revision { get; set; } = String.Empty;
        [JsonPropertyName("old_revision")] public string? old_revision { get; set; } = String.Empty;
        [JsonPropertyName("revision_changed")] public bool? revision_changed { get; set; }
        [JsonPropertyName("results")] public T? results { get; set; } = default!;
        [JsonPropertyName("vdom")] public string vdom { get; set; } = String.Empty;
        [JsonPropertyName("path")] public string path { get; set; } = String.Empty;
        [JsonPropertyName("name")] public string name { get; set; } = String.Empty;
        [JsonPropertyName("action")] public string action { get; set; } = String.Empty;
        [JsonPropertyName("status")] public string status { get; set; } = String.Empty;
        [JsonPropertyName("http_status")] public int http_status { get; set; }
        [JsonPropertyName("serial")] public string serial { get; set; } = String.Empty;
        [JsonPropertyName("version")] public string version { get; set; } = String.Empty;
        [JsonPropertyName("build")] public int build { get; set; }
    }

}
