using System;
using System.Collections.Generic;

namespace Lab1.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
        public DateTime ReviewDate { get; set; }

        public Customer Customer { get; set; }
        public Product Product { get; set; }
    }
}
