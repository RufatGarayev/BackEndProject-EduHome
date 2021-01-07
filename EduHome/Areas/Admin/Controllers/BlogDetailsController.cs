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
    public class BlogDetailsController : Controller
    {
        private readonly AppDbContext _context;

        public BlogDetailsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/BlogDetails
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.BlogDetails.Include(b => b.LatestFromBlog);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Admin/BlogDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogDetail = await _context.BlogDetails
                .Include(b => b.LatestFromBlog)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blogDetail == null)
            {
                return NotFound();
            }

            return View(blogDetail);
        }

        // GET: Admin/BlogDetails/Create
        public IActionResult Create()
        {
            ViewData["LatestFromBlogId"] = new SelectList(_context.LatestFromBlogs, "Id", "Image");
            return View();
        }

        // POST: Admin/BlogDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description,IsDeleted,TimeDeleted,LatestFromBlogId")] BlogDetail blogDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(blogDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LatestFromBlogId"] = new SelectList(_context.LatestFromBlogs, "Id", "Image", blogDetail.LatestFromBlogId);
            return View(blogDetail);
        }

        // GET: Admin/BlogDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogDetail = await _context.BlogDetails.FindAsync(id);
            if (blogDetail == null)
            {
                return NotFound();
            }
            ViewData["LatestFromBlogId"] = new SelectList(_context.LatestFromBlogs, "Id", "Image", blogDetail.LatestFromBlogId);
            return View(blogDetail);
        }

        // POST: Admin/BlogDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Description,IsDeleted,TimeDeleted,LatestFromBlogId")] BlogDetail blogDetail)
        {
            if (id != blogDetail.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(blogDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlogDetailExists(blogDetail.Id))
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
            ViewData["LatestFromBlogId"] = new SelectList(_context.LatestFromBlogs, "Id", "Image", blogDetail.LatestFromBlogId);
            return View(blogDetail);
        }

        // GET: Admin/BlogDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogDetail = await _context.BlogDetails
                .Include(b => b.LatestFromBlog)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blogDetail == null)
            {
                return NotFound();
            }

            return View(blogDetail);
        }

        // POST: Admin/BlogDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var blogDetail = await _context.BlogDetails.FindAsync(id);
            _context.BlogDetails.Remove(blogDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlogDetailExists(int id)
        {
            return _context.BlogDetails.Any(e => e.Id == id);
        }
    }
}
