using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using EduHome.DAL;
using EduHome.Models;
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
                WorkShops = _context.WorkShops.Where(ws => ws.IsDeleted == false && ws.EventId == id)
                .Include(ws => ws.Event).ToList(),
                Events = _context.Events.Where(e => e.IsDeleted == false && e.Id == id).Include(e => e.WorkShop).ToList(),
                Speakers = _context.Speakers.Where(s => s.IsDeleted == false).ToList(),
                BlogBanner = _context.BlogBanners.Where(bb => bb.IsDeleted == false).FirstOrDefault(),
                Categories = _context.Categories.Where(ctg => ctg.IsDeleted == false).ToList(),
                Tags = _context.Tags.Where(t => t.IsDeleted == false).ToList(),
                BlogDetails = _context.BlogDetails.Where(bd => bd.IsDeleted == false && bd.LatestFromBlogId == id)
                .Include(bd => bd.LatestFromBlog).ToList(),
                LatestFromBlogs = _context.LatestFromBlogs.Where(lfb => lfb.IsDeleted == false).ToList()
                //LatestFromBlogs = _context.LatestFromBlogs.Where(lfb => lfb.IsDeleted == false && lfb.Id == id)
                //.Include(lfb => lfb.BlogDetail).ToList(),
            };
            return View(eventDetailsVM);
        }


        public IActionResult Search(string search)
        {
            IEnumerable<Event> model = _context.Events.Where(e => e.Title.Contains(search)).OrderByDescending(e => e.Id).Take(4);
            return PartialView("_EventSearchPartial", model);
        }
    }
}
