using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Entities.CustomPort
{
    public class PatternPriceRole : BaseEntity
    {
        public PatternPriceRole()
        {
            SurfaceLayerPriceRole = new HashSet<SurfaceLayerPriceRole>();
        }
        public string Name { get; set; }
        public long? PriceIncrease { get; set; }
        public virtual ICollection<SurfaceLayerPriceRole> SurfaceLayerPriceRole { get; set; }
    }
}
