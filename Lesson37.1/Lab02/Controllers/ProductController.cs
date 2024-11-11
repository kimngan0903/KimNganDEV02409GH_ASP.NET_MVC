using Lab02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab02.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ViewData["messageVD"] = "Dữ liệu lưu trong ViewData";
            ViewBag.messageVD = "Dữ liệu lưu trong ViewBag";
            TempData["messageTD"] = "Dữ liệu lưu trong TempData";
            return View();
        }
        public IActionResult GetAllProduct()
        {
            Product p = new Product()
            {
                ProductId = 1,
                ProductName = "Test",
                YearRelease = 2024,
                Price = 379.99
            };
            ViewBag.product = p;
            ViewData["productVd"] = p;
            return View();
        }
    }
}
