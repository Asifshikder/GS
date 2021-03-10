using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Entities.CMS
{
    public class Contact : BaseEntity
    {
        public string Subject { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
        public int ContactReasonId { get; set; }
        public virtual ContactReason ContactReason { get; set; }
        public string Attachment { get; set; }//file 
    }
}
