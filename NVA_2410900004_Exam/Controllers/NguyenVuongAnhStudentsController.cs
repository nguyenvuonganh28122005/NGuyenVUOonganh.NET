
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NVA_2410900004_Exam.Models;

public class NguyenVuongAnhStudentsController : Controller
{
    private readonly NguyenVuongAnhStudentContext _context;

    public NguyenVuongAnhStudentsController(NguyenVuongAnhStudentContext context)
    {
        _context = context;
    }

    // GET: NGUYENVUONGANHSTUDENTS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.NguyenVuongAnhStudents.ToListAsync());
    }

    // GET: NGUYENVUONGANHSTUDENTS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var nguyenvuonganhstudent = await _context.NguyenVuongAnhStudents
            .FirstOrDefaultAsync(m => m.Id == id);
        if (nguyenvuonganhstudent == null)
        {
            return NotFound();
        }

        return View(nguyenvuonganhstudent);
    }

    // GET: NGUYENVUONGANHSTUDENTS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: NGUYENVUONGANHSTUDENTS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,NguyenVuongAnhName,NguyenVuongAnhGender,NguyenVuongAnhBirthDay,NguyenVuongAnhEmail,NguyenVuongAnhPhone,NguyenVuongAnhActive")] NguyenVuongAnhStudent nguyenvuonganhstudent)
    {
        if (ModelState.IsValid)
        {
            _context.Add(nguyenvuonganhstudent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(nguyenvuonganhstudent);
    }

    // GET: NGUYENVUONGANHSTUDENTS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var nguyenvuonganhstudent = await _context.NguyenVuongAnhStudents.FindAsync(id);
        if (nguyenvuonganhstudent == null)
        {
            return NotFound();
        }
        return View(nguyenvuonganhstudent);
    }

    // POST: NGUYENVUONGANHSTUDENTS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,NguyenVuongAnhName,NguyenVuongAnhGender,NguyenVuongAnhBirthDay,NguyenVuongAnhEmail,NguyenVuongAnhPhone,NguyenVuongAnhActive")] NguyenVuongAnhStudent nguyenvuonganhstudent)
    {
        if (id != nguyenvuonganhstudent.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(nguyenvuonganhstudent);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NguyenVuongAnhStudentExists(nguyenvuonganhstudent.Id))
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
        return View(nguyenvuonganhstudent);
    }

    // GET: NGUYENVUONGANHSTUDENTS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var nguyenvuonganhstudent = await _context.NguyenVuongAnhStudents
            .FirstOrDefaultAsync(m => m.Id == id);
        if (nguyenvuonganhstudent == null)
        {
            return NotFound();
        }

        return View(nguyenvuonganhstudent);
    }

    // POST: NGUYENVUONGANHSTUDENTS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var nguyenvuonganhstudent = await _context.NguyenVuongAnhStudents.FindAsync(id);
        if (nguyenvuonganhstudent != null)
        {
            _context.NguyenVuongAnhStudents.Remove(nguyenvuonganhstudent);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool NguyenVuongAnhStudentExists(int? id)
    {
        return _context.NguyenVuongAnhStudents.Any(e => e.Id == id);
    }
}
