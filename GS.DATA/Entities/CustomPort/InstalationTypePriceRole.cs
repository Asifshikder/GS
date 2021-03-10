using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Entities.CustomPort
{
    public class InstalationTypePriceRole : BaseEntity
    {
        public string Name { get; set; }
        public long? PriceIncrease { get; set; }

    }
}
