using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GS.WEB.Areas.Manage.Models.Delivery
{
    public class DeliveryFeeViewModel
    {
        public int Id { get; set; }
        public long? DoorCount { get; set; }
        public int? ZoneId { get; set; }
        public long Fee { get; set; }
        public string Description { get; set; }
        public string ZoneName { get; set; }
    }
}
