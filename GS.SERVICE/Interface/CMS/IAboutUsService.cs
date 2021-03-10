using GS.DATA.Entities.CMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Interface.CMS
{
    public interface IAboutUsService
    {
        IEnumerable<AboutUs> AllAsIEnumerable();
        IQueryable<AboutUs> AllAsIQueryable();
        List<AboutUs> AllAsList();
        AboutUs GetById(int id);
        void InsertEntity(AboutUs AboutUs);
        void UpdateEntity(AboutUs AboutUs);
        void DeleteEntity(AboutUs AboutUs);
        void DeleteById(int id);
    }
}
