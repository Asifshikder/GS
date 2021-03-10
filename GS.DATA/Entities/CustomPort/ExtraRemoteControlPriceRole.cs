using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Entities.CustomPort
{
    public class ExtraRemoteControlPriceRole:BaseEntity
    {
        public string Name { get; set; }
        public long? PriceIncrease { get; set; }
        public int? OperationStylePriceRoleId { get; set; }
        public virtual OperationStylePriceRole OperationStylePriceRole { get; set; }
    }
}
