using GS.DATA.Entities.Blog;
using GS.SERVICE.Interface.Blog;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;

namespace GS.WEB.ViewComponents
{
    [ViewComponent(Name = "BlogDropdown")]
    public class BlogDropdownViewComponent : ViewComponent
    {
        private readonly IBlogCategoryService _blogCategoryService;

        public BlogDropdownViewComponent(IBlogCategoryService blogCategoryService)
        {
            _blogCategoryService = blogCategoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await GetItemsAsync();
            return View(items);
        }

        private async Task<List<BlogCategory>> GetItemsAsync()
        {
            return _blogCategoryService.AllAsList();
        }
    }
}
