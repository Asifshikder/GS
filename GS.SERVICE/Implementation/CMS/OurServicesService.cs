using GS.DATA.Entities.CMS;
using GS.REPO;
using GS.SERVICE.Interface.CMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Implementation.CMS
{
    public class OurServicesService : IOurServicesService
    {
        private readonly IRepository<OurServices> OurServicesrepository;
        public OurServicesService(IRepository<OurServices> _OurServicesrepository)
        {
            this.OurServicesrepository = _OurServicesrepository;
        }


        public IEnumerable<OurServices> AllAsIEnumerable()
        {
            return OurServicesrepository.GetAllIEnumerable();
        }

        public IQueryable<OurServices> AllAsIQueryable()
        {
            return OurServicesrepository.GetAllIQueryable();
        }

        public List<OurServices> AllAsList()
        {
            return OurServicesrepository.GetAll();
        }

        public void DeleteById(int id)
        {
            var entity = OurServicesrepository.Get(id);
            OurServicesrepository.Delete(entity);
        }

        public void DeleteEntity(OurServices OurServices)
        {
            OurServicesrepository.Delete(OurServices);
        }

        public OurServices GetById(int id)
        {
            return OurServicesrepository.Get(id);
        }

        public void InsertEntity(OurServices OurServices)
        {
            OurServicesrepository.Insert(OurServices);
        }

        public void UpdateEntity(OurServices OurServices)
        {
            OurServicesrepository.Update(OurServices);
        }
    }
}
