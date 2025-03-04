using System;
using System.ComponentModel.DataAnnotations;

namespace ETicaretSitesi.Models
{
    public class ProductReview
    {
        [Key]
        public int ReviewID { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public int ProductID { get; set; }
        public int UserId { get; set; }
        public DateTime CreateDate { get; set; }

        // Navigation properties
        public Product Product { get; set; }
        public User User { get; set; }
    }
}
