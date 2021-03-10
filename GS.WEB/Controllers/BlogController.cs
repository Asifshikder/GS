using GS.SERVICE.Interface.Blog;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GS.WEB.Controllers
{
    public class BlogController : Controller
    {
        private IBlogPostService blogPostService;

        public BlogController(IBlogPostService blogPostService)
        {
            this.blogPostService = blogPostService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var bloglist = blogPostService.AllAsList();
            return View(bloglist);
        }
        //[HttpGet]
        //public IActionResult Index()
        //{
        //    var bloglist = blogPostService.AllAsList();
        //    return View(bloglist);
        //}
    }
}
