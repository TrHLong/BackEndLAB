using LAB03;
using LAB03.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace LAB2.Controllers
{
    public class UserController : Controller
    {
        static List<User> users = new List<User>()
 {
 new User() {id="1",username="aaa",password="1",phone="111",email="111"},
 new User() {id="1",username="aaa",password="1",phone="111",email="111"},
 new User() {id="1",username="aaa",password="1",phone="111",email="111"},
 new User() {id="1",username="aaa",password="1",phone="111",email="111"},
 new User() {id="1",username="aaa",password="1",phone="111",email="111"},
 };
        public IActionResult Index()
        {
            return View(users);
        }
    }
}