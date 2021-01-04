using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EduHome.DAL;
using EduHome.Extensions;
using EduHome.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EduHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CoursesController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public CoursesController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.CoursesWeOffers.Where(c => c.IsDeleted==false).ToList());
        }


        #region Create
        //Create - Get method
        public IActionResult Create()
        {
            return View();
        }

        //Create - Post method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CoursesWeOffer course)
        {
            //-- Photo --//

            if (course.Photo == null)
            {
                ModelState.AddModelError("Photo", "Please insert a photo");
                return View();
            }

            if (!course.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Please select jpg or png type");
                return View();
            }

            if (!course.Photo.MaxSize(300))
            {
                ModelState.AddModelError("Photo", "Max size of the picture must be less than 200kb");
                return View();
            }

            string fileName = Guid.NewGuid().ToString() + course.Photo.FileName;
            string path = Path.Combine(_env.WebRootPath, "img", "course", fileName);

            //--FileStream--
            FileStream fileStream = new FileStream(path, FileMode.Create);
            await course.Photo.CopyToAsync(fileStream);


            //-- Text --//

            if (!ModelState.IsValid) return NotFound(course);

            bool isExist = _context.CoursesWeOffers.Where(c => c.IsDeleted == false)
                .Any(c => c.Name.ToLower() == course.Name.ToLower());
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
        #endregion


        #region Detail
        //---Detail---//
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            CoursesWeOffer course = _context.CoursesWeOffers.Where(c => c.IsDeleted == false).FirstOrDefault(c => c.Id == id);
            if (course == null) return NotFound();
            return View(course);
        }
        #endregion


        #region Delete
        //--- Delete - Get method ---//
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            CoursesWeOffer course = _context.CoursesWeOffers.Where(c => c.IsDeleted == false).FirstOrDefault(c => c.Id == id);
            if (course == null) return NotFound();
            return View(course);
        }


        //--- Delete - Post method ---//
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            CoursesWeOffer course = _context.CoursesWeOffers.Where(c => c.IsDeleted == false)
                .Include(c => c.CourseFeature).FirstOrDefault(c => c.Id == id);

            if (course == null) return NotFound();

            _context.CoursesWeOffers.Remove(course);
            await _context.SaveChangesAsync();

            //course.IsDeleted = true;
            //course.DeletedTime = DateTime.Now;
            //foreach (CourseFeature cf in course.CourseFeatures)
            //{
            //    cf.DeletedTime = DateTime.Now;
            //    cf.IsDeleted = true;
            //}

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion

    }
}
