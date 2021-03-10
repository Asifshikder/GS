using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GS.WEB.Areas.Manage.Models.Delivery
{
    public class PostalCodeViewModel
    {
        public int Id { get; set; }
        public long PostCodeStart { get; set; }
        public long PostCodeEnd { get; set; }
        public int? ZoneId { get; set; }
        public string ZoneName { get; set; }
    }
}
