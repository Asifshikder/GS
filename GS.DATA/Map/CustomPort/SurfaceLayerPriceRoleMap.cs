using GS.DATA.Entities.CustomPort;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Map.CustomPort
{
    public class SurfaceLayerPriceRoleMap
    {
        public SurfaceLayerPriceRoleMap(EntityTypeBuilder<SurfaceLayerPriceRole> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name);
            builder.Property(t => t.PriceIncrease);
            builder.HasOne(m => m.PatternPriceRole)
                .WithMany(t => t.SurfaceLayerPriceRole)
                .HasForeignKey(t => t.PatternPriceRoleId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
