using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduHome.DAL;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    public class EventDetailsController : Controller
    {
        private readonly AppDbContext _context;
        public EventDetailsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            EventDetailsVM eventDetailsVM = new EventDetailsVM
            {
                WorkShop = _context.WorkShops.Where(ws => ws.IsDeleted==false).FirstOrDefault(),
                Speakers = _context.Speakers.Where(s => s.IsDeleted==false).ToList(),
                BlogBanner = _context.BlogBanners.Where(bb => bb.IsDeleted == false).FirstOrDefault(),
                Posts = _context.Posts.Where(lfb => lfb.IsDeleted == false).Take(3).ToList(),
                Categories = _context.Categories.Where(ctg => ctg.IsDeleted == false).ToList(),
                Tags = _context.Tags.Where(t => t.IsDeleted == false).ToList()
            };
            return View(eventDetailsVM);
        }
    }
}
