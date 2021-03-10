using GS.DATA.Entities;
using GS.DATA.Entities.CustomPort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Interface.CustomPort
{
    public interface IEmergencyLockPriceRoleService
    {
        IEnumerable<EmergencyLockPriceRole> AllAsIEnumerable();
        IQueryable<EmergencyLockPriceRole> AllAsIQueryable();
        List<EmergencyLockPriceRole> AllAsList();
        EmergencyLockPriceRole GetById(int id);
        void InsertEntity(EmergencyLockPriceRole EmergencyLock);
        void UpdateEntity(EmergencyLockPriceRole EmergencyLock);
        void DeleteEntity(EmergencyLockPriceRole EmergencyLock);
        void DeleteById(int id);
    }
}
