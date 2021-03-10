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
    public class SizePriceRoleController : Controller
    {
        private ISizePriceRoleService SizePriceRoleService;

        public SizePriceRoleController(ISizePriceRoleService SizePriceRoleService)
        {
            this.SizePriceRoleService = SizePriceRoleService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var entityList = SizePriceRoleService.AllAsList();
            return View(entityList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            SizePriceRole SizePriceRole = new SizePriceRole();
            return View(SizePriceRole);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SizePriceRole SizePriceRole)
        {
            SizePriceRoleService.InsertEntity(SizePriceRole);
            return Redirect("/Manage/SizePriceRole/Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            SizePriceRole SizePriceRole = SizePriceRoleService.GetById(id);
            return View(SizePriceRole);
        }
        [HttpPost]
        [Route("/Manage/SizePriceRole/Update")]
        [AutoValidateAntiforgeryToken]
        public IActionResult Update(SizePriceRole SizePriceRole)
        {
            SizePriceRoleService.UpdateEntity(SizePriceRole);
            return Redirect("/Manage/SizePriceRole/Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            SizePriceRole SizePriceRole = SizePriceRoleService.GetById(id);
            return View(SizePriceRole);
        }
        [HttpPost]
        [Route("/Manage/SizePriceRole/DeleteConfirm")]
        [AutoValidateAntiforgeryToken]
        public IActionResult DeleteConfirm(SizePriceRole SizePriceRole)
        {
            SizePriceRoleService.DeleteEntity(SizePriceRole);
            return Redirect("/Manage/SizePriceRole/Index");
        }
    }
}
