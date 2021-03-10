using GS.DATA.Entities;
using GS.DATA.Entities.CustomPort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Interface.CustomPort
{
    public interface ISizePriceRoleService
    {
        IEnumerable<SizePriceRole> AllAsIEnumerable();
        IQueryable<SizePriceRole> AllAsIQueryable();
        List<SizePriceRole> AllAsList();
        SizePriceRole GetById(int id);
        void InsertEntity(SizePriceRole Size);
        void UpdateEntity(SizePriceRole Size);
        void DeleteById(int id);
        void DeleteEntity(SizePriceRole Size);
    }
}
