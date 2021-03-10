using GS.DATA.Entities.Catelog;
using GS.SERVICE.Interface.Catelog;
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

    public class OperationStyleController : Controller
    {
        private IOperationStyleService OperationStyleService;

        public OperationStyleController(IOperationStyleService OperationStyleService)
        {
            this.OperationStyleService = OperationStyleService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var entityList = OperationStyleService.AllAsIEnumerable();
            return View(entityList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            OperationStyle OperationStyle = new OperationStyle();
            return View(OperationStyle);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(OperationStyle OperationStyle)
        {
            OperationStyleService.InsertEntity(OperationStyle);
            return Redirect("/Manage/OperationStyle/Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            OperationStyle OperationStyle = OperationStyleService.GetById(id);
            return View(OperationStyle);
        }
        [HttpPost]
        [Route("/Manage/OperationStyle/Update")]
        [AutoValidateAntiforgeryToken]
        public IActionResult Update(OperationStyle OperationStyle)
        {
            OperationStyleService.UpdateEntity(OperationStyle);
            return Redirect("/Manage/OperationStyle/Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            OperationStyle OperationStyle = OperationStyleService.GetById(id);
            return View(OperationStyle);
        }
        [HttpPost]
        [Route("/Manage/OperationStyle/DeleteConfirm")]
        [AutoValidateAntiforgeryToken]
        public IActionResult DeleteConfirm(OperationStyle OperationStyle)
        {
            OperationStyleService.DeleteEntity(OperationStyle);
            return Redirect("/Manage/OperationStyle/Index");
        }
    }
}
