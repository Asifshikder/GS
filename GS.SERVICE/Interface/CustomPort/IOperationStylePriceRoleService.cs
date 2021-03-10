using GS.DATA.Entities;
using GS.DATA.Entities.CustomPort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Interface.CustomPort
{
    public interface IOperationStylePriceRoleService
    {
        IEnumerable<OperationStylePriceRole> AllAsIEnumerable();
        IQueryable<OperationStylePriceRole> AllAsIQueryable();
        List<OperationStylePriceRole> AllAsList();
        OperationStylePriceRole GetById(int id);
        void InsertEntity(OperationStylePriceRole OperationStyle);
        void UpdateEntity(OperationStylePriceRole OperationStyle);
        void DeleteById(int id);
        void DeleteEntity(OperationStylePriceRole OperationStyle);
        bool CheckIfShow(int? operationrole);
    }
}
