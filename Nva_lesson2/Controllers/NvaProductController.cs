using Microsoft.AspNetCore.Mvc;
using Nva_lesson2.Models;

namespace Nva_lesson2.Controllers
{
    public class NvaProductController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.name = "Vuong Anh";
            ViewData["address"] = "Fit NTU ";
            TempData["UNI"] = "Trường Đại Học Nguyễn Trãi";

            return View();
        }
        // Danh sách sản phẩm
        public IActionResult GetProducts()
        {
            // Mock data - Tạo danh sách sản phẩm
            List<NvaProduct> productList = new List<NvaProduct>
    {
        new NvaProduct
        {
            ProductId = "P001",
            ProductName = "Laptop Dell Vostro",
            YearRelease = 2024,
            Price = 12000000
        },
        new NvaProduct
        {
            ProductId = "P002",
            ProductName = "iPhone 15 Pro Max",
            YearRelease = 2023,
            Price = 28990000
        },
        new NvaProduct
        {
            ProductId = "P003",
            ProductName = "iPad Mini 6",
            YearRelease = 2021,
            Price = 11990000
        },
        new NvaProduct
        {
            ProductId = "P004",
            ProductName = "Tai nghe Logitech G PRO X",
            YearRelease = 2022,
            Price = 3290000
        },
        new NvaProduct
        {
            ProductId = "P005",
            ProductName = "Bàn phím Cơ AKKO 3087",
            YearRelease = 2023,
            Price = 1550000
        }
    };

            return View(productList); // Truyền danh sách sang View
        }
    }
}
