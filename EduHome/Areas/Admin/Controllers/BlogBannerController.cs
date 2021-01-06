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
    public class BlogBannerController : Controller
    {
        private readonly AppDbContext _context;

        public BlogBannerController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/BlogBanner
        public async Task<IActionResult> Index()
        {
            return View(await _context.BlogBanners.ToListAsync());
        }

        // GET: Admin/BlogBanner/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogBanner = await _context.BlogBanners
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blogBanner == null)
            {
                return NotFound();
            }

            return View(blogBanner);
        }

        // GET: Admin/BlogBanner/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/BlogBanner/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Image,IsDeleted,TimeDeleted")] BlogBanner blogBanner)
        {
            if (ModelState.IsValid)
            {
                _context.Add(blogBanner);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(blogBanner);
        }

        // GET: Admin/BlogBanner/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogBanner = await _context.BlogBanners.FindAsync(id);
            if (blogBanner == null)
            {
                return NotFound();
            }
            return View(blogBanner);
        }

        // POST: Admin/BlogBanner/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Image,IsDeleted,TimeDeleted")] BlogBanner blogBanner)
        {
            if (id != blogBanner.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(blogBanner);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlogBannerExists(blogBanner.Id))
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
            return View(blogBanner);
        }

        // GET: Admin/BlogBanner/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogBanner = await _context.BlogBanners
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blogBanner == null)
            {
                return NotFound();
            }

            return View(blogBanner);
        }

        // POST: Admin/BlogBanner/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var blogBanner = await _context.BlogBanners.FindAsync(id);
            _context.BlogBanners.Remove(blogBanner);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlogBannerExists(int id)
        {
            return _context.BlogBanners.Any(e => e.Id == id);
        }
    }
}
