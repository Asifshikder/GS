using GS.DATA.Entities.CMS;
using GS.REPO;
using GS.SERVICE.Interface.CMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace GS.SERVICE.Implementation.CMS
{
    public class InstallationService : IInstallationService
    {
        private readonly IRepository<Installation> Installationrepository;
        public InstallationService(IRepository<Installation> _Installationrepository)
        {
            this.Installationrepository = _Installationrepository;
        }


        public IEnumerable<Installation> AllAsIEnumerable()
        {
            return Installationrepository.GetAllIEnumerable();
        }

        public IQueryable<Installation> AllAsIQueryable()
        {
            return Installationrepository.GetAllIQueryable();
        }

        public List<Installation> AllAsList()
        {
            return Installationrepository.GetAll();
        }

        public void DeleteById(int id)
        {
            var entity = Installationrepository.Get(id);
            Installationrepository.Delete(entity);
        }

        public void DeleteEntity(Installation Installation)
        {
            Installationrepository.Delete(Installation);
        }

        public Installation GetById(int id)
        {
            return Installationrepository.Get(id);
        }

        public void InsertEntity(Installation Installation)
        {
            Installationrepository.Insert(Installation);
        }

        public void UpdateEntity(Installation Installation)
        {
            Installationrepository.Update(Installation);
        }
    }
}
