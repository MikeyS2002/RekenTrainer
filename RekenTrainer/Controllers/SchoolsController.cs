using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RekenTrainer.Models;
using RekenTrainer.Models.ViewModels;

namespace RekenTrainer.Controllers
{
    public class SchoolsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SchoolsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize(Roles = "Leraar")]
        // GET: Schools
        public async Task<IActionResult> Index()
        {
            return View(await _context.School.ToListAsync());
        }

        [Authorize(Roles = "Leraar")]
        // GET: Schools/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var school = await _context.School
                .FirstOrDefaultAsync(m => m.Qid == id);
            if (school == null)
            {
                return NotFound();
            }

            return View(school);
        }

        [Authorize(Roles = "Leraar")]
        // GET: Schools/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Schools/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Qid,Question,Option1,Option2,Option3,Option4,Correctans,Category")] School school)
        {
            if (ModelState.IsValid)
            {
                _context.Add(school);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(school);
        }

        [Authorize(Roles = "Leraar")]
        // GET: Schools/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var school = await _context.School.FindAsync(id);
            if (school == null)
            {
                return NotFound();
            }
            return View(school);
        }

        // POST: Schools/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Qid,Question,Option1,Option2,Option3,Option4,Correctans,Category")] School school)
        {
            if (id != school.Qid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(school);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SchoolExists(school.Qid))
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
            return View(school);
        }

        [Authorize(Roles = "Leraar")]
        // GET: Schools/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var school = await _context.School
                .FirstOrDefaultAsync(m => m.Qid == id);
            if (school == null)
            {
                return NotFound();
            }

            return View(school);
        }

        // POST: Schools/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var school = await _context.School.FindAsync(id);
            _context.School.Remove(school);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SchoolExists(int id)
        {
            return _context.School.Any(e => e.Qid == id);
        }

        [Authorize(Roles = "Leraar, Leerling")]
        public IActionResult Optellen()
        {
            var optellen = from e in _context.School
                           where e.Category == "Optellen"
                           select e;
            return View(optellen);
        }

        public IActionResult Aftrekken()
        {
            var aftrekken = from e in _context.School
                           where e.Category == "Aftrekken"
                           select e;
            return View(aftrekken);
        }

        public IActionResult Geld()
        {
            var geld = from e in _context.School
                            where e.Category == "Geld"
                            select e;
            return View(geld);
        }

        public IActionResult Meten()
        {
            var meten = from e in _context.School
                       where e.Category == "Meten"
                       select e;
            return View(meten);
        }

        public IActionResult Delen()
        {
            var delen = from e in _context.School
                        where e.Category == "Delen"
                        select e;
            return View(delen);
        }

        public IActionResult Vermenigvuldigen()
        {
            var vermenigvuldigen = from e in _context.School
                        where e.Category == "Vermenigvuldigen"
                        select e;
            return View(vermenigvuldigen);
        }

        public IActionResult Percentage()
        {
            var percentage = from e in _context.School
                        where e.Category == "Percentage"
                        select e;
            return View(percentage);
        }

    }
}
