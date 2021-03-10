using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GS.WEB.Models.ViewModel
{
    public class ProductDisplayViewModel
    {
        public int Id { get; set; }
        public long Price { get; set; }
        public string Title { get; set; }
        public string PrimaryImage { get; set; }

    }
}
