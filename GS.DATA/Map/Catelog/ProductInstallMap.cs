using GS.DATA.Entities.Catelog;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Map.Catelog
{
   public class ProductInstallMap
    {
        public ProductInstallMap(EntityTypeBuilder<ProductInstall> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Title);
            builder.Property(t => t.Description);
            builder.Property(t => t.IconImage);
            builder.Property(t => t.Price);
        }
    }
}
