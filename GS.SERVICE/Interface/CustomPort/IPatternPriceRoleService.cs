using GS.DATA.Entities;
using GS.DATA.Entities.CustomPort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Interface.CustomPort
{
    public interface IPatternPriceRoleService
    {
        IEnumerable<PatternPriceRole> AllAsIEnumerable();
        IQueryable<PatternPriceRole> AllAsIQueryable();
        List<PatternPriceRole> AllAsList();
        PatternPriceRole GetById(int id);
        void InsertEntity(PatternPriceRole Pattern);
        void UpdateEntity(PatternPriceRole Pattern);
        void DeleteEntity(PatternPriceRole Pattern);
        void DeleteById(int id);
        PatternPriceRole GetSmallPattern();
    }
}
