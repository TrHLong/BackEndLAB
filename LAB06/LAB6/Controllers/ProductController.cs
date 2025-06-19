using LAB6.Models;
using Microsoft.AspNetCore.Mvc;

namespace LAB6.Controllers
{
    public class ProductController : Controller
    {
        public static List<Category> categories = new List<Category>()
        {
            new Category { Id = 1, Name = "Laptop" },
            new Category { Id = 2, Name = "Smartphone" },
            new Category { Id = 3, Name = "Tablet" },
            new Category { Id = 4, Name = "Smartwatch" },
            new Category { Id = 5, Name = "TV" },
            new Category { Id = 6, Name = "Headphones" },
            new Category { Id = 7, Name = "Monitor" },
            new Category { Id = 8, Name = "Gaming Console" },
            new Category { Id = 9, Name = "Keyboard & Mouse" },
            new Category { Id = 10, Name = "Graphics Card" },
            new Category { Id = 11, Name = "RAM & Storage" },
            new Category { Id = 12, Name = "Motherboard" },
            new Category { Id = 13, Name = "Gaming Monitor" },
            new Category { Id = 14, Name = "External Storage" }
        };

        public static List<Brand> brands = new List<Brand>()
        {
            new Brand { Id = 1, Name = "Apple" },
            new Brand { Id = 2, Name = "Samsung" },
            new Brand { Id = 3, Name = "Sony" },
            new Brand { Id = 4, Name = "LG" },
            new Brand { Id = 5, Name = "Dell" },
            new Brand { Id = 6, Name = "HP" },
            new Brand { Id = 7, Name = "Microsoft" },
            new Brand { Id = 8, Name = "Google" },
            new Brand { Id = 9, Name = "Amazon" },
            new Brand { Id = 10, Name = "Lenovo" },
            new Brand { Id = 11, Name = "Logitech" },
            new Brand { Id = 12, Name = "Razer" },
            new Brand { Id = 13, Name = "NVIDIA" },
            new Brand { Id = 14, Name = "Corsair" },
            new Brand { Id = 15, Name = "Asus" },
            new Brand { Id = 16, Name = "GoPro" },
            new Brand { Id = 17, Name = "DJI" },
            new Brand { Id = 18, Name = "HyperX" }
        };

        public static List<Product> products = new List<Product>()
        {
            new Product { Id = 1, Name = "Apple MacBook Pro 14", Description = "Powerful laptop with M2 chip.", Category = "Laptop", Brand = "Apple", OriginalPrice = 2199.99, SalePrice = 1999.99, IsFreeShipping = true, ImageUrl = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/mbp14-spacegrayselect-202301?wid=2000&hei=2000&fmt=jpeg&qlt=90" },
            new Product { Id = 2, Name = "Samsung Galaxy S24 Ultra", Description = "High-end flagship smartphone.", Category = "Smartphone", Brand = "Samsung", OriginalPrice = 1399.99, SalePrice = 1299.99, IsFreeShipping = true, ImageUrl = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/mbp14-spacegrayselect-202301?wid=2000&hei=2000&fmt=jpeg&qlt=90" },
            new Product { Id = 3, Name = "Sony WH-1000XM5", Description = "Noise-canceling wireless headphones.", Category = "Headphones", Brand = "Sony", OriginalPrice = 399.99, SalePrice = 349.99, IsFreeShipping = false, ImageUrl = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/mbp14-spacegrayselect-202301?wid=2000&hei=2000&fmt=jpeg&qlt=90" },
            // Các sản phẩm còn lại cũng được khai báo tương tự
        };

        // Phương thức Index để hiển thị danh sách sản phẩm và bộ lọc
        public IActionResult Index()
        {
            var tuple = new Tuple<List<Category>, List<Brand>, List<Product>>(categories, brands, products);
            return View(tuple);
        }

        // Phương thức Filter để lọc sản phẩm theo các tham số tìm kiếm
        [HttpGet]
        public IActionResult Filters(string searchValue, string selectedBrands, string selectedCategory, double? minPrice, double? maxPrice)
        {
            var result = products.AsQueryable();

            // Tìm kiếm theo tên sản phẩm
            if (!string.IsNullOrEmpty(searchValue))
            {
                result = result.Where(p => p.Name.ToLower().Contains(searchValue.ToLower()));
            }

            // Lọc theo danh mục sản phẩm
            if (!string.IsNullOrEmpty(selectedCategory))
            {
                result = result.Where(p => p.Category == selectedCategory);
            }

            // Lọc theo thương hiệu
            if (!string.IsNullOrEmpty(selectedBrands))
            {
                var brandList = selectedBrands.Split(',');
                result = result.Where(p => brandList.Contains(p.Brand));
            }

            // Lọc theo giá trị minPrice
            if (minPrice.HasValue)
            {
                result = result.Where(p => p.SalePrice >= minPrice);
            }

            // Lọc theo giá trị maxPrice
            if (maxPrice.HasValue)
            {
                result = result.Where(p => p.SalePrice <= maxPrice);
            }

            return Ok(result.ToList());
        }
    }
}
