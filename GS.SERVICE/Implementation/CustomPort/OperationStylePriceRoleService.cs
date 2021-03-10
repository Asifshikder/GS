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
    public class OperationStylePriceRoleService : IOperationStylePriceRoleService
    {
        private readonly IRepository<OperationStylePriceRole> OperationStylePriceRolerepository;
        public OperationStylePriceRoleService(IRepository<OperationStylePriceRole> OperationStylePriceRolerepository)
        {
            this.OperationStylePriceRolerepository = OperationStylePriceRolerepository;
        }

        public IEnumerable<OperationStylePriceRole> AllAsIEnumerable()
        {
            return OperationStylePriceRolerepository.GetAllIEnumerable();
        }

        public IQueryable<OperationStylePriceRole> AllAsIQueryable()
        {
            return OperationStylePriceRolerepository.GetAllIQueryable();
        }

        public List<OperationStylePriceRole> AllAsList()
        {
            return OperationStylePriceRolerepository.GetAll();
        }

        public bool CheckIfShow(int? operationrole)
        {
            var details = OperationStylePriceRolerepository.Get(operationrole.Value);
            if (details.PriceIncrease == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void DeleteById(int id)
        {
            var entity = OperationStylePriceRolerepository.Get(id);
            OperationStylePriceRolerepository.Delete(entity);
        }

        public void DeleteEntity(OperationStylePriceRole OperationStyle)
        {
            OperationStylePriceRolerepository.Delete(OperationStyle);
        }

        public OperationStylePriceRole GetById(int id)
        {
            return OperationStylePriceRolerepository.Get(id);
        }

        public void InsertEntity(OperationStylePriceRole OperationStyle)
        {
            OperationStylePriceRolerepository.Insert(OperationStyle);
        }

        public void UpdateEntity(OperationStylePriceRole OperationStyle)
        {
            OperationStylePriceRolerepository.Update(OperationStyle);
        }
    }
}

