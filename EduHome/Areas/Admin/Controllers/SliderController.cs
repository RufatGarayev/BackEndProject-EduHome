using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EduHome.DAL;
using EduHome.Extensions;
using EduHome.Helpers;
using EduHome.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace EduHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public SliderController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Sliders.Where(s => s.IsDeleted == false).ToList());
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
        public async Task<IActionResult> Create(Slider slider)
        {
            //-- Photo --//

            if (slider.Photo == null)
            {
                //ModelState.AddModelError("Photo", "Please insert a photo");
                return View();
            }

            if (!slider.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Please select jpg or png type");
                return View();
            }

            if (!slider.Photo.MaxSize(300))
            {
                ModelState.AddModelError("Photo", "Max size of the picture must be less than 200kb");
                return View();
            }

            string fileName = Guid.NewGuid().ToString() + slider.Photo.FileName;
            string path = Path.Combine(_env.WebRootPath, "img", fileName);

            //--FileStream--
            FileStream fileStream = new FileStream(path, FileMode.Create);
            await slider.Photo.CopyToAsync(fileStream);


            //-- Text --//

            if (!ModelState.IsValid) return NotFound(slider);

            bool isExist = _context.Sliders.Where(s => s.IsDeleted == false)
                .Any(s => s.Title.ToLower() == slider.Title.ToLower());
            if (isExist)
            {
                ModelState.AddModelError("Title", "You have already written something same this one!");
                return View();
            }

            slider.IsDeleted = false;
            await _context.Sliders.AddAsync(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion


        #region Detail
        //---Detail---//
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Slider slider  = _context.Sliders.Where(s => s.IsDeleted == false).FirstOrDefault(s => s.Id == id);
            if (slider == null) return NotFound();
            return View(slider);
        }
        #endregion


        #region Delete
        //--- Delete - Get method ---//
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Slider slider = _context.Sliders.Where(s => s.IsDeleted == false).FirstOrDefault(s => s.Id == id);
            if (slider == null) return NotFound();
            return View(slider);
        }


        //--- Delete - Post method ---//
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            Slider slider = await _context.Sliders.FindAsync(id);
            if (slider == null) return NotFound();

            int count = _context.Sliders.Count();
            if (count == 1)
            {
                return Content("Please add more sliders!");
            }

            bool isDeleted = Helper.DeleteImage(_env.WebRootPath, "img", slider.Image);
            if (!isDeleted)
            {
                ModelState.AddModelError("", "There are some errors");
                return View(slider);
            }

            _context.Sliders.Remove(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion
    }
}
