using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Entities.Shop
{
  public  class StoreEmployee:BaseEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Designation { get; set; }
        public string EmployeeImage { get; set; }
        public int StoreId { get; set; }
        public virtual Store Store { get; set; }
    }
}
