using Microsoft.AspNetCore.Mvc;
using Product.Models;
using Microsoft.EntityFrameworkCore;

namespace Product.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductDbContext _context;

        // Constructor nhận DbContext từ DI container
        public ProductController(ProductDbContext context)
        {
            _context = context;
        }

        // Hiển thị danh sách sản phẩm
        public async Task<IActionResult> Index()
        {
            var products = await _context.Products.ToListAsync();  // Sử dụng ProductItem
            return View(products);
        }

        // Hiển thị form thêm sản phẩm mới
        public IActionResult Create()
        {
            return View();
        }

        // Xử lý lưu sản phẩm mới
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductItem product)  // Thay đổi thành ProductItem
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // Hiển thị form chỉnh sửa sản phẩm
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);  // Thay đổi thành ProductItem
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // Xử lý cập nhật thông tin sản phẩm
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ProductItem product)  // Thay đổi thành ProductItem
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Products.Any(e => e.Id == product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // Xác nhận và xóa sản phẩm
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.Id == id);  // Thay đổi thành ProductItem
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // Xử lý xóa sản phẩm
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);  // Thay đổi thành ProductItem
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
