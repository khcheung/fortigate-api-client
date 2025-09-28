using System.Text.Json.Serialization;

namespace FortigateAPIClient.Models
{
    public class FirewallPolicy
    {
        [JsonPropertyName("policyid")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int policyid { get; set; }
        [JsonPropertyName("q_origin_key")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int q_origin_key { get; set; }
        [JsonPropertyName("status")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string status { get; set; } = String.Empty;
        [JsonPropertyName("name")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string name { get; set; } = String.Empty;
        [JsonPropertyName("uuid")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string uuid { get; set; } = String.Empty;
        [JsonPropertyName("uuididx")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int uuididx { get; set; }
        [JsonPropertyName("srcintf")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public FirewallPolicyInterface[] srcintf { get; set; } = null!;
        [JsonPropertyName("dstintf")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public FirewallPolicyInterface[] dstintf { get; set; } = null!;
        [JsonPropertyName("action")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string action { get; set; } = String.Empty;
        [JsonPropertyName("nat64")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string nat64 { get; set; } = String.Empty;
        [JsonPropertyName("nat46")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string nat46 { get; set; } = String.Empty;
        [JsonPropertyName("ztnastatus")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string ztnastatus { get; set; } = String.Empty;
        [JsonPropertyName("ztnadeviceownership")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string ztnadeviceownership { get; set; } = String.Empty;
        [JsonPropertyName("srcaddr")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public FirewallPolicyAddress[] srcaddr { get; set; } = null!;
        [JsonPropertyName("dstaddr")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public FirewallPolicyAddress[] dstaddr { get; set; } = null!;
        [JsonPropertyName("srcaddr6")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] srcaddr6 { get; set; } = null!;
        [JsonPropertyName("dstaddr6")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] dstaddr6 { get; set; } = null!;
        [JsonPropertyName("ztnaemstag")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] ztnaemstag { get; set; } = null!;
        [JsonPropertyName("ztnaemstagsecondary")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] ztnaemstagsecondary { get; set; } = null!;
        [JsonPropertyName("ztnatagsmatchlogic")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string ztnatagsmatchlogic { get; set; } = String.Empty;
        [JsonPropertyName("ztnageotag")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] ztnageotag { get; set; } = null!;
        [JsonPropertyName("internetservice")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string internetservice { get; set; } = String.Empty;
        [JsonPropertyName("internetservicename")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] internetservicename { get; set; } = null!;
        [JsonPropertyName("internetservicegroup")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] internetservicegroup { get; set; } = null!;
        [JsonPropertyName("internetservicecustom")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] internetservicecustom { get; set; } = null!;
        [JsonPropertyName("networkservicedynamic")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] networkservicedynamic { get; set; } = null!;
        [JsonPropertyName("internetservicecustomgroup")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] internetservicecustomgroup { get; set; } = null!;
        [JsonPropertyName("internetservicesrc")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string internetservicesrc { get; set; } = String.Empty;
        [JsonPropertyName("internetservicesrcname")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] internetservicesrcname { get; set; } = null!;
        [JsonPropertyName("internetservicesrcgroup")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] internetservicesrcgroup { get; set; } = null!;
        [JsonPropertyName("internetservicesrccustom")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] internetservicesrccustom { get; set; } = null!;
        [JsonPropertyName("networkservicesrcdynamic")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] networkservicesrcdynamic { get; set; } = null!;
        [JsonPropertyName("internetservicesrccustomgroup")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] internetservicesrccustomgroup { get; set; } = null!;
        [JsonPropertyName("reputationminimum")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int reputationminimum { get; set; }
        [JsonPropertyName("reputationdirection")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string reputationdirection { get; set; } = String.Empty;
        [JsonPropertyName("srcvendormac")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] srcvendormac { get; set; } = null!;
        [JsonPropertyName("internetservice6")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string internetservice6 { get; set; } = String.Empty;
        [JsonPropertyName("internetservice6name")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] internetservice6name { get; set; } = null!;
        [JsonPropertyName("internetservice6group")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] internetservice6group { get; set; } = null!;
        [JsonPropertyName("internetservice6custom")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] internetservice6custom { get; set; } = null!;
        [JsonPropertyName("internetservice6customgroup")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] internetservice6customgroup { get; set; } = null!;
        [JsonPropertyName("internetservice6src")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string internetservice6src { get; set; } = String.Empty;
        [JsonPropertyName("internetservice6srcname")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] internetservice6srcname { get; set; } = null!;
        [JsonPropertyName("internetservice6srcgroup")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] internetservice6srcgroup { get; set; } = null!;
        [JsonPropertyName("internetservice6srccustom")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] internetservice6srccustom { get; set; } = null!;
        [JsonPropertyName("internetservice6srccustomgroup")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] internetservice6srccustomgroup { get; set; } = null!;
        [JsonPropertyName("reputationminimum6")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int reputationminimum6 { get; set; }
        [JsonPropertyName("reputationdirection6")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string reputationdirection6 { get; set; } = String.Empty;
        [JsonPropertyName("rtpnat")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string rtpnat { get; set; } = String.Empty;
        [JsonPropertyName("rtpaddr")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] rtpaddr { get; set; } = null!;
        [JsonPropertyName("senddenypacket")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string senddenypacket { get; set; } = String.Empty;
        [JsonPropertyName("firewallsessiondirty")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string firewallsessiondirty { get; set; } = String.Empty;
        [JsonPropertyName("schedule")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public FirewallPolicySchedule schedule { get; set; } = null!;
        [JsonPropertyName("scheduletimeout")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string scheduletimeout { get; set; } = String.Empty;
        [JsonPropertyName("policyexpiry")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string policyexpiry { get; set; } = String.Empty;
        [JsonPropertyName("policybehaviourtype")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string policybehaviourtype { get; set; } = String.Empty;
        [JsonPropertyName("ipversiontype")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string ipversiontype { get; set; } = String.Empty;
        [JsonPropertyName("policyexpirydateutc")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string policyexpirydateutc { get; set; } = String.Empty;
        [JsonPropertyName("service")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public FirewallPolicyService[] service { get; set; } = null!;
        [JsonPropertyName("tosmask")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string tosmask { get; set; } = String.Empty;
        [JsonPropertyName("tos")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string tos { get; set; } = String.Empty;
        [JsonPropertyName("tosnegate")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string tosnegate { get; set; } = String.Empty;
        [JsonPropertyName("antireplay")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string antireplay { get; set; } = String.Empty;
        [JsonPropertyName("tcpsessionwithoutsyn")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string tcpsessionwithoutsyn { get; set; } = String.Empty;
        [JsonPropertyName("geoipanycast")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string geoipanycast { get; set; } = String.Empty;
        [JsonPropertyName("geoipmatch")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string geoipmatch { get; set; } = String.Empty;
        [JsonPropertyName("dynamicshaping")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string dynamicshaping { get; set; } = String.Empty;
        [JsonPropertyName("passivewanhealthmeasurement")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string passivewanhealthmeasurement { get; set; } = String.Empty;
        [JsonPropertyName("utmstatus")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string utmstatus { get; set; } = String.Empty;
        [JsonPropertyName("inspectionmode")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string inspectionmode { get; set; } = String.Empty;
        [JsonPropertyName("httppolicyredirect")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string httppolicyredirect { get; set; } = String.Empty;
        [JsonPropertyName("sshpolicyredirect")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string sshpolicyredirect { get; set; } = String.Empty;
        [JsonPropertyName("ztnapolicyredirect")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string ztnapolicyredirect { get; set; } = String.Empty;
        [JsonPropertyName("webproxyprofile")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string webproxyprofile { get; set; } = String.Empty;
        [JsonPropertyName("profiletype")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string profiletype { get; set; } = String.Empty;
        [JsonPropertyName("profilegroup")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string profilegroup { get; set; } = String.Empty;
        [JsonPropertyName("profileprotocoloptions")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public FirewallPolicyProfileProtocolOptions profileprotocoloptions { get; set; } = null!;
        [JsonPropertyName("sslsshprofile")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public FirewallPolicySslSshProfile sslsshprofile { get; set; } = null!;
        [JsonPropertyName("avprofile")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string avprofile { get; set; } = String.Empty;
        [JsonPropertyName("webfilterprofile")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string webfilterprofile { get; set; } = String.Empty;
        [JsonPropertyName("dnsfilterprofile")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string dnsfilterprofile { get; set; } = String.Empty;
        [JsonPropertyName("emailfilterprofile")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string emailfilterprofile { get; set; } = String.Empty;
        [JsonPropertyName("dlpprofile")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string dlpprofile { get; set; } = String.Empty;
        [JsonPropertyName("filefilterprofile")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string filefilterprofile { get; set; } = String.Empty;
        [JsonPropertyName("ipssensor")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string ipssensor { get; set; } = String.Empty;
        [JsonPropertyName("applicationlist")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string applicationlist { get; set; } = String.Empty;
        [JsonPropertyName("voipprofile")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string voipprofile { get; set; } = String.Empty;
        [JsonPropertyName("ipsvoipfilter")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string ipsvoipfilter { get; set; } = String.Empty;
        [JsonPropertyName("sctpfilterprofile")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string sctpfilterprofile { get; set; } = String.Empty;
        [JsonPropertyName("diameterfilterprofile")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string diameterfilterprofile { get; set; } = String.Empty;
        [JsonPropertyName("virtualpatchprofile")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string virtualpatchprofile { get; set; } = String.Empty;
        [JsonPropertyName("icapprofile")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string icapprofile { get; set; } = String.Empty;
        [JsonPropertyName("cifsprofile")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string cifsprofile { get; set; } = String.Empty;
        [JsonPropertyName("videofilterprofile")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string videofilterprofile { get; set; } = String.Empty;
        [JsonPropertyName("wafprofile")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string wafprofile { get; set; } = String.Empty;
        [JsonPropertyName("sshfilterprofile")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string sshfilterprofile { get; set; } = String.Empty;
        [JsonPropertyName("casbprofile")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string casbprofile { get; set; } = String.Empty;
        [JsonPropertyName("logtraffic")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string logtraffic { get; set; } = String.Empty;
        [JsonPropertyName("logtrafficstart")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string logtrafficstart { get; set; } = String.Empty;
        [JsonPropertyName("capturepacket")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string capturepacket { get; set; } = String.Empty;
        [JsonPropertyName("autoasicoffload")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string autoasicoffload { get; set; } = String.Empty;
        [JsonPropertyName("npacceleration")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string npacceleration { get; set; } = String.Empty;
        [JsonPropertyName("webproxyforwardserver")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string webproxyforwardserver { get; set; } = String.Empty;
        [JsonPropertyName("trafficshaper")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string trafficshaper { get; set; } = String.Empty;
        [JsonPropertyName("trafficshaperreverse")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string trafficshaperreverse { get; set; } = String.Empty;
        [JsonPropertyName("peripshaper")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string peripshaper { get; set; } = String.Empty;
        [JsonPropertyName("nat")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string nat { get; set; } = String.Empty;
        [JsonPropertyName("pcpoutbound")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string pcpoutbound { get; set; } = String.Empty;
        [JsonPropertyName("pcpinbound")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string pcpinbound { get; set; } = String.Empty;
        [JsonPropertyName("pcppoolname")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] pcppoolname { get; set; } = null!;
        [JsonPropertyName("permitanyhost")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string permitanyhost { get; set; } = String.Empty;
        [JsonPropertyName("permitstunhost")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string permitstunhost { get; set; } = String.Empty;
        [JsonPropertyName("fixedport")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string fixedport { get; set; } = String.Empty;
        [JsonPropertyName("portpreserve")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string portpreserve { get; set; } = String.Empty;
        [JsonPropertyName("ippool")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string ippool { get; set; } = String.Empty;
        [JsonPropertyName("poolname")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] poolname { get; set; } = null!;
        [JsonPropertyName("poolname6")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] poolname6 { get; set; } = null!;
        [JsonPropertyName("sessionttl")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string sessionttl { get; set; } = String.Empty;
        [JsonPropertyName("vlancosfwd")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int vlancosfwd { get; set; }
        [JsonPropertyName("vlancosrev")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int vlancosrev { get; set; }
        [JsonPropertyName("inbound")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string inbound { get; set; } = String.Empty;
        [JsonPropertyName("outbound")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string outbound { get; set; } = String.Empty;
        [JsonPropertyName("natinbound")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string natinbound { get; set; } = String.Empty;
        [JsonPropertyName("natoutbound")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string natoutbound { get; set; } = String.Empty;
        [JsonPropertyName("fec")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string fec { get; set; } = String.Empty;
        [JsonPropertyName("wccp")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string wccp { get; set; } = String.Empty;
        [JsonPropertyName("ntlm")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string ntlm { get; set; } = String.Empty;
        [JsonPropertyName("ntlmguest")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string ntlmguest { get; set; } = String.Empty;
        [JsonPropertyName("ntlmenabledbrowsers")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] ntlmenabledbrowsers { get; set; } = null!;
        [JsonPropertyName("fssoagentforntlm")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string fssoagentforntlm { get; set; } = String.Empty;
        [JsonPropertyName("groups")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] groups { get; set; } = null!;
        [JsonPropertyName("users")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] users { get; set; } = null!;
        [JsonPropertyName("fssogroups")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] fssogroups { get; set; } = null!;
        [JsonPropertyName("authpath")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string authpath { get; set; } = String.Empty;
        [JsonPropertyName("disclaimer")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string disclaimer { get; set; } = String.Empty;
        [JsonPropertyName("emailcollect")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string emailcollect { get; set; } = String.Empty;
        [JsonPropertyName("vpntunnel")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string vpntunnel { get; set; } = String.Empty;
        [JsonPropertyName("natip")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string natip { get; set; } = String.Empty;
        [JsonPropertyName("matchvip")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string matchvip { get; set; } = String.Empty;
        [JsonPropertyName("matchviponly")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string matchviponly { get; set; } = String.Empty;
        [JsonPropertyName("diffservcopy")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string diffservcopy { get; set; } = String.Empty;
        [JsonPropertyName("diffservforward")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string diffservforward { get; set; } = String.Empty;
        [JsonPropertyName("diffservreverse")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string diffservreverse { get; set; } = String.Empty;
        [JsonPropertyName("diffservcodeforward")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string diffservcodeforward { get; set; } = String.Empty;
        [JsonPropertyName("diffservcoderev")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string diffservcoderev { get; set; } = String.Empty;
        [JsonPropertyName("tcpmsssender")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int tcpmsssender { get; set; }
        [JsonPropertyName("tcpmssreceiver")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int tcpmssreceiver { get; set; }
        [JsonPropertyName("comments")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string comments { get; set; } = String.Empty;
        [JsonPropertyName("label")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string label { get; set; } = String.Empty;
        [JsonPropertyName("globallabel")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string globallabel { get; set; } = String.Empty;
        [JsonPropertyName("authcert")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string authcert { get; set; } = String.Empty;
        [JsonPropertyName("authredirectaddr")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string authredirectaddr { get; set; } = String.Empty;
        [JsonPropertyName("redirecturl")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string redirecturl { get; set; } = String.Empty;
        [JsonPropertyName("identitybasedroute")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string identitybasedroute { get; set; } = String.Empty;
        [JsonPropertyName("blocknotification")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string blocknotification { get; set; } = String.Empty;
        [JsonPropertyName("customlogfields")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] customlogfields { get; set; } = null!;
        [JsonPropertyName("replacemsgoverridegroup")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string replacemsgoverridegroup { get; set; } = String.Empty;
        [JsonPropertyName("srcaddrnegate")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string srcaddrnegate { get; set; } = String.Empty;
        [JsonPropertyName("srcaddr6negate")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string srcaddr6negate { get; set; } = String.Empty;
        [JsonPropertyName("dstaddrnegate")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string dstaddrnegate { get; set; } = String.Empty;
        [JsonPropertyName("dstaddr6negate")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string dstaddr6negate { get; set; } = String.Empty;
        [JsonPropertyName("servicenegate")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string servicenegate { get; set; } = String.Empty;
        [JsonPropertyName("internetservicenegate")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string internetservicenegate { get; set; } = String.Empty;
        [JsonPropertyName("internetservicesrcnegate")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string internetservicesrcnegate { get; set; } = String.Empty;
        [JsonPropertyName("internetservice6negate")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string internetservice6negate { get; set; } = String.Empty;
        [JsonPropertyName("internetservice6srcnegate")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string internetservice6srcnegate { get; set; } = String.Empty;
        [JsonPropertyName("timeoutsendrst")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string timeoutsendrst { get; set; } = String.Empty;
        [JsonPropertyName("captiveportalexempt")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string captiveportalexempt { get; set; } = String.Empty;
        [JsonPropertyName("decryptedtrafficmirror")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string decryptedtrafficmirror { get; set; } = String.Empty;
        [JsonPropertyName("dsri")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string dsri { get; set; } = String.Empty;
        [JsonPropertyName("radiusmacauthbypass")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string radiusmacauthbypass { get; set; } = String.Empty;
        [JsonPropertyName("delaytcpnpusession")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string delaytcpnpusession { get; set; } = String.Empty;
        [JsonPropertyName("vlanfilter")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string vlanfilter { get; set; } = String.Empty;
        [JsonPropertyName("sgtcheck")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string sgtcheck { get; set; } = String.Empty;
        [JsonPropertyName("sgt")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] sgt { get; set; } = null!;
        [JsonPropertyName("q_ref")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int q_ref { get; set; }
        [JsonPropertyName("q_static")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public bool q_static { get; set; }
        [JsonPropertyName("q_no_rename")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public bool q_no_rename { get; set; }
        [JsonPropertyName("q_global_entry")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public bool q_global_entry { get; set; }
        [JsonPropertyName("q_type")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public int q_type { get; set; }
        [JsonPropertyName("q_path")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string q_path { get; set; } = String.Empty;
        [JsonPropertyName("q_name")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string q_name { get; set; } = String.Empty;
        [JsonPropertyName("q_mkey_type")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string q_mkey_type { get; set; } = String.Empty;
        [JsonPropertyName("q_no_edit")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public bool q_no_edit { get; set; }
    }

}
