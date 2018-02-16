using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Fish_Registration.Data;
using Fish_Registration.Models;
using Microsoft.AspNetCore.Identity;

namespace Fish_Registration.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _UserManager;
       

        public ProjectsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _UserManager = userManager;
          
        }

        // GET: Projects
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Project.Include(p => p.GetCaptainVessel).Include(p => p.GetCaptainVessel.Vessel);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Projects/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Project
                .Include(p => p.GetCaptainVessel)
                .SingleOrDefaultAsync(m => m.ProjectId == id);
            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }

        // GET: Projects/Create
        public IActionResult Create()
        {
            IQueryable<Vessel> vesselQuery = from v in _context.Vessel select v;

            //ViewData["CaptainVesselId"] = new SelectList(vessal, "CaptainVesselId", "Name");
            var captainVessel = _context.CaptainVessel.ToList();
            captainVessel.ForEach(cv => cv.Vessel = vesselQuery.First(v => v.VesselId == cv.VesselID));
            ViewData["CaptainVesselId"] = new SelectList(captainVessel, "CaptainVesselId", "Vessel.Name");
            return View();
        }

        // POST: Projects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProjectId,Name,CaptainVesselId,UserId,Start,End")] Project project)
        {
            if (ModelState.IsValid)
            {
                var user = await _UserManager.GetUserAsync(User);

                project.UserId = user.Id;
                _context.Add(project);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CaptainVesselId"] = new SelectList(_context.Set<CaptainVessel>(), "CaptainVesselId", "CaptainVesselId", project.CaptainVesselId);
            return View(project);
        }

        // GET: Projects/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Project.SingleOrDefaultAsync(m => m.ProjectId == id);
            if (project == null)
            {
                return NotFound();
            }
            IQueryable<Vessel> vesselQuery = from v in _context.Vessel select v;

            var captainVessel = _context.CaptainVessel.ToList();
            captainVessel.ForEach(cv => cv.Vessel = vesselQuery.First(v => v.VesselId == cv.VesselID));
            ViewData["CaptainVesselId"] = new SelectList(captainVessel, "CaptainVesselId", "Vessel.Name", project.CaptainVesselId);
            return View(project);
        }

        // POST: Projects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProjectId,Name,CaptainVesselId,UserId,Start,End")] Project project)
        {
            if (id != project.ProjectId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(project);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectExists(project.ProjectId))
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
            ViewData["CaptainVesselId"] = new SelectList(_context.Set<CaptainVessel>(), "CaptainVesselId", "CaptainVesselId", project.CaptainVesselId);
            return View(project);
        }

        // GET: Projects/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Project
                .Include(p => p.GetCaptainVessel)
                .SingleOrDefaultAsync(m => m.ProjectId == id);
            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }

        // POST: Projects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var project = await _context.Project.SingleOrDefaultAsync(m => m.ProjectId == id);
            _context.Project.Remove(project);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectExists(int id)
        {
            return _context.Project.Any(e => e.ProjectId == id);
        }

        // For the rate vessel page
         public IActionResult RateVessel()
        {
            return View();
        }

        / For the rate vessel page
         public IActionResult VesselRatings()
        {
            return View();
        }
    }
}
