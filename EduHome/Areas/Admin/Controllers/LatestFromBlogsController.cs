using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EduHome.DAL;
using EduHome.Models;
using EduHome.Extensions;
using Microsoft.AspNetCore.Authorization;

namespace EduHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class LatestFromBlogsController : Controller
    {
        private readonly AppDbContext _context;

        public LatestFromBlogsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/LatestFromBlogs
        public async Task<IActionResult> Index()
        {
            return View(await _context.LatestFromBlogs.ToListAsync());
        }

        // GET: Admin/LatestFromBlogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var latestFromBlog = await _context.LatestFromBlogs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (latestFromBlog == null)
            {
                return NotFound();
            }

            return View(latestFromBlog);
        }

        // GET: Admin/LatestFromBlogs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/LatestFromBlogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Image,Composer,Description,Date,IsDeleted,TimeDeleted")] LatestFromBlog latestFromBlog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(latestFromBlog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(latestFromBlog);
        }

        // GET: Admin/LatestFromBlogs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var latestFromBlog = await _context.LatestFromBlogs.FindAsync(id);
            if (latestFromBlog == null)
            {
                return NotFound();
            }
            return View(latestFromBlog);
        }

        // POST: Admin/LatestFromBlogs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Image,Composer,Description,Date,IsDeleted,TimeDeleted")] LatestFromBlog latestFromBlog)
        {
            if (id != latestFromBlog.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(latestFromBlog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LatestFromBlogExists(latestFromBlog.Id))
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
            return View(latestFromBlog);
        }

        // GET: Admin/LatestFromBlogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var latestFromBlog = await _context.LatestFromBlogs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (latestFromBlog == null)
            {
                return NotFound();
            }

            return View(latestFromBlog);
        }

        // POST: Admin/LatestFromBlogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var latestFromBlog = await _context.LatestFromBlogs.FindAsync(id);
            _context.LatestFromBlogs.Remove(latestFromBlog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LatestFromBlogExists(int id)
        {
            return _context.LatestFromBlogs.Any(e => e.Id == id);
        }
    }
}
