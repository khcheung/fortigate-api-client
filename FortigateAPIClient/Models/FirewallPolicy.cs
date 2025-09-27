using System.Text.Json.Serialization;

namespace FortigateAPIClient.Models
{
    public class FirewallPolicy
    {
        [JsonPropertyName("policyid")] public int policyid { get; set; }
        [JsonPropertyName("q_origin_key")] public int q_origin_key { get; set; }
        [JsonPropertyName("status")] public string status { get; set; } = String.Empty;
        [JsonPropertyName("name")] public string name { get; set; } = String.Empty;
        [JsonPropertyName("uuid")] public string uuid { get; set; } = String.Empty;
        [JsonPropertyName("uuididx")] public int uuididx { get; set; }
        [JsonPropertyName("srcintf")] public FirewallPolicyInterface[] srcintf { get; set; }
        [JsonPropertyName("dstintf")] public FirewallPolicyInterface[] dstintf { get; set; }
        [JsonPropertyName("action")] public string action { get; set; } = String.Empty;
        [JsonPropertyName("nat64")] public string nat64 { get; set; } = String.Empty;
        [JsonPropertyName("nat46")] public string nat46 { get; set; } = String.Empty;
        [JsonPropertyName("ztnastatus")] public string ztnastatus { get; set; } = String.Empty;
        [JsonPropertyName("ztnadeviceownership")] public string ztnadeviceownership { get; set; } = String.Empty;
        [JsonPropertyName("srcaddr")] public FirewallPolicyAddress[] srcaddr { get; set; }
        [JsonPropertyName("dstaddr")] public FirewallPolicyAddress[] dstaddr { get; set; }
        [JsonPropertyName("srcaddr6")] public object[] srcaddr6 { get; set; }
        [JsonPropertyName("dstaddr6")] public object[] dstaddr6 { get; set; }
        [JsonPropertyName("ztnaemstag")] public object[] ztnaemstag { get; set; }
        [JsonPropertyName("ztnaemstagsecondary")] public object[] ztnaemstagsecondary { get; set; }
        [JsonPropertyName("ztnatagsmatchlogic")] public string ztnatagsmatchlogic { get; set; } = String.Empty;
        [JsonPropertyName("ztnageotag")] public object[] ztnageotag { get; set; }
        [JsonPropertyName("internetservice")] public string internetservice { get; set; } = String.Empty;
        [JsonPropertyName("internetservicename")] public object[] internetservicename { get; set; }
        [JsonPropertyName("internetservicegroup")] public object[] internetservicegroup { get; set; }
        [JsonPropertyName("internetservicecustom")] public object[] internetservicecustom { get; set; }
        [JsonPropertyName("networkservicedynamic")] public object[] networkservicedynamic { get; set; }
        [JsonPropertyName("internetservicecustomgroup")] public object[] internetservicecustomgroup { get; set; }
        [JsonPropertyName("internetservicesrc")] public string internetservicesrc { get; set; } = String.Empty;
        [JsonPropertyName("internetservicesrcname")] public object[] internetservicesrcname { get; set; }
        [JsonPropertyName("internetservicesrcgroup")] public object[] internetservicesrcgroup { get; set; }
        [JsonPropertyName("internetservicesrccustom")] public object[] internetservicesrccustom { get; set; }
        [JsonPropertyName("networkservicesrcdynamic")] public object[] networkservicesrcdynamic { get; set; }
        [JsonPropertyName("internetservicesrccustomgroup")] public object[] internetservicesrccustomgroup { get; set; }
        [JsonPropertyName("reputationminimum")] public int reputationminimum { get; set; }
        [JsonPropertyName("reputationdirection")] public string reputationdirection { get; set; } = String.Empty;
        [JsonPropertyName("srcvendormac")] public object[] srcvendormac { get; set; }
        [JsonPropertyName("internetservice6")] public string internetservice6 { get; set; } = String.Empty;
        [JsonPropertyName("internetservice6name")] public object[] internetservice6name { get; set; }
        [JsonPropertyName("internetservice6group")] public object[] internetservice6group { get; set; }
        [JsonPropertyName("internetservice6custom")] public object[] internetservice6custom { get; set; }
        [JsonPropertyName("internetservice6customgroup")] public object[] internetservice6customgroup { get; set; }
        [JsonPropertyName("internetservice6src")] public string internetservice6src { get; set; } = String.Empty;
        [JsonPropertyName("internetservice6srcname")] public object[] internetservice6srcname { get; set; }
        [JsonPropertyName("internetservice6srcgroup")] public object[] internetservice6srcgroup { get; set; }
        [JsonPropertyName("internetservice6srccustom")] public object[] internetservice6srccustom { get; set; }
        [JsonPropertyName("internetservice6srccustomgroup")] public object[] internetservice6srccustomgroup { get; set; }
        [JsonPropertyName("reputationminimum6")] public int reputationminimum6 { get; set; }
        [JsonPropertyName("reputationdirection6")] public string reputationdirection6 { get; set; } = String.Empty;
        [JsonPropertyName("rtpnat")] public string rtpnat { get; set; } = String.Empty;
        [JsonPropertyName("rtpaddr")] public object[] rtpaddr { get; set; }
        [JsonPropertyName("senddenypacket")] public string senddenypacket { get; set; } = String.Empty;
        [JsonPropertyName("firewallsessiondirty")] public string firewallsessiondirty { get; set; } = String.Empty;
        [JsonPropertyName("schedule")] public FirewallPolicySchedule schedule { get; set; }
        [JsonPropertyName("scheduletimeout")] public string scheduletimeout { get; set; } = String.Empty;
        [JsonPropertyName("policyexpiry")] public string policyexpiry { get; set; } = String.Empty;
        [JsonPropertyName("policybehaviourtype")] public string policybehaviourtype { get; set; } = String.Empty;
        [JsonPropertyName("ipversiontype")] public string ipversiontype { get; set; } = String.Empty;
        [JsonPropertyName("policyexpirydateutc")] public string policyexpirydateutc { get; set; } = String.Empty;
        [JsonPropertyName("service")] public FirewallPolicyService[] service { get; set; }
        [JsonPropertyName("tosmask")] public string tosmask { get; set; } = String.Empty;
        [JsonPropertyName("tos")] public string tos { get; set; } = String.Empty;
        [JsonPropertyName("tosnegate")] public string tosnegate { get; set; } = String.Empty;
        [JsonPropertyName("antireplay")] public string antireplay { get; set; } = String.Empty;
        [JsonPropertyName("tcpsessionwithoutsyn")] public string tcpsessionwithoutsyn { get; set; } = String.Empty;
        [JsonPropertyName("geoipanycast")] public string geoipanycast { get; set; } = String.Empty;
        [JsonPropertyName("geoipmatch")] public string geoipmatch { get; set; } = String.Empty;
        [JsonPropertyName("dynamicshaping")] public string dynamicshaping { get; set; } = String.Empty;
        [JsonPropertyName("passivewanhealthmeasurement")] public string passivewanhealthmeasurement { get; set; } = String.Empty;
        [JsonPropertyName("utmstatus")] public string utmstatus { get; set; } = String.Empty;
        [JsonPropertyName("inspectionmode")] public string inspectionmode { get; set; } = String.Empty;
        [JsonPropertyName("httppolicyredirect")] public string httppolicyredirect { get; set; } = String.Empty;
        [JsonPropertyName("sshpolicyredirect")] public string sshpolicyredirect { get; set; } = String.Empty;
        [JsonPropertyName("ztnapolicyredirect")] public string ztnapolicyredirect { get; set; } = String.Empty;
        [JsonPropertyName("webproxyprofile")] public string webproxyprofile { get; set; } = String.Empty;
        [JsonPropertyName("profiletype")] public string profiletype { get; set; } = String.Empty;
        [JsonPropertyName("profilegroup")] public string profilegroup { get; set; } = String.Empty;
        [JsonPropertyName("profileprotocoloptions")] public FirewallPolicyProfileProtocolOptions profileprotocoloptions { get; set; }
        [JsonPropertyName("sslsshprofile")] public FirewallPolicySslSshProfile sslsshprofile { get; set; }
        [JsonPropertyName("avprofile")] public string avprofile { get; set; } = String.Empty;
        [JsonPropertyName("webfilterprofile")] public string webfilterprofile { get; set; } = String.Empty;
        [JsonPropertyName("dnsfilterprofile")] public string dnsfilterprofile { get; set; } = String.Empty;
        [JsonPropertyName("emailfilterprofile")] public string emailfilterprofile { get; set; } = String.Empty;
        [JsonPropertyName("dlpprofile")] public string dlpprofile { get; set; } = String.Empty;
        [JsonPropertyName("filefilterprofile")] public string filefilterprofile { get; set; } = String.Empty;
        [JsonPropertyName("ipssensor")] public string ipssensor { get; set; } = String.Empty;
        [JsonPropertyName("applicationlist")] public string applicationlist { get; set; } = String.Empty;
        [JsonPropertyName("voipprofile")] public string voipprofile { get; set; } = String.Empty;
        [JsonPropertyName("ipsvoipfilter")] public string ipsvoipfilter { get; set; } = String.Empty;
        [JsonPropertyName("sctpfilterprofile")] public string sctpfilterprofile { get; set; } = String.Empty;
        [JsonPropertyName("diameterfilterprofile")] public string diameterfilterprofile { get; set; } = String.Empty;
        [JsonPropertyName("virtualpatchprofile")] public string virtualpatchprofile { get; set; } = String.Empty;
        [JsonPropertyName("icapprofile")] public string icapprofile { get; set; } = String.Empty;
        [JsonPropertyName("cifsprofile")] public string cifsprofile { get; set; } = String.Empty;
        [JsonPropertyName("videofilterprofile")] public string videofilterprofile { get; set; } = String.Empty;
        [JsonPropertyName("wafprofile")] public string wafprofile { get; set; } = String.Empty;
        [JsonPropertyName("sshfilterprofile")] public string sshfilterprofile { get; set; } = String.Empty;
        [JsonPropertyName("casbprofile")] public string casbprofile { get; set; } = String.Empty;
        [JsonPropertyName("logtraffic")] public string logtraffic { get; set; } = String.Empty;
        [JsonPropertyName("logtrafficstart")] public string logtrafficstart { get; set; } = String.Empty;
        [JsonPropertyName("capturepacket")] public string capturepacket { get; set; } = String.Empty;
        [JsonPropertyName("autoasicoffload")] public string autoasicoffload { get; set; } = String.Empty;
        [JsonPropertyName("npacceleration")] public string npacceleration { get; set; } = String.Empty;
        [JsonPropertyName("webproxyforwardserver")] public string webproxyforwardserver { get; set; } = String.Empty;
        [JsonPropertyName("trafficshaper")] public string trafficshaper { get; set; } = String.Empty;
        [JsonPropertyName("trafficshaperreverse")] public string trafficshaperreverse { get; set; } = String.Empty;
        [JsonPropertyName("peripshaper")] public string peripshaper { get; set; } = String.Empty;
        [JsonPropertyName("nat")] public string nat { get; set; } = String.Empty;
        [JsonPropertyName("pcpoutbound")] public string pcpoutbound { get; set; } = String.Empty;
        [JsonPropertyName("pcpinbound")] public string pcpinbound { get; set; } = String.Empty;
        [JsonPropertyName("pcppoolname")] public object[] pcppoolname { get; set; }
        [JsonPropertyName("permitanyhost")] public string permitanyhost { get; set; } = String.Empty;
        [JsonPropertyName("permitstunhost")] public string permitstunhost { get; set; } = String.Empty;
        [JsonPropertyName("fixedport")] public string fixedport { get; set; } = String.Empty;
        [JsonPropertyName("portpreserve")] public string portpreserve { get; set; } = String.Empty;
        [JsonPropertyName("ippool")] public string ippool { get; set; } = String.Empty;
        [JsonPropertyName("poolname")] public object[] poolname { get; set; }
        [JsonPropertyName("poolname6")] public object[] poolname6 { get; set; }
        [JsonPropertyName("sessionttl")] public string sessionttl { get; set; } = String.Empty;
        [JsonPropertyName("vlancosfwd")] public int vlancosfwd { get; set; }
        [JsonPropertyName("vlancosrev")] public int vlancosrev { get; set; }
        [JsonPropertyName("inbound")] public string inbound { get; set; } = String.Empty;
        [JsonPropertyName("outbound")] public string outbound { get; set; } = String.Empty;
        [JsonPropertyName("natinbound")] public string natinbound { get; set; } = String.Empty;
        [JsonPropertyName("natoutbound")] public string natoutbound { get; set; } = String.Empty;
        [JsonPropertyName("fec")] public string fec { get; set; } = String.Empty;
        [JsonPropertyName("wccp")] public string wccp { get; set; } = String.Empty;
        [JsonPropertyName("ntlm")] public string ntlm { get; set; } = String.Empty;
        [JsonPropertyName("ntlmguest")] public string ntlmguest { get; set; } = String.Empty;
        [JsonPropertyName("ntlmenabledbrowsers")] public object[] ntlmenabledbrowsers { get; set; }
        [JsonPropertyName("fssoagentforntlm")] public string fssoagentforntlm { get; set; } = String.Empty;
        [JsonPropertyName("groups")] public object[] groups { get; set; }
        [JsonPropertyName("users")] public object[] users { get; set; }
        [JsonPropertyName("fssogroups")] public object[] fssogroups { get; set; }
        [JsonPropertyName("authpath")] public string authpath { get; set; } = String.Empty;
        [JsonPropertyName("disclaimer")] public string disclaimer { get; set; } = String.Empty;
        [JsonPropertyName("emailcollect")] public string emailcollect { get; set; } = String.Empty;
        [JsonPropertyName("vpntunnel")] public string vpntunnel { get; set; } = String.Empty;
        [JsonPropertyName("natip")] public string natip { get; set; } = String.Empty;
        [JsonPropertyName("matchvip")] public string matchvip { get; set; } = String.Empty;
        [JsonPropertyName("matchviponly")] public string matchviponly { get; set; } = String.Empty;
        [JsonPropertyName("diffservcopy")] public string diffservcopy { get; set; } = String.Empty;
        [JsonPropertyName("diffservforward")] public string diffservforward { get; set; } = String.Empty;
        [JsonPropertyName("diffservreverse")] public string diffservreverse { get; set; } = String.Empty;
        [JsonPropertyName("diffservcodeforward")] public string diffservcodeforward { get; set; } = String.Empty;
        [JsonPropertyName("diffservcoderev")] public string diffservcoderev { get; set; } = String.Empty;
        [JsonPropertyName("tcpmsssender")] public int tcpmsssender { get; set; }
        [JsonPropertyName("tcpmssreceiver")] public int tcpmssreceiver { get; set; }
        [JsonPropertyName("comments")] public string comments { get; set; } = String.Empty;
        [JsonPropertyName("label")] public string label { get; set; } = String.Empty;
        [JsonPropertyName("globallabel")] public string globallabel { get; set; } = String.Empty;
        [JsonPropertyName("authcert")] public string authcert { get; set; } = String.Empty;
        [JsonPropertyName("authredirectaddr")] public string authredirectaddr { get; set; } = String.Empty;
        [JsonPropertyName("redirecturl")] public string redirecturl { get; set; } = String.Empty;
        [JsonPropertyName("identitybasedroute")] public string identitybasedroute { get; set; } = String.Empty;
        [JsonPropertyName("blocknotification")] public string blocknotification { get; set; } = String.Empty;
        [JsonPropertyName("customlogfields")] public object[] customlogfields { get; set; }
        [JsonPropertyName("replacemsgoverridegroup")] public string replacemsgoverridegroup { get; set; } = String.Empty;
        [JsonPropertyName("srcaddrnegate")] public string srcaddrnegate { get; set; } = String.Empty;
        [JsonPropertyName("srcaddr6negate")] public string srcaddr6negate { get; set; } = String.Empty;
        [JsonPropertyName("dstaddrnegate")] public string dstaddrnegate { get; set; } = String.Empty;
        [JsonPropertyName("dstaddr6negate")] public string dstaddr6negate { get; set; } = String.Empty;
        [JsonPropertyName("servicenegate")] public string servicenegate { get; set; } = String.Empty;
        [JsonPropertyName("internetservicenegate")] public string internetservicenegate { get; set; } = String.Empty;
        [JsonPropertyName("internetservicesrcnegate")] public string internetservicesrcnegate { get; set; } = String.Empty;
        [JsonPropertyName("internetservice6negate")] public string internetservice6negate { get; set; } = String.Empty;
        [JsonPropertyName("internetservice6srcnegate")] public string internetservice6srcnegate { get; set; } = String.Empty;
        [JsonPropertyName("timeoutsendrst")] public string timeoutsendrst { get; set; } = String.Empty;
        [JsonPropertyName("captiveportalexempt")] public string captiveportalexempt { get; set; } = String.Empty;
        [JsonPropertyName("decryptedtrafficmirror")] public string decryptedtrafficmirror { get; set; } = String.Empty;
        [JsonPropertyName("dsri")] public string dsri { get; set; } = String.Empty;
        [JsonPropertyName("radiusmacauthbypass")] public string radiusmacauthbypass { get; set; } = String.Empty;
        [JsonPropertyName("delaytcpnpusession")] public string delaytcpnpusession { get; set; } = String.Empty;
        [JsonPropertyName("vlanfilter")] public string vlanfilter { get; set; } = String.Empty;
        [JsonPropertyName("sgtcheck")] public string sgtcheck { get; set; } = String.Empty;
        [JsonPropertyName("sgt")] public object[] sgt { get; set; }
        [JsonPropertyName("q_ref")] public int q_ref { get; set; }
        [JsonPropertyName("q_static")] public bool q_static { get; set; }
        [JsonPropertyName("q_no_rename")] public bool q_no_rename { get; set; }
        [JsonPropertyName("q_global_entry")] public bool q_global_entry { get; set; }
        [JsonPropertyName("q_type")] public int q_type { get; set; }
        [JsonPropertyName("q_path")] public string q_path { get; set; } = String.Empty;
        [JsonPropertyName("q_name")] public string q_name { get; set; } = String.Empty;
        [JsonPropertyName("q_mkey_type")] public string q_mkey_type { get; set; } = String.Empty;
        [JsonPropertyName("q_no_edit")] public bool q_no_edit { get; set; }
    }

}
