using GS.DATA.Entities;
using GS.DATA.Entities.Catelog;
using GS.DATA.Entities.Delivery;
using GS.REPO;
using GS.SERVICE.Interface.Blog;
using GS.SERVICE.Interface.Catelog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Implementation.Catelog
{
    public class PostalCodeService : IPostalCodeService
    {
        private readonly IRepository<PostalCode> PostalCoderepository;
        public PostalCodeService(IRepository<PostalCode> _PostalCoderepository)
        {
            this.PostalCoderepository = _PostalCoderepository;
        }


        public IEnumerable<PostalCode> AllAsIEnumerable()
        {
            return PostalCoderepository.GetAllIEnumerable();
        }

        public IQueryable<PostalCode> AllAsIQueryable()
        {
            return PostalCoderepository.GetAllIQueryable();
        }

        public List<PostalCode> AllAsList()
        {
            return PostalCoderepository.GetAll();
        }

        public void DeleteById(int id)
        {
            var entity = PostalCoderepository.Get(id);
            PostalCoderepository.Delete(entity);
        }

        public void DeleteEntity(PostalCode PostalCode)
        {
            PostalCoderepository.Delete(PostalCode);
        }

        public PostalCode GetById(int id)
        {
            return PostalCoderepository.Get(id);
        }

        public void InsertEntity(PostalCode PostalCode)
        {
            PostalCoderepository.Insert(PostalCode);
        }

        public void UpdateEntity(PostalCode PostalCode)
        {
            PostalCoderepository.Update(PostalCode);
        }
    }
}

