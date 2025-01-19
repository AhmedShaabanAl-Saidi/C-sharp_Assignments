using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_
{
    public interface IAuthenticationService
    {
        bool AuthenticateUser(string username , string password);
        bool AuthorizeUser(string user , string role);
    }
}
