using GS.DATA.Entities.CMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Interface.CMS
{
    public interface IReturnPolicyService
    {
        IEnumerable<ReturnPolicy> AllAsIEnumerable();
        IQueryable<ReturnPolicy> AllAsIQueryable();
        List<ReturnPolicy> AllAsList();
        ReturnPolicy GetById(int id);
        void InsertEntity(ReturnPolicy ReturnPolicy);
        void UpdateEntity(ReturnPolicy ReturnPolicy);
        void DeleteEntity(ReturnPolicy ReturnPolicy);
        void DeleteById(int id);
    }
}
