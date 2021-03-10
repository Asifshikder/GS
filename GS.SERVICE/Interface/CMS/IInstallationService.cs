using GS.DATA.Entities.CMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Interface.CMS
{
    public interface IInstallationService
    {
        IEnumerable<Installation> AllAsIEnumerable();
        IQueryable<Installation> AllAsIQueryable();
        List<Installation> AllAsList();
        Installation GetById(int id);
        void InsertEntity(Installation Installation);
        void UpdateEntity(Installation Installation);
        void DeleteEntity(Installation Installation);
        void DeleteById(int id);
    }
}
