using System;
using System.Collections.Generic;

namespace Lab1.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Country { get; set; }
        public int Weight { get; set; }
        public int StockQuantity { get; set; }
        public int Price { get; set; }

        public Category Category { get; set; }
        public List<Review> Reviews { get; set; } = new();
        public List<CartItem> CartItems { get; set; } = new();
        public List<OrderItem> OrderItems { get; set; } = new();

    }
}
