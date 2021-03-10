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
    public class BaseGaragePortService : IBaseGaragePortService
    {
        private readonly IRepository<BaseGaragePort> BaseGaragePortrepository;
        public BaseGaragePortService(IRepository<BaseGaragePort> BaseGaragePortrepository)
        {
            this.BaseGaragePortrepository = BaseGaragePortrepository;
        }

        public IEnumerable<BaseGaragePort> AllAsIEnumerable()
        {
            return BaseGaragePortrepository.GetAllIEnumerable();
        }

        public IQueryable<BaseGaragePort> AllAsIQueryable()
        {
            return BaseGaragePortrepository.GetAllIQueryable();
        }

        public List<BaseGaragePort> AllAsList()
        {
            return BaseGaragePortrepository.GetAll();
        }

        public void DeleteById(int id)
        {
            var entity = BaseGaragePortrepository.Get(id);
            BaseGaragePortrepository.Delete(entity);
        }

        public void DeleteEntity(BaseGaragePort Color)
        {
            BaseGaragePortrepository.Delete(Color);
        }

        public BaseGaragePort GetById(int id)
        {
            return BaseGaragePortrepository.Get(id);
        }

        public void InsertEntity(BaseGaragePort Color)
        {
            BaseGaragePortrepository.Insert(Color);
        }

        public void UpdateEntity(BaseGaragePort Color)
        {
            BaseGaragePortrepository.Update(Color);
        }
    }
}

