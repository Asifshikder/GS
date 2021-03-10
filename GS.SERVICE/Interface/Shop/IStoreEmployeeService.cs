using GS.DATA.Entities.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Interface.Shop
{
    public interface IStoreEmployeeService
    {
        IEnumerable<StoreEmployee> AllAsIEnumerable();
        IQueryable<StoreEmployee> AllAsIQueryable();
        List<StoreEmployee> AllAsList();
        StoreEmployee GetById(int id);
        void InsertEntity(StoreEmployee Size);
        void UpdateEntity(StoreEmployee Size);
        void DeleteById(int id);
        void DeleteEntity(StoreEmployee Size);
    }
}
