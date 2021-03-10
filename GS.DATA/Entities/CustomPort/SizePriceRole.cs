using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Entities.CustomPort
{
    public class SizePriceRole:BaseEntity
    {
        public long? FromHeight { get; set; }
        public long ToHeight { get; set; }
        public long? FromWidth { get; set; }
        public long ToWidth { get; set; }
        public long? PriceIncrease { get; set; }
    }
}
