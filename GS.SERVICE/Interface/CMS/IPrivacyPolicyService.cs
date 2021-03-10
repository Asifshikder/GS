using GS.DATA.Entities.CMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Interface.CMS
{
    public interface IPrivacyPolicyService
    {
        IEnumerable<PrivacyPolicy> AllAsIEnumerable();
        IQueryable<PrivacyPolicy> AllAsIQueryable();
        List<PrivacyPolicy> AllAsList();
        PrivacyPolicy GetById(int id);
        void InsertEntity(PrivacyPolicy PrivacyPolicy);
        void UpdateEntity(PrivacyPolicy PrivacyPolicy);
        void DeleteEntity(PrivacyPolicy PrivacyPolicy);
        void DeleteById(int id);
    }
}
