using ClientApiLibrary.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ClientApiLibrary.Controller
{
    public class EditorialController : Controller
    {
        private HttpClient client;

        public EditorialController(string token)
        {
            client = new HttpClient();
            // Configurar el encabezado de autorización
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        public async Task<List<Editorial>> findAll()
        {
            try
            {  
                List<Editorial> editorials = new List<Editorial>();
                HttpResponseMessage response = await client.GetAsync(getUrlBase() + "editorial");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                editorials = JsonConvert.DeserializeObject<List<Editorial>>(responseBody);
                return editorials;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<Editorial> findById(int id)
        {
            try
            {
                Editorial editorial = new Editorial();
                HttpResponseMessage response = await client.GetAsync(getUrlBase() + "editorial/" + id);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                editorial = JsonConvert.DeserializeObject<Editorial>(responseBody);
                return editorial;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<EditorialResponse> store(Editorial editorial)
        {
            try
            {
                EditorialResponse editorialResponse = new EditorialResponse();
                var json = JsonConvert.SerializeObject(editorial);
                var content = new StringContent(json, Encoding.UTF8, "application/json");                
                HttpResponseMessage response = await client.PostAsync(getUrlBase() + "editorial", content);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();                
                editorialResponse = JsonConvert.DeserializeObject<EditorialResponse>(responseBody);
                
                return editorialResponse;
            }
            catch (Exception ex)
            {
                return new EditorialResponse { Editorial = null, Message = ex.Message };
            }
        }

        public async Task<EditorialResponse> update(int id, Editorial editorial)
        {
            try
            {
                EditorialResponse editorialResponse = new EditorialResponse();
                var json = JsonConvert.SerializeObject(editorial);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PutAsync(getUrlBase() + "editorial/" + id, content);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                editorialResponse = JsonConvert.DeserializeObject<EditorialResponse>(responseBody);
                return editorialResponse;
            }
            catch (Exception ex)
            {
                return new EditorialResponse { Editorial = null, Message = ex.Message };
            }
        }

        public async Task<EditorialResponse> delete(int id)
        {
            try
            {
                HttpResponseMessage response = await client.DeleteAsync(getUrlBase() + "editorial/" + id);
                response.EnsureSuccessStatusCode();

                EditorialResponse editorialResponse = new EditorialResponse();
                string responseBody = await response.Content.ReadAsStringAsync();
                editorialResponse = JsonConvert.DeserializeObject<EditorialResponse>(responseBody);
                return editorialResponse;
            }
            catch (Exception ex)
            {
                return new EditorialResponse { Editorial = null, Message = ex.Message };
            }
        }
    }
}
