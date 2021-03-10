using GS.DATA.Entities.Blog;
using GS.DATA.Entities.CustomPort;
using GS.DATA.Entities.Delivery;
using GS.SERVICE.Interface.Blog;
using GS.SERVICE.Interface.CustomPort;
using GS.WEB.Areas.Manage.Models.Delivery;
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

    public class DeliveryFeeController : Controller
    {
        private IDeliveryFeeService DeliveryFeeService;
        private IDeliveryZoneService deliveryZoneService;

        public DeliveryFeeController(IDeliveryFeeService DeliveryFeeService, IDeliveryZoneService deliveryZoneService)
        {
            this.DeliveryFeeService = DeliveryFeeService;
            this.deliveryZoneService = deliveryZoneService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<DeliveryFeeViewModel> lstModel = new List<DeliveryFeeViewModel>();
            var entityList = DeliveryFeeService.AllAsIEnumerable();
            foreach (var item in entityList)
            {
                DeliveryFeeViewModel model = new DeliveryFeeViewModel();
                model.Id = item.Id;
                model.Fee = item.Fee;
                model.Description = item.Description;
                model.DoorCount = item.DoorCount;
                model.ZoneName = item.ZoneId != 0 ? deliveryZoneService.GetById(item.ZoneId).ZoneName : "...";
                lstModel.Add(model);
            }
            return View(lstModel);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.zoneList = new SelectList(deliveryZoneService.AllAsIEnumerable().Select(s => new { Id = s.Id, Name = s.ZoneName }), "Id", "Name");

            DeliveryFee DeliveryFee = new DeliveryFee();
            return View(DeliveryFee);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(DeliveryFee DeliveryFee)
        {

            DeliveryFeeService.InsertEntity(DeliveryFee);
            return Redirect("/Manage/DeliveryFee/Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.zoneList = new SelectList(deliveryZoneService.AllAsIEnumerable().Select(s => new { Id = s.Id, Name = s.ZoneName }), "Id", "Name");

            DeliveryFee DeliveryFee = DeliveryFeeService.GetById(id);
            return View(DeliveryFee);
        }
        [HttpPost]
        [Route("/Manage/DeliveryFee/Update")]
        [AutoValidateAntiforgeryToken]
        public IActionResult Update(DeliveryFee DeliveryFee)
        {
            DeliveryFeeService.UpdateEntity(DeliveryFee);
            return Redirect("/Manage/DeliveryFee/Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            DeliveryFee DeliveryFee = DeliveryFeeService.GetById(id);
            return View(DeliveryFee);
        }
        [HttpPost]
        [Route("/Manage/DeliveryFee/DeleteConfirm")]
        [AutoValidateAntiforgeryToken]
        public IActionResult DeleteConfirm(DeliveryFee DeliveryFee)
        {
            DeliveryFeeService.DeleteEntity(DeliveryFee);
            return Redirect("/Manage/DeliveryFee/Index");
        }
    }
}
