using GS.DATA.Entities.Blog;
using GS.DATA.Entities.CustomPort;
using GS.SERVICE.Interface.Blog;
using GS.SERVICE.Interface.CustomPort;
using GS.WEB.Areas.Manage.Models.Blog;
using GS.WEB.Models.Handler;
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

    public class BlogPostController : Controller
    {
        private IBlogPostService blogPostService;
        private IBlogCategoryService blogCategoryService;
        private IFileHandler fileHandler;

        public BlogPostController(IBlogPostService blogPostService, IFileHandler fileHandler,IBlogCategoryService blogCategoryService)
        {
            this.blogPostService = blogPostService;
            this.blogCategoryService = blogCategoryService;
            this.fileHandler = fileHandler;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var entityList = blogPostService.AllAsIEnumerable();
            return View(entityList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.catlist = new SelectList(blogCategoryService.AllAsIEnumerable().Select(s => new { Id = s.Id, Name = s.Name }), "Id", "Name");
            BlogPostViewModel BlogPost = new BlogPostViewModel();
            return View(BlogPost);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BlogPostViewModel blogPost)
        {
            if (blogPost.PrimaryImageFile != null)
            {
                blogPost.PrimaryImage = fileHandler.UploadFile("Blog", blogPost.PrimaryImageFile);
            }
            BlogPost model = new BlogPost();
            model.Title = blogPost.Title;
            model.Description = blogPost.Description;
            model.PrimaryImage = blogPost.PrimaryImage;
            model.BlogCategoryId = blogPost.BlogCategoryId;
            model.IsFeatured = blogPost.IsFeatured;
            blogPostService.InsertEntity(model);
            return Redirect("/Blog/BlogPost/Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.catlist = new SelectList(blogCategoryService.AllAsIEnumerable().Select(s => new { Id = s.Id, Name = s.Name }), "Id", "Name");

            BlogPost model = blogPostService.GetById(id);
            BlogPostViewModel blog = new BlogPostViewModel();
            blog.Id = model.Id;
            blog.Title = model.Title;
            blog.Description = model.Description;
            blog.BlogCategoryId = model.BlogCategoryId;
            blog.IsFeatured = model.IsFeatured.Value;
            blog.PrimaryImage = model.PrimaryImage;
            return View(blog);
        }
        [HttpPost]
        [Route("/Blog/BlogPost/Update")]
        [AutoValidateAntiforgeryToken]
        public IActionResult Update(BlogPostViewModel blogPost)
        {
            if (blogPost.PrimaryImageFile != null)
            {
                blogPost.PrimaryImage = fileHandler.UpdateFile(blogPost.PrimaryImage, "Blog", blogPost.PrimaryImageFile);
            }
            BlogPost model = new BlogPost();
            model.Id = model.Id;
            model.Title = model.Title;
            model.Description = model.Description;
            model.PrimaryImage = model.PrimaryImage;
            model.BlogCategoryId = model.BlogCategoryId;
            blogPostService.UpdateEntity(model);
            return Redirect("/Blog/BlogPost/Index");
        }
        //[HttpGet]
        //public IActionResult Delete(int id)
        //{
        //    BlogPost BlogPost = blogPostService.GetById(id);
        //    return View(BlogPost);
        //}
        //[HttpPost]
        //[Route("/Blog/BlogPost/DeleteConfirm")]
        //[AutoValidateAntiforgeryToken]
        //public IActionResult DeleteConfirm(BlogPost blogPost)
        //{
        //    if (blogPost.PrimaryImage != null)
        //    {
        //        fileHandler.DeleteFile(blogPost.PrimaryImage);
        //    }
        //    blogPostService.DeleteEntity(blogPost);
        //    return Redirect("/Blog/BlogPost/Index");
        //}
    }
}
