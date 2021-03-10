using GS.DATA.Entities.Delivery;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Map.Delivery
{
    public class DeliveryZoneMap
    {
        public DeliveryZoneMap(EntityTypeBuilder<DeliveryZone> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.ZoneName);
        }
    }
}
