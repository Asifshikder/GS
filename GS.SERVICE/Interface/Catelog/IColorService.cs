using GS.DATA.Entities;
using GS.DATA.Entities.Catelog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Interface.Catelog
{
    public interface IColorService
    {
        IEnumerable<Color> AllAsIEnumerable();
        IQueryable<Color> AllAsIQueryable();
        List<Color> AllAsList();
        Color GetById(int id);
        void InsertEntity(Color Color);
        void UpdateEntity(Color Color);
        void DeleteEntity(Color Color);
        void DeleteById(int id);
    }
}
