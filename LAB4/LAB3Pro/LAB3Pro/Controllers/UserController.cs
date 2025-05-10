using LAB3Pro.Models;
using Microsoft.AspNetCore.Mvc;

namespace LAB3Pro.Controllers
{
    public class UserController : Controller
    {
        // Dữ liệu tạm thời - sống trong runtime
        static List<User> users = new List<User>()
        {
            new User { id = "1", username = "khanh", password = "123456", email = "khanh@gmail.com", phone = "0123456789" },
            new User { id = "2", username = "minh", password = "abcdef", email = "minh@gmail.com", phone = "0987654321" }
        };

        // Danh sách
        public IActionResult Index()
        {
            return View(users);
        }

        // Hiển thị form thêm
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        // Xử lý thêm người dùng
        [HttpPost]
        public IActionResult Add(User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    users.Add(user);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(user);
        }

        // Hiển thị form sửa
        [HttpGet]
        public IActionResult Edit(string id)
        {
            var user = users.FirstOrDefault(u => u.id == id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // Xử lý sửa
        [HttpPost]
        public IActionResult Edit(User updatedUser)
        {
            if (!ModelState.IsValid)
            {
                return View(updatedUser);
            }

            var user = users.FirstOrDefault(u => u.id == updatedUser.id);
            if (user == null)
            {
                return NotFound();
            }

            user.username = updatedUser.username;
            user.password = updatedUser.password;
            user.email = updatedUser.email;
            user.phone = updatedUser.phone;

            return RedirectToAction("Index");
        }
    }
}
