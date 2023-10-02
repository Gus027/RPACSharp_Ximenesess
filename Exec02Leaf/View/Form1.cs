using Exec02Leaf.Model;
using Exec02Leaf.WebApplication;

namespace Exec02Leaf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void buttonConsultar_Click(object sender, EventArgs e)
        { 
            LoginRepository loginValid = new LoginRepository();
            loginValid.CheckLogin(textBoxUsuario.Text,textBoxSenha.Text);
        }
           
    }
}