using GS.DATA.Entities.Catelog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Interface.Catelog
{
   public interface IProductTypeService
    {
        IEnumerable<ProductType> AllAsIEnumerable();
        IQueryable<ProductType> AllAsIQueryable();
        List<ProductType> AllAsList();
        ProductType GetById(int id);
        void InsertEntity(ProductType accessoriesWindows);
        void UpdateEntity(ProductType accessoriesWindows);
        void DeleteEntity(ProductType accessoriesWindows);
        void DeleteById(int id);
    }
}
