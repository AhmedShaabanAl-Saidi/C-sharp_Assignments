using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_.Authentication
{
    public class BasicAuthenticationService : IAuthenticationService
    {
        public string userName = "Ahmed";
        public string password = "123321";
        public string role = "Admin";

        public bool AuthenticateUser(string _username, string _password)
        {
            if (_username == userName && _password == password)
            {
                Console.WriteLine("Success AuthenticateUser");
                return true;
            }
            else
            {
                Console.WriteLine("Faild AuthenticateUser");
                return false;
            }
        }

        public bool AuthorizeUser(string _username, string _role)
        {
            if (_username == userName && _role == role)
            {
                Console.WriteLine("Success AuthorizeUser");
                return true;
            }
            else
            {
                Console.WriteLine("Faild AuthorizeUser");
                return false;
            }
        }
    }
}
