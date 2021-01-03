using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduHome.DAL;
using EduHome.Models;
using Microsoft.AspNetCore.Mvc;

namespace EduHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CoursesController : Controller
    {
        private readonly AppDbContext _context;
        public CoursesController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.CoursesWeOffers.Where(cwo => cwo.IsDeleted==false).ToList());
        }


        //Create - Get metodu
        public IActionResult Create()
        {
            return View();
        }

        //Create - Post metodu
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CoursesWeOffer course)
        {
            if (!ModelState.IsValid) return NotFound(course);

            bool isExist = _context.CoursesWeOffers.Where(k => k.IsDeleted == false)
                .Any(k => k.Name.ToLower() == course.Name.ToLower());
            if (isExist)
            {
                ModelState.AddModelError("Name", "You have already written something same this one!");
                return View();
            }

            course.IsDeleted = false;
            await _context.CoursesWeOffers.AddAsync(course);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
