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
    public class OurTeachersController : Controller
    {
        private readonly AppDbContext _context;

        public OurTeachersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/OurTeachers
        public async Task<IActionResult> Index()
        {
            return View(await _context.OurTeachers.ToListAsync());
        }

        // GET: Admin/OurTeachers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ourTeacher = await _context.OurTeachers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ourTeacher == null)
            {
                return NotFound();
            }

            return View(ourTeacher);
        }

        // GET: Admin/OurTeachers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/OurTeachers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Image,Name,Position,Facebook,Pinterest,Vimeo,Twitter,IsDeleted,TimeDeleted")] OurTeacher ourTeacher)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ourTeacher);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ourTeacher);
        }

        // GET: Admin/OurTeachers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ourTeacher = await _context.OurTeachers.FindAsync(id);
            if (ourTeacher == null)
            {
                return NotFound();
            }
            return View(ourTeacher);
        }

        // POST: Admin/OurTeachers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Image,Name,Position,Facebook,Pinterest,Vimeo,Twitter,IsDeleted,TimeDeleted")] OurTeacher ourTeacher)
        {
            if (id != ourTeacher.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ourTeacher);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OurTeacherExists(ourTeacher.Id))
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
            return View(ourTeacher);
        }

        // GET: Admin/OurTeachers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ourTeacher = await _context.OurTeachers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ourTeacher == null)
            {
                return NotFound();
            }

            return View(ourTeacher);
        }

        // POST: Admin/OurTeachers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ourTeacher = await _context.OurTeachers.FindAsync(id);
            _context.OurTeachers.Remove(ourTeacher);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OurTeacherExists(int id)
        {
            return _context.OurTeachers.Any(e => e.Id == id);
        }
    }
}
