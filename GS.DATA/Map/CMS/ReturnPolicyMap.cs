using GS.DATA.Entities.CMS;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Map.CMS
{
  public  class ReturnPolicyMap
    {
        public ReturnPolicyMap(EntityTypeBuilder<ReturnPolicy> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Title);
            builder.Property(s => s.Description);
            builder.Property(s => s.PrimaryImage);
        }
    }
}
