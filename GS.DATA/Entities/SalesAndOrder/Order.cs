using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Entities.SalesAndOrder
{
    public class Order:BaseEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public long ProductPrice { get; set; }
        public int Quantity { get; set; }
        public int BillingAddressId { get; set; }

    }
}
