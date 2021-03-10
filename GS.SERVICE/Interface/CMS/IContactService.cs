using GS.DATA.Entities.CMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Interface.CMS
{
    public interface IContactService
    {
        IEnumerable<Contact> AllAsIEnumerable();
        IQueryable<Contact> AllAsIQueryable();
        List<Contact> AllAsList();
        Contact GetById(int id);
        void InsertEntity(Contact Contact);
        void UpdateEntity(Contact Contact);
        void DeleteEntity(Contact Contact);
        void DeleteById(int id);
    }
}
