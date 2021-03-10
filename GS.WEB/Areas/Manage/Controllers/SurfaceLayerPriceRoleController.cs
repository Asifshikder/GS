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
    public class SurfaceLayerPriceRoleController : Controller
    {
        private ISurfaceLayerPriceRoleService SurfaceLayerPriceRoleService;
        private IPatternPriceRoleService patternPriceRoleService;

        public SurfaceLayerPriceRoleController(ISurfaceLayerPriceRoleService SurfaceLayerPriceRoleService,
            IPatternPriceRoleService patternPriceRoleService
            )
        {
            this.SurfaceLayerPriceRoleService = SurfaceLayerPriceRoleService;
            this.patternPriceRoleService = patternPriceRoleService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var entityList = SurfaceLayerPriceRoleService.AllAsList();
            List<SurfaceLayerPriceRoleVM> surfaceLayerPriceRole = new List<SurfaceLayerPriceRoleVM>();
            foreach(var item in entityList)
            {
                SurfaceLayerPriceRoleVM surface = new SurfaceLayerPriceRoleVM();
                surface.PatternPriceRoleId = item.PatternPriceRoleId;
                surface.Id = item.Id;
                surface.Name = item.Name;
                surface.PriceIncrease = item.PriceIncrease;
                surface.PatternPriceRoleName =item.PatternPriceRoleId!=null? patternPriceRoleService.GetById(item.PatternPriceRoleId.Value).Name:"..";
                surfaceLayerPriceRole.Add(surface);
            }
            return View(surfaceLayerPriceRole);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.patternlist = new SelectList(patternPriceRoleService.AllAsIEnumerable(), "Id", "Name");
            SurfaceLayerPriceRole SurfaceLayerPriceRole = new SurfaceLayerPriceRole();
            return View(SurfaceLayerPriceRole);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SurfaceLayerPriceRole SurfaceLayerPriceRole)
        {
            SurfaceLayerPriceRoleService.InsertEntity(SurfaceLayerPriceRole);
            return Redirect("/Manage/SurfaceLayerPriceRole/Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.patternlist = new SelectList(patternPriceRoleService.AllAsIEnumerable(), "Id", "Name");
            SurfaceLayerPriceRole SurfaceLayerPriceRole = SurfaceLayerPriceRoleService.GetById(id);
            return View(SurfaceLayerPriceRole);
        }
        [HttpPost]
        [Route("/Manage/SurfaceLayerPriceRole/Update")]
        [AutoValidateAntiforgeryToken]
        public IActionResult Update(SurfaceLayerPriceRole SurfaceLayerPriceRole)
        {
            SurfaceLayerPriceRoleService.UpdateEntity(SurfaceLayerPriceRole);
            return Redirect("/Manage/SurfaceLayerPriceRole/Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            SurfaceLayerPriceRole SurfaceLayerPriceRole = SurfaceLayerPriceRoleService.GetById(id);
            return View(SurfaceLayerPriceRole);
        }
        [HttpPost]
        [Route("/Manage/SurfaceLayerPriceRole/DeleteConfirm")]
        [AutoValidateAntiforgeryToken]
        public IActionResult DeleteConfirm(SurfaceLayerPriceRole SurfaceLayerPriceRole)
        {
            SurfaceLayerPriceRoleService.DeleteEntity(SurfaceLayerPriceRole);
            return Redirect("/Manage/SurfaceLayerPriceRole/Index");
        }
    }
}
