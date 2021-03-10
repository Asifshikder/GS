using GS.DATA.Entities;
using GS.DATA.Entities.Catelog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Interface.Catelog
{
    public interface IModelService
    {
        IEnumerable<Model> AllAsIEnumerable();
        IQueryable<Model> AllAsIQueryable();
        List<Model> AllAsList();
        Model GetById(int id);
        void InsertEntity(Model Model);
        void UpdateEntity(Model Model);
        void DeleteEntity(Model Model);
        void DeleteById(int id);
    }
}
