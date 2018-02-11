using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Fish_Registration.Data;
using Fish_Registration.Models;

namespace Fish_Registration.Controllers
{
    public class CaptainsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CaptainsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Captains
        public async Task<IActionResult> Index()
        {
            return View(await _context.Captain.ToListAsync());
        }

        // GET: Captains/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var captain = await _context.Captain
                .SingleOrDefaultAsync(m => m.ID == id);
            if (captain == null)
            {
                return NotFound();
            }

            return View(captain);
        }

        // GET: Captains/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Captains/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,FirstName,LastName")] Captain captain)
        {
            if (ModelState.IsValid)
            {
                _context.Add(captain);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(captain);
        }

        // GET: Captains/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var captain = await _context.Captain.SingleOrDefaultAsync(m => m.ID == id);
            if (captain == null)
            {
                return NotFound();
            }
            return View(captain);
        }

        // POST: Captains/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,FirstName,LastName")] Captain captain)
        {
            if (id != captain.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(captain);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CaptainExists(captain.ID))
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
            return View(captain);
        }

        // GET: Captains/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var captain = await _context.Captain
                .SingleOrDefaultAsync(m => m.ID == id);
            if (captain == null)
            {
                return NotFound();
            }

            return View(captain);
        }

        // POST: Captains/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var captain = await _context.Captain.SingleOrDefaultAsync(m => m.ID == id);
            _context.Captain.Remove(captain);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CaptainExists(int id)
        {
            return _context.Captain.Any(e => e.ID == id);
        }
    }
}
