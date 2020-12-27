using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduHome.DAL;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    public class BlogDetailsController : Controller
    {
        private readonly AppDbContext _context;
        public BlogDetailsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            BlogDetailsVM blogDetailsVM = new BlogDetailsVM
            {
                BlogBanner = _context.BlogBanners.Where(bb => bb.IsDeleted == false).FirstOrDefault(),
                Posts = _context.Posts.Where(lfb => lfb.IsDeleted == false).Take(3).ToList(),
                Categories = _context.Categories.Where(ctg => ctg.IsDeleted == false).ToList(),
                Tags = _context.Tags.Where(t => t.IsDeleted == false).ToList(),
                Explaining = _context.Explainings.Where(exp => exp.IsDeleted == false).FirstOrDefault()
            };
            return View(blogDetailsVM);
        }
    }
}
