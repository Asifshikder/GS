using GS.DATA.Entities.CMS;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Map.CMS
{
   public class InstallationMap
    {
        public InstallationMap(EntityTypeBuilder<Installation> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Email);
            builder.Property(s => s.FirstName);
            builder.Property(s => s.PhoneNumber);
            builder.Property(s => s.City);
            builder.Property(s => s.District);
            builder.Property(s => s.Height);
            builder.Property(s => s.Width);
            builder.Property(s => s.OldGateStatusId);
            builder.HasOne(s => s.OldGateStatus).WithMany(s=>s.Installation).HasForeignKey(s=>s.OldGateStatusId).OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.ClientSetNull);
        }
    }
}
