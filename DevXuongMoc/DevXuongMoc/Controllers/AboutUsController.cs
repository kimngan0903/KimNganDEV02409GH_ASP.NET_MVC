using Microsoft.AspNetCore.Mvc;

namespace DevXuongMoc.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
