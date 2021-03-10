using GS.DATA.Entities.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Interface.Blog
{
    public interface IBlogPostService
    {
        IEnumerable<BlogPost> AllAsIEnumerable();
        IQueryable<BlogPost> AllAsIQueryable();
        List<BlogPost> AllAsList();
        BlogPost GetById(int id);
        void InsertEntity(BlogPost blogPost);
        void UpdateEntity(BlogPost blogPost);
        void DeleteEntity(BlogPost blogPost);
        void DeleteById(int id);
    }
}
