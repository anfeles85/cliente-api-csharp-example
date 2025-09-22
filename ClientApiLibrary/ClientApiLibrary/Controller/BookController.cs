using ClientApiLibrary.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ClientApiLibrary.Controller
{
    public class BookController : Controller
    {
        private HttpClient client;

        public BookController(string token)
        {
            client = new HttpClient();
            // Configurar el encabezado de autorización
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        public async Task<List<Book>> findAll()
        {
            try
            {
                List<Book> books = new List<Book>();
                HttpResponseMessage response = await client.GetAsync(getUrlBase() + "book");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                books = JsonConvert.DeserializeObject<List<Book>>(responseBody);
                return books;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<Book> findById(long id)
        {
            try
            {
                Book book = new Book();
                HttpResponseMessage response = await client.GetAsync(getUrlBase() + "book/" + id);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                book = JsonConvert.DeserializeObject<Book>(responseBody);
                return book;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<BookResponse> store(Book book)
        {
            try
            {
                BookResponse bookResponse = new BookResponse();
                var json = JsonConvert.SerializeObject(book);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(getUrlBase() + "book", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                bookResponse = JsonConvert.DeserializeObject<BookResponse>(responseBody);
                return bookResponse;
            }
            catch (Exception ex)
            {
                return new BookResponse { Book = null, Message = ex.Message };
            }
        }

        public async Task<BookResponse> update(long id, Book book)
        {
            try
            {
                BookResponse bookResponse = new BookResponse();
                var json = JsonConvert.SerializeObject(book);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PutAsync(getUrlBase() + "book/" + id, content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                bookResponse = JsonConvert.DeserializeObject<BookResponse>(responseBody);
                return bookResponse;
            }
            catch (Exception ex)
            {
                return new BookResponse { Book = null, Message = ex.Message };
            }
        }

        public async Task<BookResponse> delete(int id)
        {
            try
            {
                HttpResponseMessage response = await client.DeleteAsync(getUrlBase() + "book/" + id);
                response.EnsureSuccessStatusCode();

                BookResponse bookResponse = new BookResponse();
                string responseBody = await response.Content.ReadAsStringAsync();
                bookResponse = JsonConvert.DeserializeObject<BookResponse>(responseBody);
                return bookResponse;
            }
            catch (Exception ex)
            {
                return new BookResponse { Book = null, Message = ex.Message };
            }
        }
    }
}
