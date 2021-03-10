using GS.DATA.Entities.CMS;
using GS.REPO;
using GS.SERVICE.Interface.CMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Implementation.CMS
{
    public class TermsOfPurchaseService : ITermsOfPurchaseService
    {
        private readonly IRepository<TermsOfPurchase> TermsOfPurchaserepository;
        public TermsOfPurchaseService(IRepository<TermsOfPurchase> _TermsOfPurchaserepository)
        {
            this.TermsOfPurchaserepository = _TermsOfPurchaserepository;
        }


        public IEnumerable<TermsOfPurchase> AllAsIEnumerable()
        {
            return TermsOfPurchaserepository.GetAllIEnumerable();
        }

        public IQueryable<TermsOfPurchase> AllAsIQueryable()
        {
            return TermsOfPurchaserepository.GetAllIQueryable();
        }

        public List<TermsOfPurchase> AllAsList()
        {
            return TermsOfPurchaserepository.GetAll();
        }

        public void DeleteById(int id)
        {
            var entity = TermsOfPurchaserepository.Get(id);
            TermsOfPurchaserepository.Delete(entity);
        }

        public void DeleteEntity(TermsOfPurchase TermsOfPurchase)
        {
            TermsOfPurchaserepository.Delete(TermsOfPurchase);
        }

        public TermsOfPurchase GetById(int id)
        {
            return TermsOfPurchaserepository.Get(id);
        }

        public void InsertEntity(TermsOfPurchase TermsOfPurchase)
        {
            TermsOfPurchaserepository.Insert(TermsOfPurchase);
        }

        public void UpdateEntity(TermsOfPurchase TermsOfPurchase)
        {
            TermsOfPurchaserepository.Update(TermsOfPurchase);
        }
    }
}
