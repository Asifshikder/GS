using GS.DATA.Entities;
using GS.WEB.Models.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GS.WEB.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> userManager;
        private SignInManager<ApplicationUser> signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = "/")
        {
            if (signInManager.IsSignedIn(User))
            {
                return Redirect("/Manage/Home/Index");
            }
            returnUrl = returnUrl.Replace("%2F", "/");
            LoginViewModel login = new LoginViewModel()
            {
                ReturnUrl = returnUrl
            };
            return View(login);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            var result = await signInManager.PasswordSignInAsync(login.Email, login.Password, false, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                if (string.IsNullOrEmpty(login.ReturnUrl))
                    {
                        return Redirect("/Manage/Home/Index");
                    }
                    return Redirect(login.ReturnUrl);
            }
            ModelState.AddModelError("IncorrectInput", "Username or Password is incorrect");

            return View(login);
        }


      
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            if (signInManager.IsSignedIn(User))
            {
                await signInManager.SignOutAsync();
            }
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Logout(ApplicationUser user)
        {
            if (signInManager.IsSignedIn(User))
            {
                await signInManager.SignOutAsync();
            }
            return RedirectToAction("Index", "Home");
        }
        private Task<ApplicationUser> GetCurrentUserAsync() => userManager.GetUserAsync(HttpContext.User);


    }
}
