using GS.DATA.Entities.Catelog;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Map.Catelog
{
    public class BrandMap
    {
        public BrandMap(EntityTypeBuilder<Brand> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name);
        }
    }
}
