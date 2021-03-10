using GS.DATA.Entities.Shop;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Map.Shop
{
   public class StoreMap
    {
        public StoreMap(EntityTypeBuilder<Store> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name);
            builder.Property(t => t.Address);
            builder.Property(t => t.Email);
            builder.Property(t => t.Phone);
            builder.Property(t => t.StoreViewImage);
            builder.Property(t => t.MapIFrame);
            builder.Property(t => t.StoreOnTime);
            builder.Property(t => t.SeoMETA);
            builder.Property(t => t.SeoMETAEnglish);
        }
    }
}
