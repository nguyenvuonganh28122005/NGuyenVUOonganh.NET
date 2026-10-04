using Microsoft.AspNetCore.Mvc;

namespace Nva_lesson13.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Search(string keyword)
        {
            ViewData["keyword"] = keyword;
            return View();
        }
        public IActionResult Hots()
        {
            return View();
        }
    }
}
