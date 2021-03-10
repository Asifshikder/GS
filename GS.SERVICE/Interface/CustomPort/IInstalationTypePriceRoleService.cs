using GS.DATA.Entities;
using GS.DATA.Entities.CustomPort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Interface.CustomPort
{
    public interface IInstalationTypePriceRoleService
    {
        IEnumerable<InstalationTypePriceRole> AllAsIEnumerable();
        IQueryable<InstalationTypePriceRole> AllAsIQueryable();
        List<InstalationTypePriceRole> AllAsList();
        InstalationTypePriceRole GetById(int id);
        void InsertEntity(InstalationTypePriceRole InstalationType);
        void UpdateEntity(InstalationTypePriceRole InstalationType);
        void DeleteEntity(InstalationTypePriceRole InstalationType);
        void DeleteById(int id);
    }
}
