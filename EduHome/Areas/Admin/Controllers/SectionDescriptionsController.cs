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
    public class SectionDescriptionsController : Controller
    {
        private readonly AppDbContext _context;

        public SectionDescriptionsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/SectionDescriptions
        public async Task<IActionResult> Index()
        {
            return View(await _context.SectionDescriptions.ToListAsync());
        }

        // GET: Admin/SectionDescriptions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sectionDescription = await _context.SectionDescriptions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sectionDescription == null)
            {
                return NotFound();
            }

            return View(sectionDescription);
        }

        // GET: Admin/SectionDescriptions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/SectionDescriptions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,IsDeleted,TimeDeleted")] SectionDescription sectionDescription)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sectionDescription);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sectionDescription);
        }

        // GET: Admin/SectionDescriptions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sectionDescription = await _context.SectionDescriptions.FindAsync(id);
            if (sectionDescription == null)
            {
                return NotFound();
            }
            return View(sectionDescription);
        }

        // POST: Admin/SectionDescriptions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,IsDeleted,TimeDeleted")] SectionDescription sectionDescription)
        {
            if (id != sectionDescription.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sectionDescription);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SectionDescriptionExists(sectionDescription.Id))
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
            return View(sectionDescription);
        }

        // GET: Admin/SectionDescriptions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sectionDescription = await _context.SectionDescriptions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sectionDescription == null)
            {
                return NotFound();
            }

            return View(sectionDescription);
        }

        // POST: Admin/SectionDescriptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sectionDescription = await _context.SectionDescriptions.FindAsync(id);
            _context.SectionDescriptions.Remove(sectionDescription);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SectionDescriptionExists(int id)
        {
            return _context.SectionDescriptions.Any(e => e.Id == id);
        }
    }
}
