using GS.DATA.Entities.CMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Interface.CMS
{
    public interface IContactReasonService
    {
        IEnumerable<ContactReason> AllAsIEnumerable();
        IQueryable<ContactReason> AllAsIQueryable();
        List<ContactReason> AllAsList();
        ContactReason GetById(int id);
        void InsertEntity(ContactReason ContactReason);
        void UpdateEntity(ContactReason ContactReason);
        void DeleteEntity(ContactReason ContactReason);
        void DeleteById(int id);
    }
}
