using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Entities.Delivery
{
   public class PostalCode:BaseEntity
    {
        public long PostCodeStart { get; set; }
        public long PostCodeEnd { get; set; }
        public int ZoneId { get; set; }
        public virtual DeliveryZone DeliveryZone { get; set; }
    }
}
