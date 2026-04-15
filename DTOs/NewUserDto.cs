using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aballe_ITEActivity4.DTOs
{
    /// <summary>
    /// Carries AddUserForm input to the datastore.
    /// </summary>
    public class NewUserDto
    {
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
    }
}
