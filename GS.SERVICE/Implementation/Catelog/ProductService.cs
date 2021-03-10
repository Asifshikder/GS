using GS.DATA.Entities;
using GS.DATA.Entities.Catelog;
using GS.REPO;
using GS.SERVICE.Interface.Catelog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Implementation.Catelog
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> Productrepository;
        public ProductService(IRepository<Product> _Productrepository)
        {
            this.Productrepository = _Productrepository;
        }


        public IEnumerable<Product> AllAsIEnumerable()
        {
            return Productrepository.GetAllIEnumerable();
        }

        public IQueryable<Product> AllAsIQueryable()
        {
            return Productrepository.GetAllIQueryable();
        }

        public List<Product> AllAsList()
        {
            return Productrepository.GetAll();
        }

        public void DeleteById(int id)
        {
            var entity = Productrepository.Get(id);
            Productrepository.Delete(entity);
        }

        public void DeleteEntity(Product Product)
        {
            Productrepository.Delete(Product);
        }

        public Product GetById(int id)
        {
            return Productrepository.Get(id);
        }

        public void InsertEntity(Product Product)
        {
            Productrepository.Insert(Product);
        }

        public void UpdateEntity(Product Product)
        {
            Productrepository.Update(Product);
        }
    }
}

