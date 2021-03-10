using GS.DATA.Entities;
using GS.DATA.Entities.CustomPort;
using GS.REPO;
using GS.SERVICE.Interface.CustomPort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Implementation.CustomPort
{
    public class InstalationTypePriceRoleService : IInstalationTypePriceRoleService
    {
        private readonly IRepository<InstalationTypePriceRole> InstalationTypePriceRolerepository;
        public InstalationTypePriceRoleService(IRepository<InstalationTypePriceRole> InstalationTypePriceRolerepository)
        {
            this.InstalationTypePriceRolerepository = InstalationTypePriceRolerepository;
        }

        public IEnumerable<InstalationTypePriceRole> AllAsIEnumerable()
        {
            return InstalationTypePriceRolerepository.GetAllIEnumerable();
        }

        public IQueryable<InstalationTypePriceRole> AllAsIQueryable()
        {
            return InstalationTypePriceRolerepository.GetAllIQueryable();
        }

        public List<InstalationTypePriceRole> AllAsList()
        {
            return InstalationTypePriceRolerepository.GetAll();
        }

        public void DeleteById(int id)
        {
            var entity = InstalationTypePriceRolerepository.Get(id);
            InstalationTypePriceRolerepository.Delete(entity);
        }


        public void DeleteEntity(InstalationTypePriceRole InstalationType)
        {
            InstalationTypePriceRolerepository.Delete(InstalationType);
        }

        public InstalationTypePriceRole GetById(int id)
        {
            return InstalationTypePriceRolerepository.Get(id);
        }

        public void InsertEntity(InstalationTypePriceRole InstalationType)
        {
            InstalationTypePriceRolerepository.Insert(InstalationType);
        }

        public void UpdateEntity(InstalationTypePriceRole InstalationType)
        {
            InstalationTypePriceRolerepository.Update(InstalationType);
        }
    }
}

