using GS.DATA.Entities.Catelog;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Map.Catelog
{
    public class ColorMap
    {
        public ColorMap(EntityTypeBuilder<Color> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.ColorSamplmage);
            builder.Property(t => t.ColorName);
        }
    }
}
