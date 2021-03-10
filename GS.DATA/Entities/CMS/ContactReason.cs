using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Entities.CMS
{
    public class ContactReason : BaseEntity
    {
        public ContactReason()
        {
            Contact = new HashSet<Contact>();
        }
        public string Name { get; set; }
        public virtual ICollection<Contact> Contact { get; set; }
    }
}
