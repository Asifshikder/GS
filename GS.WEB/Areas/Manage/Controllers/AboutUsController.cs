using GS.DATA.Entities.CMS;
using GS.DATA.Entities.CustomPort;
using GS.SERVICE.Interface.CMS;
using GS.SERVICE.Interface.CustomPort;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GS.WEB.Areas.Manage.Controllers
{
    [Area("Manage")]
    [Authorize]
    public class AboutUsController : Controller
    {
        private IAboutUsService AboutUsService;

        public AboutUsController(IAboutUsService AboutUsService)
        {
            this.AboutUsService = AboutUsService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var entityList = AboutUsService.AllAsList();
            return View(entityList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            AboutUs AboutUs = new AboutUs();
            return View(AboutUs);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AboutUs AboutUs)
        {
            AboutUsService.InsertEntity(AboutUs);
            return Redirect("/Manage/AboutUs/Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            AboutUs AboutUs = AboutUsService.GetById(id);
            return View(AboutUs);
        }
        [HttpPost]
        [Route("/Manage/AboutUs/Update")]
        [AutoValidateAntiforgeryToken]
        public IActionResult Update(AboutUs AboutUs)
        {
            AboutUsService.UpdateEntity(AboutUs);
            return Redirect("/Manage/AboutUs/Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            AboutUs AboutUs = AboutUsService.GetById(id);
            return View(AboutUs);
        }
        [HttpPost]
        [Route("/Manage/AboutUs/DeleteConfirm")]
        [AutoValidateAntiforgeryToken]
        public IActionResult DeleteConfirm(AboutUs AboutUs)
        {
            AboutUsService.DeleteEntity(AboutUs);
            return Redirect("/Manage/AboutUs/Index");
        }
    }
}
