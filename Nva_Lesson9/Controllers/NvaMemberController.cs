using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nva_Lesson9.Models.DataModels;

namespace Nva_Lesson9.Controllers
{
    public class NvaMemberController : Controller
    {
        // GET: NvaMemberController
        private static List<NvaMember> nvaMembers = new List<NvaMember>();
        public ActionResult Index()
        {
            return View();
        }

        // GET: NvaMemberController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NvaMemberController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NvaMemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NvaMemberController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NvaMemberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NvaMemberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NvaMemberController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
