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

namespace FrontConFin.Views
{
    public partial class FrmEstados : Form
    {
        private PaginacaoResponse<Estado> paginacao = null;
        public FrmEstados()
        {
            InitializeComponent();
            atualizaDados();
        }

        private async void atualizaDados()
        {
            int skip = int.Parse(textBoxSkip.Text);
            int take = int.Parse(textBoxTake.Text);
            paginacao = await EstadoServices.Paginacao(textBoxPesquisa.Text, skip, take, checkBoxOrdem.Checked);
            dataGridView1.DataSource = paginacao.Dados;
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            atualizaDados();
        }

        private void FrmEstados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonPesquisar_Click(sender, e);
            }
        }

        private void buttonPrimeira_Click(object sender, EventArgs e)
        {
            if (paginacao.Skip > 1)
            {
                textBoxSkip.Text = "1";
                atualizaDados();
            }
        }

        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            if (paginacao.Skip > 1)
            {
                paginacao.Skip--;
                textBoxSkip.Text = paginacao.Skip.ToString();
                atualizaDados();
            }
        }

        private void buttonProxima_Click(object sender, EventArgs e)
        {
            decimal paginas = (decimal)paginacao.TotalLinhas / paginacao.Take;
            int quantidadePaginas = (int)Math.Ceiling(paginas);
            if (paginacao.Skip < quantidadePaginas)
            {
                paginacao.Skip++;
                textBoxSkip.Text = paginacao.Skip.ToString();
                atualizaDados();
            }

        }

        private void buttonUltima_Click(object sender, EventArgs e)
        {
            decimal paginas = (decimal)paginacao.TotalLinhas / paginacao.Take;
            int quantidadePaginas = (int)Math.Ceiling(paginas);
            if (paginacao.Skip < quantidadePaginas)
            {
                textBoxSkip.Text = quantidadePaginas.ToString();
                atualizaDados();
            }
        }
    }
}
