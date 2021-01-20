using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

namespace TamagotchiClient.WebClient
{
    class TamagotchiClient
    {
        private HttpClient client;
        private string baseUrl;
        public TamagotchiClient(string baseUrl)
        {
            this.baseUrl = baseUrl;
            //Set client handler to support cookies!!
            HttpClientHandler handler = new HttpClientHandler();
            handler.CookieContainer = new System.Net.CookieContainer();

            //Create client with the handler!
            this.client = new HttpClient(handler, true);
        }

        public async Task<string> TestAsync()
        {
            string url = this.baseUrl + "/Test";
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    return content;
                }
                else
                    return string.Empty;
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
