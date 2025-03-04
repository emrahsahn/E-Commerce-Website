using System;
using System.ComponentModel.DataAnnotations;

namespace ETicaretSitesi.Models
{
    public class Contact
    {
        [Key] // Primary key olarak tanımlandı
        public int ContactID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
