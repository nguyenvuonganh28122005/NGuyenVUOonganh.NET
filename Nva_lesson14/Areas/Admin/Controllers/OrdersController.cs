using Microsoft.AspNetCore.Mvc;

namespace Nva_lesson14.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Quản Lý Đơn Hàng";
            return View();
        }
    }
}
