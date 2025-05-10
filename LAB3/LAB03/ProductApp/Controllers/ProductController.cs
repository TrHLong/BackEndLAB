using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;

namespace ProductApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Details()
        {
            var product = new Product
            {
                Id = 1,
                Name = "Tai nghe Bluetooth",
                Price = 799000
            };

            return View(product);
        }
    }
}
