using System;
using System.Collections.Generic;

namespace ETicaretSitesi.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryImageuRL { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }

        // Navigation properties
        public ICollection<SubCategory> SubCategories { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
