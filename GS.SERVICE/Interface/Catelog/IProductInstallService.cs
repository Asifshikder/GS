using GS.DATA.Entities;
using GS.DATA.Entities.Catelog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Interface.Catelog
{
    public interface IProductInstallService
    {
        IEnumerable<ProductInstall> AllAsIEnumerable();
        IQueryable<ProductInstall> AllAsIQueryable();
        List<ProductInstall> AllAsList();
        ProductInstall GetById(int id);
        void InsertEntity(ProductInstall ProductInstall);
        void UpdateEntity(ProductInstall ProductInstall);
        void DeleteEntity(ProductInstall ProductInstall);
        void DeleteById(int id);
    }
}
