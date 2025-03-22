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
            labelUsuario = new Label();
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            lançamentoToolStripMenuItem = new ToolStripMenuItem();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            estadoToolStripMenuItem = new ToolStripMenuItem();
            cidadeToolStripMenuItem = new ToolStripMenuItem();
            pessoaToolStripMenuItem = new ToolStripMenuItem();
            contaToolStripMenuItem = new ToolStripMenuItem();
            usuárioToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(12, 426);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(53, 15);
            labelUsuario.TabIndex = 0;
            labelUsuario.Text = "Usuário: ";
            labelUsuario.Click += this.label1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, cadastroToolStripMenuItem, lançamentoToolStripMenuItem, configuraçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(785, 24);
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
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { estadoToolStripMenuItem, cidadeToolStripMenuItem, pessoaToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // lançamentoToolStripMenuItem
            // 
            lançamentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contaToolStripMenuItem });
            lançamentoToolStripMenuItem.Name = "lançamentoToolStripMenuItem";
            lançamentoToolStripMenuItem.Size = new Size(85, 20);
            lançamentoToolStripMenuItem.Text = "Lançamento";
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuárioToolStripMenuItem });
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(96, 20);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // estadoToolStripMenuItem
            // 
            estadoToolStripMenuItem.Name = "estadoToolStripMenuItem";
            estadoToolStripMenuItem.Size = new Size(180, 22);
            estadoToolStripMenuItem.Text = "Estado";
            // 
            // cidadeToolStripMenuItem
            // 
            cidadeToolStripMenuItem.Name = "cidadeToolStripMenuItem";
            cidadeToolStripMenuItem.Size = new Size(180, 22);
            cidadeToolStripMenuItem.Text = "Cidade";
            // 
            // pessoaToolStripMenuItem
            // 
            pessoaToolStripMenuItem.Name = "pessoaToolStripMenuItem";
            pessoaToolStripMenuItem.Size = new Size(180, 22);
            pessoaToolStripMenuItem.Text = "Pessoa";
            // 
            // contaToolStripMenuItem
            // 
            contaToolStripMenuItem.Name = "contaToolStripMenuItem";
            contaToolStripMenuItem.Size = new Size(180, 22);
            contaToolStripMenuItem.Text = "Conta";
            // 
            // usuárioToolStripMenuItem
            // 
            usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            usuárioToolStripMenuItem.Size = new Size(180, 22);
            usuárioToolStripMenuItem.Text = "Usuário";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(180, 22);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 450);
            Controls.Add(labelUsuario);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrontConFin - Controle Financeiro";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUsuario;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem estadoToolStripMenuItem;
        private ToolStripMenuItem cidadeToolStripMenuItem;
        private ToolStripMenuItem pessoaToolStripMenuItem;
        private ToolStripMenuItem lançamentoToolStripMenuItem;
        private ToolStripMenuItem contaToolStripMenuItem;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem usuárioToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}
