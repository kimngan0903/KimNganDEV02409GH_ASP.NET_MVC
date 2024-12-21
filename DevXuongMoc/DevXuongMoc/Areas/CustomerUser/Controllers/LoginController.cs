﻿using Microsoft.AspNetCore.Mvc;
using DevXuongMoc.Models;
using Microsoft.AspNetCore.Http;
using DevXuongMoc.Areas.CustomerUser.Models;
using Newtonsoft.Json;
namespace DevXuongMoc.Areas.CustomerUser.Controllers
{
    [Area("CustomerUser")]
    public class LoginController : Controller
    {
        private readonly DevXuongMocContext _context;

        public LoginController(DevXuongMocContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Models.LoginUser model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "Thông tin đăng nhập không hợp lệ.");
                return View(model);
            }

            var dataLogin = _context.Customers
                .Where(x => x.Email == model.Email && x.Password == model.Password)
                .FirstOrDefault();

            if (dataLogin != null)
            {
                // Serialize đối tượng Customer và lưu vào session
                string customerJson = JsonConvert.SerializeObject(dataLogin);
                HttpContext.Session.SetString("CustomerLogin", customerJson);
                HttpContext.Session.SetInt32("CustomerId", dataLogin.CustomerId);

                return RedirectToAction("Index", "Dashboard", new { customerId = dataLogin.CustomerId });
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Thông tin đăng nhập không chính xác.");
                return View(model);
            }
        }


        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("CustomerLogin");
            HttpContext.Session.Remove("CustomerId");

            return RedirectToAction("Index");
        }
    }
}