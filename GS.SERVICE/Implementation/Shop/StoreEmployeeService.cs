using GS.DATA.Entities.Shop;
using GS.REPO;
using GS.SERVICE.Interface.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Implementation.Shop
{
    public class StoreEmployeeService : IStoreEmployeeService
    {
        private readonly IRepository<StoreEmployee> StoreEmployeerepository;
        public StoreEmployeeService(IRepository<StoreEmployee> _StoreEmployeerepository)
        {
            this.StoreEmployeerepository = _StoreEmployeerepository;
        }

        public IEnumerable<StoreEmployee> AllAsIEnumerable()
        {
            return StoreEmployeerepository.GetAllIEnumerable();
        }

        public IQueryable<StoreEmployee> AllAsIQueryable()
        {
            return StoreEmployeerepository.GetAllIQueryable();
        }

        public List<StoreEmployee> AllAsList()
        {
            return StoreEmployeerepository.GetAll();
        }

        public void DeleteById(int id)
        {
            var entity = StoreEmployeerepository.Get(id);
            StoreEmployeerepository.Delete(entity);
        }

        public void DeleteEntity(StoreEmployee StoreEmployee)
        {
            StoreEmployeerepository.Delete(StoreEmployee);
        }

        public StoreEmployee GetById(int id)
        {
            return StoreEmployeerepository.Get(id);
        }

        public void InsertEntity(StoreEmployee StoreEmployee)
        {
            StoreEmployeerepository.Insert(StoreEmployee);
        }

        public void UpdateEntity(StoreEmployee StoreEmployee)
        {
            StoreEmployeerepository.Update(StoreEmployee);
        }
    }
}
