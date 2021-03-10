using GS.DATA.Entities.Delivery;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Map.Delivery
{
    public class DeliveryFeeMap
    {
        public DeliveryFeeMap(EntityTypeBuilder<DeliveryFee> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.DoorCount);
            builder.Property(t => t.ZoneId);
            builder.Property(t => t.Fee);
            builder.Property(t => t.Description);
            builder.HasOne(t => t.DeliveryZone).WithMany(s=>s.DeliveryFee).HasForeignKey(s=>s.ZoneId).OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
