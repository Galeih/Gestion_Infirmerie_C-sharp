using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfirmerieBO
{
    public class Login
    {

        //Plutot utiliser des propriétés auto-implementées (User et Password). Ces propriétés offrent des méthodes get et set automatiques 
        //pour accéder aux champs privés correspondants (user et password)
        //Utiliser une propriété sur id_login -> devenue IdLogin pour la convention de nommage 
        public int IdLogin { get; protected set; }
        public string User { get; set; }
        public string Password { get; set; }

        public Login(string user, string password)
        {
            User = user;
            Password = password;
        }
    }
}

/*

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
        //Passer gette setter en propriété
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

*/