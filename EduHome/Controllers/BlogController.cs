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
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        public BlogController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? page)
        {
            //---Pagination---//

            ViewBag.PageCount = Decimal.Ceiling((decimal)_context.LatestFromBlogs.Where(b => b.IsDeleted == false).Count() / 3);
            ViewBag.page = page;
            if (page == null)
            {
                List<LatestFromBlog> latestFromBlog = _context.LatestFromBlogs.Where(b => b.IsDeleted == false).Take(3).ToList();
                return View(latestFromBlog);
            }
            List<LatestFromBlog> LatestFromBlog = _context.LatestFromBlogs.Where(b => b.IsDeleted == false).Skip(((int)page-1) * 4).Take(3).ToList();
            return View(LatestFromBlog);
        }

        public IActionResult Details(int? id)
        {
            BlogDetailsVM blogDetailsVM = new BlogDetailsVM
            {
                BlogBanners = _context.BlogBanners.Where(bb => bb.IsDeleted == false).ToList(),

                Categories = _context.Categories.Where(ctg => ctg.IsDeleted == false).ToList(),
                Tags = _context.Tags.Where(t => t.IsDeleted == false).ToList(),

                Explainings = _context.Explainings.Where(exp => exp.IsDeleted == false).ToList(),
                //Posts = _context.Posts.Where(lfb => lfb.IsDeleted == false).ToList(),

                BlogDetails = _context.BlogDetails.Where(bd => bd.IsDeleted == false && bd.LatestFromBlogId == id)
                .Include(bd => bd.LatestFromBlog).ToList(),
                LatestFromBlogs = _context.LatestFromBlogs.Where(lfb => lfb.IsDeleted == false && lfb.Id==id)
                .Include(lfb => lfb.BlogDetail).Take(3).ToList(),
            };
            return View(blogDetailsVM);
        }
    }
}
