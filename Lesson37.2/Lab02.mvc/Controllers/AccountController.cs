using Lab02.mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab02.mvc.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            List<Account> accounts = new List<Account>
            {
                new Account()
                {
                    Id = 1,
                    Name = "Hoàng Anh",
                    Email = "anh@gmail.com",
                    Phone = "0987654321",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/images/Avatar/1.jpg"),
                    Gender = 1,
                    Bio = "Bad",
                    Birthday = new DateTime(2003, 9 , 3)
                },
                new Account()
                {
                    Id = 2,
                    Name = "Trường Giang",
                    Email = "giang@gmail.com",
                    Phone = "0987654321",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/images/Avatar/2.jpg"),
                    Gender = 1,
                    Bio = "Bad",
                    Birthday = new DateTime(2003, 9 , 3)
                },
                new Account()
                {
                    Id = 3,
                    Name = "Hoàng Thúy",
                    Email = "thuy@gmail.com",
                    Phone = "0987654321",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/images/Avatar/3.jpg"),
                    Gender = 1,
                    Bio = "Bad",
                    Birthday = new DateTime(2003, 9 , 3)
                },
                new Account()
                {
                    Id = 4,
                    Name = "Minh Anh",
                    Email = "anh123@gmail.com",
                    Phone = "0987654321",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/images/Avatar/4.jpg"),
                    Gender = 1,
                    Bio = "Bad",
                    Birthday = new DateTime(2003, 9 , 3)
                },
            };
            ViewBag.Accounts = accounts;
            return View();
        }

        // Định nghĩa url và cho action
        [Route("ho-so-cua-toi", Name = "profile")]
        public IActionResult Profile(int id)
        {
            List<Account> accounts = new List<Account>
            {
                new Account()
                {
                    Id = 1,
                    Name = "Hoàng Anh",
                    Email = "anh@gmail.com",
                    Phone = "0987654321",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/images/Avatar/1.jpg"),
                    Gender = 1,
                    Bio = "Bad",
                    Birthday = new DateTime(2003, 9 , 3)
                },
                new Account()
                {
                    Id = 2,
                    Name = "Trường Giang",
                    Email = "giang@gmail.com",
                    Phone = "0987654321",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/images/Avatar/2.jpg"),
                    Gender = 1,
                    Bio = "Bad",
                    Birthday = new DateTime(2003, 9 , 3)
                },
                new Account()
                {
                    Id = 3,
                    Name = "Hoàng Thúy",
                    Email = "thuy@gmail.com",
                    Phone = "0987654321",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/images/Avatar/3.jpg"),
                    Gender = 1,
                    Bio = "Bad",
                    Birthday = new DateTime(2003, 9 , 3)
                },
                new Account()
                {
                    Id = 4,
                    Name = "Minh Anh",
                    Email = "anh123@gmail.com",
                    Phone = "0987654321",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/images/Avatar/4.jpg"),
                    Gender = 1,
                    Bio = "Bad",
                    Birthday = new DateTime(2003, 9 , 3)
                },
            };
            
            // Truy xuất dữ liệu 1 đối tượng 
            Account account = accounts.FirstOrDefault(ac => ac.Id == id);
            // Gửi đối tượng account qua view
            ViewBag.accounts = account;
            return View();
        }
    }
}
