using Microsoft.AspNetCore.Mvc;

using System;

namespace ETicaretSitesi.Models
{
    public class Cart
    {
        public int CartID { get; set; }
        public int ProductID { get; set; }
        public int? Quantity { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }

        // Navigation properties
        public Product Product { get; set; }
        public User User { get; set; }
    }
}

