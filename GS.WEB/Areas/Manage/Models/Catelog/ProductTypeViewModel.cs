using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GS.WEB.Areas.Manage.Models.Catelog
{
    public class ProductTypeViewModel
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public int? ParentId { get; set; }
        public string ParentName { get; set; }
    }
}
