using GS.DATA.Entities.CMS;
using GS.REPO;
using GS.SERVICE.Interface.CMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Implementation.CMS
{
    public class ContactReasonService : IContactReasonService
    {
        private readonly IRepository<ContactReason> ContactReasonrepository;
        public ContactReasonService(IRepository<ContactReason> _ContactReasonrepository)
        {
            this.ContactReasonrepository = _ContactReasonrepository;
        }


        public IEnumerable<ContactReason> AllAsIEnumerable()
        {
            return ContactReasonrepository.GetAllIEnumerable();
        }

        public IQueryable<ContactReason> AllAsIQueryable()
        {
            return ContactReasonrepository.GetAllIQueryable();
        }

        public List<ContactReason> AllAsList()
        {
            return ContactReasonrepository.GetAll();
        }

        public void DeleteById(int id)
        {
            var entity = ContactReasonrepository.Get(id);
            ContactReasonrepository.Delete(entity);
        }

        public void DeleteEntity(ContactReason ContactReason)
        {
            ContactReasonrepository.Delete(ContactReason);
        }

        public ContactReason GetById(int id)
        {
            return ContactReasonrepository.Get(id);
        }

        public void InsertEntity(ContactReason ContactReason)
        {
            ContactReasonrepository.Insert(ContactReason);
        }

        public void UpdateEntity(ContactReason ContactReason)
        {
            ContactReasonrepository.Update(ContactReason);
        }
    }
}
