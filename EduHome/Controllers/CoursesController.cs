using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduHome.DAL;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    public class CoursesController : Controller
    {
        private readonly AppDbContext _context;
        public CoursesController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            CoursesVM coursesVM = new CoursesVM
            {
                CoursesWeOffers = _context.CoursesWeOffers.Where(cwo => cwo.IsDeleted == false).Take(9).ToList()
            };
            return View(coursesVM);
        }
    }
}
