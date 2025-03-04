using System;
using System.Collections.Generic;

namespace ETicaretSitesi.Models
{
    public class SubCategory
    {
        public int SubCategoryID { get; set; }
        public string SubCategoryName { get; set; }
        public int CategoryId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }

        // Navigation properties
        public Category Category { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
