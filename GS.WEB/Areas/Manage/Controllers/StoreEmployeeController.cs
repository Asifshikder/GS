using GS.DATA.Entities.Shop;
using GS.SERVICE.Interface.Shop;
using GS.WEB.Areas.Manage.Models.Shop;
using GS.WEB.Models.Handler;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GS.WEB.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class StoreEmployeeController : Controller
    {
        private IStoreEmployeeService storeEmployeeService;
        private IStoreService storeService;
        private IFileHandler fileHandler;

        public StoreEmployeeController(IStoreEmployeeService storeEmployeeService, IStoreService storeService, IFileHandler fileHandler)
        {
            this.storeEmployeeService = storeEmployeeService;
            this.storeService = storeService;
            this.fileHandler = fileHandler;
        }
        [HttpGet]
        public IActionResult Index(int id)
        {

            ViewBag.StoreId = id;
            var sE = storeEmployeeService.AllAsList().Where(s => s.StoreId == id);
            List<StoreEmployeeVM> model = new List<StoreEmployeeVM>();
            foreach (var item in sE)
            {
                StoreEmployeeVM sEV = new StoreEmployeeVM();
                sEV.Id = item.Id;
                sEV.FullName = item.FullName;
                sEV.Email = item.Email;
                sEV.PhoneNumber = item.PhoneNumber;
                sEV.Designation = item.Designation;
                sEV.EmployeeImage = item.EmployeeImage;
                sEV.StoreName = item.StoreId != 0 ? storeService.GetById(item.StoreId).Name : "..";
                model.Add(sEV);
            }
            return View(model);

        }
        public IActionResult Create(int storeid)
        {
            StoreEmployeeVM model = new StoreEmployeeVM();
            model.StoreId = storeid;
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(StoreEmployeeVM model)
        {
            if (model.EmployeImageefile != null)
            {
                var imgurl = fileHandler.UploadFile("StoreEmployee", model.EmployeImageefile);
                model.EmployeeImage = imgurl;
            }
            StoreEmployee sEV = new StoreEmployee();
            sEV.FullName = model.FullName;
            sEV.Email = model.Email;
            sEV.PhoneNumber = model.PhoneNumber;
            sEV.Designation = model.Designation;
            sEV.EmployeeImage = model.EmployeeImage;
            sEV.StoreId = model.StoreId.Value;
            storeEmployeeService.InsertEntity(sEV);
            return Redirect("/Manage/StoreEmployee/Index?id=" + model.StoreId + "");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            StoreEmployee model = storeEmployeeService.GetById(id);
            StoreEmployeeVM sEV = new StoreEmployeeVM();
            sEV.Id = model.Id;
            sEV.FullName = model.FullName;
            sEV.Email = model.Email;
            sEV.PhoneNumber = model.PhoneNumber;
            sEV.Designation = model.Designation;
            sEV.EmployeeImage = model.EmployeeImage;
            sEV.StoreId = model.StoreId;
            return View(sEV);
        }
        [HttpPost]
        [Route("/Manage/StoreEmployee/Update")]
        [AutoValidateAntiforgeryToken]
        public IActionResult Update(StoreEmployeeVM sEmp)
        {
            if (sEmp.EmployeImageefile != null)
            {
                var imgurl = fileHandler.UploadFile("StoreEmployee", sEmp.EmployeImageefile);
                sEmp.EmployeeImage = imgurl;
            }
            StoreEmployee model = new StoreEmployee();
            model.Id = sEmp.Id;
            model.FullName = sEmp.FullName;
            model.Email = sEmp.Email;
            model.PhoneNumber = sEmp.PhoneNumber;
            model.Designation = sEmp.Designation;
            model.EmployeeImage = sEmp.EmployeeImage;
            model.StoreId = sEmp.StoreId.Value;
            storeEmployeeService.UpdateEntity(model);
            return Redirect("/Manage/StoreEmployee/Index?id=" + model.StoreId + "");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            StoreEmployee storem = storeEmployeeService.GetById(id);
            return View(storem);
        }
        [HttpPost]
        [Route("/Manage/StoreEmployee/DeleteConfirm")]
        public IActionResult DeleteConfirm(StoreEmployee storeM)
        {
            if (storeM.EmployeeImage != null)
            {
                fileHandler.DeleteFile(storeM.EmployeeImage);
            }
            storeEmployeeService.DeleteEntity(storeM);
            return Redirect("/Manage/StoreEmployee/Index?id="+storeM.StoreId+"");
        }
    }

}
