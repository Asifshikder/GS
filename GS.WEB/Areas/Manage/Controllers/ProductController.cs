using GS.DATA.Entities.Catelog;
using GS.SERVICE.Interface.Catelog;
using GS.WEB.Areas.Manage.Models.Catelog;
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
    public class ProductController : Controller
    {
        private IProductService productService;
        private IProductTypeService productTypeService;
        private IModelService modelService;
        private IOperationStyleService operationStyleService;
        private IFileHandler fileHandler;

        public ProductController(IProductService productService,
            IProductTypeService productTypeService,
            IModelService modelService,
            IOperationStyleService operationStyleService,
            IFileHandler fileHandler
            )
        {
            this.productService = productService;
            this.productTypeService = productTypeService;
            this.modelService = modelService;
            this.operationStyleService = operationStyleService;
            this.fileHandler = fileHandler;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var pl = productService.AllAsList();
            List<ProductViewModel> model = new List<ProductViewModel>();
            foreach (var item in pl)
            {
                ProductViewModel md = new ProductViewModel();
                md.Id = item.Id;
                md.Title = item.Title;
                md.PrimaryImage = item.PrimaryImage;
                md.Price = item.Price;
                md.CategoryName = item.CategoryId != null ? productTypeService.GetById(item.CategoryId.Value).TypeName : "..";
                model.Add(md);
            }
            return View(model);
        }


        [HttpGet]
        public IActionResult Create()
        {
            ProductViewModel model = new ProductViewModel();
            ViewBag.catlist = new SelectList(productTypeService.AllAsIEnumerable().Where(s => s.ParentType == null).Select(s => new { Id = s.Id, Name = s.TypeName }), "Id", "Name");
            ViewBag.subcatlist = new SelectList(productTypeService.AllAsIEnumerable().Where(s => s.ParentType != null).Select(s => new { Id = s.Id, Name = s.TypeName }), "Id", "Name");
            ViewBag.modellist = new SelectList(modelService.AllAsIEnumerable().Select(s => new { Id = s.Id, Name = s.ModelName }), "Id", "Name");
            ViewBag.operationlist = new SelectList(operationStyleService.AllAsIEnumerable().Select(s => new { Id = s.Id, Name = s.Name }), "Id", "Name");
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ProductViewModel model)
        {
            if (model.PrimaryImageFile != null)
            {
                var imgurl = fileHandler.UploadFile("Product", model.PrimaryImageFile);
                model.PrimaryImage = imgurl;
            }
            if (model.Image1File != null)
            {
                var imgurl = fileHandler.UploadFile("Product", model.Image1File);
                model.Image1 = imgurl;
            }
            if (model.Image2File != null)
            {
                var imgurl = fileHandler.UploadFile("Product", model.Image2File);
                model.Image2 = imgurl;
            }
            if (model.Image3File != null)
            {
                var imgurl = fileHandler.UploadFile("Product", model.Image3File);
                model.Image3 = imgurl;
            }
            if (model.Image4File != null)
            {
                var imgurl = fileHandler.UploadFile("Product", model.Image4File);
                model.Image4 = imgurl;
            }
            if (model.DocumentationFile1File != null)
            {
                var fileUrl = fileHandler.UploadFile("Product", model.DocumentationFile1File);
                model.DocumentationFile1 = fileUrl;
            }
            if (model.DocumentationFile2File != null)
            {
                var fileUrl = fileHandler.UploadFile("Product", model.DocumentationFile2File);
                model.DocumentationFile2 = fileUrl;
            }
            Product pro = new Product();
            pro.Image1 = model.Image1;
            pro.Image2 = model.Image2;
            pro.Image3 = model.Image3;
            pro.Image4 = model.Image4;
            pro.PrimaryImage = model.PrimaryImage;
            pro.Title = model.Title;
            pro.Description = model.Description;
            pro.TechnicalSpec = model.TechnicalSpec;
            pro.Price = model.Price;
            pro.CategoryId = model.SubCategoryId!=null?model.SubCategoryId:model.CategoryId;
            pro.ModelId = model.ModelId;
            pro.OperationStyleId = model.OperationStyleId;
            pro.DocumentationFile1 = model.DocumentationFile1;
            pro.DocumentationFile2 = model.DocumentationFile2;
            productService.InsertEntity(pro);
            return Redirect("/Manage/Product/Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ProductViewModel pro = new ProductViewModel();
            ViewBag.catlist = new SelectList(productTypeService.AllAsIEnumerable().Where(s => s.ParentType == null).Select(s => new { Id = s.Id, Name = s.TypeName }), "Id", "Name");
            ViewBag.subcatlist = new SelectList(productTypeService.AllAsIEnumerable().Where(s => s.ParentType != null).Select(s => new { Id = s.Id, Name = s.TypeName }), "Id", "Name");
            ViewBag.modellist = new SelectList(modelService.AllAsIEnumerable().Select(s => new { Id = s.Id, Name = s.ModelName }), "Id", "Name");
            ViewBag.operationlist = new SelectList(operationStyleService.AllAsIEnumerable().Select(s => new { Id = s.Id, Name = s.Name }), "Id", "Name");
            var model = productService.GetById(id);
            var check = productTypeService.GetById(model.CategoryId.Value);

            pro.Id = model.Id;
            pro.Image1 = model.Image1;
            pro.Image2 = model.Image2;
            pro.Image3 = model.Image3;
            pro.Image4 = model.Image4;
            pro.PrimaryImage = model.PrimaryImage;
            pro.Title = model.Title;
            pro.Description = model.Description; pro.TechnicalSpec = model.TechnicalSpec;

            pro.Price = model.Price;
            if (check.ParentType != null)
            {
                pro.SubCategoryId = model.CategoryId;
                pro.CategoryId = check.ParentType;
            }
            else
            {
                pro.CategoryId = model.CategoryId;
            }
            pro.ModelId = model.ModelId;
            pro.OperationStyleId = model.OperationStyleId;
            pro.DocumentationFile1 = model.DocumentationFile1;
            pro.DocumentationFile2 = model.DocumentationFile2;
            return View(pro);
        }
        [HttpPost]
        [Route("/Manage/Product/Update")]
        [ValidateAntiForgeryToken]
        public IActionResult Update(ProductViewModel model)
        {
            if (model.PrimaryImageFile != null)
            {
                var imgurl = fileHandler.UpdateFile(model.PrimaryImage,"Product", model.PrimaryImageFile);
                model.PrimaryImage = imgurl;
            }
            if (model.Image1File != null)
            {
                var imgurl = fileHandler.UpdateFile(model.Image1,"Product", model.Image1File);
                model.Image1 = imgurl;
            }
            if (model.Image2File != null)
            {
                var imgurl = fileHandler.UpdateFile(model.Image2,"Product", model.Image2File);
                model.Image2 = imgurl;
            }
            if (model.Image3File != null)
            {
                var imgurl = fileHandler.UpdateFile(model.Image3,"Product", model.Image3File);
                model.Image3 = imgurl;
            }
            if (model.Image4File != null)
            {
                var imgurl = fileHandler.UpdateFile(model.Image4,"Product", model.Image4File);
                model.Image4 = imgurl;
            }
            if (model.DocumentationFile1File != null)
            {
                var fileUrl = fileHandler.UpdateFile(model.DocumentationFile1,"Product", model.DocumentationFile1File);
                model.DocumentationFile1 = fileUrl;
            }
            if (model.DocumentationFile2File != null)
            {
                var fileUrl = fileHandler.UpdateFile(model.DocumentationFile2,"Product", model.DocumentationFile2File);
                model.DocumentationFile2 = fileUrl;
            }
            Product pro = new Product();
            pro.Id = model.Id;
            pro.Image1 = model.Image1;
            pro.Image2 = model.Image2;
            pro.Image3 = model.Image3;
            pro.Image4 = model.Image4;
            pro.PrimaryImage = model.PrimaryImage;
            pro.Title = model.Title;
            pro.Description = model.Description; pro.TechnicalSpec = model.TechnicalSpec;

            pro.Price = model.Price;
            pro.CategoryId = model.SubCategoryId != null ? model.SubCategoryId : model.CategoryId;
            pro.ModelId = model.ModelId;
            pro.OperationStyleId = model.OperationStyleId;
            pro.DocumentationFile1 = model.DocumentationFile1;
            pro.DocumentationFile2 = model.DocumentationFile2;
            productService.UpdateEntity(pro);
            return Redirect("/Manage/Product/Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            
            var model = productService.GetById(id);
            return View(model);
        }
        [HttpPost]
        [Route("/Manage/Product/Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirm(Product model)
        {
            if (model.PrimaryImage != null)
            {
                fileHandler.DeleteFile(model.PrimaryImage);
            }
            if (model.Image1!= null)
            {
                fileHandler.DeleteFile(model.Image1);
            }
            if (model.Image2 != null)
            {
                fileHandler.DeleteFile(model.Image2);
            }
            if (model.Image3 != null)
            {
                fileHandler.DeleteFile(model.Image3);
            }
            if (model.Image4 != null)
            {
                fileHandler.DeleteFile(model.Image4);
            }
            if (model.DocumentationFile1 != null)
            {
                fileHandler.DeleteFile(model.DocumentationFile1);
            }
            if (model.DocumentationFile2 != null)
            {
                fileHandler.DeleteFile(model.DocumentationFile2);
            }
          
            productService.DeleteEntity(model);
            return Redirect("/Manage/Product/Index");
        }


        [HttpGet]
        public JsonResult GetSubCategory(int? categoryId)
        {
            if (categoryId != null)
            {
                ViewBag.subcatlist = new SelectList(productTypeService.AllAsIEnumerable().Where(s => s.ParentType == categoryId).Select(s => new { Id = s.Id, Name = s.TypeName }), "Id", "Name");
            }
            else
            {
                ViewBag.subcatlist = new SelectList(productTypeService.AllAsIEnumerable().Where(s => s.ParentType != null).Select(s => new { Id = s.Id, Name = s.TypeName }), "Id", "Name");
            }
            return Json(ViewBag.subcatlist);

        }
    }
}
