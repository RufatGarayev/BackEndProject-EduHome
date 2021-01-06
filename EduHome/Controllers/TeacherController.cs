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

        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();
            TeacherDetailsVM teacherDetailsVM = new TeacherDetailsVM
            {
                TeacherBasicInfo = _context.TeacherBasicInfos.Where(tbi => tbi.IsDeleted == false).Include(tbi => tbi.OurTeacher)
                .FirstOrDefault(tbi => tbi.OurTeacherId == id),
                TeacherContactInfo = _context.TeacherContactInfos.Where(tci => tci.IsDeleted == false).Include(tbi => tbi.OurTeacher)
                .FirstOrDefault(tbi => tbi.OurTeacherId == id),
                TeacherSkills = _context.TeacherSkills.Where(ts => ts.IsDeleted == false).ToList(),
                TeacherSkillSkills = _context.TeacherSkillSkills.ToList()
            };
            
            return View(teacherDetailsVM);
        }

        public IActionResult Search(string search)
        {
            IEnumerable<OurTeacher> model = _context.OurTeachers.Where(t => t.Name.Contains(search)).OrderByDescending(t => t.Id).Take(4);
            return PartialView("_TeacherSearchPartial", model);
        }
    }
}
