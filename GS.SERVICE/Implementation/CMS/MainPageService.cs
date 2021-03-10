using GS.DATA.Entities.CMS;
using GS.REPO;
using GS.SERVICE.Interface.CMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Implementation.CMS
{
    public class MainPageService : IMainPageService
    {
        private readonly IRepository<MainPage> MainPagerepository;
        public MainPageService(IRepository<MainPage> _MainPagerepository)
        {
            this.MainPagerepository = _MainPagerepository;
        }


        public IEnumerable<MainPage> AllAsIEnumerable()
        {
            return MainPagerepository.GetAllIEnumerable();
        }

        public IQueryable<MainPage> AllAsIQueryable()
        {
            return MainPagerepository.GetAllIQueryable();
        }

        public List<MainPage> AllAsList()
        {
            return MainPagerepository.GetAll();
        }

        public void DeleteById(int id)
        {
            var entity = MainPagerepository.Get(id);
            MainPagerepository.Delete(entity);
        }

        public void DeleteEntity(MainPage MainPage)
        {
            MainPagerepository.Delete(MainPage);
        }

        public MainPage GetById(int id)
        {
            return MainPagerepository.Get(id);
        }

        public void InsertEntity(MainPage MainPage)
        {
            MainPagerepository.Insert(MainPage);
        }

        public void UpdateEntity(MainPage MainPage)
        {
            MainPagerepository.Update(MainPage);
        }
    }
}
