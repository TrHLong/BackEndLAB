using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QLSV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;
namespace QLSV.Controllers
{
    public class StudentController : Controller
    {
        private readonly QLSVDbContext _context;
        public StudentController()
        {
            _context = new QLSVDbContext();
        }
        public IActionResult Index()
        {
            var students = _context.Students.Include(s => s.Class).ToList();  // Kiểm tra để đảm bảo lấy Class kèm theo
            return View(students); // Truyền dữ liệu vào view
        }

    }
}

