using Lab04.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab04.Controllers
{
    public class PeoplesController : Controller
    {
        // GET: PeoplesController
        /// <summary>
        /// Index: Hiển thị danh sách dữ liệu Peoples
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var _peoples = DataLocal.GetPeoples();
            return View(_peoples);
        }

        // GET: PeoplesController/Details/5
        public ActionResult Details(int id)
        {
            var peoples = DataLocal.GetPeopleById(id);
            return View(peoples);
        }

        // GET: PeoplesController/Create
        public ActionResult Create()
        {
            People people = new People();
            return View(people);
        }

        // POST: PeoplesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PeoplesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PeoplesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PeoplesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PeoplesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
