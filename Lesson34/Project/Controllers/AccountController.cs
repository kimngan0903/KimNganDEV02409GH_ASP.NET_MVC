using Microsoft.AspNetCore.Mvc;
using Project.Models;
using System.Net;
using System.Numerics;
using System.Reflection;
using System.Security.Principal;
using System.Xml.Linq;

namespace Project.Controllers
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
                    Phone = "123456789",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/images/Avatar/images.jpg"),
                    Gender = 1,
                    Bio = "My name is big",
                    Birthday = new DateTime(1998,7,15)
                },
                new Account()
                {
                    Id = 2,
                    Name = "Trường Giang",
                    Email = "giang@gmail.com",
                    Phone = "234567890",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/images/Avatar/images.jpg"),
                    Gender = 1,
                    Bio = "My name is big",
                    Birthday = new DateTime(1997,7,15)
                },
                new Account()
                {
                    Id = 3,
                    Name = "Hoàng Thúy",
                    Email = "thuy@gmail.com",
                    Phone = "123456789",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/images/Avatar/images.jpg"),
                    Gender = 1,
                    Bio = "My name is big",
                    Birthday = new DateTime(1998,7,15)
                }
            };
            // Gửi đối tượng account qua view
            ViewBag.Accounts = accounts;
            return View();
        }

        // Định nghĩa url và nam cho action
        [Route("ho-so-cua-toi", Name = "Profile")]
        public IActionResult Profile(int id)
        {
            List<Account> accounts = new List<Account>
            {
                new Account()
                {
                    Id = 1,
                    Name = "Hoàng Anh",
                    Email = "anh@gmail.com",
                    Phone = "123456789",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/images/Avatar/images.jpg"),
                    Gender = 1,
                    Bio = "My name is big",
                    Birthday = new DateTime(1998,7,15)
                },
                new Account()
                {
                    Id = 2,
                    Name = "Trường Giang",
                    Email = "giang@gmail.com",
                    Phone = "234567890",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/images/Avatar/images.jpg"),
                    Gender = 1,
                    Bio = "My name is big",
                    Birthday = new DateTime(1997,7,15)
                },
                new Account()
                {
                    Id = 3,
                    Name = "Hoàng Thúy",
                    Email = "thuy@gmail.com",
                    Phone = "123456789",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/images/Avatar/images.jpg"),
                    Gender = 1,
                    Bio = "My name is big",
                    Birthday = new DateTime(1998,7,15)
                }
            };
            // Sử dụng using System.Linq; truy xuất dữ liệu 1 đối tượng trong danh sách theo id
            Account account = accounts.FirstOrDefault(ac => ac.Id == id);
            // Gửi đối tượng account qua view
            ViewBag.account = account;
            return View();


            //Account account = new Account()
            //{
            //    Id = 1,
            //    Name = "Hoàng Anh",
            //    Email = "anh@gmail.com",
            //    Phone = "123456789",
            //    Address = "Hà Nội",
            //    Avatar = Url.Content("~/images/Avatar/images.jpg"),
            //    Gender = 1,
            //    Bio = "My name is big",
            //    Birthday = new DateTime(1998, 7, 15)
            //};
        }
    }
}
