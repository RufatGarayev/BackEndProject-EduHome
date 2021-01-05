using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduHome.DAL;
using EduHome.Extensions;
using EduHome.Models;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;  
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager; 
        private readonly AppDbContext _context; 
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager, AppDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _context = context;
        }

        #region Login
        //----- Log In-Get -----//
        public IActionResult Login()
        {
            return View();
        }


        //----- Log In-Post -----//
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
        #endregion


        #region Register
        //----- Register-Get -----//
        public IActionResult Register()
        {
            return View();
        }

        //----- Register-Post -----//
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (!ModelState.IsValid) return View();
            AppUser newUser = new AppUser
            {
                Fullname = register.Fullname,
                UserName = register.Username,
                Email = register.Email
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

            await _userManager.AddToRoleAsync(newUser, Roles.Admin.ToString());
            await _signInManager.SignInAsync(newUser, true);
            return RedirectToAction("Index", "Home");
        }
        #endregion


        #region LogOut
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();  
            return RedirectToAction("Index", "Home");
        }
        #endregion


        #region Create User Role
        //public async Task CreateUserRole()                                                   
        //{
        //    if (!(await _roleManager.RoleExistsAsync("Admin")))                                
        //        await _roleManager.CreateAsync(new IdentityRole { Name = Roles.Admin.ToString() });
        //    if (!(await _roleManager.RoleExistsAsync("Member")))
        //        await _roleManager.CreateAsync(new IdentityRole { Name = Roles.Member.ToString() });
        //}
        #endregion


        #region Subscribe
        //-----Subscribe-----//
        public IActionResult Subscribe()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Subscribe(Subscribe subscribe)
        {
            if (ModelState.IsValid)
            {
                Subscribe subscribed = new Subscribe();
                subscribed.Email = subscribe.Email.Trim().ToLower();
                bool isExist = _context.Subscribes.Any(e => e.Email.Trim().ToLower() == subscribe.Email.Trim().ToLower());

                if (isExist)
                {
                    ModelState.AddModelError("", "This email already subscribed");
                }
                else
                {
                    await _context.Subscribes.AddAsync(subscribe);
                    await _context.SaveChangesAsync();
                }
            }
            return RedirectToAction("Index","Home");
        }
        #endregion
    }
}
