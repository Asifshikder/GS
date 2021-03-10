using GS.DATA.Entities.Blog;
using GS.REPO;
using GS.SERVICE.Interface.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Implementation.Blog
{
    public class BlogPostService : IBlogPostService
    {
        private readonly IRepository<BlogPost> BlogPostrepository;
        public BlogPostService(IRepository<BlogPost> _BlogPostrepository)
        {
            this.BlogPostrepository = _BlogPostrepository;
        }


        public IEnumerable<BlogPost> AllAsIEnumerable()
        {
            return BlogPostrepository.GetAllIEnumerable();
        }

        public IQueryable<BlogPost> AllAsIQueryable()
        {
            return BlogPostrepository.GetAllIQueryable();
        }

        public List<BlogPost> AllAsList()
        {
            return BlogPostrepository.GetAll();
        }

        public void DeleteById(int id)
        {
            var entity = BlogPostrepository.Get(id);
            BlogPostrepository.Delete(entity);
        }

        public void DeleteEntity(BlogPost Color)
        {
            BlogPostrepository.Delete(Color);
        }

        public BlogPost GetById(int id)
        {
            return BlogPostrepository.Get(id);
        }

        public void InsertEntity(BlogPost Color)
        {
            BlogPostrepository.Insert(Color);
        }

        public void UpdateEntity(BlogPost Color)
        {
            BlogPostrepository.Update(Color);
        }
    }
}