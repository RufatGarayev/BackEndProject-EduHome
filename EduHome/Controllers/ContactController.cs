using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduHome.DAL;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        public ContactController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ContactVM contactVM = new ContactVM
            {
                Map = _context.Maps.Where(m => m.IsDeleted==false).FirstOrDefault(),
                Addresses = _context.Addresses.Where(a => a.IsDeleted==false).ToList()
            };
            return View(contactVM);
        }
    }
}
