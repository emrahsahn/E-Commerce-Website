using System;
using System.Collections.Generic;

namespace ETicaretSitesi.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string Password { get; set; }
        public string ImageUrl { get; set; }
        public int RoleID { get; set; }
        public DateTime CreateDate { get; set; }

        // Navigation properties
        public Role Role { get; set; }
        public ICollection<ProductReview> Reviews { get; set; }
        public ICollection<Wishlist> Wishlists { get; set; }
        public ICollection<Cart> Carts { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
