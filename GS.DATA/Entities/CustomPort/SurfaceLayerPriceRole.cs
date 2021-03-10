using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Entities.CustomPort
{
    public class SurfaceLayerPriceRole : BaseEntity
    {
        public string Name { get; set; }
        public long? PriceIncrease { get; set; }
        public int? PatternPriceRoleId { get; set; }
        public virtual PatternPriceRole PatternPriceRole { get; set; }

    }
}
