using GS.DATA.Entities.CMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Interface.CMS
{
    public interface IMainPageService
    {
        IEnumerable<MainPage> AllAsIEnumerable();
        IQueryable<MainPage> AllAsIQueryable();
        List<MainPage> AllAsList();
        MainPage GetById(int id);
        void InsertEntity(MainPage MainPage);
        void UpdateEntity(MainPage MainPage);
        void DeleteEntity(MainPage MainPage);
        void DeleteById(int id);
    }
}
