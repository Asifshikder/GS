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
    public class PatternPriceRoleService : IPatternPriceRoleService
    {
        private readonly IRepository<PatternPriceRole> PatternPriceRolerepository;
        public PatternPriceRoleService(IRepository<PatternPriceRole> PatternPriceRolerepository)
        {
            this.PatternPriceRolerepository = PatternPriceRolerepository;
        }

        public IEnumerable<PatternPriceRole> AllAsIEnumerable()
        {
            return PatternPriceRolerepository.GetAllIEnumerable();
        }

        public IQueryable<PatternPriceRole> AllAsIQueryable()
        {
            return PatternPriceRolerepository.GetAllIQueryable();
        }

        public List<PatternPriceRole> AllAsList()
        {
            return PatternPriceRolerepository.GetAll();
        }

        public void DeleteById(int id)
        {
            var entity = PatternPriceRolerepository.Get(id);
            PatternPriceRolerepository.Delete(entity);
        }


        public void DeleteEntity(PatternPriceRole Pattern)
        {
            PatternPriceRolerepository.Delete(Pattern);
        }

        public PatternPriceRole GetById(int id)
        {
            return PatternPriceRolerepository.Get(id);
        }

        public PatternPriceRole GetSmallPattern()
        {
            var allpattern = PatternPriceRolerepository.GetAllIEnumerable().Where(s => s.PriceIncrease == 0).FirstOrDefault();
            return allpattern;
        }

        public void InsertEntity(PatternPriceRole Pattern)
        {
            PatternPriceRolerepository.Insert(Pattern);
        }

        public void UpdateEntity(PatternPriceRole Pattern)
        {
            PatternPriceRolerepository.Update(Pattern);
        }
    }
}

