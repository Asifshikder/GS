using GS.DATA.Entities.CMS;
using GS.REPO;
using GS.SERVICE.Interface.CMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Implementation.CMS
{
    public class PrivacyPolicyService : IPrivacyPolicyService
    {
        private readonly IRepository<PrivacyPolicy> PrivacyPolicyrepository;
        public PrivacyPolicyService(IRepository<PrivacyPolicy> _PrivacyPolicyrepository)
        {
            this.PrivacyPolicyrepository = _PrivacyPolicyrepository;
        }


        public IEnumerable<PrivacyPolicy> AllAsIEnumerable()
        {
            return PrivacyPolicyrepository.GetAllIEnumerable();
        }

        public IQueryable<PrivacyPolicy> AllAsIQueryable()
        {
            return PrivacyPolicyrepository.GetAllIQueryable();
        }

        public List<PrivacyPolicy> AllAsList()
        {
            return PrivacyPolicyrepository.GetAll();
        }

        public void DeleteById(int id)
        {
            var entity = PrivacyPolicyrepository.Get(id);
            PrivacyPolicyrepository.Delete(entity);
        }

        public void DeleteEntity(PrivacyPolicy PrivacyPolicy)
        {
            PrivacyPolicyrepository.Delete(PrivacyPolicy);
        }

        public PrivacyPolicy GetById(int id)
        {
            return PrivacyPolicyrepository.Get(id);
        }

        public void InsertEntity(PrivacyPolicy PrivacyPolicy)
        {
            PrivacyPolicyrepository.Insert(PrivacyPolicy);
        }

        public void UpdateEntity(PrivacyPolicy PrivacyPolicy)
        {
            PrivacyPolicyrepository.Update(PrivacyPolicy);
        }
    }
}
