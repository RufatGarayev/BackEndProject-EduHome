using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduHome.DAL;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EduHome.Controllers
{
    public class EventController : Controller
    {
        private readonly AppDbContext _context;
        public EventController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            EventVM eventVM = new EventVM
            {
                Events = _context.Events.Where(e => e.IsDeleted == false).Take(9).ToList()
            };
            return View(eventVM);
        }

        public IActionResult Details(int? id)
        {
            EventDetailsVM eventDetailsVM = new EventDetailsVM
            {
                WorkShops = _context.WorkShops.Where(ws => ws.IsDeleted == false).ToList()


                //Speakers = _context.Speakers.Where(s => s.IsDeleted == false).ToList(),
                //BlogBanners = _context.BlogBanners.Where(bb => bb.IsDeleted == false).ToList(),
                //Posts = _context.Posts.Where(lfb => lfb.IsDeleted == false).Take(3).ToList(),
                //Categories = _context.Categories.Where(ctg => ctg.IsDeleted == false).ToList(),
                //Tags = _context.Tags.Where(t => t.IsDeleted == false).ToList(),

                //LatestFromBlog = _context.LatestFromBlogs.Where(lfb => lfb.IsDeleted == false).Take(3).ToList()
            };
            return View(eventDetailsVM);
        }
    }
}
