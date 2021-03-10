using GS.DATA.Entities.Blog;
using GS.DATA.Entities.CustomPort;
using GS.DATA.Entities.Delivery;
using GS.SERVICE.Interface.Blog;
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

    public class DeliveryZoneController : Controller
    {
        private IDeliveryZoneService DeliveryZoneService;

        public DeliveryZoneController(IDeliveryZoneService DeliveryZoneService)
        {
            this.DeliveryZoneService = DeliveryZoneService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var entityList = DeliveryZoneService.AllAsIEnumerable();
            return View(entityList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            DeliveryZone deliveryZone = new DeliveryZone();
            return View(deliveryZone);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(DeliveryZone deliveryZone)
        {
            DeliveryZoneService.InsertEntity(deliveryZone);
            return Redirect("/Manage/DeliveryZone/Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            DeliveryZone deliveryZone = DeliveryZoneService.GetById(id);
            return View(deliveryZone);
        }
        [HttpPost]
        [Route("/Manage/DeliveryZone/Update")]
        [AutoValidateAntiforgeryToken]
        public IActionResult Update(DeliveryZone deliveryZone)
        {
            DeliveryZoneService.UpdateEntity(deliveryZone);
            return Redirect("/Manage/DeliveryZone/Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            DeliveryZone deliveryZone = DeliveryZoneService.GetById(id);
            return View(deliveryZone);
        }
        [HttpPost]
        [Route("/Manage/DeliveryZone/DeleteConfirm")]
        [AutoValidateAntiforgeryToken]
        public IActionResult DeleteConfirm(DeliveryZone deliveryZone)
        {
            DeliveryZoneService.DeleteEntity(deliveryZone);
            return Redirect("/Manage/DeliveryZone/Index");
        }
    }
}
