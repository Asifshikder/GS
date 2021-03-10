using GS.DATA.Entities.CMS;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Map.CMS
{
   public class ContactMap
    {
        public ContactMap(EntityTypeBuilder<Contact> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.FullName);
            builder.Property(s => s.Email);
            builder.Property(s => s.Subject);
            builder.Property(s => s.Description);
            builder.Property(s => s.ContactReasonId);
            builder.Property(s => s.Attachment);
            builder.Property(s => s.PhoneNumber);
            builder.HasOne(a => a.ContactReason).WithMany(s=>s.Contact).HasForeignKey(t=>t.ContactReasonId).OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.ClientSetNull);
        }
    }
}
