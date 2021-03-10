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
    public class DeliveryFeeService : IDeliveryFeeService
    {
        private readonly IRepository<DeliveryFee> DeliveryFeerepository;
        public DeliveryFeeService(IRepository<DeliveryFee> _DeliveryFeerepository)
        {
            this.DeliveryFeerepository = _DeliveryFeerepository;
        }


        public IEnumerable<DeliveryFee> AllAsIEnumerable()
        {
            return DeliveryFeerepository.GetAllIEnumerable();
        }

        public IQueryable<DeliveryFee> AllAsIQueryable()
        {
            return DeliveryFeerepository.GetAllIQueryable();
        }

        public List<DeliveryFee> AllAsList()
        {
            return DeliveryFeerepository.GetAll();
        }

        public void DeleteById(int id)
        {
            var entity = DeliveryFeerepository.Get(id);
            DeliveryFeerepository.Delete(entity);
        }

        public void DeleteEntity(DeliveryFee DeliveryFee)
        {
            DeliveryFeerepository.Delete(DeliveryFee);
        }

        public DeliveryFee GetById(int id)
        {
            return DeliveryFeerepository.Get(id);
        }

        public void InsertEntity(DeliveryFee DeliveryFee)
        {
            DeliveryFeerepository.Insert(DeliveryFee);
        }

        public void UpdateEntity(DeliveryFee DeliveryFee)
        {
            DeliveryFeerepository.Update(DeliveryFee);
        }
    }
}

