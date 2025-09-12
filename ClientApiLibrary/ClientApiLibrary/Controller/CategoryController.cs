using ClientApiLibrary.Model;
using Newtonsoft.Json;

namespace ClientApiLibrary.Controller
{
    public class CategoryController : Controller
    {
        private HttpClient client;

        public CategoryController()
        {
            client = new HttpClient();
        }

        public async Task<List<Category>> findAll()
        {
            try
            {
                List<Category> categories = new List<Category>();
                HttpResponseMessage response = await client.GetAsync(getUrlBase() + "category");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                categories = JsonConvert.DeserializeObject<List<Category>>(responseBody);
                return categories;
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
