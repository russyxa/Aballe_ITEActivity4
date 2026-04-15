using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aballe_ITEActivity4.Domain
{
    public class User
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }

        // Convenience property — no extra DB call needed
        public string RoleName { get; set; }

        public bool IsAdmin => RoleName == "Admin";
    }
}
