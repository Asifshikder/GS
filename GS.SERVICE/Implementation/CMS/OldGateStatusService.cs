using GS.DATA.Entities.CMS;
using GS.REPO;
using GS.SERVICE.Interface.CMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Implementation.CMS
{
    public class OldGateStatusService : IOldGateStatusService
    {
        private readonly IRepository<OldGateStatus> OldGateStatusrepository;
        public OldGateStatusService(IRepository<OldGateStatus> _OldGateStatusrepository)
        {
            this.OldGateStatusrepository = _OldGateStatusrepository;
        }


        public IEnumerable<OldGateStatus> AllAsIEnumerable()
        {
            return OldGateStatusrepository.GetAllIEnumerable();
        }

        public IQueryable<OldGateStatus> AllAsIQueryable()
        {
            return OldGateStatusrepository.GetAllIQueryable();
        }

        public List<OldGateStatus> AllAsList()
        {
            return OldGateStatusrepository.GetAll();
        }

        public void DeleteById(int id)
        {
            var entity = OldGateStatusrepository.Get(id);
            OldGateStatusrepository.Delete(entity);
        }

        public void DeleteEntity(OldGateStatus OldGateStatus)
        {
            OldGateStatusrepository.Delete(OldGateStatus);
        }

        public OldGateStatus GetById(int id)
        {
            return OldGateStatusrepository.Get(id);
        }

        public void InsertEntity(OldGateStatus OldGateStatus)
        {
            OldGateStatusrepository.Insert(OldGateStatus);
        }

        public void UpdateEntity(OldGateStatus OldGateStatus)
        {
            OldGateStatusrepository.Update(OldGateStatus);
        }
    }
}
