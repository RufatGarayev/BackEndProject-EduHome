using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EduHome.DAL;
using EduHome.Models;

namespace EduHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TakeAVideoToursController : Controller
    {
        private readonly AppDbContext _context;

        public TakeAVideoToursController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/TakeAVideoTours
        public async Task<IActionResult> Index()
        {
            return View(await _context.TakeAVideoTours.ToListAsync());
        }

        // GET: Admin/TakeAVideoTours/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var takeAVideoTour = await _context.TakeAVideoTours
                .FirstOrDefaultAsync(m => m.Id == id);
            if (takeAVideoTour == null)
            {
                return NotFound();
            }

            return View(takeAVideoTour);
        }

        // GET: Admin/TakeAVideoTours/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/TakeAVideoTours/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Video,IsDeleted,TimeDeleted")] TakeAVideoTour takeAVideoTour)
        {
            if (ModelState.IsValid)
            {
                _context.Add(takeAVideoTour);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(takeAVideoTour);
        }

        // GET: Admin/TakeAVideoTours/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var takeAVideoTour = await _context.TakeAVideoTours.FindAsync(id);
            if (takeAVideoTour == null)
            {
                return NotFound();
            }
            return View(takeAVideoTour);
        }

        // POST: Admin/TakeAVideoTours/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Video,IsDeleted,TimeDeleted")] TakeAVideoTour takeAVideoTour)
        {
            if (id != takeAVideoTour.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(takeAVideoTour);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TakeAVideoTourExists(takeAVideoTour.Id))
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
            return View(takeAVideoTour);
        }

        // GET: Admin/TakeAVideoTours/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var takeAVideoTour = await _context.TakeAVideoTours
                .FirstOrDefaultAsync(m => m.Id == id);
            if (takeAVideoTour == null)
            {
                return NotFound();
            }

            return View(takeAVideoTour);
        }

        // POST: Admin/TakeAVideoTours/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var takeAVideoTour = await _context.TakeAVideoTours.FindAsync(id);
            _context.TakeAVideoTours.Remove(takeAVideoTour);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TakeAVideoTourExists(int id)
        {
            return _context.TakeAVideoTours.Any(e => e.Id == id);
        }
    }
}
