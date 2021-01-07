using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EduHome.DAL;
using EduHome.Models;
using Microsoft.AspNetCore.Authorization;

namespace EduHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ChooseEduHomesController : Controller
    {
        private readonly AppDbContext _context;

        public ChooseEduHomesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/ChooseEduHomes
        public async Task<IActionResult> Index()
        {
            return View(await _context.ChooseEduHomes.ToListAsync());
        }

        // GET: Admin/ChooseEduHomes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chooseEduHome = await _context.ChooseEduHomes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (chooseEduHome == null)
            {
                return NotFound();
            }

            return View(chooseEduHome);
        }

        // GET: Admin/ChooseEduHomes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/ChooseEduHomes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,IsDeleted,TimeDeleted")] ChooseEduHome chooseEduHome)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chooseEduHome);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chooseEduHome);
        }

        // GET: Admin/ChooseEduHomes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chooseEduHome = await _context.ChooseEduHomes.FindAsync(id);
            if (chooseEduHome == null)
            {
                return NotFound();
            }
            return View(chooseEduHome);
        }

        // POST: Admin/ChooseEduHomes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,IsDeleted,TimeDeleted")] ChooseEduHome chooseEduHome)
        {
            if (id != chooseEduHome.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chooseEduHome);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChooseEduHomeExists(chooseEduHome.Id))
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
            return View(chooseEduHome);
        }

        // GET: Admin/ChooseEduHomes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chooseEduHome = await _context.ChooseEduHomes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (chooseEduHome == null)
            {
                return NotFound();
            }

            return View(chooseEduHome);
        }

        // POST: Admin/ChooseEduHomes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chooseEduHome = await _context.ChooseEduHomes.FindAsync(id);
            _context.ChooseEduHomes.Remove(chooseEduHome);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChooseEduHomeExists(int id)
        {
            return _context.ChooseEduHomes.Any(e => e.Id == id);
        }
    }
}
