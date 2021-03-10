using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Entities.Shop
{
    public class Store:BaseEntity
    {
        public Store()
        {
            StoreEmployee = new HashSet<StoreEmployee>();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string StoreViewImage { get; set; }
        public string MapIFrame { get; set; }
        public string StoreOnTime { get; set; }
        public string SeoMETA { get; set; }
        public string SeoMETAEnglish { get; set; }
        public virtual ICollection<StoreEmployee> StoreEmployee { get; set; }
    }
}
