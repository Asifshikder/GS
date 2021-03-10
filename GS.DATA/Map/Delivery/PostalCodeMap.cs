using GS.DATA.Entities.Delivery;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Map.Delivery
{
    public class PostalCodeMap
    {
        public PostalCodeMap(EntityTypeBuilder<PostalCode> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.PostCodeStart);
            builder.Property(s => s.PostCodeEnd);
            builder.Property(s => s.ZoneId);
            builder.HasOne(s => s.DeliveryZone).WithMany(s => s.PostalCode).HasForeignKey(s => s.ZoneId).OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.ClientSetNull);
        }
    }
}
