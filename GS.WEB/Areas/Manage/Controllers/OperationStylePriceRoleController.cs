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
    public class OperationStylePriceRoleController : Controller
    {
        private IOperationStylePriceRoleService OperationStylePriceRoleService;

        public OperationStylePriceRoleController(IOperationStylePriceRoleService OperationStylePriceRoleService)
        {
            this.OperationStylePriceRoleService = OperationStylePriceRoleService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var entityList = OperationStylePriceRoleService.AllAsList();
            return View(entityList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            OperationStylePriceRole OperationStylePriceRole = new OperationStylePriceRole();
            return View(OperationStylePriceRole);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(OperationStylePriceRole OperationStylePriceRole)
        {
            OperationStylePriceRoleService.InsertEntity(OperationStylePriceRole);
            return Redirect("/Manage/OperationStylePriceRole/Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            OperationStylePriceRole OperationStylePriceRole = OperationStylePriceRoleService.GetById(id);
            return View(OperationStylePriceRole);
        }
        [HttpPost]
        [Route("/Manage/OperationStylePriceRole/Update")]
        [AutoValidateAntiforgeryToken]
        public IActionResult Update(OperationStylePriceRole OperationStylePriceRole)
        {
            OperationStylePriceRoleService.UpdateEntity(OperationStylePriceRole);
            return Redirect("/Manage/OperationStylePriceRole/Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            OperationStylePriceRole OperationStylePriceRole = OperationStylePriceRoleService.GetById(id);
            return View(OperationStylePriceRole);
        }
        [HttpPost]
        [Route("/Manage/OperationStylePriceRole/DeleteConfirm")]
        [AutoValidateAntiforgeryToken]
        public IActionResult DeleteConfirm(OperationStylePriceRole OperationStylePriceRole)
        {
            OperationStylePriceRoleService.DeleteEntity(OperationStylePriceRole);
            return Redirect("/Manage/OperationStylePriceRole/Index");
        }
    }
}
