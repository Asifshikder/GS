using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Entities.CMS
{
   public class OldGateStatus:BaseEntity
    {
        public OldGateStatus()
        {
            Installation = new HashSet<Installation>();
        }
        public string Name { get; set; }
        public virtual ICollection<Installation> Installation { get; set; }
    }
}
