//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore;
//using System.Collections.Generic;

//namespace ECommerceVS.Models
//{
//    public class ApplicationUser : IdentityUser
//    {
//        // Ek özellikler eklemek için burayı kullanabilirsiniz
//    }

//    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
//    {
//        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
//            : base(options)
//        {
//        }

//        // Ek DbSet'ler
//        public DbSet<Product> Products { get; set; }
//        public DbSet<Category> Categories { get; set; }
//        public DbSet<SubCategory> SubCategories { get; set; }
//    }
//}
