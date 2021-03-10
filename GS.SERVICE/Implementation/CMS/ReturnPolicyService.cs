using GS.DATA.Entities.CMS;
using GS.REPO;
using GS.SERVICE.Interface.CMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Implementation.CMS
{
    public class ReturnPolicyService : IReturnPolicyService
    {
        private readonly IRepository<ReturnPolicy> ReturnPolicyrepository;
        public ReturnPolicyService(IRepository<ReturnPolicy> _ReturnPolicyrepository)
        {
            this.ReturnPolicyrepository = _ReturnPolicyrepository;
        }


        public IEnumerable<ReturnPolicy> AllAsIEnumerable()
        {
            return ReturnPolicyrepository.GetAllIEnumerable();
        }

        public IQueryable<ReturnPolicy> AllAsIQueryable()
        {
            return ReturnPolicyrepository.GetAllIQueryable();
        }

        public List<ReturnPolicy> AllAsList()
        {
            return ReturnPolicyrepository.GetAll();
        }

        public void DeleteById(int id)
        {
            var entity = ReturnPolicyrepository.Get(id);
            ReturnPolicyrepository.Delete(entity);
        }

        public void DeleteEntity(ReturnPolicy ReturnPolicy)
        {
            ReturnPolicyrepository.Delete(ReturnPolicy);
        }

        public ReturnPolicy GetById(int id)
        {
            return ReturnPolicyrepository.Get(id);
        }

        public void InsertEntity(ReturnPolicy ReturnPolicy)
        {
            ReturnPolicyrepository.Insert(ReturnPolicy);
        }

        public void UpdateEntity(ReturnPolicy ReturnPolicy)
        {
            ReturnPolicyrepository.Update(ReturnPolicy);
        }
    }
}
