using GS.DATA.Entities;
using GS.DATA.Entities.Catelog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Interface.Catelog
{
    public interface IProductService
    {
        IEnumerable<Product> AllAsIEnumerable();
        IQueryable<Product> AllAsIQueryable();
        List<Product> AllAsList();
        Product GetById(int id);
        void InsertEntity(Product Product);
        void UpdateEntity(Product Product);
        void DeleteEntity(Product Product);
        void DeleteById(int id);
    }
}
