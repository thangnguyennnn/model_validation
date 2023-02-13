using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model_Binding_Validation_And_Routing.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Model_Binding_Validation_And_Routing.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Register()
        {
            return View();
        }

        //Routing của Register là https://localhost:44322/Home/Register
        [HttpPost]
        public IActionResult Register(Buyer student)
        {
            if (ModelState.IsValid)
            {
                Repository.SetBuyer(student);
                return View("Thanks", student);
            }
            //user nhập vào không đúng với tất cả các kiểu dữ liệu và điều kiện
            else
            {
                //trả về View
                return View();
            }
        }
        //Routing của Register là https://localhost:44322/Home/ListStudent
        public IActionResult ListStudent()
        {
            return View(Repository.GetBuyer());
        }
    }
}
