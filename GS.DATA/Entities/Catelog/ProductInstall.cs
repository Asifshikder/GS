using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Entities.Catelog
{
    public class ProductInstall:BaseEntity
    {
        public string  Title { get; set; }
        public string Description { get; set; }
        public string IconImage { get; set; }
        public long Price { get; set; }
    }
}
