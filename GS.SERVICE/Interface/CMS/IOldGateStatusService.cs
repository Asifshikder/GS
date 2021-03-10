using GS.DATA.Entities.CMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Interface.CMS
{
    public interface IOldGateStatusService
    {
        IEnumerable<OldGateStatus> AllAsIEnumerable();
        IQueryable<OldGateStatus> AllAsIQueryable();
        List<OldGateStatus> AllAsList();
        OldGateStatus GetById(int id);
        void InsertEntity(OldGateStatus OldGateStatus);
        void UpdateEntity(OldGateStatus OldGateStatus);
        void DeleteEntity(OldGateStatus OldGateStatus);
        void DeleteById(int id);
    }
}
