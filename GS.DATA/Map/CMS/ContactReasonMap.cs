using GS.DATA.Entities.CMS;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Map.CMS
{
  public  class ContactReasonMap:BaseEntity
    {
        public ContactReasonMap(EntityTypeBuilder<ContactReason> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Name);
        }
    }
}
