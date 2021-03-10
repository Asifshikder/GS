using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Entities.Blog
{
    public class BlogPost : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string PrimaryImage { get; set; }
        public int BlogCategoryId { get; set; }
        public bool? IsFeatured { get; set; }
        public virtual BlogCategory BlogCategory { get; set; }
    }
}
