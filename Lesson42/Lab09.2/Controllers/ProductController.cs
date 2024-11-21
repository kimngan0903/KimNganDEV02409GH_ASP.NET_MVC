using Lab09._2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab09._2.Controllers
{
    public class ProductController : Controller
    {
        public readonly DevXuongMocContext _context;
        public ProductController(DevXuongMocContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.Products.ToListAsync();
            return View(data);
        }
    }
}
