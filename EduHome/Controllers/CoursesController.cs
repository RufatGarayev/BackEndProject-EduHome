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
                //CoursesTexts = _context.CoursesTexts.Where(ct => ct.IsDeleted == false).ToList(),                                                                                     //where

                CourseFeature = _context.CourseFeatures.Include(cd => cd.CoursesWeOffer).FirstOrDefault(cd => cd.CoursesWeOfferId == id),                                               //fod
                //if (detail == null) return NotFound();

                BlogBanner = _context.BlogBanners.Where(bb => bb.IsDeleted == false).FirstOrDefault(),
                Posts = _context.Posts.Where(lfb => lfb.IsDeleted == false).Take(3).ToList(),
                Categories = _context.Categories.Where(ctg => ctg.IsDeleted == false).ToList(),
                Tags = _context.Tags.Where(t => t.IsDeleted == false).ToList(),
                LeaveMessage = _context.LeaveMessages.FirstOrDefault()
            };
            return View(coursesDetailsVM);
        }  
    }
}
