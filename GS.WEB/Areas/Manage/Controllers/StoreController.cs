using GS.DATA.Entities.Shop;
using GS.SERVICE.Interface.Shop;
using GS.WEB.Areas.Manage.Models.Shop;
using GS.WEB.Models.Handler;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GS.WEB.Areas.Manage.Controllers
{
    [Area("Manage")]
    [Authorize]
    public class StoreController : Controller
    {
        private IStoreService storeService;
        private IFileHandler fileHandelar;

        public StoreController(IStoreService storeService, IFileHandler fileHandelar)
        {
            this.storeService = storeService;
            this.fileHandelar = fileHandelar;
        }
        [HttpGet]
        public ActionResult Index()
        {

            var entityList = storeService.AllAsList();
            return View(entityList);
        }

       
        public ActionResult Create()
        {
            StoreVM store = new StoreVM();
            return View(store);
        }

        // POST: StoreController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StoreVM storeVM)
        {
            try
            {
                if (storeVM.StoreViewImageFile != null)
                {
                    var imgurl = fileHandelar.UploadFile("Store", storeVM.StoreViewImageFile);
                    storeVM.StoreViewImage = imgurl;
                }
                Store model = new Store();
                model.Name = storeVM.Name;
                model.Address = storeVM.Address;
                model.Description = storeVM.Description;
                model.Email = storeVM.Email;
                model.Phone = storeVM.Phone;
                model.MapIFrame = storeVM.MapIFrame;
                model.StoreOnTime = storeVM.StoreOnTime;
                model.SeoMETA = storeVM.SeoMETA;
                model.SeoMETAEnglish = storeVM.SeoMETAEnglish;
                model.StoreViewImage = storeVM.StoreViewImage;
                storeService.InsertEntity(model);
                return Redirect("/Manage/Store/Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: StoreController/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Store store = storeService.GetById(id);
            StoreVM model = new StoreVM();
            model.Name = store.Name;
            model.Address = store.Address;
            model.Description = store.Description;
            model.Email = store.Email;
            model.Phone = store.Phone;
            model.MapIFrame = store.MapIFrame;
            model.StoreOnTime = store.StoreOnTime;
            model.SeoMETA = store.SeoMETA;
            model.SeoMETAEnglish = store.SeoMETAEnglish;
            model.StoreViewImage = store.StoreViewImage;
            return View(model);
        }

        // POST: StoreController/Edit/5
        [HttpPost]
        [Route("/Manage/Store/Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(StoreVM storeVM)
        {
            try
            {
                if (storeVM.StoreViewImageFile != null)
                {
                    var imgurl = fileHandelar.UpdateFile(storeVM.StoreViewImage,"Store", storeVM.StoreViewImageFile);
                    storeVM.StoreViewImage = imgurl;
                }
                Store store = new Store();
                store.Id = storeVM.Id;
                store.Name = storeVM.Name;
                store.Description = storeVM.Description;
                store.Email = storeVM.Email;
                store.Phone = storeVM.Phone;
                store.MapIFrame = storeVM.MapIFrame;
                store.StoreOnTime = storeVM.StoreOnTime;
                store.SeoMETA = storeVM.SeoMETA;
                store.SeoMETAEnglish = storeVM.SeoMETAEnglish;
                store.StoreViewImage = storeVM.StoreViewImage;
                storeService.UpdateEntity(store);
                return Redirect("/Manage/Store/Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: StoreController/Delete/5
        public ActionResult Delete(int id)
        {
            Store store = storeService.GetById(id);
            return View(store);
        }

        // POST: StoreController/Delete/5
        [HttpPost]
        [Route("/Manage/Store/Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Store store)
        {

            try
            {
                storeService.DeleteEntity(store);
                return Redirect("/Manage/Store/Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
