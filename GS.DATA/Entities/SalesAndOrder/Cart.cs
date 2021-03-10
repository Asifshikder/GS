using System;
using System.Collections.Generic;
using System.Text;

namespace GS.DATA.Entities.SalesAndOrder
{
    public class Cart:BaseEntity
    {
        public string UserId { get; set; }
        public ICollection<CartItem> CartItem { get; set; }
    }
}
