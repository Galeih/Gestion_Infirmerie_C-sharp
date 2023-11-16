using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfirmerieBO
{
    public class Login
    {
        protected int id_login;
        private string user;
        private string password;

        public Login(string user, string password)
        {
            this.user = user;
            this.password = password;
        }
        //Passer getter setter en propriété
        public string GetUser()
        {
            return user;
        }

        public string GetPassword()
        {
            return password;
        }

        public void SetUser(string unUser)
        {
            user = unUser;
        }

        public void setPassword(string unPassword)
        {
            password = unPassword;
        }
    }

}