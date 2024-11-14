﻿using Lab04.Models;
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
        public ActionResult Create(People model)
        {
            try
            {
                // Upload file vào thư mục wwwroot/images/avatar
                var files = HttpContext.Request.Form.Files;
                // using System.Linq
                if (files.Count > 0 && files[0].Length > 0)
                {
                    var file = files[0];
                    var fileName = file.FileName;
                    // Nhớ tạo thư mục avatar trong thư mục wwwroot/images
                    // using System.IO
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\avatar", fileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                        model.Avatar = "/images/avatar/" + fileName; // Gán tên ảnh cho thuộc tính Avatar
                    }
                }
                // Thêm peoples vào danh sách DataLocal
                DataLocal._peoples.Add(model);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.error = ex.Message;
                return View(model);
            }
        }
        // GET: PeoplesController/Edit/5
        public ActionResult Edit(int id)
        {
            var people = DataLocal.GetPeopleById(id);
            return View(people);
        }

        // POST: PeoplesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, People model)
        {
            try 
            {
                // Upload file vào thư mục wwwroot/images/avatar
                var files = HttpContext.Request.Form.Files;
                // using System.Linq
                if (files.Count > 0 && files[0].Length > 0)
                {
                    var file = files[0];
                    var fileName = file.FileName;
                    // Nhớ tạo thư mục avatar trong thư mục wwwroot/images
                    // using System.IO
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\avatar", fileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                        model.Avatar = "/images/avatar/" + fileName; // Set relative path to Avatar
                    }
                }
                // Cập nhật model vào danh sách DataLocal
                for (int i = 0; i < DataLocal._peoples.Count; i++)
                {
                    if (DataLocal._peoples[i].Id == id)
                    {
                        DataLocal._peoples[i] = model;
                        break;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }

        // GET: PeoplesController/Delete/5
        public ActionResult Delete(int id)
        {
            var peoples = DataLocal.GetPeopleById(id);
            return View(peoples);
        }

        // POST: PeoplesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                for (int i = 0; i < DataLocal._peoples.Count; i++)
                {
                    if (DataLocal._peoples[i].Id == id)
                    {
                        DataLocal._peoples.RemoveAt(i);
                        break;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
