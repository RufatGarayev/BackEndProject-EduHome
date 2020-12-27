using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduHome.DAL;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    public class TeacherDetailsController : Controller
    {
        private readonly AppDbContext _context;
        public TeacherDetailsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            TeacherDetailsVM teacherDetailsVM = new TeacherDetailsVM
            {
                TeacherBasicInfo = _context.TeacherBasicInfos.Where(tbi => tbi.IsDeleted==false).FirstOrDefault(),
                TeacherContactInfo = _context.TeacherContactInfos.Where(tci => tci.IsDeleted==false).FirstOrDefault(),
                TeacherSkills = _context.TeacherSkills.Where(ts => ts.IsDeleted==false).ToList()
            };
            return View(teacherDetailsVM);
        }
    }
}
