using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
