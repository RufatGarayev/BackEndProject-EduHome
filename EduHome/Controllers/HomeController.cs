using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EduHome.Models;
using EduHome.DAL;
using EduHome.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace EduHome.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Sliders = _context.Sliders.Where(s => s.IsDeleted == false).ToList(),
                NoticeBoards = _context.NoticeBoards.Where(nb => nb.IsDeleted == false).ToList(),
                SectionDescriptions = _context.SectionDescriptions.Where(sd => sd.IsDeleted == false).ToList(),

                ChooseEduHome = _context.ChooseEduHomes.Where(ceh => ceh.IsDeleted == false)
                .FirstOrDefault(),

                CoursesWeOffers = _context.CoursesWeOffers.Where(cwo => cwo.IsDeleted == false).Take(3).ToList(),

                UpcomingEvents = _context.UpcomingEvents.Where(ue => ue.IsDeleted == false).ToList(),

                Students = _context.Students.Where(stu => stu.IsDeleted == false).ToList(),
                LatestFromBlogs = _context.LatestFromBlogs.Where(lfb => lfb.IsDeleted == false).Take(3).ToList()
            };
            return View(homeVM);
        }



        //public IActionResult Search(string search)
        //{
        //    IEnumerable<Student> model = _context.Students.Where(h => h.Name.Contains(search)).OrderByDescending(h => h.Id);
        //    return PartialView("_SearchPartial", model);
        //}


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
