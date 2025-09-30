using System;
using System.Collections.Generic;

namespace Lab1.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string RecipientFirstName { get; set; }
        public string RecipientLastName { get; set; }
        public bool CustomerIsRecipient { get; set; }
        public string DeliveryType { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public string PaymentType { get; set; }
        public int TotalPrice { get; set; }

        public Customer Customer { get; set; }
        public Address Address { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}
