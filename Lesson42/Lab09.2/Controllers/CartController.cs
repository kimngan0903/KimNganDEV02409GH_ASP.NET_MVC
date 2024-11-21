using Lab09._2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;

namespace Lab09._2.Controllers
{
    public class CartController : Controller, IActionFilter
    {
        private readonly DevXuongMocContext _context;
        public List<Cart> carts = new List<Cart>();
        public CartController(DevXuongMocContext context)
        {
            _context = context;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var cartInSession = HttpContext.Session.GetString("My-Cart");
            if (cartInSession != null)
            {
                // Nếu cartInSession không null thì gán dữ liệu cho biến carts
                // Chyển sang json
                carts = JsonConvert.DeserializeObject<List<Cart>>(cartInSession);
            }
            base.OnActionExecuting(context);
        }
        // GET: CartController
        public IActionResult Index()
        {
            float total = 0;
            foreach (var item in carts)
            {
                total += item.Quantity * item.Price;
            }
            ViewBag.total = total; // Tổng tiền của đơn hàng
            return View(carts);
        }
        public IActionResult Add(int id)
        {
            /// <summary>
            /// Code logic cho chức năng thêm sản phẩm và giỏ hàng
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>

            if (carts.Any(c => c.Id == id)) // Nếu sản phẩm đã cs trong giỏ hàng 
            {
                carts.Where(c => c.Id == id).First().Quantity += 1; // Tăng số lượng
            }
            else // Nếu sản phẩm chưa có trong giỏ hàng, thêm sản phẩm vào giỏ hàng
            {
                var p = _context.Products.Find(id); // Tìm sản phẩm cần mua trong bảng sản phẩm
                                                    // Tạo mới một sản phẩm đẻ thêm vào giỏ hàng
                var item = new Cart()
                {
                    Id = id,
                    Name = p.Title,
                    Price = (float)p.PriceNew.Value,
                    Quantity = 1,
                    Image = p.Image,
                    Total = (float)p.PriceNew.Value * 1,
                };
                // Thêm sản phẩm vào giỏ hàng
                carts.Add(item);
            }
            // Lưu carts vào sesson, cần pahir chuyển sang dữ liệu json
            HttpContext.Session.SetString("My-Cart", JsonConvert.SerializeObject(carts));
            return RedirectToAction("Index");
        }
        public IActionResult Remove(int id)
        {
            /// <summary>
            /// Code logic cho chức năng xóa sản phẩm và giỏ hàng
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>

            if (carts.Any(c => c.Id == id))
            {
                // Tìm sản phẩm tronf giỏ hàng
                var item = carts.Where(c => c.Id == id).First();
                // Thực hiện xóa
                carts.Remove(item);

                // Lưu carts vào session, cần phải chuyển dữ liệu sang json
                HttpContext.Session.SetString("My-Cart", JsonConvert.SerializeObject(carts));
            }
            return RedirectToAction("Index");
        }
        public IActionResult Update(int id, int quantity)
        {
            /// <summary>
            /// Code logic cho chức năng cập nhật sản phẩm và giỏ hàng
            /// </summary>
            /// <param name="id"></param>
            /// <param name="quantity"></param>
            /// <returns></returns>
            
            if (carts.Any(c => c.Id == id))
            {
                // Tìm sản phẩm trong giỏ hàng và cập nhật lại số lượng mới
                carts.Where(c => c.Id == id).First().Quantity = quantity;

                // Lưu carts vào session, cần phải chuyển sang dữ liệu json
                HttpContext.Session.SetString("My-Cart", JsonConvert.SerializeObject(carts));
            }
            return RedirectToAction("Index");
        }
        public IActionResult Clear()
        {
            /// <summary>
            /// Code logic cho chức năng xóa sản phẩm và giỏ hàng
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>
            
            HttpContext.Session.Remove("My-Cart");
            return RedirectToAction("Index");
        }
    }
}
