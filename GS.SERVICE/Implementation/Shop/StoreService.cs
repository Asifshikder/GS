using GS.DATA.Entities.Shop;
using GS.REPO;
using GS.SERVICE.Interface.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Implementation.Shop
{
    public class StoreService : IStoreService
    {
        private readonly IRepository<Store> Storerepository;
        public StoreService(IRepository<Store> _Storerepository)
        {
            this.Storerepository = _Storerepository;
        }


        public IEnumerable<Store> AllAsIEnumerable()
        {
            return Storerepository.GetAllIEnumerable();
        }

        public IQueryable<Store> AllAsIQueryable()
        {
            return Storerepository.GetAllIQueryable();
        }

        public List<Store> AllAsList()
        {
            return Storerepository.GetAll();
        }

        public void DeleteById(int id)
        {
            var entity = Storerepository.Get(id);
            Storerepository.Delete(entity);
        }

        public void DeleteEntity(Store Store)
        {
            Storerepository.Delete(Store);
        }

        public Store GetById(int id)
        {
            return Storerepository.Get(id);
        }

        public void InsertEntity(Store Store)
        {
            Storerepository.Insert(Store);
        }

        public void UpdateEntity(Store Store)
        {
            Storerepository.Update(Store);
        }
    }
}
