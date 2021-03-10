using GS.DATA.Entities.CMS;
using GS.REPO;
using GS.SERVICE.Interface.CMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Implementation.CMS
{
    public class ContactService : IContactService
    {
        private readonly IRepository<Contact> Contactrepository;
        public ContactService(IRepository<Contact> _Contactrepository)
        {
            this.Contactrepository = _Contactrepository;
        }


        public IEnumerable<Contact> AllAsIEnumerable()
        {
            return Contactrepository.GetAllIEnumerable();
        }

        public IQueryable<Contact> AllAsIQueryable()
        {
            return Contactrepository.GetAllIQueryable();
        }

        public List<Contact> AllAsList()
        {
            return Contactrepository.GetAll();
        }

        public void DeleteById(int id)
        {
            var entity = Contactrepository.Get(id);
            Contactrepository.Delete(entity);
        }

        public void DeleteEntity(Contact Contact)
        {
            Contactrepository.Delete(Contact);
        }

        public Contact GetById(int id)
        {
            return Contactrepository.Get(id);
        }

        public void InsertEntity(Contact Contact)
        {
            Contactrepository.Insert(Contact);
        }

        public void UpdateEntity(Contact Contact)
        {
            Contactrepository.Update(Contact);
        }
    }
}
