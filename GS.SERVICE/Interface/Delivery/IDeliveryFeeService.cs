using GS.DATA.Entities;
using GS.DATA.Entities.Delivery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Interface.Blog
{
    public interface IDeliveryFeeService
    {
        IEnumerable<DeliveryFee> AllAsIEnumerable();
        IQueryable<DeliveryFee> AllAsIQueryable();
        List<DeliveryFee> AllAsList();
        DeliveryFee GetById(int id);
        void InsertEntity(DeliveryFee DeliveryFee);
        void UpdateEntity(DeliveryFee DeliveryFee);
        void DeleteEntity(DeliveryFee DeliveryFee);
        void DeleteById(int id);
    }
}
