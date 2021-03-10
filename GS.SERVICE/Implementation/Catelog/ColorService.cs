using GS.DATA.Entities;
using GS.DATA.Entities.Catelog;
using GS.REPO;
using GS.SERVICE.Interface.Catelog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Implementation.Catelog
{
    public class ColorService : IColorService
    {
        private readonly IRepository<Color> Colorrepository;
        public ColorService(IRepository<Color> _Colorrepository)
        {
            this.Colorrepository = _Colorrepository;
        }


        public IEnumerable<Color> AllAsIEnumerable()
        {
            return Colorrepository.GetAllIEnumerable();
        }

        public IQueryable<Color> AllAsIQueryable()
        {
            return Colorrepository.GetAllIQueryable();
        }

        public List<Color> AllAsList()
        {
            return Colorrepository.GetAll();
        }

        public void DeleteById(int id)
        {
            var entity = Colorrepository.Get(id);
            Colorrepository.Delete(entity);
        }

        public void DeleteEntity(Color Color)
        {
            Colorrepository.Delete(Color);
        }

        public Color GetById(int id)
        {
            return Colorrepository.Get(id);
        }

        public void InsertEntity(Color Color)
        {
            Colorrepository.Insert(Color);
        }

        public void UpdateEntity(Color Color)
        {
            Colorrepository.Update(Color);
        }
    }
}

