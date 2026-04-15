using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aballe_ITEActivity4.DTOs
{
    /// <summary>
    /// Used to display users in the ManageUsersForm DataGridView.
    /// </summary>
    public class UserDto
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string RoleName { get; set; }
        public bool IsActive { get; set; }

        // Binds to colStatus in the DataGridView
        public string StatusDisplay => IsActive ? "Active" : "Inactive";
    }
}
