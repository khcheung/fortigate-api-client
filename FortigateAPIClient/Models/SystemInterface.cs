using System.Text.Json.Serialization;

namespace FortigateAPIClient.Models
{
    public class SystemInterface
    {
        [JsonPropertyName("name")] public string name { get; set; } = String.Empty;
        [JsonPropertyName("valid_in_policy")] public bool valid_in_policy { get; set; }
        [JsonPropertyName("icon")] public string icon { get; set; } = String.Empty;
        [JsonPropertyName("type")] public string type { get; set; } = String.Empty;
        [JsonPropertyName("real_interface_name")] public string real_interface_name { get; set; } = String.Empty;
        [JsonPropertyName("vdom")] public string vdom { get; set; } = String.Empty;
        [JsonPropertyName("is_system_interface")] public bool is_system_interface { get; set; }
        [JsonPropertyName("status")] public string status { get; set; } = String.Empty;
        [JsonPropertyName("in_bandwidth_limit")] public int in_bandwidth_limit { get; set; }
        [JsonPropertyName("out_bandwidth_limit")] public int out_bandwidth_limit { get; set; }
        [JsonPropertyName("vlan_protocol")] public string vlan_protocol { get; set; } = String.Empty;
        [JsonPropertyName("dhcp4_client_count")] public int dhcp4_client_count { get; set; }
        [JsonPropertyName("dhcp6_client_count")] public int dhcp6_client_count { get; set; }
        [JsonPropertyName("role")] public string role { get; set; } = String.Empty;
        [JsonPropertyName("estimated_upstream_bandwidth")] public int estimated_upstream_bandwidth { get; set; }
        [JsonPropertyName("estimated_downstream_bandwidth")] public int estimated_downstream_bandwidth { get; set; }
        [JsonPropertyName("monitor_bandwidth")] public bool monitor_bandwidth { get; set; }
        [JsonPropertyName("ipv4_addresses")] public List<SystemInterfaceAddress> ipv4_addresses { get; set; } = [];
        [JsonPropertyName("mac_address")] public string mac_address { get; set; } = String.Empty;
        [JsonPropertyName("port_speed")] public string port_speed { get; set; } = String.Empty;
        [JsonPropertyName("media")] public string media { get; set; } = String.Empty;
        [JsonPropertyName("chip_id")] public int chip_id { get; set; }
        [JsonPropertyName("link")] public string link { get; set; } = String.Empty;
        [JsonPropertyName("duplex")] public string duplex { get; set; } = String.Empty;
        [JsonPropertyName("speed")] public int speed { get; set; }
        [JsonPropertyName("hardware_switch")] public string hardware_switch { get; set; } = String.Empty;
        [JsonPropertyName("physical_switch")] public string physical_switch { get; set; } = String.Empty;
        [JsonPropertyName("alias")] public string alias { get; set; } = String.Empty;
        [JsonPropertyName("members")] public string[] members { get; set; } = [];
        [JsonPropertyName("is_sdwan_zone")] public bool is_sdwan_zone { get; set; }
    }


}
