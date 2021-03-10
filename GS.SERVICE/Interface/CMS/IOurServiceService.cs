using GS.DATA.Entities.CMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Interface.CMS
{
    public interface IOurServicesService
    {
        IEnumerable<OurServices> AllAsIEnumerable();
        IQueryable<OurServices> AllAsIQueryable();
        List<OurServices> AllAsList();
        OurServices GetById(int id);
        void InsertEntity(OurServices OurService);
        void UpdateEntity(OurServices OurService);
        void DeleteEntity(OurServices OurService);
        void DeleteById(int id);
    }
}
