using GS.DATA.Entities;
using GS.DATA.Entities.CustomPort;
using GS.REPO;
using GS.SERVICE.Interface.CustomPort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Implementation.CustomPort
{
    public class EmergencyLockPriceRoleService : IEmergencyLockPriceRoleService
    {
        private readonly IRepository<EmergencyLockPriceRole> EmergencyLockPriceRolerepository;
        public EmergencyLockPriceRoleService(IRepository<EmergencyLockPriceRole> EmergencyLockPriceRolerepository)
        {
            this.EmergencyLockPriceRolerepository = EmergencyLockPriceRolerepository;
        }

        public IEnumerable<EmergencyLockPriceRole> AllAsIEnumerable()
        {
            return EmergencyLockPriceRolerepository.GetAllIEnumerable();
        }

        public IQueryable<EmergencyLockPriceRole> AllAsIQueryable()
        {
            return EmergencyLockPriceRolerepository.GetAllIQueryable();
        }

        public List<EmergencyLockPriceRole> AllAsList()
        {
            return EmergencyLockPriceRolerepository.GetAll();
        }

        public void DeleteById(int id)
        {
            var entity = EmergencyLockPriceRolerepository.Get(id);
            EmergencyLockPriceRolerepository.Delete(entity);
        }

        public void DeleteEntity(EmergencyLockPriceRole EmergencyLock)
        {
            EmergencyLockPriceRolerepository.Delete(EmergencyLock);
        }

        public EmergencyLockPriceRole GetById(int id)
        {
            return EmergencyLockPriceRolerepository.Get(id);
        }

        public void InsertEntity(EmergencyLockPriceRole EmergencyLock)
        {
            EmergencyLockPriceRolerepository.Insert(EmergencyLock);
        }

        public void UpdateEntity(EmergencyLockPriceRole EmergencyLock)
        {
            EmergencyLockPriceRolerepository.Update(EmergencyLock);
        }
    }
}

