using GS.DATA.Entities.CustomPort;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Map.CustomPort
{
    public class PatternPriceRoleMap
    {
        public PatternPriceRoleMap(EntityTypeBuilder<PatternPriceRole> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name);
            builder.Property(t => t.PriceIncrease);
        }
    }
}
