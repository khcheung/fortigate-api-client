using FortigateAPIClient.Models;

namespace ClientConsole
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            var client = new FortigateAPIClient.Client("https://192.168.1.99/", "716tzknfcr1Qdkqr594ffyrbm96pwc");

            //var r1 = await client.GetRouterDefaultAsync();
            //var r2 = await client.GetRouterDefaultAsync("192.168.1.105");

            //var  ifaces = await client.GetSystemInterfaceAsync();
            //var ifaces = await client.GetSystemAvailableInterfaceAsync(GetInterfaceViewTypeEnum.Limited);

            //var policies = await client.GetFirewallPolicyAsync();

            //var availableInterface = ifaces
            //    .Where(i => i.valid_in_policy == true)
            //    .Select(i => new
            //    {
            //        Name = i.name,
            //        IP = i.ipv4_addresses.FirstOrDefault()?.ip ?? ""
            //    }).ToList();

            //var vipList = await client.GetFirewallVIPListAsync();
            //await client.CreateFirewallVIPAsync(new VIPItem()
            //{
            //    name = "VS6",
            //    servertype = "tcp",
            //    type = "server-load-balance",
            //    extport = 80,
            //    extintf = new VIPExtInterface()
            //    {
            //        q_origin_key = "wan1"
            //    },
            //    realservers = new[] {
            //        new VIPRealServerItem()
            //        {
            //             ip = "192.168.1.101",
            //              port = 8080,
            //              status = "active",
            //              type="ip",
            //              healthcheck = "vip",
            //              translatehost = "enable"
            //        },
            //                            new VIPRealServerItem()
            //        {
            //            ip = "192.168.1.102",
            //              port = 8080,
            //              status = "active",
            //              type="ip",
            //              healthcheck = "vip",
            //              translatehost = "enable"
            //        },
            //    }
            //});

            //{"name":"VS5","type":"server-load-balance","server-type":"tcp","extintf":{"q_origin_key":"wan1"},"extport":80,"realservers":[{"id":0,"type":"ip","address":"","ip":"192.168.1.101","port":8080,"status":"active","weight":1,"holddown-interval":300,"healthcheck":"vip","http-host":"","translate-host":"enable","max-connections":0,"monitor":[],"client-ip":""}]}
            //var del = await client.DeleteVIPAsync("VS1");

            //foreach (var vip in vipList)
            //{
            //    await client.DeleteFirewallVIPAsync(vip.q_origin_key);
            //}

        }
    }
}
