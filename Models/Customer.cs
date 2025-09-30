using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab1.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName {get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateOnly DateOfBirth { get; set; }

        public List<Order> Orders { get; set; } = new();
        public List<Review> Reviews { get; set; } = new();
        public List<Address> Addresses { get; set; } = new();
        public Cart Cart { get; set; }

    }
}
