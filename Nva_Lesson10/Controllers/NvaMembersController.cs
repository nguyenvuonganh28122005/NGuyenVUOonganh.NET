using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nva_Lesson10.Models;

namespace Nva_Lesson10.Controllers
{
    public class NvaMembersController : Controller
    {
        private readonly NvaLesson10Context _context;

        public NvaMembersController(NvaLesson10Context context)
        {
            _context = context;
        }

        // GET: NvaMembers
        public async Task<IActionResult> Index()
        {
            return View(await _context.NvaMembers.ToListAsync());
        }

        // GET: NvaMembers/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nvamember = await _context.NvaMembers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nvamember == null)
            {
                return NotFound();
            }

            return View(nvamember);
        }

        // GET: NvaMembers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NvaMembers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NvaUserName,NvaPassword,NvaFullName,NvaEmail,NvaPhone,NvaStatus")] NvaMember nvamember)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nvamember);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nvamember);
        }

        // GET: NvaMembers/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nvamember = await _context.NvaMembers.FindAsync(id);
            if (nvamember == null)
            {
                return NotFound();
            }
            return View(nvamember);
        }

        // POST: NvaMembers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,NvaUserName,NvaPassword,NvaFullName,NvaEmail,NvaPhone,NvaStatus")] NvaMember nvamember)
        {
            if (id != nvamember.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nvamember);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NvaMemberExists(nvamember.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(nvamember);
        }

        // GET: NvaMembers/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nvamember = await _context.NvaMembers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nvamember == null)
            {
                return NotFound();
            }

            return View(nvamember);
        }

        // POST: NvaMembers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var nvamember = await _context.NvaMembers.FindAsync(id);
            if (nvamember != null)
            {
                _context.NvaMembers.Remove(nvamember);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        private bool NvaMemberExists(long id)
        {
            return _context.NvaMembers.Any(e => e.Id == id);
        }
    }
}