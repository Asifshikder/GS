using GS.DATA.Entities.Catelog;
using GS.DATA.Entities.CMS;
using GS.SERVICE.Interface.Catelog;
using GS.SERVICE.Interface.CMS;
using GS.SERVICE.Interface.CustomPort;
using GS.WEB.Areas.Manage.Models.Catelog;
using GS.WEB.Areas.Manage.Models.CMS;
using GS.WEB.Models.Handler;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GS.WEB.Areas.Manage.Controllers
{
    [Area("Manage")]
    [Authorize]

    public class MainPageController : Controller
    {
        private IMainPageService MainPageService;
        private IFileHandler fileHandler;
        private IWebHostEnvironment webHost;

        public MainPageController(IMainPageService MainPageService, IFileHandler fileHandler,IWebHostEnvironment webHost)
        {
            this.MainPageService = MainPageService;
            this.fileHandler = fileHandler;
            this.webHost = webHost;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var entityList = MainPageService.AllAsIEnumerable();
            return View(entityList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            MainPageViewModel mainPage = new MainPageViewModel();
            return View(mainPage);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MainPageViewModel MainPageView)
        {
            if (MainPageView.PrimaryImageFile != null)
            {
                var file = MainPageView.PrimaryImageFile;
                Guid nameguid = Guid.NewGuid();
                string webrootpath = webHost.WebRootPath;
                string filename = "mainpageimage";
                string extension = Path.GetExtension(file.FileName);
                filename = filename + extension;
                string path = Path.Combine(webrootpath, "MainPage", filename);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                string pathName = Path.Combine("MainPage", filename);
                string fileUrl = "~/MainPage/" + filename;
                MainPageView.PrimaryImage = fileUrl;
            }
            MainPage mainPage = new MainPage();
            mainPage.Title = MainPageView.PrimaryImage;
            mainPage.Description = MainPageView.PrimaryImage;
            mainPage.PrimaryImage = MainPageView.PrimaryImage;
            MainPageService.InsertEntity(mainPage);
            return Redirect("/Manage/MainPage/Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            MainPage cl = MainPageService.GetById(id);
            MainPageViewModel model = new MainPageViewModel();
            model.Id = cl.Id;
            model.Title = cl.Title;
            model.Description = cl.Description;
            model.PrimaryImage = cl.PrimaryImage;
            return View(model);
        }
        [HttpPost]
        [Route("/Manage/MainPage/Update")]
        [AutoValidateAntiforgeryToken]
        public IActionResult Update(MainPageViewModel mainPageView)
        {
            if (mainPageView.PrimaryImageFile != null)
            {
                if (mainPageView.PrimaryImage != null)
                {
                    string dbpath = mainPageView.PrimaryImage.Replace("~/", "").ToString();
                    string uppath = dbpath.Replace("/", "\\").ToString();
                    string fullpath = webHost.WebRootPath + "\\" + uppath;
                    System.IO.File.Delete(fullpath);
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }
                var file = mainPageView.PrimaryImageFile;
                string webrootpath = webHost.WebRootPath;
                string filename = "mainpageimage";
                string extension = Path.GetExtension(file.FileName);
                string foldername = "MainPage";
                filename = filename + extension;
                string path = Path.Combine(webrootpath, foldername, filename);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                string pathName = Path.Combine(foldername, filename);
                string fileUrl = "~/" + foldername + "/" + filename;
                mainPageView.PrimaryImage = fileUrl;
            }
            MainPage mainPage = new MainPage();
            mainPage.Id = mainPageView.Id;
            mainPage.Title = mainPageView.Title;
            mainPage.Description = mainPageView.Description;
            mainPage.PrimaryImage = mainPageView.PrimaryImage;
            MainPageService.UpdateEntity(mainPage);
            return Redirect("/Manage/MainPage/Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            MainPage MainPage = MainPageService.GetById(id);
            return View(MainPage);
        }
        [HttpPost]
        [Route("/Manage/MainPage/DeleteConfirm")]
        [AutoValidateAntiforgeryToken]
        public IActionResult DeleteConfirm(MainPage MainPage)
        {
            if(MainPage.PrimaryImage!= null)
            {
                fileHandler.DeleteFile(MainPage.PrimaryImage);
            }
            MainPageService.DeleteEntity(MainPage);
            return Redirect("/Manage/MainPage/Index");
        }
    }
}
