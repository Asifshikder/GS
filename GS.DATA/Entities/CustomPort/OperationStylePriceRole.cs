using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Entities.CustomPort
{
    public class OperationStylePriceRole : BaseEntity
    {
        //public OperationStylePriceRole()
        //{
        //    AccssoriesEmergencyLockPriceRole = new HashSet<EmergencyLockPriceRole>();
        //    ExtraRemoteControlPriceRole = new HashSet<ExtraRemoteControlPriceRole>();
        //}
        public string Name { get; set; }
        public long? PriceIncrease { get; set; }
        //public virtual ICollection<EmergencyLockPriceRole> AccssoriesEmergencyLockPriceRole { get; set; }
        //public virtual ICollection<ExtraRemoteControlPriceRole> ExtraRemoteControlPriceRole { get; set; }

    }
}
