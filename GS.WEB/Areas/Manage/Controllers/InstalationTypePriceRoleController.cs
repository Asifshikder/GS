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
    public class InstalationTypePriceRoleController : Controller
    {
        private IInstalationTypePriceRoleService InstalationTypePriceRoleService;

        public InstalationTypePriceRoleController(IInstalationTypePriceRoleService InstalationTypePriceRoleService)
        {
            this.InstalationTypePriceRoleService = InstalationTypePriceRoleService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var entityList = InstalationTypePriceRoleService.AllAsList();
            return View(entityList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            InstalationTypePriceRole InstalationTypePriceRole = new InstalationTypePriceRole();
            return View(InstalationTypePriceRole);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(InstalationTypePriceRole InstalationTypePriceRole)
        {
            InstalationTypePriceRoleService.InsertEntity(InstalationTypePriceRole);
            return Redirect("/Manage/InstalationTypePriceRole/Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            InstalationTypePriceRole InstalationTypePriceRole = InstalationTypePriceRoleService.GetById(id);
            return View(InstalationTypePriceRole);
        }
        [HttpPost]
        [Route("/Manage/InstalationTypePriceRole/Update")]
        [AutoValidateAntiforgeryToken]
        public IActionResult Update(InstalationTypePriceRole InstalationTypePriceRole)
        {
            InstalationTypePriceRoleService.UpdateEntity(InstalationTypePriceRole);
            return Redirect("/Manage/InstalationTypePriceRole/Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            InstalationTypePriceRole InstalationTypePriceRole = InstalationTypePriceRoleService.GetById(id);
            return View(InstalationTypePriceRole);
        }
        [HttpPost]
        [Route("/Manage/InstalationTypePriceRole/DeleteConfirm")]
        [AutoValidateAntiforgeryToken]
        public IActionResult DeleteConfirm(InstalationTypePriceRole InstalationTypePriceRole)
        {
            InstalationTypePriceRoleService.DeleteEntity(InstalationTypePriceRole);
            return Redirect("/Manage/InstalationTypePriceRole/Index");
        }
    }
}
