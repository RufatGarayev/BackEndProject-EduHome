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
    public class WelcomeToEduHomesController : Controller
    {
        private readonly AppDbContext _context;

        public WelcomeToEduHomesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/WelcomeToEduHomes
        public async Task<IActionResult> Index()
        {
            return View(await _context.WelcomeToEduHomes.ToListAsync());
        }

        // GET: Admin/WelcomeToEduHomes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var welcomeToEduHome = await _context.WelcomeToEduHomes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (welcomeToEduHome == null)
            {
                return NotFound();
            }

            return View(welcomeToEduHome);
        }

        // GET: Admin/WelcomeToEduHomes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/WelcomeToEduHomes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Image,Title,Description,IsDeleted,TimeDeleted")] WelcomeToEduHome welcomeToEduHome)
        {
            if (ModelState.IsValid)
            {
                _context.Add(welcomeToEduHome);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(welcomeToEduHome);
        }

        // GET: Admin/WelcomeToEduHomes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var welcomeToEduHome = await _context.WelcomeToEduHomes.FindAsync(id);
            if (welcomeToEduHome == null)
            {
                return NotFound();
            }
            return View(welcomeToEduHome);
        }

        // POST: Admin/WelcomeToEduHomes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Image,Title,Description,IsDeleted,TimeDeleted")] WelcomeToEduHome welcomeToEduHome)
        {
            if (id != welcomeToEduHome.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(welcomeToEduHome);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WelcomeToEduHomeExists(welcomeToEduHome.Id))
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
            return View(welcomeToEduHome);
        }

        // GET: Admin/WelcomeToEduHomes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var welcomeToEduHome = await _context.WelcomeToEduHomes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (welcomeToEduHome == null)
            {
                return NotFound();
            }

            return View(welcomeToEduHome);
        }

        // POST: Admin/WelcomeToEduHomes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var welcomeToEduHome = await _context.WelcomeToEduHomes.FindAsync(id);
            _context.WelcomeToEduHomes.Remove(welcomeToEduHome);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WelcomeToEduHomeExists(int id)
        {
            return _context.WelcomeToEduHomes.Any(e => e.Id == id);
        }
    }
}
