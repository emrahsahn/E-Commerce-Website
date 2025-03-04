using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ETicaretSitesi.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        public string ProductName { get; set; }

        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string Size { get; set; }
        public string Color { get; set; }
        public string CompanyName { get; set; }

        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }

        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }

        public string ImageUrl { get; set; }

        // Navigation properties
        public Category Category { get; set; }
        public SubCategory SubCategory { get; set; }

        // Yeni eklenen özellik: Ürün resimleri
        public ICollection<ProductImages> ProductImages { get; set; }
    }
}
