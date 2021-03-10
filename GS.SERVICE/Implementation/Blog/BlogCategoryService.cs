using GS.DATA.Entities;
using GS.DATA.Entities.Blog;
using GS.DATA.Entities.Catelog;
using GS.REPO;
using GS.SERVICE.Interface.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Implementation.Blog
{
    public class BlogCategoryService : IBlogCategoryService
    {
        private readonly IRepository<BlogCategory> BlogCategoryrepository;
        public BlogCategoryService(IRepository<BlogCategory> _BlogCategoryrepository)
        {
            this.BlogCategoryrepository = _BlogCategoryrepository;
        }


        public IEnumerable<BlogCategory> AllAsIEnumerable()
        {
            return BlogCategoryrepository.GetAllIEnumerable();
        }

        public IQueryable<BlogCategory> AllAsIQueryable()
        {
            return BlogCategoryrepository.GetAllIQueryable();
        }

        public List<BlogCategory> AllAsList()
        {
            return BlogCategoryrepository.GetAll();
        }

        public void DeleteById(int id)
        {
            var entity = BlogCategoryrepository.Get(id);
            BlogCategoryrepository.Delete(entity);
        }

        public void DeleteEntity(BlogCategory Color)
        {
            BlogCategoryrepository.Delete(Color);
        }

        public BlogCategory GetById(int id)
        {
            return BlogCategoryrepository.Get(id);
        }

        public void InsertEntity(BlogCategory Color)
        {
            BlogCategoryrepository.Insert(Color);
        }

        public void UpdateEntity(BlogCategory Color)
        {
            BlogCategoryrepository.Update(Color);
        }
    }
}

