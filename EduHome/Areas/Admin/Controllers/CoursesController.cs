﻿using System;
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
    public class CoursesController : Controller
    {
        private readonly AppDbContext _context;

        public CoursesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Courses
        public async Task<IActionResult> Index()
        {
            return View(await _context.CoursesWeOffers.ToListAsync());
        }

        // GET: Admin/Courses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coursesWeOffer = await _context.CoursesWeOffers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (coursesWeOffer == null)
            {
                return NotFound();
            }

            return View(coursesWeOffer);
        }

        // GET: Admin/Courses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Courses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Image,IsDeleted,TimeDeleted")] CoursesWeOffer coursesWeOffer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(coursesWeOffer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(coursesWeOffer);
        }

        // GET: Admin/Courses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coursesWeOffer = await _context.CoursesWeOffers.FindAsync(id);
            if (coursesWeOffer == null)
            {
                return NotFound();
            }
            return View(coursesWeOffer);
        }

        // POST: Admin/Courses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Image,IsDeleted,TimeDeleted")] CoursesWeOffer coursesWeOffer)
        {
            if (id != coursesWeOffer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(coursesWeOffer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CoursesWeOfferExists(coursesWeOffer.Id))
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
            return View(coursesWeOffer);
        }

        // GET: Admin/Courses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coursesWeOffer = await _context.CoursesWeOffers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (coursesWeOffer == null)
            {
                return NotFound();
            }

            return View(coursesWeOffer);
        }

        // POST: Admin/Courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var coursesWeOffer = await _context.CoursesWeOffers.FindAsync(id);
            _context.CoursesWeOffers.Remove(coursesWeOffer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CoursesWeOfferExists(int id)
        {
            return _context.CoursesWeOffers.Any(e => e.Id == id);
        }
    }
}
