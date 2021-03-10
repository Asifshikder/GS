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
    public class PatternPriceRoleController : Controller
    {
        private IPatternPriceRoleService patternPriceRoleService;

        public PatternPriceRoleController(IPatternPriceRoleService patternPriceRoleService)
        {
            this.patternPriceRoleService = patternPriceRoleService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var entityList = patternPriceRoleService.AllAsList();
            return View(entityList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            PatternPriceRole patternPriceRole = new PatternPriceRole();
            return View(patternPriceRole);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PatternPriceRole patternPriceRole)
        {
            patternPriceRoleService.InsertEntity(patternPriceRole);
            return Redirect("/Manage/PatternPriceRole/Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            PatternPriceRole patternPriceRole = patternPriceRoleService.GetById(id);
            return View(patternPriceRole);
        }
        [HttpPost]
        [Route("/Manage/PatternPriceRole/Update")]
        [AutoValidateAntiforgeryToken]
        public IActionResult Update(PatternPriceRole patternPriceRole)
        {
            patternPriceRoleService.UpdateEntity(patternPriceRole);
            return Redirect("/Manage/PatternPriceRole/Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            PatternPriceRole patternPriceRole = patternPriceRoleService.GetById(id);
            return View(patternPriceRole);
        }
        [HttpPost]
        [Route("/Manage/PatternPriceRole/DeleteConfirm")]
        [AutoValidateAntiforgeryToken]
        public IActionResult DeleteConfirm(PatternPriceRole patternPriceRole)
        {
            patternPriceRoleService.DeleteEntity(patternPriceRole);
            return Redirect("/Manage/PatternPriceRole/Index");
        }
    }
}
