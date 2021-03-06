﻿using System;
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
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        public AboutController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? id)
        {
            TempData["controllerName"] = this.ControllerContext.RouteData.Values["controller"].ToString();

            AboutVM aboutVM = new AboutVM {
                WelcomeToEduHome = _context.WelcomeToEduHomes.Where(wte => wte.IsDeleted==false).FirstOrDefault(),
                OurTeachers = _context.OurTeachers.Where(t => t.IsDeleted==false).Take(4).ToList(),

                Students = _context.Students.Where(stu => stu.IsDeleted == false).ToList(),
                NoticeBoards = _context.NoticeBoards.Where(stu => stu.IsDeleted == false).ToList(),
                TakeAVideoTour = _context.TakeAVideoTours.Where(stu => stu.IsDeleted == false).FirstOrDefault()

            };
            return View(aboutVM);
        }


        public IActionResult Search(string search)
        {
            IEnumerable<OurTeacher> model = _context.OurTeachers.Where(h => h.Name.Contains(search)).OrderByDescending(h => h.Id).Take(4);
            return PartialView("_SearchPartial", model);
        }

    }
}
