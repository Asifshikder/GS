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
    public class ModelService : IModelService
    {
        private readonly IRepository<Model> Modelrepository;
        public ModelService(IRepository<Model> _Modelrepository)
        {
            this.Modelrepository = _Modelrepository;
        }


        public IEnumerable<Model> AllAsIEnumerable()
        {
            return Modelrepository.GetAllIEnumerable();
        }

        public IQueryable<Model> AllAsIQueryable()
        {
            return Modelrepository.GetAllIQueryable();
        }

        public List<Model> AllAsList()
        {
            return Modelrepository.GetAll();
        }

        public void DeleteById(int id)
        {
            var entity = Modelrepository.Get(id);
            Modelrepository.Delete(entity);
        }

        public void DeleteEntity(Model Model)
        {
            Modelrepository.Delete(Model);
        }

        public Model GetById(int id)
        {
            return Modelrepository.Get(id);
        }

        public void InsertEntity(Model Model)
        {
            Modelrepository.Insert(Model);
        }

        public void UpdateEntity(Model Model)
        {
            Modelrepository.Update(Model);
        }
    }
}

