using System.Collections.Generic;

namespace ETicaretSitesi.Models
{
    public class Role
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }

        // Navigation property
        public ICollection<User> Users { get; set; }
    }
}
