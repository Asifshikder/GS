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
    public class ExtraRemoteControlPriceRoleController : Controller
    {
        private IExtraRemoteControlPriceRoleService ExtraRemoteControlPriceRoleService;
        private IOperationStylePriceRoleService OperationStylePriceRoleService;

        public ExtraRemoteControlPriceRoleController(IExtraRemoteControlPriceRoleService ExtraRemoteControlPriceRoleService,
            IOperationStylePriceRoleService OperationStylePriceRoleService
            )
        {
            this.ExtraRemoteControlPriceRoleService = ExtraRemoteControlPriceRoleService;
            this.OperationStylePriceRoleService = OperationStylePriceRoleService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var entityList = ExtraRemoteControlPriceRoleService.AllAsList();
            List<ExtraRemoteControlPriceRoleVM> ExtraRemoteControlPriceRole = new List<ExtraRemoteControlPriceRoleVM>();
            foreach(var item in entityList)
            {
                ExtraRemoteControlPriceRoleVM surface = new ExtraRemoteControlPriceRoleVM();
                surface.OperationStylePriceRoleId = item.OperationStylePriceRoleId;
                surface.Id = item.Id;
                surface.Name = item.Name;
                surface.PriceIncrease = item.PriceIncrease;
                surface.OperationStylePriceRoleName =item.OperationStylePriceRoleId!=null? OperationStylePriceRoleService.GetById(item.OperationStylePriceRoleId.Value).Name:"..";
                ExtraRemoteControlPriceRole.Add(surface);
            }
            return View(ExtraRemoteControlPriceRole);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.OperationStylelist = new SelectList(OperationStylePriceRoleService.AllAsIEnumerable(), "Id", "Name");
            ExtraRemoteControlPriceRole ExtraRemoteControlPriceRole = new ExtraRemoteControlPriceRole();
            return View(ExtraRemoteControlPriceRole);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ExtraRemoteControlPriceRole ExtraRemoteControlPriceRole)
        {
            ExtraRemoteControlPriceRoleService.InsertEntity(ExtraRemoteControlPriceRole);
            return Redirect("/Manage/ExtraRemoteControlPriceRole/Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.OperationStylelist = new SelectList(OperationStylePriceRoleService.AllAsIEnumerable(), "Id", "Name");
            ExtraRemoteControlPriceRole ExtraRemoteControlPriceRole = ExtraRemoteControlPriceRoleService.GetById(id);
            return View(ExtraRemoteControlPriceRole);
        }
        [HttpPost]
        [Route("/Manage/ExtraRemoteControlPriceRole/Update")]
        [AutoValidateAntiforgeryToken]
        public IActionResult Update(ExtraRemoteControlPriceRole ExtraRemoteControlPriceRole)
        {
            ExtraRemoteControlPriceRoleService.UpdateEntity(ExtraRemoteControlPriceRole);
            return Redirect("/Manage/ExtraRemoteControlPriceRole/Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            ExtraRemoteControlPriceRole ExtraRemoteControlPriceRole = ExtraRemoteControlPriceRoleService.GetById(id);
            return View(ExtraRemoteControlPriceRole);
        }
        [HttpPost]
        [Route("/Manage/ExtraRemoteControlPriceRole/DeleteConfirm")]
        [AutoValidateAntiforgeryToken]
        public IActionResult DeleteConfirm(ExtraRemoteControlPriceRole ExtraRemoteControlPriceRole)
        {
            ExtraRemoteControlPriceRoleService.DeleteEntity(ExtraRemoteControlPriceRole);
            return Redirect("/Manage/ExtraRemoteControlPriceRole/Index");
        }
    }
}
