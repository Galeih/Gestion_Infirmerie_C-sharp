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