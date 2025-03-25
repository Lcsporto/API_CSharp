using FrontConFin.Models;
using FrontConFin.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontConFin
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            //Verificação do Usuário
            UsuarioLogin login = new UsuarioLogin()
            {
                Login = textBoxLogin.Text,
                Password = textBoxPassword.Text
            };

            UsuarioResponse response = await UsuarioServices.Login(login);

            if (response == null)
            {
                MessageBox.Show("Login ou senha inválidos.");
                return;
            }



            Close();
        }
    }
}
