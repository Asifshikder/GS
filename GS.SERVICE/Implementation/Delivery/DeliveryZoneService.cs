using GS.DATA.Entities;
using GS.DATA.Entities.Catelog;
using GS.DATA.Entities.Delivery;
using GS.REPO;
using GS.SERVICE.Interface.Blog;
using GS.SERVICE.Interface.Catelog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Implementation.Catelog
{
    public class DeliveryZoneService : IDeliveryZoneService
    {
        private readonly IRepository<DeliveryZone> DeliveryZonerepository;
        public DeliveryZoneService(IRepository<DeliveryZone> _DeliveryZonerepository)
        {
            this.DeliveryZonerepository = _DeliveryZonerepository;
        }


        public IEnumerable<DeliveryZone> AllAsIEnumerable()
        {
            return DeliveryZonerepository.GetAllIEnumerable();
        }

        public IQueryable<DeliveryZone> AllAsIQueryable()
        {
            return DeliveryZonerepository.GetAllIQueryable();
        }

        public List<DeliveryZone> AllAsList()
        {
            return DeliveryZonerepository.GetAll();
        }

        public void DeleteById(int id)
        {
            var entity = DeliveryZonerepository.Get(id);
            DeliveryZonerepository.Delete(entity);
        }

        public void DeleteEntity(DeliveryZone DeliveryZone)
        {
            DeliveryZonerepository.Delete(DeliveryZone);
        }

        public DeliveryZone GetById(int id)
        {
            return DeliveryZonerepository.Get(id);
        }

        public void InsertEntity(DeliveryZone DeliveryZone)
        {
            DeliveryZonerepository.Insert(DeliveryZone);
        }

        public void UpdateEntity(DeliveryZone DeliveryZone)
        {
            DeliveryZonerepository.Update(DeliveryZone);
        }
    }
}

