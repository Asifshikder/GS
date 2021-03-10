using GS.DATA.Entities.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Interface.Shop
{
    public interface IStoreService
    {
        IEnumerable<Store> AllAsIEnumerable();
        IQueryable<Store> AllAsIQueryable();
        List<Store> AllAsList();
        Store GetById(int id);
        void InsertEntity(Store Size);
        void UpdateEntity(Store Size);
        void DeleteById(int id);
        void DeleteEntity(Store Size);
    }
}
