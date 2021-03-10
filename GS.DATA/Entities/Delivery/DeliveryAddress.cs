using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Entities.Delivery
{
    public class DeliveryAddress:BaseEntity
    {
        public string UserId { get; set; }
        public int ZoneId { get; set; }
        public int MyProperty { get; set; }
    }
}
