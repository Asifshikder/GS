using GS.DATA.Entities;
using GS.DATA.Entities.Delivery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Interface.Blog
{
    public interface IPostalCodeService
    {
        IEnumerable<PostalCode> AllAsIEnumerable();
        IQueryable<PostalCode> AllAsIQueryable();
        List<PostalCode> AllAsList();
        PostalCode GetById(int id);
        void InsertEntity(PostalCode PostalCode);
        void UpdateEntity(PostalCode PostalCode);
        void DeleteEntity(PostalCode PostalCode);
        void DeleteById(int id);
    }
}
