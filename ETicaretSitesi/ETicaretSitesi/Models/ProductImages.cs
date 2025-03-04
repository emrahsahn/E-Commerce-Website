using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETicaretSitesi.Models
{
    public class ProductImages
    {
        [Key]
        public int ImageID { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public bool? DefaultImage { get; set; }

        // Navigation property
        public Product Product { get; set; }
    }
}
