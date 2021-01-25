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
                    JsonSerializerOptions options = new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    string content = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<PlayerDTO>(content,options);
                }
                else
                    return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<bool> LogoutAsync()
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
        public async Task<List<AnimalDTO>> GetAnimals()
        {
            string url = this.baseUrl + $"/GetAnimals";
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    JsonSerializerOptions options = new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    string content = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<List<AnimalDTO>>(content, options);
                }
                else
                    return null;
            }
            catch (Exception)
            {
                return null;
            }

        }
        public async Task<bool> RegisterAsync(PlayerDTO player)
        {
            string url = this.baseUrl + "/Register";
            try
            {
                string json = JsonSerializer.Serialize(player);
                StringContent stringContent = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(url, stringContent);
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
        public async Task<bool> UserNameExist(string userName)
        {
            string url = this.baseUrl + $"/UserNameExist?userName={userName}";
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    JsonSerializerOptions options = new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    string content = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<bool>(content, options);
                }
                else
                    return true;
            }
            catch (Exception)
            {
                return true;
            }
        }
        public async Task<bool> EmailExist(string email)
        {
            string url = this.baseUrl + $"/EmailExist?email={email}";
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    JsonSerializerOptions options = new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    string content = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<bool>(content, options);
                }
                else
                    return true;
            }
            catch (Exception)
            {
                return true;
            }
        }
    }
    
}
