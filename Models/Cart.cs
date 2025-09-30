using System;
using System.Collections.Generic;

namespace Lab1.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public int TotalPrice { get; set; }
        
        public Customer Customer { get; set; }
        public List<CartItem> CartItems { get; set; } = new();
    }
}
