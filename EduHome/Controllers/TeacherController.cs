using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduHome.DAL;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    public class TeacherController : Controller
    {
        private readonly AppDbContext _context;
        public TeacherController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            OurTeacherVM ourTeacherVM = new OurTeacherVM
            {
                OurTeachers = _context.OurTeachers.Where(t => t.IsDeleted == false).Take(12).ToList()
            };
            return View(ourTeacherVM);
        }
    }
}
