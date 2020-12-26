using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduHome.DAL;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    public class CoursesDetailsController : Controller
    {
        private readonly AppDbContext _context;
        public CoursesDetailsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            CoursesDetailsVM coursesDetailsVM = new CoursesDetailsVM
            {
                CoursesTexts = _context.CoursesTexts.Where(ct => ct.IsDeleted==false).ToList(),
                CourseFeature = _context.CourseFeatures.Where(cf => cf.IsDeleted==false).FirstOrDefault(),
                BlogBanner = _context.BlogBanners.Where(bb => bb.IsDeleted==false).FirstOrDefault(),
                Posts = _context.Posts.Where(lfb => lfb.IsDeleted==false).Take(3).ToList()
            };
            return View(coursesDetailsVM);
        }
    }
}
