using GS.DATA.Entities.Blog;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Map.Blog
{
   public class BlogCategoryMap
    {
        public BlogCategoryMap(EntityTypeBuilder<BlogCategory> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name);
        }
    }
}
