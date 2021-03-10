using GS.DATA.Entities.Blog;
using GS.DATA.Entities.Catelog;
using GS.DATA.Entities.CMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GS.WEB.Models.ViewModel
{
    public class IndexViewModel
    {
        public MainPage MainPage { get; set; }
        public List<Product> Products { get; set; }
        public List<BlogPost> BlogPosts { get; set; }
    }
}
