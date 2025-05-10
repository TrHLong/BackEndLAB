using Microsoft.AspNetCore.Mvc;
using Product.Models;

public class ProductController : Controller
{
    public IActionResult Details()
    {
        var product = new ProductModel
        {
            Id = 1,
            Name = "Tai nghe Bluetooth",
            Price = 799000
        };
        return View(product);
    }
}
