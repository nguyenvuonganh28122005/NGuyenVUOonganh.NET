using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Nva_lesson8.Models;

namespace Nva_lesson8.Controllers
{
    public class NvaHomeController : Controller
    {
        private readonly ILogger<NvaHomeController> _logger;

        public NvaHomeController(ILogger<NvaHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult NvaIndex()
        {
            return View();
        }

        public IActionResult NvaPrivacy()
        {
            return View();
        }
        public IActionResult NvaAbout()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
