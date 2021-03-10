using GS.DATA.Entities;
using GS.DATA.Entities.CustomPort;
using GS.REPO;
using GS.SERVICE.Interface.CustomPort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Implementation.CustomPort
{
    public class ColorPriceRoleService : IColorPriceRoleService
    {
        private readonly IRepository<ColorPriceRole> colorPriceRolerepository;
        public ColorPriceRoleService(IRepository<ColorPriceRole> _colorPriceRolerepository)
        {
            this.colorPriceRolerepository = _colorPriceRolerepository;
        }


        public IEnumerable<ColorPriceRole> AllAsIEnumerable()
        {
            return colorPriceRolerepository.GetAllIEnumerable();
        }

        public IQueryable<ColorPriceRole> AllAsIQueryable()
        {
            return colorPriceRolerepository.GetAllIQueryable();
        }

        public List<ColorPriceRole> AllAsList()
        {
            return colorPriceRolerepository.GetAll();
        }

        public void DeleteById(int id)
        {
            var entity = colorPriceRolerepository.Get(id);
            colorPriceRolerepository.Delete(entity);
        }

        public void DeleteEntity(ColorPriceRole Color)
        {
            colorPriceRolerepository.Delete(Color);
        }

        public ColorPriceRole GetById(int id)
        {
            return colorPriceRolerepository.Get(id);
        }

        public void InsertEntity(ColorPriceRole Color)
        {
            colorPriceRolerepository.Insert(Color);
        }

        public void UpdateEntity(ColorPriceRole Color)
        {
            colorPriceRolerepository.Update(Color);
        }
    }
}

