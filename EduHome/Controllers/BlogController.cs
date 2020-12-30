using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduHome.DAL;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        public BlogController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            BlogVM blogVM = new BlogVM
            {
                LatestFromBlogs = _context.LatestFromBlogs.Where(lfb => lfb.IsDeleted == false).Take(9).ToList()
            };
            return View(blogVM);
        }

        //Pagination
        public IActionResult Pagination(int? page)
        {
            ViewBag.PageCount = Decimal.Ceiling((decimal)_context.LatestFromBlogs.Where(bb => bb.IsDeleted == false).Count() / 4);
            ViewBag.Page = page;
            if (page == null)
            {
                return View(_context.LatestFromBlogs.Where(bb => bb.IsDeleted == false).Take(4).ToList());
            }
            return View(_context.LatestFromBlogs.Where(bb => bb.IsDeleted == false).Skip(((int)page - 1) * 4).Take(4).ToList());
        }

        public IActionResult Details()
        {
            BlogDetailsVM blogDetailsVM = new BlogDetailsVM
            {
                BlogDetails = _context.BlogDetails.Where(bd => bd.IsDeleted == false).ToList(),
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
