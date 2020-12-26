using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduHome.DAL;
using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    public class CoursesDetailsController : Controller
    {
        private readonly AppDbContext _context;
        public CoursesDetailsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //CoursesDetailsVM coursesDetailsVM = new CoursesDetailsVM
            //{

            //};
            return View();
        }
    }
}
