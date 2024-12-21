using DevXuongMoc.Controllers;
using DevXuongMoc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DevXuongMoc.Areas.CustomerUser.Controllers
{
    [Area("CustomerUser")]
    public class DashboardController : Controller
    {
        private readonly ILogger<DashboardController> _logger;
        private readonly DevXuongMocContext _context;

        public DashboardController(ILogger<DashboardController> logger, DevXuongMocContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            var products = _context.Products.Take(4).ToList();
            return View(products);
        }
    }
}
