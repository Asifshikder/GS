using GS.DATA.Entities;
using GS.DATA.Entities.Catelog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Interface.Catelog
{
    public interface ISurfaceTypeService
    {
        IEnumerable<SurfaceType> AllAsIEnumerable();
        IQueryable<SurfaceType> AllAsIQueryable();
        List<SurfaceType> AllAsList();
        SurfaceType GetById(int id);
        void InsertEntity(SurfaceType SurfaceType);
        void UpdateEntity(SurfaceType SurfaceType);
        void DeleteEntity(SurfaceType SurfaceType);
        void DeleteById(int id);
    }
}
