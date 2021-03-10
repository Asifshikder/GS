using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Entities.Catelog
{
    public class Product : BaseEntity
    {
        public Product()
        {
            Heights = new HashSet<Height>();
            Widths = new HashSet<Width>();
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public string TechnicalSpec { get; set; }
        public string PrimaryImage { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }
        public long Price { get; set; }
        public int? ModelId { get; set; }
        public int? CategoryId { get; set; }
        public int? OperationStyleId { get; set; }
        public virtual ICollection<Height> Heights { get; set; }
        public virtual ICollection<Width> Widths { get; set; }
        public string DocumentationFile1 { get; set; }
        public string DocumentationFile2 { get; set; }
    }
}
