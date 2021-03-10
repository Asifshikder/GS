using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Entities.Catelog
{
    public class ProductType:BaseEntity
    {
        public string TypeName { get; set; }
        public int? ParentType { get; set; }
    }
}
