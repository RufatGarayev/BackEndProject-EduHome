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
            OurTeacherVM OurTeacherVM = new OurTeacherVM
            {
                OurTeachers = _context.OurTeachers.Where(t => t.IsDeleted == false).Take(12).ToList()
            };
            return View(OurTeacherVM);
        }

        public IActionResult Details()
        {
            TeacherDetailsVM teacherDetailsVM = new TeacherDetailsVM
            {
                TeacherBasicInfo = _context.TeacherBasicInfos.Where(tbi => tbi.IsDeleted == false).FirstOrDefault(),
                TeacherContactInfo = _context.TeacherContactInfos.Where(tci => tci.IsDeleted == false).FirstOrDefault(),
                TeacherSkills = _context.TeacherSkills.Where(ts => ts.IsDeleted == false).ToList()
            };
            return View(teacherDetailsVM);
        }
    }
}
