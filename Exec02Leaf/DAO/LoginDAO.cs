using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec02Leaf.DAO
{
    internal class LoginDAO
    {
        string user = "RENAC_ITAU_ESC";
        string password = "RENAC4242";
        string contrato = "556375533";


        public string GetUser() {
            return this.user;
        }

        public string GetPassword()
        {
            return this.password;
        }

        public string GetContrat()
        {
            return this.contrato;
        }
    }
}
