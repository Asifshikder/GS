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
    public class OperationStyleService : IOperationStyleService
    {
        private readonly IRepository<OperationStyle> OperationStylerepository;
        public OperationStyleService(IRepository<OperationStyle> _OperationStylerepository)
        {
            this.OperationStylerepository = _OperationStylerepository;
        }


        public IEnumerable<OperationStyle> AllAsIEnumerable()
        {
            return OperationStylerepository.GetAllIEnumerable();
        }

        public IQueryable<OperationStyle> AllAsIQueryable()
        {
            return OperationStylerepository.GetAllIQueryable();
        }

        public List<OperationStyle> AllAsList()
        {
            return OperationStylerepository.GetAll();
        }

        public void DeleteById(int id)
        {
            var entity = OperationStylerepository.Get(id);
            OperationStylerepository.Delete(entity);
        }

        public void DeleteEntity(OperationStyle OperationStyle)
        {
            OperationStylerepository.Delete(OperationStyle);
        }

        public OperationStyle GetById(int id)
        {
            return OperationStylerepository.Get(id);
        }

        public void InsertEntity(OperationStyle OperationStyle)
        {
            OperationStylerepository.Insert(OperationStyle);
        }

        public void UpdateEntity(OperationStyle OperationStyle)
        {
            OperationStylerepository.Update(OperationStyle);
        }
    }
}

