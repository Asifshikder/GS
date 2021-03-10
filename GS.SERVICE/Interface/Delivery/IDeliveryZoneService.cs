using GS.DATA.Entities;
using GS.DATA.Entities.Delivery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Interface.Blog
{
    public interface IDeliveryZoneService
    {
        IEnumerable<DeliveryZone> AllAsIEnumerable();
        IQueryable<DeliveryZone> AllAsIQueryable();
        List<DeliveryZone> AllAsList();
        DeliveryZone GetById(int id);
        void InsertEntity(DeliveryZone DeliveryZone);
        void UpdateEntity(DeliveryZone DeliveryZone);
        void DeleteEntity(DeliveryZone DeliveryZone);
        void DeleteById(int id);
    }
}
