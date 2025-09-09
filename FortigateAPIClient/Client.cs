
using FortigateAPIClient.Models;
using System.Net.Http.Json;
using System.Runtime;

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

        public async Task<List<VIPItem>> GetVIPListAsync()
        {
            //datasource=1&key=type&pattern=server-load-balance&
            var path = $"api/v2/cmdb/firewall/vip?vdom={_VDom}&with_meta=1&datasource=1";

            //var raw = await GetRawAsync(path);
            var result = await GetAsync<ResponseBase<List<VIPItem>>>(path);

            return result?.results ?? [];
        }

        public async Task CreateVIPAsync(VIPItem vip)
        {
            var path = $"api/v2/cmdb/firewall/vip?datasource=1&vdom={_VDom}&with_meta=1";
            var result = await PostAsync<VIPItem, ResponseBase<Object>>(path, vip);
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
