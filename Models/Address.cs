using System;
using System.Collections.Generic;

namespace Lab1.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string AddressLine { get; set; }

        public Customer Customer { get; set; }
        public List<Order> Orders { get; set; } = new();
    }
}
