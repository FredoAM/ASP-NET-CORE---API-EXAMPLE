using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using APIEJEMPLO.Models;
using System.Collections.Generic;

namespace APIEJEMPLO.Controllers {
    public class HomeController : Controller {
        private readonly IHttpClientFactory _clientFactory;

        public HomeController(IHttpClientFactory clientFactory) {
            _clientFactory = clientFactory;
        }

        public async Task<IActionResult> Index() {
            var client = _clientFactory.CreateClient();
            var response = await client.GetAsync("https://fakestoreapi.com/products");
            if (response.IsSuccessStatusCode) {
                var responseStream = await response.Content.ReadAsStreamAsync();
                var products = await JsonSerializer.DeserializeAsync<List<Product>>(responseStream, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return View(products);
            } else {
                // Handle the error
                return View();
            }
        }
    }
}
