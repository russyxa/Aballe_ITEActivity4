using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aballe_ITEActivity4.DTOs
{
    /// <summary>
    /// Carries login form input to the datastore.
    /// </summary>
    public class LoginDto
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public LoginDto(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
