using GS.DATA.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GS.WEB.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class FullFillmentController : Controller
    {
        private RoleManager<IdentityRole> roleManager;
        private UserManager<ApplicationUser> userManager;
        private SignInManager<ApplicationUser> signInManager;

        public FullFillmentController(RoleManager<IdentityRole> roleManager,UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.Message = string.Empty;
            if (userManager.Users.Count() == 0)
            {
                IdentityRole model = new IdentityRole();
                IdentityRole model1 = new IdentityRole();
                model.Name = "Admin";
                model1.Name = "Client";
                await roleManager.CreateAsync(model);
                await roleManager.CreateAsync(model1);
                ViewBag.Message = "system is already configured";
            }
            var check = userManager.FindByEmailAsync("admin@garagespecialisten.se");
            if (check.Result == null)
            {
                ApplicationUser user = new ApplicationUser();
                user.PhoneNumber = "0909099032432";
                user.UserName = "garagespecialisten";
                user.FullName = "Garage Specialisten";
                user.Email = "admin@garagespecialisten.se";
                var password = "garagespecialisten";
                var result = await userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Admin");
                }
                ViewBag.Message = "Welcome! We are all done. Let's dig everything";
            }
            return View();
        }
    }
}
