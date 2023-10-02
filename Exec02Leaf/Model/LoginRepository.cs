using Exec02Leaf.DAO;
using Exec02Leaf.WebApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec02Leaf.Model
{
    internal class LoginRepository : ILoginRepository
    {

        public void CheckLogin(string user, string password)
        {
            LoginDAO ld = new LoginDAO();

            if (user != ld.GetUser() || password != ld.GetPassword())
            {
                MessageBox.Show("Usuario ou Senha, estão incorretos!\nFavor Verificar.");
            }
            else 
            {
                RobotWeb rb = new RobotWeb();
                rb.InsertLogin();
            }
        }
    }
}
