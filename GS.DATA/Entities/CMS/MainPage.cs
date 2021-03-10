using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Entities.CMS
{
    public class MainPage : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string PrimaryImage { get; set; }
    }
}
