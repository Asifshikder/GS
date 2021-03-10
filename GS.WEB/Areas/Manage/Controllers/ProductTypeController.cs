using GS.DATA.Entities.Catelog;
using GS.SERVICE.Interface.Catelog;
using GS.WEB.Areas.Manage.Models.Catelog;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GS.WEB.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class ProductTypeController : Controller
    {
        private IProductTypeService productTypeService;

        public ProductTypeController(IProductTypeService productTypeService)
        {
            this.productTypeService = productTypeService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<ProductTypeViewModel> list = new List<ProductTypeViewModel>();
            var allpt = productTypeService.AllAsList();
            foreach(var item in allpt)
            {
                ProductTypeViewModel model = new ProductTypeViewModel();
                model.Id = item.Id;
                model.TypeName = item.TypeName;
                model.ParentId = item.ParentType;
                model.ParentName =item.ParentType!=null? productTypeService.GetById(item.ParentType.Value).TypeName:"";
                list.Add(model);
            }
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ProductType product = new ProductType();
            ViewBag.parentlist = new SelectList(productTypeService.AllAsIEnumerable().Where(s=>s.ParentType==null).Select(s=> new { Id=s.Id,Name=s.TypeName}), "Id", "Name");
            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ProductType model)
        {
            productTypeService.InsertEntity(model);
            return Redirect("/Manage/ProductType/Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ProductType product =productTypeService.GetById(id);
            ViewBag.parentlist = new SelectList(productTypeService.AllAsIEnumerable().Where(s=>s.ParentType==null).Select(s=> new { Id=s.Id,Name=s.TypeName}), "Id", "Name");
            return View(product);
        }
        [HttpPost]
        [Route("/Manage/ProductType/Update")]
        [ValidateAntiForgeryToken]
        public IActionResult Update(ProductType model)
        {
            productTypeService.UpdateEntity(model);
            return Redirect("/Manage/ProductType/Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            ProductType model = productTypeService.GetById(id);
            return View(model);
        }
        [HttpPost]
        [Route("/Manage/ProductType/DeleteConfirm")]
        [AutoValidateAntiforgeryToken]
        public IActionResult DeleteConfirm(ProductType model)
        {
            productTypeService.DeleteEntity(model);
            return Redirect("/Manage/productType/Index");
        }
    }
}
