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

    public class ColorController : Controller
    {
        private IColorService ColorService;
        private IFileHandler fileHandler;

        public ColorController(IColorService ColorService,IFileHandler fileHandler)
        {
            this.ColorService = ColorService;
            this.fileHandler = fileHandler;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var entityList = ColorService.AllAsIEnumerable();
            return View(entityList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ColorViewModel Color = new ColorViewModel();
            return View(Color);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ColorViewModel colorView)
        {
            if (colorView.SampleImageFile != null)
            {
                var imgurl = fileHandler.UploadFile("Color", colorView.SampleImageFile);
                colorView.ColorSamplmage = imgurl;
            }
            Color color = new Color();
            color.ColorName = colorView.ColorName;
            color.ColorSamplmage = colorView.ColorSamplmage;
            ColorService.InsertEntity(color);
            return Redirect("/Manage/Color/Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Color cl = ColorService.GetById(id);
            ColorViewModel model = new ColorViewModel();
            model.Id = cl.Id;
            model.ColorName = cl.ColorName;
            model.ColorSamplmage = cl.ColorSamplmage;
            return View(model);
        }
        [HttpPost]
        [Route("/Manage/Color/Update")]
        [AutoValidateAntiforgeryToken]
        public IActionResult Update(ColorViewModel colorView)
        {
            if (colorView.SampleImageFile != null)
            {
                var imgurl = fileHandler.UpdateFile(colorView.ColorSamplmage, "Color", colorView.SampleImageFile);
                colorView.ColorSamplmage = imgurl;
            }
            Color color = new Color();
            color.Id = colorView.Id;
            color.ColorName = colorView.ColorName;
            color.ColorSamplmage = colorView.ColorSamplmage;
            ColorService.UpdateEntity(color);
            return Redirect("/Manage/Color/Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Color Color = ColorService.GetById(id);
            return View(Color);
        }
        [HttpPost]
        [Route("/Manage/Color/DeleteConfirm")]
        [AutoValidateAntiforgeryToken]
        public IActionResult DeleteConfirm(Color Color)
        {
            ColorService.DeleteEntity(Color);
            return Redirect("/Manage/Color/Index");
        }
    }
}
