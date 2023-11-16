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
        private int IdLogin;
        private string User;
        private string Password;

        public Login(string user, string password)
        {
            User1 = user;
            Password1 = password;
        }

        public int IdLogin1 { get => IdLogin; set => IdLogin = value; }
        public string User1 { get => User; set => User = value; }
        public string Password1 { get => Password; set => Password = value; }
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