using GS.DATA.Entities;
using GS.DATA.Entities.Catelog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Interface.Catelog
{
    public interface IOperationStyleService
    {
        IEnumerable<OperationStyle> AllAsIEnumerable();
        IQueryable<OperationStyle> AllAsIQueryable();
        List<OperationStyle> AllAsList();
        OperationStyle GetById(int id);
        void InsertEntity(OperationStyle OperationStyle);
        void UpdateEntity(OperationStyle OperationStyle);
        void DeleteEntity(OperationStyle OperationStyle);
        void DeleteById(int id);
    }
}
