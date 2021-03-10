using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Entities.Delivery
{
   public class DeliveryZone:BaseEntity
    {
        public DeliveryZone()
        {
            PostalCode = new HashSet<PostalCode>();
            DeliveryFee = new HashSet<DeliveryFee>();
        }
        public string ZoneName { get; set; }
        public ICollection<PostalCode> PostalCode { get; set; }
        public ICollection<DeliveryFee> DeliveryFee { get; set; }
    }
}
