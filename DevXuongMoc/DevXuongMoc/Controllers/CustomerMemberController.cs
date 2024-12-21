using DevXuongMoc.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NuGet.Protocol;

namespace DevXuongMoc.Controllers
{
    public class CustomerMemberController : Controller
    {
        private readonly DevXuongMocContext _context;
        public CustomerMemberController(DevXuongMocContext context)
        {
            _context = context;
        }
        public IActionResult Index(string url)
        {
            if (HttpContext.Session.GetString("Member") != null)
            {
                var dataLogin = JsonConvert.DeserializeObject<Customer>(HttpContext.Session.GetString("Member"));
                ViewBag.Customer = dataLogin;
            }
            ViewBag.UrlAction = url;
            return View();
        }

        /// <sumary>
        /// Xứ lý chức năng khi người dùng click vào nút Register
        /// </sumary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Register(Customer model)
        {
            try
            {
                var pass = model.Password;
                model.Password = pass;
                model.CreatedDate = DateTime.Now;
                model.UpdatedDate = DateTime.Now;
                model.Isactive = 1;
                _context.Add(model);
                _context.SaveChanges();
                return View();
            }
            catch (Exception ex)
            {
                TempData["errorRegister"] = "Lỗi đăng ký" + ex.Message;
                return RedirectToAction("Index");
            }
        }

        public IActionResult Login(LoginUser model, string urlAction)
        {
            var pass = model.Password;
            var data = _context.Customers
                               .Where(x => x.Isactive == 1)
                               .Where(x => x.Username.Equals(model.UserOrEmail) || x.Email.Equals(model.UserOrEmail))
                               .FirstOrDefault(x => x.Password.Equals(pass));

            if (data != null)
            {
                // Lưu thông tin vào session khi đăng nhập thành công
                var dataLogin = JsonConvert.SerializeObject(data);
                HttpContext.Session.SetString("Member", dataLogin); // Lưu thông tin vào session

                if (!string.IsNullOrEmpty(urlAction))
                {
                    return Redirect(urlAction);  // Chuyển hướng về URL đã định
                }
                return RedirectToAction("Index");  // Quay lại trang chủ
            }

            TempData["errorLogin"] = "Lỗi đăng nhập";
            return RedirectToAction("Index");
        }

        // Đăng xuất
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("Member");  // Xóa session khi đăng xuất
            return RedirectToAction("Index", "Home");
        }

    }
}
