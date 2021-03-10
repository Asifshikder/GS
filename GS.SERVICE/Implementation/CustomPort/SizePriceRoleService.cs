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
    public class SizePriceRoleService : ISizePriceRoleService
    {
        private readonly IRepository<SizePriceRole> SizePriceRolerepository;
        public SizePriceRoleService(IRepository<SizePriceRole> SizePriceRolerepository)
        {
            this.SizePriceRolerepository = SizePriceRolerepository;
        }

        public IEnumerable<SizePriceRole> AllAsIEnumerable()
        {
            return SizePriceRolerepository.GetAllIEnumerable();
        }

        public IQueryable<SizePriceRole> AllAsIQueryable()
        {
            return SizePriceRolerepository.GetAllIQueryable();
        }

        public List<SizePriceRole> AllAsList()
        {
            return SizePriceRolerepository.GetAll();
        }

        public void DeleteEntity(SizePriceRole Size)
        {
            SizePriceRolerepository.Delete(Size);
        }

        public void DeleteById(int id)
        {
            var entity = SizePriceRolerepository.Get(id);
            SizePriceRolerepository.Delete(entity);
        }

        public SizePriceRole GetById(int id)
        {
            return SizePriceRolerepository.Get(id);
        }

        public void InsertEntity(SizePriceRole Size)
        {
            SizePriceRolerepository.Insert(Size);
        }

        public void UpdateEntity(SizePriceRole Size)
        {
            SizePriceRolerepository.Update(Size);
        }
    }
}

