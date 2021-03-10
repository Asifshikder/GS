using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GS.WEB.Areas.Manage.Models
{
    public class NUmberOfWindowsPriceRoleVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long? PriceIncrease { get; set; }
        public int? AccessoriesWindowsPriceRoleId { get; set; }
        public string AccessoriesWindowsPriceRoleName { get; set; }
    }
}
