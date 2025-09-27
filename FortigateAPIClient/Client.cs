
using FortigateAPIClient.Models;
using System.Collections.Generic;
using System.Net.Http.Json;

namespace FortigateAPIClient
{
    public class Client
    {

        private String _BaseUrl { get; set; }
        private String _Token { get; set; }

        private String _VDom { get; set; }

        private HttpClient _HttpClient = null!;

        public Client(String baseUrl, String token, String vdom = "root")
        {
            this._BaseUrl = baseUrl;
            this._Token = token;
            this._VDom = vdom;
        }

        private HttpClient GetClient()
        {
            if (this._HttpClient == null)
            {
                var handler = new HttpClientHandler();
                handler.ServerCertificateCustomValidationCallback = (r, c, cc, p) => true;
                this._HttpClient = new HttpClient(handler);
                this._HttpClient.BaseAddress = new Uri(this._BaseUrl);
                this._HttpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _Token);
            }
            return this._HttpClient;
        }

        public async Task<Dictionary<String, SystemInterface>> GetSystemInterfaceAsync()
        {
            // https://192.168.1.99/api/v2/cmdb/system/interface?datasource=true&format=name%7Cmode%7Callowaccess%7Cfortilink%7Cfortitelemetry%7Cipv6%7Csecurity-mode%7Cvrf%7Cip-managed-by-fortiipam%7Cdhcp-relay-ip%7Cdhcp-relay-service%7Cdedicated-to&vdom=root&with_meta=true
            var path = $"/api/v2/monitor/system/interface?vdom={_VDom}&with_meta=1&datasource=1";
            var result = await GetAsync<ResponseBase<Dictionary<String, SystemInterface>>>(path);
            return result?.results ?? new();
        }

        public async Task<List<SystemAvailableInterface>> GetSystemAvailableInterfaceAsync(GetInterfaceViewTypeEnum? viewType = null)
        {
            var paramViewType = "";
            if (viewType.HasValue)
            {
                switch (viewType.Value)
                {
                    case GetInterfaceViewTypeEnum.Limited:
                        paramViewType = viewType.Value.ToString().ToLower();
                        break;
                    default:
                        break;
                }
            }
            // /api/v2/monitor/system/available-interfaces?count=18&start=0&vdom=root&view_type=limited
            var path = $"/api/v2/monitor/system/available-interfaces?vdom={_VDom}&with_meta=1&datasource=1&view_type={paramViewType}";
            var result = await GetAsync<ResponseBase<List<SystemAvailableInterface>>>(path);
            return result?.results ?? [];
        }

        public async Task<RouterGateway> GetRouterDefaultAsync(String destination = "0.0.0.0")
        {
            //https://192.168.1.99/api/v2/monitor/router/lookup?vdom=root&destination=0.0.0.0
            var path = $"/api/v2/monitor/router/lookup?vdom={_VDom}&destination={destination}";
            var result = await GetAsync<ResponseBase<RouterGateway>>(path);
            return result?.results ?? default!;
        }

        public async Task<List<FirewallPolicy>> GetFirewallPolicyAsync()
        {
            //https://192.168.1.99/api/v2/cmdb/firewall/policy?start=0&count=1&datasource=true&with_meta=true&vdom=root
            var path = $"/api/v2/cmdb/firewall/policy?vdom={_VDom}&with_meta=1&datasource=1";
            var result = await GetAsync<ResponseBase<List<FirewallPolicy>>>(path);
            return result?.results ?? default!;
        }

        public async Task<List<FirewallVIPItem>> GetFirewallVIPListAsync()
        {
            //datasource=1&key=type&pattern=server-load-balance&
            var path = $"api/v2/cmdb/firewall/vip?vdom={_VDom}&with_meta=1&datasource=1";

            //var raw = await GetRawAsync(path);
            var result = await GetAsync<ResponseBase<List<FirewallVIPItem>>>(path);

            return result?.results ?? [];
        }

        public async Task CreateFirewallVIPAsync(FirewallVIPItem vip)
        {
            var path = $"api/v2/cmdb/firewall/vip?datasource=1&vdom={_VDom}&with_meta=1";
            var result = await PostAsync<FirewallVIPItem, ResponseBase<Object>>(path, vip);
        }

        public async Task<ResponseBase<Object>?> DeleteVIPAsync(String name)
        {
            //https://192.168.1.99/api/v2/cmdb/firewall/vip/VS1?vdom=root
            var path = $"api/v2/cmdb/firewall/vip/{name}?vdom={_VDom}";
            var result = await DeleteAsync<ResponseBase<Object>>(path);
            return result;

        }

        private async Task<TOut?> GetAsync<TOut>(String path)
        {
            var client = this.GetClient();
            using (var response = await client.GetAsync(path))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadFromJsonAsync<TOut>();
                    return result!;

                }
            }
            return default;
        }

        private async Task<String> GetRawAsync(String path)
        {
            var client = this.GetClient();
            using (var response = await client.GetAsync(path))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    return result!;

                }
            }
            return String.Empty;
        }

        private async Task<TOut?> PostAsync<T, TOut>(String path, T req)
        {
            var client = this.GetClient();
            JsonContent content = JsonContent.Create(req);
            await content.LoadIntoBufferAsync();
            using (var response = await client.PostAsync(path, content))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadFromJsonAsync<TOut>();
                    return result!;

                }
            }
            return default;
        }

        private async Task<TOut?> DeleteAsync<TOut>(String path)
        {
            var client = this.GetClient();
            using (var response = await client.DeleteAsync(path))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadFromJsonAsync<TOut>();
                    return result!;

                }
            }
            return default;
        }
    }

}
