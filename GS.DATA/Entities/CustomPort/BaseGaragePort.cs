using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Entities.CustomPort
{
    public class BaseGaragePort : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string DocumentFile { get; set; }
        public string DocumentFile1 { get; set; }
        public string Instruction { get; set; }
        public string TechnicalSpecification { get; set; }
        public string BaseImage { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public long? BasePrice { get; set; }
    }
}
