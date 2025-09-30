using System;
using System.Collections.Generic;

namespace Lab1.Models
{
    public class CartItem
    {
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int TotalItemPrice { get; set; }

        public Cart Cart { get; set; }
        public Product Product { get; set; }
    }
}
