using GS.DATA.Entities.CustomPort;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Map.CustomPort
{
    public class SizePriceRoleMap
    {
        public SizePriceRoleMap(EntityTypeBuilder<SizePriceRole> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.FromHeight);
            builder.Property(t => t.ToHeight);
            builder.Property(t => t.FromWidth);
            builder.Property(t => t.ToWidth);
            builder.Property(t => t.PriceIncrease);
        }
    }
}
