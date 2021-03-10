using GS.DATA.Entities;
using GS.DATA.Entities.Catelog;
using GS.REPO;
using GS.SERVICE.Interface.Catelog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Implementation.Catelog
{
    public class SurfaceTypeService : ISurfaceTypeService
    {
        private readonly IRepository<SurfaceType> SurfaceTyperepository;
        public SurfaceTypeService(IRepository<SurfaceType> _SurfaceTyperepository)
        {
            this.SurfaceTyperepository = _SurfaceTyperepository;
        }


        public IEnumerable<SurfaceType> AllAsIEnumerable()
        {
            return SurfaceTyperepository.GetAllIEnumerable();
        }

        public IQueryable<SurfaceType> AllAsIQueryable()
        {
            return SurfaceTyperepository.GetAllIQueryable();
        }

        public List<SurfaceType> AllAsList()
        {
            return SurfaceTyperepository.GetAll();
        }

        public void DeleteById(int id)
        {
            var entity = SurfaceTyperepository.Get(id);
            SurfaceTyperepository.Delete(entity);
        }

        public void DeleteEntity(SurfaceType SurfaceType)
        {
            SurfaceTyperepository.Delete(SurfaceType);
        }

        public SurfaceType GetById(int id)
        {
            return SurfaceTyperepository.Get(id);
        }

        public void InsertEntity(SurfaceType SurfaceType)
        {
            SurfaceTyperepository.Insert(SurfaceType);
        }

        public void UpdateEntity(SurfaceType SurfaceType)
        {
            SurfaceTyperepository.Update(SurfaceType);
        }
    }
}

