using System;
using System.ComponentModel.DataAnnotations;

namespace ETicaretSitesi.Models
{
    public class Order
    {
        [Key]
        public int OrderDetailsID { get; set; }
        public string OrderNo { get; set; }
        public int ProductId { get; set; }
        public int? Quantity { get; set; }
        public int UserId { get; set; }
        public string Status { get; set; }
        public int PaymentId { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsCancel { get; set; }

        // Navigation properties
        public Product Product { get; set; }
        public User User { get; set; }
        public Payment Payment { get; set; }
    }
}
