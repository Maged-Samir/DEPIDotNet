using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }

        public User()
        {
        }
        public User(string userName, string password, string email)
        {
            UserName = userName;
            Password = password;
            Email = email;
        }

        public void Login()
        {
            Console.WriteLine($"{UserName} logged in.");
        }
        public void Logout()
        {
            Console.WriteLine($"{UserName} logged out.");
        }
        public string UserInfo()
        {
            return $"User: {UserName}, Email: {Email}";
        }
    }
}
