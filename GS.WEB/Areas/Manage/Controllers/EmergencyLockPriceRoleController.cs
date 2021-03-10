using GS.DATA.Entities.CustomPort;
using GS.SERVICE.Interface.CustomPort;
using GS.WEB.Areas.Manage.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GS.WEB.Areas.Manage.Controllers
{
    [Area("Manage")]
    [Authorize]

    public class EmergencyLockPriceRoleController : Controller
    {
        private IEmergencyLockPriceRoleService EmergencyLockPriceRoleService;
        private IOperationStylePriceRoleService OperationStylePriceRoleService;

        public EmergencyLockPriceRoleController(IEmergencyLockPriceRoleService EmergencyLockPriceRoleService,
            IOperationStylePriceRoleService OperationStylePriceRoleService
            )
        {
            this.EmergencyLockPriceRoleService = EmergencyLockPriceRoleService;
            this.OperationStylePriceRoleService = OperationStylePriceRoleService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var entityList = EmergencyLockPriceRoleService.AllAsList();
            List<EmergencyLockPriceRoleVM> EmergencyLockPriceRole = new List<EmergencyLockPriceRoleVM>();
            foreach(var item in entityList)
            {
                EmergencyLockPriceRoleVM surface = new EmergencyLockPriceRoleVM();
                surface.OperationStylePriceRoleId = item.OperationStylePriceRoleId;
                surface.Id = item.Id;
                surface.Name = item.Name;
                surface.PriceIncrease = item.PriceIncrease;
                surface.OperationStylePriceRoleName = item.OperationStylePriceRoleId!=null?OperationStylePriceRoleService.GetById(item.OperationStylePriceRoleId.Value).Name:"..";
                EmergencyLockPriceRole.Add(surface);
            }
            return View(EmergencyLockPriceRole);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.OperationStylelist = new SelectList(OperationStylePriceRoleService.AllAsIEnumerable(), "Id", "Name");
            EmergencyLockPriceRole EmergencyLockPriceRole = new EmergencyLockPriceRole();
            return View(EmergencyLockPriceRole);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EmergencyLockPriceRole EmergencyLockPriceRole)
        {
            EmergencyLockPriceRoleService.InsertEntity(EmergencyLockPriceRole);
            return Redirect("/Manage/EmergencyLockPriceRole/Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.OperationStylelist = new SelectList(OperationStylePriceRoleService.AllAsIEnumerable(), "Id", "Name");
            EmergencyLockPriceRole EmergencyLockPriceRole = EmergencyLockPriceRoleService.GetById(id);
            return View(EmergencyLockPriceRole);
        }
        [HttpPost]
        [Route("/Manage/EmergencyLockPriceRole/Update")]
        [AutoValidateAntiforgeryToken]
        public IActionResult Update(EmergencyLockPriceRole EmergencyLockPriceRole)
        {
            EmergencyLockPriceRoleService.UpdateEntity(EmergencyLockPriceRole);
            return Redirect("/Manage/EmergencyLockPriceRole/Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            EmergencyLockPriceRole EmergencyLockPriceRole = EmergencyLockPriceRoleService.GetById(id);
            return View(EmergencyLockPriceRole);
        }
        [HttpPost]
        [Route("/Manage/EmergencyLockPriceRole/DeleteConfirm")]
        [AutoValidateAntiforgeryToken]
        public IActionResult DeleteConfirm(EmergencyLockPriceRole EmergencyLockPriceRole)
        {
            EmergencyLockPriceRoleService.DeleteEntity(EmergencyLockPriceRole);
            return Redirect("/Manage/EmergencyLockPriceRole/Index");
        }
    }
}
