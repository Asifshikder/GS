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
    public class ProductInstallService : IProductInstallService
    {
        private readonly IRepository<ProductInstall> ProductInstallrepository;
        public ProductInstallService(IRepository<ProductInstall> _ProductInstallrepository)
        {
            this.ProductInstallrepository = _ProductInstallrepository;
        }


        public IEnumerable<ProductInstall> AllAsIEnumerable()
        {
            return ProductInstallrepository.GetAllIEnumerable();
        }

        public IQueryable<ProductInstall> AllAsIQueryable()
        {
            return ProductInstallrepository.GetAllIQueryable();
        }

        public List<ProductInstall> AllAsList()
        {
            return ProductInstallrepository.GetAll();
        }

        public void DeleteById(int id)
        {
            var entity = ProductInstallrepository.Get(id);
            ProductInstallrepository.Delete(entity);
        }

        public void DeleteEntity(ProductInstall ProductInstall)
        {
            ProductInstallrepository.Delete(ProductInstall);
        }

        public ProductInstall GetById(int id)
        {
            return ProductInstallrepository.Get(id);
        }

        public void InsertEntity(ProductInstall ProductInstall)
        {
            ProductInstallrepository.Insert(ProductInstall);
        }

        public void UpdateEntity(ProductInstall ProductInstall)
        {
            ProductInstallrepository.Update(ProductInstall);
        }
    }
}

