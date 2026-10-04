using Microsoft.AspNetCore.Mvc;

namespace Nva_lesson14.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Trang Quản Trị - Dashboard";
            return View();
        }
    }
}
