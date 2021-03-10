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

    public class PostalCodeController : Controller
    {
        private IPostalCodeService PostalCodeService;
        private IDeliveryZoneService deliveryZoneService;

        public PostalCodeController(IPostalCodeService PostalCodeService,IDeliveryZoneService deliveryZoneService)
        {
            this.PostalCodeService = PostalCodeService;
            this.deliveryZoneService = deliveryZoneService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<PostalCodeViewModel> lstModel = new List<PostalCodeViewModel>();
            var entityList = PostalCodeService.AllAsIEnumerable();
            foreach(var item in entityList)
            {
                PostalCodeViewModel model = new PostalCodeViewModel();
                model.Id = item.Id;
                model.PostCodeStart = item.PostCodeStart;
                model.PostCodeEnd = item.PostCodeEnd;
                model.ZoneName = item.ZoneId!=0? deliveryZoneService.GetById(item.ZoneId).ZoneName:"...";
                lstModel.Add(model);
            }
            return View(lstModel);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.zoneList = new SelectList(deliveryZoneService.AllAsIEnumerable().Select(s=> new {Id= s.Id,Name= s.ZoneName}), "Id", "Name");

            PostalCode PostalCode = new PostalCode();
            return View(PostalCode);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PostalCode PostalCode)
        {

            PostalCodeService.InsertEntity(PostalCode);
            return Redirect("/Manage/PostalCode/Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.zoneList = new SelectList(deliveryZoneService.AllAsIEnumerable().Select(s => new { Id = s.Id, Name = s.ZoneName }), "Id", "Name");

            PostalCode PostalCode = PostalCodeService.GetById(id);
            return View(PostalCode);
        }
        [HttpPost]
        [Route("/Manage/PostalCode/Update")]
        [AutoValidateAntiforgeryToken]
        public IActionResult Update(PostalCode PostalCode)
        {
            PostalCodeService.UpdateEntity(PostalCode);
            return Redirect("/Manage/PostalCode/Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            PostalCode PostalCode = PostalCodeService.GetById(id);
            return View(PostalCode);
        }
        [HttpPost]
        [Route("/Manage/PostalCode/DeleteConfirm")]
        [AutoValidateAntiforgeryToken]
        public IActionResult DeleteConfirm(PostalCode PostalCode)
        {
            PostalCodeService.DeleteEntity(PostalCode);
            return Redirect("/Manage/PostalCode/Index");
        }
    }
}
