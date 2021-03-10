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

    public class ModelController : Controller
    {
        private IModelService ModelService;
        private IFileHandler fileHandler;

        public ModelController(IModelService ModelService, IFileHandler fileHandler)
        {
            this.ModelService = ModelService;
            this.fileHandler = fileHandler;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var entityList = ModelService.AllAsIEnumerable();
            return View(entityList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ModelViewModel Model = new ModelViewModel();
            return View(Model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ModelViewModel ModelView)
        {
            if (ModelView.ModelLogoFile != null)
            {
                var imgurl = fileHandler.UploadFile("Model", ModelView.ModelLogoFile);
                ModelView.ModelLogo = imgurl;
            }
            Model Model = new Model();
            Model.ModelName = ModelView.ModelName;
            Model.ModelLogo = ModelView.ModelLogo;
            ModelService.InsertEntity(Model);
            return Redirect("/Manage/Model/Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Model md = ModelService.GetById(id);
            ModelViewModel model = new ModelViewModel();
            model.Id = md.Id;
            model.ModelName = md.ModelName;
            model.ModelLogo = md.ModelLogo;
            return View(model);
        }
        [HttpPost]
        [Route("/Manage/Model/Update")]
        [AutoValidateAntiforgeryToken]
        public IActionResult Update(ModelViewModel ModelView)
        {
            if (ModelView.ModelLogoFile != null)
            {
                var imgurl = fileHandler.UpdateFile(ModelView.ModelLogo, "Model", ModelView.ModelLogoFile);
                ModelView.ModelLogo = imgurl;
            }
            Model Model = new Model();
            Model.Id = ModelView.Id;
            Model.ModelName = ModelView.ModelName;
            Model.ModelLogo = ModelView.ModelLogo;
            ModelService.UpdateEntity(Model);
            return Redirect("/Manage/Model/Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Model Model = ModelService.GetById(id);
            return View(Model);
        }
        [HttpPost]
        [Route("/Manage/Model/DeleteConfirm")]
        [AutoValidateAntiforgeryToken]
        public IActionResult DeleteConfirm(Model Model)
        {
            ModelService.DeleteEntity(Model);
            return Redirect("/Manage/Model/Index");
        }
    }
}
