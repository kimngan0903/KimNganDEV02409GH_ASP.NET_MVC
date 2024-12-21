using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DevXuongMoc.Models;
using X.PagedList;

namespace DevXuongMoc.Areas.AdminQL.Controllers
{
    public class ProductExtensionsController : BaseController
    {
        private readonly DevXuongMocContext _context;

        public ProductExtensionsController(DevXuongMocContext context)
        {
            _context = context;
        }

        // GET: AdminQL/ProductExtensions
        public async Task<IActionResult> Index(string name, int page = 1)
        {
            // Số ghi trên 1 trang
            int limit = 5;

            // var category = await _context.Categories.ToListAsync();
            var productextensions = await _context.ProductExtensions.OrderBy(c => c.Id).ToPagedListAsync(page, limit);
            // Nếu có tham số name trên url
            if (!String.IsNullOrEmpty(name))
            {
                productextensions = await _context.ProductExtensions.Where(c => c.Content.Contains(name)).OrderBy(c => c.Id).ToPagedListAsync(page, limit);
            }
            ViewBag.keyword = name;
            return View(productextensions);
        }

        // GET: AdminQL/ProductExtensions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productExtension = await _context.ProductExtensions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productExtension == null)
            {
                return NotFound();
            }
            // Return partial view for AJAX
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                return PartialView("_Details", productExtension);
            }
            return View(productExtension);
        }

        // GET: AdminQL/ProductExtensions/Create
        public IActionResult Create()
        {
            // Return partial view for AJAX
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                return PartialView("_Create");
            }

            return View();
        }

        // POST: AdminQL/ProductExtensions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Pid,Eid,Content")] ProductExtension productExtension)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productExtension);
                await _context.SaveChangesAsync();
                // Return success response for AJAX
                if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                {
                    return Json(new { success = true, redirectUrl = Url.Action("Index") });
                }
                return RedirectToAction(nameof(Index));
            }
            // Return partial view for AJAX in case of validation errors
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                return PartialView("_Create", productExtension);
            }
            return View(productExtension);
        }

        // GET: AdminQL/ProductExtensions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productExtension = await _context.ProductExtensions.FindAsync(id);
            if (productExtension == null)
            {
                return NotFound();
            }
            // Return partial view for AJAX
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                return PartialView("_Edit", productExtension);
            }
            return View(productExtension);
        }

        // POST: AdminQL/ProductExtensions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Pid,Eid,Content")] ProductExtension productExtension)
        {
            if (id != productExtension.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productExtension);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExtensionExists(productExtension.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(productExtension);
        }

        // GET: AdminQL/ProductExtensions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productExtension = await _context.ProductExtensions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productExtension == null)
            {
                return NotFound();
            }

            // Return partial view for AJAX
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                return PartialView("_Delete", productExtension);
            }
            return View(productExtension);
        }
        // POST: AdminQL/ProductExtensions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productExtension = await _context.ProductExtensions.FindAsync(id);
            if (productExtension != null)
            {
                _context.ProductExtensions.Remove(productExtension);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExtensionExists(int id)
        {
            return _context.ProductExtensions.Any(e => e.Id == id);
        }
    }
}
