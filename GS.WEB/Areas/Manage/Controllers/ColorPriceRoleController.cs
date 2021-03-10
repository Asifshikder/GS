using GS.DATA.Entities.CustomPort;
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

    public class ColorPriceRoleController : Controller
    {
        private IColorPriceRoleService ColorPriceRoleService;

        public ColorPriceRoleController(IColorPriceRoleService ColorPriceRoleService)
        {
            this.ColorPriceRoleService = ColorPriceRoleService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var entityList = ColorPriceRoleService.AllAsIEnumerable();
            return View(entityList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ColorPriceRole ColorPriceRole = new ColorPriceRole();
            return View(ColorPriceRole);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ColorPriceRole ColorPriceRole)
        {
            ColorPriceRoleService.InsertEntity(ColorPriceRole);
            return Redirect("/Manage/ColorPriceRole/Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ColorPriceRole ColorPriceRole = ColorPriceRoleService.GetById(id);
            return View(ColorPriceRole);
        }
        [HttpPost]
        [Route("/Manage/ColorPriceRole/Update")]
        [AutoValidateAntiforgeryToken]
        public IActionResult Update(ColorPriceRole ColorPriceRole)
        {
            ColorPriceRoleService.UpdateEntity(ColorPriceRole);
            return Redirect("/Manage/ColorPriceRole/Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            ColorPriceRole ColorPriceRole = ColorPriceRoleService.GetById(id);
            return View(ColorPriceRole);
        }
        [HttpPost]
        [Route("/Manage/ColorPriceRole/DeleteConfirm")]
        [AutoValidateAntiforgeryToken]
        public IActionResult DeleteConfirm(ColorPriceRole ColorPriceRole)
        {
            ColorPriceRoleService.DeleteEntity(ColorPriceRole);
            return Redirect("/Manage/ColorPriceRole/Index");
        }
    }
}
