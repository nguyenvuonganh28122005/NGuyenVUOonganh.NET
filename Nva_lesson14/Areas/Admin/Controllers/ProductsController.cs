using Microsoft.AspNetCore.Mvc;

namespace Nva_lesson14.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Quản Lý Sản Phẩm";
            return View();
        }

        public IActionResult Create()
        {
            ViewData["Title"] = "Thêm Mới Sản Phẩm";
            return View();
        }
    }
}
