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
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        public AboutController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? id)
        {
            AboutVM aboutVM = new AboutVM {
                WelcomeToEduHome = _context.WelcomeToEduHomes.Where(wte => wte.IsDeleted==false).FirstOrDefault(),
                OurTeachers = _context.OurTeachers.Where(t => t.IsDeleted==false).Take(4).ToList(),

                Students = _context.Students.Where(stu => stu.IsDeleted == false).ToList(),
                NoticeBoards = _context.NoticeBoards.Where(stu => stu.IsDeleted == false).ToList(),
                TakeAVideoTour = _context.TakeAVideoTours.Where(stu => stu.IsDeleted == false).FirstOrDefault()

            };
            return View(aboutVM);
        }
    }
}
