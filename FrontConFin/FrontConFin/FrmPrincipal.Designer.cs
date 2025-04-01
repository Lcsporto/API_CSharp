using System.Drawing;
using System.Windows.Forms;

namespace FrontConFin
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            cidadeToolStripMenuItem = new ToolStripMenuItem();
            cidadeToolStripMenuItem1 = new ToolStripMenuItem();
            pessoaToolStripMenuItem = new ToolStripMenuItem();
            lançamentoToolStripMenuItem = new ToolStripMenuItem();
            contaToolStripMenuItem = new ToolStripMenuItem();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            usuárioToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            labelUsuario = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, cadastroToolStripMenuItem, lançamentoToolStripMenuItem, configuraçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(620, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Image = Properties.Resources.Sair32X32;
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(93, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cidadeToolStripMenuItem, cidadeToolStripMenuItem1, pessoaToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // cidadeToolStripMenuItem
            // 
            cidadeToolStripMenuItem.Image = Properties.Resources.Estado32X32;
            cidadeToolStripMenuItem.Name = "cidadeToolStripMenuItem";
            cidadeToolStripMenuItem.Size = new Size(180, 22);
            cidadeToolStripMenuItem.Text = "Estado";
            cidadeToolStripMenuItem.Click += cidadeToolStripMenuItem_Click;
            // 
            // cidadeToolStripMenuItem1
            // 
            cidadeToolStripMenuItem1.Image = Properties.Resources.Cidade32X32;
            cidadeToolStripMenuItem1.Name = "cidadeToolStripMenuItem1";
            cidadeToolStripMenuItem1.Size = new Size(180, 22);
            cidadeToolStripMenuItem1.Text = "Cidade";
            cidadeToolStripMenuItem1.Click += cidadeToolStripMenuItem_Click;
            // 
            // pessoaToolStripMenuItem
            // 
            pessoaToolStripMenuItem.Image = Properties.Resources.Pessoa32X32;
            pessoaToolStripMenuItem.Name = "pessoaToolStripMenuItem";
            pessoaToolStripMenuItem.Size = new Size(180, 22);
            pessoaToolStripMenuItem.Text = "Pessoa";
            // 
            // lançamentoToolStripMenuItem
            // 
            lançamentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contaToolStripMenuItem });
            lançamentoToolStripMenuItem.Name = "lançamentoToolStripMenuItem";
            lançamentoToolStripMenuItem.Size = new Size(85, 20);
            lançamentoToolStripMenuItem.Text = "Lançamento";
            // 
            // contaToolStripMenuItem
            // 
            contaToolStripMenuItem.Image = Properties.Resources.Conta32X32;
            contaToolStripMenuItem.Name = "contaToolStripMenuItem";
            contaToolStripMenuItem.Size = new Size(106, 22);
            contaToolStripMenuItem.Text = "Conta";
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuárioToolStripMenuItem });
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(96, 20);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // usuárioToolStripMenuItem
            // 
            usuárioToolStripMenuItem.Image = Properties.Resources.Usuario32X32;
            usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            usuárioToolStripMenuItem.Size = new Size(114, 22);
            usuárioToolStripMenuItem.Text = "Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 8);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(8, 13);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(53, 15);
            labelUsuario.TabIndex = 4;
            labelUsuario.Text = "Usuário: ";
            // 
            // panel1
            // 
            panel1.Controls.Add(labelUsuario);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 342);
            panel1.Name = "panel1";
            panel1.Size = new Size(620, 44);
            panel1.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 24);
            panel3.Name = "panel3";
            panel3.Size = new Size(620, 44);
            panel3.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(44, 274);
            panel2.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(576, 68);
            panel4.Name = "panel4";
            panel4.Size = new Size(44, 274);
            panel4.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Financeiro;
            pictureBox1.Location = new Point(44, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(532, 274);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 386);
            Controls.Add(pictureBox1);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrontConFin - Controle Financeiro";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem cidadeToolStripMenuItem;
        private ToolStripMenuItem lançamentoToolStripMenuItem;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem cidadeToolStripMenuItem1;
        private ToolStripMenuItem pessoaToolStripMenuItem;
        private ToolStripMenuItem contaToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem usuárioToolStripMenuItem;
        private Label label2;
        private Label labelUsuario;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private PictureBox pictureBox1;
    }
}
