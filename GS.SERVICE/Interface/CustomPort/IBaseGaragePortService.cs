using GS.DATA.Entities;
using GS.DATA.Entities.CustomPort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Interface.CustomPort
{
    public interface IBaseGaragePortService
    {
        IEnumerable<BaseGaragePort> AllAsIEnumerable();
        IQueryable<BaseGaragePort> AllAsIQueryable();
        List<BaseGaragePort> AllAsList();
        BaseGaragePort GetById(int id);
        void InsertEntity(BaseGaragePort Size);
        void UpdateEntity(BaseGaragePort Size);
        void DeleteById(int id);
        void DeleteEntity(BaseGaragePort Size);
    }
}
