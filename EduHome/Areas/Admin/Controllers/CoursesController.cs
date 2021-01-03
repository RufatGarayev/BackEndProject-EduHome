using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduHome.DAL;
using Microsoft.AspNetCore.Mvc;

namespace EduHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CoursesController : Controller
    {
        private readonly AppDbContext _context;
        public CoursesController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
