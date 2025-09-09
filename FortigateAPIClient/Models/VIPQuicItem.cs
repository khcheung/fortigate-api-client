using System.Text.Json.Serialization;

namespace FortigateAPIClient.Models
{
    public class VIPQuicItem
    {
        [JsonPropertyName("maxidletimeout")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int maxidletimeout { get; set; }
        [JsonPropertyName("maxudppayloadsize")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int maxudppayloadsize { get; set; }
        [JsonPropertyName("activeconnectionidlimit")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int activeconnectionidlimit { get; set; }
        [JsonPropertyName("ackdelayexponent")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int ackdelayexponent { get; set; }
        [JsonPropertyName("maxackdelay")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int maxackdelay { get; set; }
        [JsonPropertyName("maxdatagramframesize")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int maxdatagramframesize { get; set; }
        [JsonPropertyName("activemigration")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string activemigration { get; set; } = string.Empty;
        [JsonPropertyName("greasequicbit")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string greasequicbit { get; set; } = string.Empty;
    }




}
