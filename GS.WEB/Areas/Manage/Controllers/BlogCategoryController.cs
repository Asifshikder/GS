using GS.DATA.Entities.Blog;
using GS.DATA.Entities.CustomPort;
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

    public class BlogCategoryController : Controller
    {
        private IBlogCategoryService BlogCategoryService;

        public BlogCategoryController(IBlogCategoryService BlogCategoryService)
        {
            this.BlogCategoryService = BlogCategoryService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var entityList = BlogCategoryService.AllAsIEnumerable();
            return View(entityList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            BlogCategory BlogCategory = new BlogCategory();
            return View(BlogCategory);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BlogCategory BlogCategory)
        {
            BlogCategoryService.InsertEntity(BlogCategory);
            return Redirect("/Blog/BlogCategory/Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            BlogCategory BlogCategory = BlogCategoryService.GetById(id);
            return View(BlogCategory);
        }
        [HttpPost]
        [Route("/Blog/BlogCategory/Update")]
        [AutoValidateAntiforgeryToken]
        public IActionResult Update(BlogCategory BlogCategory)
        {
            BlogCategoryService.UpdateEntity(BlogCategory);
            return Redirect("/Blog/BlogCategory/Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            BlogCategory BlogCategory = BlogCategoryService.GetById(id);
            return View(BlogCategory);
        }
        [HttpPost]
        [Route("/Blog/BlogCategory/DeleteConfirm")]
        [AutoValidateAntiforgeryToken]
        public IActionResult DeleteConfirm(BlogCategory BlogCategory)
        {
            BlogCategoryService.DeleteEntity(BlogCategory);
            return Redirect("/Blog/BlogCategory/Index");
        }
    }
}
