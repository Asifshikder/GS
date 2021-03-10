using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Entities.Blog
{
    public class BlogCategory : BaseEntity
    {
        public BlogCategory()
        {
            BlogPost = new HashSet<BlogPost>();
        }
        public string Name { get; set; }
        public virtual ICollection<BlogPost> BlogPost { get; set; }
    }
}
