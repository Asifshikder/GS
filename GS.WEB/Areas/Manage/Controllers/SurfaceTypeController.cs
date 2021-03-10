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

    public class SurfaceTypeController : Controller
    {
        private ISurfaceTypeService SurfaceTypeService;
        private IFileHandler fileHandler;

        public SurfaceTypeController(ISurfaceTypeService SurfaceTypeService, IFileHandler fileHandler)
        {
            this.SurfaceTypeService = SurfaceTypeService;
            this.fileHandler = fileHandler;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var entityList = SurfaceTypeService.AllAsIEnumerable();
            return View(entityList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            SurfaceTypeViewModel SurfaceType = new SurfaceTypeViewModel();
            return View(SurfaceType);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SurfaceTypeViewModel ModelView)
        {
            if (ModelView.SurfaceLogoFile != null)
            {
                var imgurl = fileHandler.UploadFile("SurfaceType", ModelView.SurfaceLogoFile);
                ModelView.SurfaceLogo = imgurl;
            }
            SurfaceType SurfaceType = new SurfaceType();
            SurfaceType.SurfaceTypeName = ModelView.SurfaceTypeName;
            SurfaceType.SurfaceTypeLogo = ModelView.SurfaceLogo;
            SurfaceTypeService.InsertEntity(SurfaceType);
            return Redirect("/Manage/SurfaceType/Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            SurfaceType st = SurfaceTypeService.GetById(id);
            SurfaceTypeViewModel model = new SurfaceTypeViewModel();
            model.Id = st.Id;
            model.SurfaceTypeName = st.SurfaceTypeName;
            model.SurfaceLogo = st.SurfaceTypeLogo;
            return View(model);
        }
        [HttpPost]
        [Route("/Manage/SurfaceType/Update")]
        [AutoValidateAntiforgeryToken]
        public IActionResult Update(SurfaceTypeViewModel ModelView)
        {
            if (ModelView.SurfaceLogoFile != null)
            {
                var imgurl = fileHandler.UpdateFile(ModelView.SurfaceLogo, "SurfaceType", ModelView.SurfaceLogoFile);
                ModelView.SurfaceLogo = imgurl;
            }
            SurfaceType SurfaceType = new SurfaceType();
            SurfaceType.Id = ModelView.Id;
            SurfaceType.SurfaceTypeName = ModelView.SurfaceTypeName;
            SurfaceType.SurfaceTypeLogo = ModelView.SurfaceLogo;
            SurfaceTypeService.UpdateEntity(SurfaceType);
            return Redirect("/Manage/SurfaceType/Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            SurfaceType SurfaceType = SurfaceTypeService.GetById(id);
            return View(SurfaceType);
        }
        [HttpPost]
        [Route("/Manage/SurfaceType/DeleteConfirm")]
        [AutoValidateAntiforgeryToken]
        public IActionResult DeleteConfirm(SurfaceType SurfaceType)
        {
            SurfaceTypeService.DeleteEntity(SurfaceType);
            return Redirect("/Manage/SurfaceType/Index");
        }
    }
}
