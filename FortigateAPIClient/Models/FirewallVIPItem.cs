using System.Text.Json.Serialization;

namespace FortigateAPIClient.Models
{

    public class FirewallVIPItem
    {
        [JsonPropertyName("name")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public string name { get; set; } = null!;
        [JsonPropertyName("q_origin_key")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string q_origin_key { get; set; } = null!;
        [JsonPropertyName("cssclass")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string cssclass { get; set; } = null!;
        [JsonPropertyName("id")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public int id { get; set; }
        [JsonPropertyName("uuid")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string uuid { get; set; } = null!;
        [JsonPropertyName("comment")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string comment { get; set; } = null!;
        [JsonPropertyName("type")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string type { get; set; } = null!;
        [JsonPropertyName("server-type")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string servertype { get; set; } = null!;
        [JsonPropertyName("dnsmappingttl")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public int dnsmappingttl { get; set; }
        [JsonPropertyName("ldbmethod")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string ldbmethod { get; set; } = null!;
        [JsonPropertyName("srcfilter")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] srcfilter { get; set; } = null!;
        [JsonPropertyName("srcvipfilter")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string srcvipfilter { get; set; } = null!;
        [JsonPropertyName("service")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] service { get; set; } = null!;
        [JsonPropertyName("extip")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string extip { get; set; } = null!;
        [JsonPropertyName("extaddr")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] extaddr { get; set; } = null!;
        [JsonPropertyName("h2support")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string h2support { get; set; } = null!;
        [JsonPropertyName("h3support")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string h3support { get; set; } = null!;
        [JsonPropertyName("quic")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public FirewallVIPQuicItem quic { get; set; } = null!;
        [JsonPropertyName("nat44")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string nat44 { get; set; } = null!;
        [JsonPropertyName("nat46")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string nat46 { get; set; } = null!;
        [JsonPropertyName("addnat46route")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string addnat46route { get; set; } = null!;
        [JsonPropertyName("mappedip")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] mappedip { get; set; } = null!;
        [JsonPropertyName("mappedaddr")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string mappedaddr { get; set; } = null!;
        [JsonPropertyName("extintf")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public FirewallVIPExtInterface extintf { get; set; } = null!;
        [JsonPropertyName("arpreply")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string arpreply { get; set; } = null!;
        [JsonPropertyName("httpredirect")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string httpredirect { get; set; } = null!;
        [JsonPropertyName("persistence")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string persistence { get; set; } = null!;
        [JsonPropertyName("natsourcevip")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string natsourcevip { get; set; } = null!;
        [JsonPropertyName("portforward")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string portforward { get; set; } = null!;
        [JsonPropertyName("status")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string status { get; set; } = null!;
        [JsonPropertyName("protocol")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string protocol { get; set; } = null!;
        [JsonPropertyName("extport")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public int? extport { get; set; } = null!;
        [JsonPropertyName("mappedport")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string mappedport { get; set; } = null!;
        [JsonPropertyName("gratuitousarpinterval")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public int gratuitousarpinterval { get; set; }
        [JsonPropertyName("srcintffilter")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] srcintffilter { get; set; } = null!;
        [JsonPropertyName("portmappingtype")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string portmappingtype { get; set; } = null!;
        [JsonPropertyName("realservers")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public FirewallVIPRealServerItem[]  realservers { get; set; } = null!;
        [JsonPropertyName("httpcookiedomainfromhost")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string httpcookiedomainfromhost { get; set; } = null!;
        [JsonPropertyName("httpcookiedomain")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string httpcookiedomain { get; set; } = null!;
        [JsonPropertyName("httpcookiepath")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string httpcookiepath { get; set; } = null!;
        [JsonPropertyName("httpcookiegeneration")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public int httpcookiegeneration { get; set; }
        [JsonPropertyName("httpcookieage")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public int httpcookieage { get; set; }
        [JsonPropertyName("httpcookieshare")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string httpcookieshare { get; set; } = null!;
        [JsonPropertyName("httpscookiesecure")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string httpscookiesecure { get; set; } = null!;
        [JsonPropertyName("httpmultiplex")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string httpmultiplex { get; set; } = null!;
        [JsonPropertyName("httpmultiplexttl")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public int httpmultiplexttl { get; set; }
        [JsonPropertyName("httpmultiplexmaxrequest")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public int httpmultiplexmaxrequest { get; set; }
        [JsonPropertyName("httpmultiplexmaxconcurrentrequest")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public int httpmultiplexmaxconcurrentrequest { get; set; }
        [JsonPropertyName("httpipheader")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string httpipheader { get; set; } = null!;
        [JsonPropertyName("httpipheadername")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string httpipheadername { get; set; } = null!;
        [JsonPropertyName("outlookwebaccess")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string outlookwebaccess { get; set; } = null!;
        [JsonPropertyName("weblogicserver")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string weblogicserver { get; set; } = null!;
        [JsonPropertyName("websphereserver")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string websphereserver { get; set; } = null!;
        [JsonPropertyName("sslmode")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string sslmode { get; set; } = null!;
        [JsonPropertyName("sslcertificate")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] sslcertificate { get; set; } = null!;
        [JsonPropertyName("ssldhbits")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string ssldhbits { get; set; } = null!;
        [JsonPropertyName("sslalgorithm")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string sslalgorithm { get; set; } = null!;
        [JsonPropertyName("sslciphersuites")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] sslciphersuites { get; set; } = null!;
        [JsonPropertyName("sslserveralgorithm")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string sslserveralgorithm { get; set; } = null!;
        [JsonPropertyName("sslserverciphersuites")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] sslserverciphersuites { get; set; } = null!;
        [JsonPropertyName("sslpfs")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string sslpfs { get; set; } = null!;
        [JsonPropertyName("sslminversion")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string sslminversion { get; set; } = null!;
        [JsonPropertyName("sslmaxversion")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string sslmaxversion { get; set; } = null!;
        [JsonPropertyName("sslserverminversion")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string sslserverminversion { get; set; } = null!;
        [JsonPropertyName("sslservermaxversion")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string sslservermaxversion { get; set; } = null!;
        [JsonPropertyName("sslacceptffdhegroups")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string sslacceptffdhegroups { get; set; } = null!;
        [JsonPropertyName("sslsendemptyfrags")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string sslsendemptyfrags { get; set; } = null!;
        [JsonPropertyName("sslclientfallback")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string sslclientfallback { get; set; } = null!;
        [JsonPropertyName("sslclientrenegotiation")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string sslclientrenegotiation { get; set; } = null!;
        [JsonPropertyName("sslclientsessionstatetype")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string sslclientsessionstatetype { get; set; } = null!;
        [JsonPropertyName("sslclientsessionstatetimeout")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public int sslclientsessionstatetimeout { get; set; }
        [JsonPropertyName("sslclientsessionstatemax")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public int sslclientsessionstatemax { get; set; }
        [JsonPropertyName("sslclientrekeycount")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public int sslclientrekeycount { get; set; }
        [JsonPropertyName("sslserverrenegotiation")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string sslserverrenegotiation { get; set; } = null!;
        [JsonPropertyName("sslserversessionstatetype")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string sslserversessionstatetype { get; set; } = null!;
        [JsonPropertyName("sslserversessionstatetimeout")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public int sslserversessionstatetimeout { get; set; }
        [JsonPropertyName("sslserversessionstatemax")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public int sslserversessionstatemax { get; set; }
        [JsonPropertyName("sslhttplocationconversion")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string sslhttplocationconversion { get; set; } = null!;
        [JsonPropertyName("sslhttpmatchhost")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string sslhttpmatchhost { get; set; } = null!;
        [JsonPropertyName("sslhpkp")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string sslhpkp { get; set; } = null!;
        [JsonPropertyName("sslhpkpprimary")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string sslhpkpprimary { get; set; } = null!;
        [JsonPropertyName("sslhpkpbackup")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string sslhpkpbackup { get; set; } = null!;
        [JsonPropertyName("sslhpkpage")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public int sslhpkpage { get; set; }
        [JsonPropertyName("sslhpkpreporturi")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string sslhpkpreporturi { get; set; } = null!;
        [JsonPropertyName("sslhpkpincludesubdomains")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string sslhpkpincludesubdomains { get; set; } = null!;
        [JsonPropertyName("sslhsts")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string sslhsts { get; set; } = null!;
        [JsonPropertyName("sslhstsage")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public int sslhstsage { get; set; }
        [JsonPropertyName("sslhstsincludesubdomains")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string sslhstsincludesubdomains { get; set; } = null!;
        [JsonPropertyName("monitor")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] monitor { get; set; } = null!;
        [JsonPropertyName("maxembryonicconnections")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public int maxembryonicconnections { get; set; }
        [JsonPropertyName("color")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public int color { get; set; }
        [JsonPropertyName("ipv6mappedip")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string ipv6mappedip { get; set; } = null!;
        [JsonPropertyName("ipv6mappedport")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string ipv6mappedport { get; set; } = null!;
        [JsonPropertyName("oneclickgslbserver")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string oneclickgslbserver { get; set; } = null!;
        [JsonPropertyName("gslbhostname")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string gslbhostname { get; set; } = null!;
        [JsonPropertyName("gslbdomainname")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string gslbdomainname { get; set; } = null!;
        [JsonPropertyName("gslbpublicips")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] public object[] gslbpublicips { get; set; } = null!;
        [JsonPropertyName("q_ref")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public int q_ref { get; set; }
        [JsonPropertyName("q_static")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public bool q_static { get; set; }
        [JsonPropertyName("q_no_rename")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public bool q_no_rename { get; set; }
        [JsonPropertyName("q_global_entry")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public bool q_global_entry { get; set; }
        [JsonPropertyName("q_type")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public int q_type { get; set; }
        [JsonPropertyName("q_path")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string q_path { get; set; } = null!;
        [JsonPropertyName("q_name")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string q_name { get; set; } = null!;
        [JsonPropertyName("q_mkey_type")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string q_mkey_type { get; set; } = null!;
        [JsonPropertyName("q_no_edit")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public bool q_no_edit { get; set; }
        [JsonPropertyName("q_class")][JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]  public string q_class { get; set; } = null!;
    }

}
