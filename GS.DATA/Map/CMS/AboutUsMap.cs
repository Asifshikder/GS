using GS.DATA.Entities.CMS;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Map.CMS
{
   public class AboutUsMap
    {
        public AboutUsMap(EntityTypeBuilder<AboutUs> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Title);
            builder.Property(a => a.Description);
            builder.Property(a => a.PrimaryImage);
        }
    }
}
