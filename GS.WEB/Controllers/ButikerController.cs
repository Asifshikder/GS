using GS.SERVICE.Interface.Shop;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GS.WEB.Controllers
{
    public class ButikerController : Controller
    {
        private IStoreService storeService;
        private IStoreEmployeeService storeEmployeeService;

        public ButikerController(IStoreService storeService, IStoreEmployeeService storeEmployeeService)
        {
            this.storeService = storeService;
            this.storeEmployeeService = storeEmployeeService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var butikers = storeService.AllAsIEnumerable();
            ViewBag.shoplist = new SelectList(storeService.AllAsIEnumerable().Select(s => new { Id = s.Id, Name = s.Name }), "Id", "Name");
            return View(butikers);
        }
    }
}
