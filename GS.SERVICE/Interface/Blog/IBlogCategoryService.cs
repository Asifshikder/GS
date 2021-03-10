using GS.DATA.Entities;
using GS.DATA.Entities.Blog;
using GS.DATA.Entities.Catelog;
using GS.DATA.Entities.CustomPort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Interface.Blog
{
    public interface IBlogCategoryService
    {
        IEnumerable<BlogCategory> AllAsIEnumerable();
        IQueryable<BlogCategory> AllAsIQueryable();
        List<BlogCategory> AllAsList();
        BlogCategory GetById(int id);
        void InsertEntity(BlogCategory BlogCategory);
        void UpdateEntity(BlogCategory BlogCategory);
        void DeleteEntity(BlogCategory BlogCategory);
        void DeleteById(int id);
    }
}
