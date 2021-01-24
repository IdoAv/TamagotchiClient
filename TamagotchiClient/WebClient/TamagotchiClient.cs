using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using TamagotchiClient.DataTransferObjects;

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
                    return "";
            }
            catch (Exception)
            {
                return "";
            }
        }

        public async Task<PlayerDTO> LoginAsync(UserDTO user)
        {
            string url = this.baseUrl + "/Login";
            try
            {
                string json = JsonSerializer.Serialize(user);
                StringContent stringContent = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(url, stringContent); 
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<PlayerDTO>(content);
                }
                else
                    return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<bool> Logout()
        {
            string url = this.baseUrl + "/Logout";
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
