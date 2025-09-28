using System.Text.Json.Serialization;

namespace FortigateAPIClient.Models
{
    public class SystemAvailableInterface
    {
        [JsonPropertyName("name")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string name { get; set; } = String.Empty;
        [JsonPropertyName("valid_in_policy")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public bool valid_in_policy { get; set; }
        [JsonPropertyName("icon")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string icon { get; set; } = String.Empty;
        [JsonPropertyName("type")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string type { get; set; } = String.Empty;
        [JsonPropertyName("real_interface_name")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string real_interface_name { get; set; } = String.Empty;
        [JsonPropertyName("vdom")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string vdom { get; set; } = String.Empty;
        [JsonPropertyName("is_system_interface")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public bool is_system_interface { get; set; }
        [JsonPropertyName("status")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string status { get; set; } = String.Empty;
        [JsonPropertyName("in_bandwidth_limit")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int in_bandwidth_limit { get; set; }
        [JsonPropertyName("out_bandwidth_limit")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int out_bandwidth_limit { get; set; }
        [JsonPropertyName("vlan_protocol")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string vlan_protocol { get; set; } = String.Empty;
        [JsonPropertyName("dhcp4_client_count")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int dhcp4_client_count { get; set; }
        [JsonPropertyName("dhcp6_client_count")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int dhcp6_client_count { get; set; }
        [JsonPropertyName("role")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string role { get; set; } = String.Empty;
        [JsonPropertyName("estimated_upstream_bandwidth")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int estimated_upstream_bandwidth { get; set; }
        [JsonPropertyName("estimated_downstream_bandwidth")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int estimated_downstream_bandwidth { get; set; }
        [JsonPropertyName("monitor_bandwidth")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public bool monitor_bandwidth { get; set; }
        [JsonPropertyName("ipv4_addresses")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public List<SystemInterfaceAddress> ipv4_addresses { get; set; } = [];
        [JsonPropertyName("mac_address")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string mac_address { get; set; } = String.Empty;
        [JsonPropertyName("port_speed")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string port_speed { get; set; } = String.Empty;
        [JsonPropertyName("media")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string media { get; set; } = String.Empty;
        [JsonPropertyName("chip_id")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int chip_id { get; set; }
        [JsonPropertyName("link")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string link { get; set; } = String.Empty;
        [JsonPropertyName("duplex")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string duplex { get; set; } = String.Empty;
        [JsonPropertyName("speed")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int speed { get; set; }
        [JsonPropertyName("hardware_switch")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string hardware_switch { get; set; } = String.Empty;
        [JsonPropertyName("physical_switch")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string physical_switch { get; set; } = String.Empty;
        [JsonPropertyName("alias")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string alias { get; set; } = String.Empty;
        [JsonPropertyName("members")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string[] members { get; set; } = [];
        [JsonPropertyName("is_sdwan_zone")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public bool is_sdwan_zone { get; set; }
    }


}
