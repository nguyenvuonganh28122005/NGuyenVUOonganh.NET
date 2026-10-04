using Microsoft.AspNetCore.Mvc;

namespace Nva_lesson14.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Quản Lý Khách Hàng";
            return View();
        }
    }
}
