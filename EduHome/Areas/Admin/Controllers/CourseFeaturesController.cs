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
    public class CourseFeaturesController : Controller
    {
        private readonly AppDbContext _context;

        public CourseFeaturesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/CourseFeatures
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.CourseFeatures.Include(c => c.CoursesWeOffer);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Admin/CourseFeatures/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseFeature = await _context.CourseFeatures
                .Include(c => c.CoursesWeOffer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (courseFeature == null)
            {
                return NotFound();
            }

            return View(courseFeature);
        }

        // GET: Admin/CourseFeatures/Create
        public IActionResult Create()
        {
            ViewData["CoursesWeOfferId"] = new SelectList(_context.CoursesWeOffers, "Id", "Description");
            return View();
        }

        // POST: Admin/CourseFeatures/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Starts,Title,Description,AboutCourse,HowToApply,Certification,Duration,ClassDuration,SkillLevel,Language,Students,Assesments,CourseFee,IsDeleted,TimeDeleted,CoursesWeOfferId")] CourseFeature courseFeature)
        {
            if (ModelState.IsValid)
            {
                _context.Add(courseFeature);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CoursesWeOfferId"] = new SelectList(_context.CoursesWeOffers, "Id", "Description", courseFeature.CoursesWeOfferId);
            return View(courseFeature);
        }

        // GET: Admin/CourseFeatures/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseFeature = await _context.CourseFeatures.FindAsync(id);
            if (courseFeature == null)
            {
                return NotFound();
            }
            ViewData["CoursesWeOfferId"] = new SelectList(_context.CoursesWeOffers, "Id", "Description", courseFeature.CoursesWeOfferId);
            return View(courseFeature);
        }

        // POST: Admin/CourseFeatures/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Starts,Title,Description,AboutCourse,HowToApply,Certification,Duration,ClassDuration,SkillLevel,Language,Students,Assesments,CourseFee,IsDeleted,TimeDeleted,CoursesWeOfferId")] CourseFeature courseFeature)
        {
            if (id != courseFeature.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(courseFeature);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseFeatureExists(courseFeature.Id))
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
            ViewData["CoursesWeOfferId"] = new SelectList(_context.CoursesWeOffers, "Id", "Description", courseFeature.CoursesWeOfferId);
            return View(courseFeature);
        }

        // GET: Admin/CourseFeatures/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseFeature = await _context.CourseFeatures
                .Include(c => c.CoursesWeOffer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (courseFeature == null)
            {
                return NotFound();
            }

            return View(courseFeature);
        }

        // POST: Admin/CourseFeatures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var courseFeature = await _context.CourseFeatures.FindAsync(id);
            _context.CourseFeatures.Remove(courseFeature);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseFeatureExists(int id)
        {
            return _context.CourseFeatures.Any(e => e.Id == id);
        }
    }
}
