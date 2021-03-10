using GS.DATA.Entities.Catelog;
using GS.REPO;
using GS.SERVICE.Interface.Catelog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Implementation.Catelog
{
    public class ProductTypeService : IProductTypeService
    {
        private readonly IRepository<ProductType> repository;
        public ProductTypeService(IRepository<ProductType> repository)
        {
            this.repository = repository;
        }

        public IEnumerable<ProductType> AllAsIEnumerable()
        {
            return repository.GetAllIEnumerable();
        }

        public IQueryable<ProductType> AllAsIQueryable()
        {
            return repository.GetAllIQueryable();
        }

        public List<ProductType> AllAsList()
        {
            return repository.GetAll();
        }

        public void DeleteById(int id)
        {
            var prt = repository.Get(id);
            repository.Delete(prt);

        }

        public void DeleteEntity(ProductType accessoriesWindows)
        {
            repository.Delete(accessoriesWindows);
        }

        public ProductType GetById(int id)
        {
            return repository.Get(id);
        }

        public void InsertEntity(ProductType accessoriesWindows)
        {
            repository.Insert(accessoriesWindows);
        }

        public void UpdateEntity(ProductType accessoriesWindows)
        {
            repository.Update(accessoriesWindows);
        }
    }
}
