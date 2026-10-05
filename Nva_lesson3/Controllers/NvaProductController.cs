using Microsoft.AspNetCore.Mvc;
using Nva_lesson3.Models;

namespace Nva_lesson3.Controllers
{
    public class NvaProductController : Controller
    {
        private readonly List<NvaProduct> _products = new()
        {
            new NvaProduct
            {
                NvaProductId = "PROD-001",
                NvaProductName = "CPU Intel Core i9-14900K",
                NvaYearRelease = "2023",
                NvaPrice = 589.99m
            },
            new NvaProduct
            {
                NvaProductId = "PROD-002",
                NvaProductName = "CPU AMD Ryzen 7 7800X3D",
                NvaYearRelease = "2023",
                NvaPrice = 449.00m
            },
            new NvaProduct
            {
                NvaProductId = "PROD-003",
                NvaProductName = "VGA NVIDIA GeForce RTX 4090 24GB",
                NvaYearRelease = "2022",
                NvaPrice = 1599.99m
            }
        };
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetAllProduct() 
        {
            ViewData["products"]= _products;
            return View();
        }
    }
}
