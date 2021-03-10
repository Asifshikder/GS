using GS.DATA.Entities.CMS;
using GS.REPO;
using GS.SERVICE.Interface.CMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Implementation.CMS
{
    public class AboutUsService : IAboutUsService
    {
        private readonly IRepository<AboutUs> AboutUsrepository;
        public AboutUsService(IRepository<AboutUs> _AboutUsrepository)
        {
            this.AboutUsrepository = _AboutUsrepository;
        }


        public IEnumerable<AboutUs> AllAsIEnumerable()
        {
            return AboutUsrepository.GetAllIEnumerable();
        }

        public IQueryable<AboutUs> AllAsIQueryable()
        {
            return AboutUsrepository.GetAllIQueryable();
        }

        public List<AboutUs> AllAsList()
        {
            return AboutUsrepository.GetAll();
        }

        public void DeleteById(int id)
        {
            var entity = AboutUsrepository.Get(id);
            AboutUsrepository.Delete(entity);
        }

        public void DeleteEntity(AboutUs AboutUs)
        {
            AboutUsrepository.Delete(AboutUs);
        }

        public AboutUs GetById(int id)
        {
            return AboutUsrepository.Get(id);
        }

        public void InsertEntity(AboutUs AboutUs)
        {
            AboutUsrepository.Insert(AboutUs);
        }

        public void UpdateEntity(AboutUs AboutUs)
        {
            AboutUsrepository.Update(AboutUs);
        }
    }
}
