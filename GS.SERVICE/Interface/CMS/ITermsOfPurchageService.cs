using GS.DATA.Entities.CMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Interface.CMS
{
    public interface ITermsOfPurchaseService
    {
        IEnumerable<TermsOfPurchase> AllAsIEnumerable();
        IQueryable<TermsOfPurchase> AllAsIQueryable();
        List<TermsOfPurchase> AllAsList();
        TermsOfPurchase GetById(int id);
        void InsertEntity(TermsOfPurchase TermsOfPurchase);
        void UpdateEntity(TermsOfPurchase TermsOfPurchase);
        void DeleteEntity(TermsOfPurchase TermsOfPurchase);
        void DeleteById(int id);
    }
}
