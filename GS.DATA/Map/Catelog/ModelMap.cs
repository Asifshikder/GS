using GS.DATA.Entities.Catelog;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Map.Catelog
{
    public class ModelMap
    {
        public ModelMap(EntityTypeBuilder<Model> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.ModelLogo);
            builder.Property(t => t.ModelName);
        }
    }
}