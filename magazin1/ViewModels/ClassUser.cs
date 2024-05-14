using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magazin1.ViewModels
{
    internal class ClassUser
    {
        public string login="1";
        public string passwords="1";
        public bool admin=false;

        public ClassUser(string? login, string? password, bool admin)
        {
         login = login;
        password = password;
         admin = admin;

        }

      
        
        public bool provAdmin(string login, string password)
        {
            if (login == "admin" && password == "admin")
            {
                admin = true;
            }
            else
            {
                admin = false;
            }

            return admin;
        }
    }
}
