using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GS.WEB.Areas.Manage.Models
{
    public class SurfaceLayerPriceRoleVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long? PriceIncrease { get; set; }
        public int? PatternPriceRoleId { get; set; }
        public string PatternPriceRoleName { get; set; }
    }
}
