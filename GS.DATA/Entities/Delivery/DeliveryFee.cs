using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Entities.Delivery
{
    public class DeliveryFee : BaseEntity
    {
        public long? DoorCount { get; set; }
        public int ZoneId { get; set; }
        public long Fee { get; set; }
        public string Description { get; set; }
        public virtual DeliveryZone DeliveryZone{ get; set; }
    }
}
