using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WindForm_fetch_API.Models;

namespace WindForm_fetch_API.Services
{
    public class UserService
    {
        private readonly HttpClient _httpClient = ApiClient.Instance;
        private const string Endpoint = "users";

        public async Task<List<User>> GetUser()
        {
            try
            {
                var response  = await _httpClient.GetAsync(Endpoint);
                response.EnsureSuccessStatusCode();

                string jsonRes = await response.Content.ReadAsStringAsync();
                var jsonObject = JObject.Parse(jsonRes);
                var data = jsonObject["data"].ToString();
                var users = JsonConvert.DeserializeObject<List<User>>(data);

                return users;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<bool> CrateAsync(User user)
        {
            try
            {
                
                string json = JsonConvert.SerializeObject(user);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync(Endpoint, data);
                response.EnsureSuccessStatusCode();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public async Task<User> GetUserById(string id)
        {
            try
            {
                
                var response = await _httpClient.GetAsync($"{Endpoint}/{id}");
                response.EnsureSuccessStatusCode();

                string jsonRes = await response.Content.ReadAsStringAsync();
                var jsonObject = JObject.Parse(jsonRes);
                var data = jsonObject["data"].ToString();
                var users = JsonConvert.DeserializeObject<User>(data);

                return users;
            }
            catch (Exception ex) 
            {
                throw new Exception();
            }
        }

        public async Task<bool> UpdateAsync(string id, User user)
        {
            try
            {
                string json = JsonConvert.SerializeObject(user);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _httpClient.PutAsync($"{Endpoint}/{id}", data);
                return response.IsSuccessStatusCode;
            }
            catch { throw new Exception("Gagal update data"); }
        }

        public async Task<bool> DeleteAsync(string id)
        {
            try
            {
                var response = await _httpClient.DeleteAsync($"{Endpoint}/{id}");
                return response.IsSuccessStatusCode;
            }
            catch { throw new Exception("Gagal menghapus data"); }
        }
    }
}
