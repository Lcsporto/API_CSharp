using FrontConFin.Models;
using FrontConFin.Views;
using System;
using System.Windows.Forms;

namespace FrontConFin
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent(); //Todos os componentes existirão após essa chamada
            labelUsuario.Text = "Usuario: " + UsuarioSession.Nome;
            verificaPermissoesUsuario();
        }

        private void verificaPermissoesUsuario()
        {
            usuárioToolStripMenuItem.Enabled = false;
            if (UsuarioSession.Funcao == "Gerente")
            {
                usuárioToolStripMenuItem.Enabled = true;
            }
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstados form = new FrmEstados();
            form.ShowDialog();
        }
    }
}
