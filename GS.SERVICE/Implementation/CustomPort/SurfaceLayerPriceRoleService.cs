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
    public class SurfaceLayerPriceRoleService : ISurfaceLayerPriceRoleService
    {
        private readonly IRepository<SurfaceLayerPriceRole> SurfaceLayerPriceRolerepository;
        public SurfaceLayerPriceRoleService(IRepository<SurfaceLayerPriceRole> SurfaceLayerPriceRolerepository)
        {
            this.SurfaceLayerPriceRolerepository = SurfaceLayerPriceRolerepository;
        }

        public IEnumerable<SurfaceLayerPriceRole> AllAsIEnumerable()
        {
            return SurfaceLayerPriceRolerepository.GetAllIEnumerable();
        }

        public IQueryable<SurfaceLayerPriceRole> AllAsIQueryable()
        {
            return SurfaceLayerPriceRolerepository.GetAllIQueryable();
        }

        public List<SurfaceLayerPriceRole> AllAsList()
        {
            return SurfaceLayerPriceRolerepository.GetAll();
        }

        public void DeleteById(int id)
        {
            var entity = SurfaceLayerPriceRolerepository.Get(id);
            SurfaceLayerPriceRolerepository.Delete(entity);
        }


        public void DeleteEntity(SurfaceLayerPriceRole SurfaceLayer)
        {
            SurfaceLayerPriceRolerepository.Delete(SurfaceLayer);
        }

        public SurfaceLayerPriceRole GetById(int id)
        {
            return SurfaceLayerPriceRolerepository.Get(id);
        }

        public void InsertEntity(SurfaceLayerPriceRole SurfaceLayer)
        {
            SurfaceLayerPriceRolerepository.Insert(SurfaceLayer);
        }

        public void UpdateEntity(SurfaceLayerPriceRole SurfaceLayer)
        {
            SurfaceLayerPriceRolerepository.Update(SurfaceLayer);
        }
    }
}

