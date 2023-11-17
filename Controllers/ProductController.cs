
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using APIEJEMPLO.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConsumeAPI {
    public class BooksController : Controller {
        public async Task<IActionResult> Index() {
            // Crear un cliente HTTP
            var client = new HttpClient();

            // Realizar una solicitud GET a la API
            var response = await client.GetAsync("https://fakestoreapi.com/products");

            // Comprobar si la solicitud tuvo éxito
            if (response.IsSuccessStatusCode) {
                // Decodificar la respuesta JSON
                //var products = await response.Content.ReadAsJsonAsync<List<Product>>();

                // Mostrar los productos en la vista
                //return View(products);
            }

            // La solicitud falló
            return NotFound();
        }

    }


}


