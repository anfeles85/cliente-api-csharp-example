using ClientApiLibrary.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApiLibrary.Controller
{
    public class AuthController : Controller
    {
        private HttpClient client;

        public AuthController()
        {
            client = new HttpClient();
        }

        public async Task<LoginResponse> login(LoginRequest loginRequest)
        {
            try
            {                
                var json = JsonConvert.SerializeObject(loginRequest);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(getUrlBase() + "auth/login", content);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                LoginResponse loginResponse = new LoginResponse();
                loginResponse = JsonConvert.DeserializeObject<LoginResponse>(responseBody);

                return loginResponse;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public async Task<LogoutResponse> logout(string token)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsync(getUrlBase() + "auth/logout", null);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                LogoutResponse logoutResponse = new LogoutResponse();
                logoutResponse = JsonConvert.DeserializeObject<LogoutResponse>(responseBody);

                return logoutResponse;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
