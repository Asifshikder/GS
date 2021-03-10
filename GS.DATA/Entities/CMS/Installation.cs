using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Entities.CMS
{
    public class Installation:BaseEntity
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public long Height { get; set; }
        public long Width { get; set; }
        public int? OldGateStatusId { get; set; }
        public virtual OldGateStatus OldGateStatus { get; set; }
    }
}
