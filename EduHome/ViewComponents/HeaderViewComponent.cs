using EduHome.DAL;
using EduHome.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        public HeaderViewComponent(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.UserFullname = string.Empty;
            if (User.Identity.IsAuthenticated)
            {
                string username = (await _userManager.FindByNameAsync(User.Identity.Name)).UserName;
                ViewBag.UserName = username;
            }

            Bio model = _context.Bios.FirstOrDefault();
            return View(await Task.FromResult(model));
        }
    }
}
