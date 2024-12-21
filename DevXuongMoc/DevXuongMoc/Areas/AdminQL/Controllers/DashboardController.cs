using Microsoft.AspNetCore.Mvc;

namespace DevXuongMoc.Areas.AdminQL.Controllers
{
    //[Area("Admin")]
    public class DashboardController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
