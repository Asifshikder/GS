using GS.DATA.Entities;
using GS.DATA.Entities.CustomPort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Interface.CustomPort
{
    public interface ISurfaceLayerPriceRoleService
    {
        IEnumerable<SurfaceLayerPriceRole> AllAsIEnumerable();
        IQueryable<SurfaceLayerPriceRole> AllAsIQueryable();
        List<SurfaceLayerPriceRole> AllAsList();
        SurfaceLayerPriceRole GetById(int id);
        void InsertEntity(SurfaceLayerPriceRole SurfaceLayer);
        void UpdateEntity(SurfaceLayerPriceRole SurfaceLayer);
        void DeleteEntity(SurfaceLayerPriceRole SurfaceLayer);
        void DeleteById(int id);
    }
}
