using GS.DATA.Entities.Catelog;
using GS.SERVICE.Interface.Catelog;
using GS.SERVICE.Interface.CustomPort;
using GS.WEB.Areas.Manage.Models.Catelog;
using GS.WEB.Models.Handler;
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

    public class ProductInstallController : Controller
    {
        private IProductInstallService ProductInstallService;
        private IFileHandler fileHandler;

        public ProductInstallController(IProductInstallService ProductInstallService,IFileHandler fileHandler)
        {
            this.ProductInstallService = ProductInstallService;
            this.fileHandler = fileHandler;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var entityList = ProductInstallService.AllAsIEnumerable();
            return View(entityList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ProductInstallViewModel ProductInstall = new ProductInstallViewModel();
            return View(ProductInstall);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ProductInstallViewModel model)
        {
            if (model.IconImageFile != null)
            {
                var imgurl = fileHandler.UploadFile("ProductInstall", model.IconImageFile);
                model.IconImage = imgurl;
            }
            ProductInstall pi = new ProductInstall();
            pi.Title = model.Title;
            pi.Description = model.Description;
            pi.Price = model.Price;
            pi.IconImage = model.IconImage;
            ProductInstallService.InsertEntity(pi);
            return Redirect("/Manage/ProductInstall/Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ProductInstall model = ProductInstallService.GetById(id);
            ProductInstallViewModel pi = new ProductInstallViewModel();
            pi.Id = model.Id;
            pi.Title = model.Title;
            pi.Description = model.Description;
            pi.Price = model.Price;
            pi.IconImage = model.IconImage;
            return View(model);
        }
        [HttpPost]
        [Route("/Manage/ProductInstall/Update")]
        [AutoValidateAntiforgeryToken]
        public IActionResult Update(ProductInstallViewModel model)
        {
            if (model.IconImageFile != null)
            {
                var imgurl = fileHandler.UpdateFile(model.IconImage,"ProductInstall", model.IconImageFile);
                model.IconImage = imgurl;
            }
            ProductInstall pi = new ProductInstall();
            pi.Title = model.Title;
            pi.Id = model.Id;
            pi.Description = model.Description;
            pi.Price = model.Price;
            pi.IconImage = model.IconImage;
            ProductInstallService.UpdateEntity(pi);
            return Redirect("/Manage/ProductInstall/Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            ProductInstall ProductInstall = ProductInstallService.GetById(id);
            return View(ProductInstall);
        }
        [HttpPost]
        [Route("/Manage/ProductInstall/DeleteConfirm")]
        [AutoValidateAntiforgeryToken]
        public IActionResult DeleteConfirm(ProductInstall ProductInstall)
        {
            ProductInstallService.DeleteEntity(ProductInstall);
            return Redirect("/Manage/ProductInstall/Index");
        }
    }
}
