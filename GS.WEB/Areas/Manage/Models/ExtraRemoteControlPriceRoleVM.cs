using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GS.WEB.Areas.Manage.Models
{
    public class ExtraRemoteControlPriceRoleVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long? PriceIncrease { get; set; }
        public int? OperationStylePriceRoleId { get; set; }
        public string OperationStylePriceRoleName { get; set; }
    }
}
