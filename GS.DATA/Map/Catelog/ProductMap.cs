using GS.DATA.Entities.Catelog;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Map.Catelog
{
   public class ProductMap
    {
        public ProductMap(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Title);
            builder.Property(t => t.Description);
            builder.Property(t => t.TechnicalSpec);
            builder.Property(t => t.PrimaryImage);
            builder.Property(t => t.Image1);
            builder.Property(t => t.Image2);
            builder.Property(t => t.Image3);
            builder.Property(t => t.Image4);
            builder.Property(t => t.Price);
            builder.Property(t => t.ModelId);
            builder.Property(t => t.CategoryId);
            builder.Property(t => t.OperationStyleId);
            builder.Property(t => t.DocumentationFile1);
            builder.Property(t => t.DocumentationFile2);
        }
    }
}
