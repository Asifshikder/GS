using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Entities.SalesAndOrder
{
    public class CartItem : BaseEntity
    {
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public int ProductId { get; set; }
        public int CartId { get; set; }
        public virtual Cart Cart { get; set; }
    }
}
