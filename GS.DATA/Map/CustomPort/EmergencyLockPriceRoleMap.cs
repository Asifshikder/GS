using GS.DATA.Entities.CustomPort;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Map.CustomPort
{
    public class EmergencyLockPriceRoleMap
    {
        public EmergencyLockPriceRoleMap(EntityTypeBuilder<EmergencyLockPriceRole> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name);
            builder.Property(t => t.PriceIncrease);
            builder.HasOne(m => m.OperationStylePriceRole)
                .WithMany(t => t.AccssoriesEmergencyLockPriceRole)
                .HasForeignKey(t => t.OperationStylePriceRoleId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
