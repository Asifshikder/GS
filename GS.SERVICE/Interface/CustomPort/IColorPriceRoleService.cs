using GS.DATA.Entities;
using GS.DATA.Entities.CustomPort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Interface.CustomPort
{
    public interface IColorPriceRoleService
    {
        IEnumerable<ColorPriceRole> AllAsIEnumerable();
        IQueryable<ColorPriceRole> AllAsIQueryable();
        List<ColorPriceRole> AllAsList();
        ColorPriceRole GetById(int id);
        void InsertEntity(ColorPriceRole Color);
        void UpdateEntity(ColorPriceRole Color);
        void DeleteEntity(ColorPriceRole Color);
        void DeleteById(int id);
    }
}
