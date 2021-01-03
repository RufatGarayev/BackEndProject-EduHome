using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduHome.Extensions;
using EduHome.Models;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;    //Burada create, update, delete kimi sheyleri UserManager<AppUser> vasitesile edirik 
        private readonly SignInManager<AppUser> _signInManager;    //Register olmaq, Log in, Log out etmek uchun SignInManager ist olunur.
        private readonly RoleManager<IdentityRole> _roleManager; 
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        //-----Log In-----
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (!ModelState.IsValid) return View();
            AppUser user = await _userManager.FindByEmailAsync(login.Email);
            if (user==null)
            {
                ModelState.AddModelError("", "Email or Password is wrong.");
            }

            if (user.IsDeleted)
            {
                ModelState.AddModelError("", "This account has been blocked.");
            }

            Microsoft.AspNetCore.Identity.SignInResult signInResult = 
            await _signInManager.PasswordSignInAsync(user, login.Password, true, true);    //user password-nu yadda saxlamaq uchun
            if (signInResult.IsLockedOut)
            {
                ModelState.AddModelError("", "Please try few minutes later");
                return View(login);
            }

            if (!signInResult.Succeeded)     //password'un sehv olub-olmamasini yoxlamaq uchun                       
            {
                ModelState.AddModelError("", "Email or password is wrong.");
                return View();
            }

            return RedirectToAction("Index", "Home");
        }

        //-----Register-----
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (!ModelState.IsValid) return View();
            AppUser newUser = new AppUser
            {
                Fullname=register.Fullname,
                UserName=register.Username,
                Email=register.Email
            };

            IdentityResult identityResult = await _userManager.CreateAsync(newUser, register.Password);
            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }
                                                                //Member
            await _userManager.AddToRoleAsync(newUser, Roles.Member.ToString());    //yeni user-e member rolu vermek uchun
            await _signInManager.SignInAsync(newUser, true);                        //register olduq avtomatik sign olsun
            return RedirectToAction("Index", "Home");
        }

        //-----Log Out-----
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();          //Logout ede bilmek uchun
            return RedirectToAction("Index", "Home");
        }


        #region Create User Role
        //public async Task CreateUserRole()                                                            //Admin panelde role yaratmagi admine vermek istesek bu kodlar vasitesile edirik.
        //{
        //    if (!(await _roleManager.RoleExistsAsync("Admin")))                                       //db - da ikinci defe yaratmamasi uchun. 
        //        await _roleManager.CreateAsync(new IdentityRole { Name = Roles.Admin.ToString() });
        //    if (!(await _roleManager.RoleExistsAsync("Member")))
        //        await _roleManager.CreateAsync(new IdentityRole { Name = Roles.Member.ToString() });
        //}
        #endregion
    }
}
