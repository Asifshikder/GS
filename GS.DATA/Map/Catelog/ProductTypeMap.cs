using GS.DATA.Entities.Catelog;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Map.Catelog
{
   public class ProductTypeMap
    {
        public ProductTypeMap(EntityTypeBuilder<ProductType> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.TypeName);
            builder.Property(t => t.ParentType);
        }
    }
}
