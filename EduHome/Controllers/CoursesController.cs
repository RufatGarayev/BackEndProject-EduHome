using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduHome.DAL;
using EduHome.Models;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EduHome.Controllers
{
    public class CoursesController : Controller
    {
        private readonly AppDbContext _context;
        public CoursesController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            CoursesWeOfferVM coursesVM = new CoursesWeOfferVM
            {
                CoursesWeOffers = _context.CoursesWeOffers.Where(cwo => cwo.IsDeleted == false).Take(9).ToList()
            };
            return View(coursesVM);
        }

        public IActionResult Details(int? id)
        {
            CoursesDetailsVM coursesDetailsVM = new CoursesDetailsVM
            {   
                CourseFeatures = _context.CourseFeatures.Where(cf => cf.IsDeleted == false && cf.CoursesWeOfferId==id)
                .Include(cf => cf.CoursesWeOffer).ToList(),
                CoursesWeOffers = _context.CoursesWeOffers.Where(cwo => cwo.IsDeleted == false && cwo.Id == id)
                .Include(cwo => cwo.CourseFeature).ToList(),
                Posts = _context.Posts.Where(p => p.IsDeleted == false).ToList(),
                BlogDetails = _context.BlogDetails.Where(bd => bd.IsDeleted == false && bd.LatestFromBlogId == id)
                .Include(bd => bd.LatestFromBlog).ToList(),
                LatestFromBlogs = _context.LatestFromBlogs.Where(lfb => lfb.IsDeleted == false).ToList(),
                Categories = _context.Categories.Where(ctg => ctg.IsDeleted == false).ToList(),
                BlogBanners = _context.BlogBanners.Where(bb => bb.IsDeleted == false).ToList(),
                Tags = _context.Tags.Where(t => t.IsDeleted == false).ToList(),
                LeaveMessage = _context.LeaveMessages.FirstOrDefault(),
            };
            return View(coursesDetailsVM);
        }

        public IActionResult Search(string search)
        {
            IEnumerable<CoursesWeOffer> model = _context.CoursesWeOffers.Where(c => c.Name.Contains(search)).OrderByDescending(c => c.Id).Take(4);
            return PartialView("_SearchPartial", model);
        }
    }
}
