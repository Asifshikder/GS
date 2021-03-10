using GS.DATA.Entities.CustomPort;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Map.CustomPort
{
    public class BaseGaragePortMap
    {
        public BaseGaragePortMap(EntityTypeBuilder<BaseGaragePort> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Title);
            builder.Property(t => t.Description);
            builder.Property(t => t.DocumentFile);
            builder.Property(t => t.DocumentFile1);
            builder.Property(t => t.Instruction);
            builder.Property(t => t.TechnicalSpecification);
            builder.Property(t => t.BasePrice);
            builder.Property(t => t.BaseImage);
            builder.Property(t => t.Image1);
            builder.Property(t => t.Image2);
        }
    }
}
