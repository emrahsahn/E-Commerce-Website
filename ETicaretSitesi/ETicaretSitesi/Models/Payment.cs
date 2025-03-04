using System.ComponentModel.DataAnnotations;

namespace ETicaretSitesi.Models
{
    public class Payment
    {
        [Required]
        public string CardHolderName { get; set; }

        [Required]
        [CreditCard]
        public string CardNumber { get; set; }

        [Required]
        public string ExpireMonth { get; set; }

        [Required]
        public string ExpireYear { get; set; }

        [Required]
        public string Cvc { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string BuyerName { get; set; }

        [Required]
        public string BuyerSurname { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string BuyerAddress { get; set; }
    }
}

