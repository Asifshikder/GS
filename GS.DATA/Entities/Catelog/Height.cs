using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Entities.Catelog
{
   public class Height : BaseEntity
    {
        public int MeasuredValue { get; set; }

        public int ProductId { get; set; }
    }
}
