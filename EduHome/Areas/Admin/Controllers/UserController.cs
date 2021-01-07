using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduHome.Extensions;
using EduHome.Models;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public UserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        #region Index
        public async Task<IActionResult> Index()
        {
            List<AppUser> users = _userManager.Users.ToList();
            List<UserVM> usersVM = new List<UserVM>();
            foreach (AppUser user in users)
            {
                UserVM userVM = new UserVM
                {
                    Id = user.Id,
                    Fullname = user.Fullname,
                    Username = user.UserName,
                    Email = user.Email,
                    IsDeleted = user.IsDeleted,
                    Role = (await _userManager.GetRolesAsync(user))[0]
                };
                usersVM.Add(userVM);
            }

            return View(usersVM);
        }
        #endregion


        #region ChangeStatus  
        public async Task<IActionResult> ChangeStatus(string id)
        {
            if (id == null) return NotFound();
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeStatusPost(string id)
        {
            if (id == null) return NotFound();
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            if (user.IsDeleted)
                user.IsDeleted = false;
            else
                user.IsDeleted = true;

            await _userManager.UpdateAsync(user);
            return RedirectToAction(nameof(Index));
        }
        #endregion


        #region ChangeRole
        public async Task<IActionResult> ChangeRole(string id)
        {
            if (id == null) return NotFound();
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            if (user.UserName == User.Identity.Name)
            {
                return Content("...");
            }
            UserVM userVM = await getUserVM(user);
            return View(userVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeRole(string id, string role)
        {
            if (id == null || role == null) return NotFound();
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            if (user.UserName == User.Identity.Name)
            {
                return Content("...");
            }

            IdentityResult addResult = await _userManager.AddToRoleAsync(user, role);
            if (!addResult.Succeeded)
            {
                ModelState.AddModelError("", "Some problem exist");
                UserVM userVM = await getUserVM(user);
                return View(userVM);
            }

            string oldRole = (await _userManager.GetRolesAsync(user))[0];
            IdentityResult removeResult = await _userManager.RemoveFromRoleAsync(user, oldRole);
            if (!removeResult.Succeeded)
            {
                ModelState.AddModelError("", "Some problem is exist");
                UserVM userVM = await getUserVM(user);
                return View(userVM);
            }

            await _userManager.AddToRoleAsync(user, role);
            return RedirectToAction(nameof(Index));
        }
        #endregion


        #region ResetPassword
        public IActionResult ResetPassword(string id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(string id, ResetPasswordVM reg)
        {
            if (!ModelState.IsValid) return View();
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                ModelState.AddModelError("", "We couldn't find specified user..");
                return View();
            }
            String passwordToken = await _userManager.GeneratePasswordResetTokenAsync(user);
            await _userManager.ResetPasswordAsync(user, passwordToken, reg.Password);
            return RedirectToAction(nameof(Index));
        }
        #endregion


        #region GetUserVM
        private async Task<UserVM> getUserVM(AppUser user)
        {
            List<string> roles = new List<string>();
            foreach (var item in Enum.GetValues(typeof(Roles)))
            {
                roles.Add(item.ToString());
            }
            UserVM userVM = new UserVM
            {
                Id = user.Id,
                Fullname = user.Fullname,
                Email = user.Email,
                Username = user.UserName,
                IsDeleted = user.IsDeleted,
                Role = (await _userManager.GetRolesAsync(user))[0],
                Roles = roles
            };
            return userVM;
        }
        #endregion
    }
}
