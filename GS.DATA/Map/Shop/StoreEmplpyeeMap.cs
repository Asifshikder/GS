using GS.DATA.Entities.Shop;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Map.Shop
{
  public  class StoreEmplpyeeMap
    {
        public StoreEmplpyeeMap(EntityTypeBuilder<StoreEmployee> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.FullName);
            builder.Property(t => t.Email);
            builder.Property(t => t.PhoneNumber);
            builder.Property(t => t.Designation);
            builder.Property(t => t.EmployeeImage);
            builder.Property(t => t.StoreId);
            builder.HasOne(t => t.Store).WithMany(s=>s.StoreEmployee).HasForeignKey(s=>s.StoreId).OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.ClientSetNull);
        }
    }
}
