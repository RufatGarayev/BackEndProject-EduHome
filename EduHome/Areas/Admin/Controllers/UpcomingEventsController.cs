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
    public class UpcomingEventsController : Controller
    {
        private readonly AppDbContext _context;

        public UpcomingEventsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/UpcomingEvents
        public async Task<IActionResult> Index()
        {
            return View(await _context.UpcomingEvents.ToListAsync());
        }

        // GET: Admin/UpcomingEvents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var upcomingEvent = await _context.UpcomingEvents
                .FirstOrDefaultAsync(m => m.Id == id);
            if (upcomingEvent == null)
            {
                return NotFound();
            }

            return View(upcomingEvent);
        }

        // GET: Admin/UpcomingEvents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/UpcomingEvents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Day,TimeSpan,Location,IsDeleted,TimeDeleted")] UpcomingEvent upcomingEvent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(upcomingEvent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(upcomingEvent);
        }

        // GET: Admin/UpcomingEvents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var upcomingEvent = await _context.UpcomingEvents.FindAsync(id);
            if (upcomingEvent == null)
            {
                return NotFound();
            }
            return View(upcomingEvent);
        }

        // POST: Admin/UpcomingEvents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Day,TimeSpan,Location,IsDeleted,TimeDeleted")] UpcomingEvent upcomingEvent)
        {
            if (id != upcomingEvent.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(upcomingEvent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UpcomingEventExists(upcomingEvent.Id))
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
            return View(upcomingEvent);
        }

        // GET: Admin/UpcomingEvents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var upcomingEvent = await _context.UpcomingEvents
                .FirstOrDefaultAsync(m => m.Id == id);
            if (upcomingEvent == null)
            {
                return NotFound();
            }

            return View(upcomingEvent);
        }

        // POST: Admin/UpcomingEvents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var upcomingEvent = await _context.UpcomingEvents.FindAsync(id);
            _context.UpcomingEvents.Remove(upcomingEvent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UpcomingEventExists(int id)
        {
            return _context.UpcomingEvents.Any(e => e.Id == id);
        }
    }
}
