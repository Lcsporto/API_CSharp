namespace FrontConFin.Views
{
    partial class FrmEstados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new System.Windows.Forms.Panel();
            panel5 = new System.Windows.Forms.Panel();
            checkBoxOrdem = new System.Windows.Forms.CheckBox();
            buttonPesquisar = new System.Windows.Forms.Button();
            textBoxPesquisa = new System.Windows.Forms.TextBox();
            panel4 = new System.Windows.Forms.Panel();
            textBoxSkip = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            textBoxTake = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            buttonUltima = new System.Windows.Forms.Button();
            buttonProxima = new System.Windows.Forms.Button();
            buttonAnterior = new System.Windows.Forms.Button();
            buttonPrimeira = new System.Windows.Forms.Button();
            panel3 = new System.Windows.Forms.Panel();
            buttonSair = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            panel7 = new System.Windows.Forms.Panel();
            buttonCancelar = new System.Windows.Forms.Button();
            buttonSalvar = new System.Windows.Forms.Button();
            panel6 = new System.Windows.Forms.Panel();
            buttonExcluir = new System.Windows.Forms.Button();
            buttonAlterar = new System.Windows.Forms.Button();
            buttonNovo = new System.Windows.Forms.Button();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            tabPage2 = new System.Windows.Forms.TabPage();
            textBoxNome = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            textBoxSigla = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            Sigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(863, 83);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(checkBoxOrdem);
            panel5.Controls.Add(buttonPesquisar);
            panel5.Controls.Add(textBoxPesquisa);
            panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            panel5.Location = new System.Drawing.Point(424, 0);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(332, 83);
            panel5.TabIndex = 2;
            // 
            // checkBoxOrdem
            // 
            checkBoxOrdem.AutoSize = true;
            checkBoxOrdem.Location = new System.Drawing.Point(6, 56);
            checkBoxOrdem.Name = "checkBoxOrdem";
            checkBoxOrdem.Size = new System.Drawing.Size(136, 19);
            checkBoxOrdem.TabIndex = 2;
            checkBoxOrdem.Text = "Ordenar Decrescente";
            checkBoxOrdem.UseVisualStyleBackColor = true;
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Image = Properties.Resources.Lupa32X32;
            buttonPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            buttonPesquisar.Location = new System.Drawing.Point(218, 12);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new System.Drawing.Size(99, 41);
            buttonPesquisar.TabIndex = 1;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // textBoxPesquisa
            // 
            textBoxPesquisa.Location = new System.Drawing.Point(6, 12);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.Size = new System.Drawing.Size(206, 23);
            textBoxPesquisa.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(textBoxSkip);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(textBoxTake);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(buttonUltima);
            panel4.Controls.Add(buttonProxima);
            panel4.Controls.Add(buttonAnterior);
            panel4.Controls.Add(buttonPrimeira);
            panel4.Dock = System.Windows.Forms.DockStyle.Left;
            panel4.Location = new System.Drawing.Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(424, 83);
            panel4.TabIndex = 1;
            // 
            // textBoxSkip
            // 
            textBoxSkip.Location = new System.Drawing.Point(229, 56);
            textBoxSkip.Name = "textBoxSkip";
            textBoxSkip.Size = new System.Drawing.Size(33, 23);
            textBoxSkip.TabIndex = 7;
            textBoxSkip.Text = "1";
            textBoxSkip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(184, 60);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(43, 15);
            label2.TabIndex = 6;
            label2.Text = "Página";
            // 
            // textBoxTake
            // 
            textBoxTake.Location = new System.Drawing.Point(127, 56);
            textBoxTake.Name = "textBoxTake";
            textBoxTake.Size = new System.Drawing.Size(33, 23);
            textBoxTake.TabIndex = 5;
            textBoxTake.Text = "10";
            textBoxTake.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(11, 60);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(115, 15);
            label1.TabIndex = 4;
            label1.Text = "Registros por Página";
            // 
            // buttonUltima
            // 
            buttonUltima.Image = Properties.Resources.SetaUltima32X32;
            buttonUltima.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            buttonUltima.Location = new System.Drawing.Point(311, 12);
            buttonUltima.Name = "buttonUltima";
            buttonUltima.Size = new System.Drawing.Size(94, 41);
            buttonUltima.TabIndex = 3;
            buttonUltima.Text = "Últma";
            buttonUltima.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            buttonUltima.UseVisualStyleBackColor = true;
            buttonUltima.Click += buttonUltima_Click;
            // 
            // buttonProxima
            // 
            buttonProxima.Image = Properties.Resources.Setaproxima32X32;
            buttonProxima.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            buttonProxima.Location = new System.Drawing.Point(211, 12);
            buttonProxima.Name = "buttonProxima";
            buttonProxima.Size = new System.Drawing.Size(94, 41);
            buttonProxima.TabIndex = 2;
            buttonProxima.Text = "Próxima";
            buttonProxima.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            buttonProxima.UseVisualStyleBackColor = true;
            buttonProxima.Click += buttonProxima_Click;
            // 
            // buttonAnterior
            // 
            buttonAnterior.Image = Properties.Resources.SetaAnterior32X32;
            buttonAnterior.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            buttonAnterior.Location = new System.Drawing.Point(111, 12);
            buttonAnterior.Name = "buttonAnterior";
            buttonAnterior.Size = new System.Drawing.Size(94, 41);
            buttonAnterior.TabIndex = 1;
            buttonAnterior.Text = "Anterior";
            buttonAnterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonAnterior.UseVisualStyleBackColor = true;
            buttonAnterior.Click += buttonAnterior_Click;
            // 
            // buttonPrimeira
            // 
            buttonPrimeira.Image = Properties.Resources.SetaPrimeira32X32;
            buttonPrimeira.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            buttonPrimeira.Location = new System.Drawing.Point(11, 12);
            buttonPrimeira.Name = "buttonPrimeira";
            buttonPrimeira.Size = new System.Drawing.Size(94, 41);
            buttonPrimeira.TabIndex = 0;
            buttonPrimeira.Text = "Primeira";
            buttonPrimeira.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonPrimeira.UseVisualStyleBackColor = true;
            buttonPrimeira.Click += buttonPrimeira_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonSair);
            panel3.Dock = System.Windows.Forms.DockStyle.Right;
            panel3.Location = new System.Drawing.Point(756, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(107, 83);
            panel3.TabIndex = 0;
            // 
            // buttonSair
            // 
            buttonSair.Image = Properties.Resources.Sair32X32;
            buttonSair.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            buttonSair.Location = new System.Drawing.Point(15, 12);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new System.Drawing.Size(80, 41);
            buttonSair.TabIndex = 0;
            buttonSair.Text = "Sair";
            buttonSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonSair.UseVisualStyleBackColor = true;
            buttonSair.Click += buttonSair_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel2.Location = new System.Drawing.Point(0, 398);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(863, 52);
            panel2.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Controls.Add(buttonCancelar);
            panel7.Controls.Add(buttonSalvar);
            panel7.Dock = System.Windows.Forms.DockStyle.Right;
            panel7.Location = new System.Drawing.Point(652, 0);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(211, 52);
            panel7.TabIndex = 1;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Image = Properties.Resources.Cancelar32X321;
            buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            buttonCancelar.Location = new System.Drawing.Point(110, 6);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new System.Drawing.Size(94, 41);
            buttonCancelar.TabIndex = 12;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Image = Properties.Resources.Salvar32X32;
            buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            buttonSalvar.Location = new System.Drawing.Point(10, 6);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new System.Drawing.Size(94, 41);
            buttonSalvar.TabIndex = 11;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(buttonExcluir);
            panel6.Controls.Add(buttonAlterar);
            panel6.Controls.Add(buttonNovo);
            panel6.Dock = System.Windows.Forms.DockStyle.Left;
            panel6.Location = new System.Drawing.Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(319, 52);
            panel6.TabIndex = 0;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Image = Properties.Resources.Excluir32X32;
            buttonExcluir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            buttonExcluir.Location = new System.Drawing.Point(211, 6);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new System.Drawing.Size(94, 41);
            buttonExcluir.TabIndex = 10;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonAlterar
            // 
            buttonAlterar.Image = Properties.Resources.Editar32X32;
            buttonAlterar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            buttonAlterar.Location = new System.Drawing.Point(111, 6);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new System.Drawing.Size(94, 41);
            buttonAlterar.TabIndex = 9;
            buttonAlterar.Text = "Alterar";
            buttonAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonAlterar.UseVisualStyleBackColor = true;
            buttonAlterar.Click += buttonAlterar_Click;
            // 
            // buttonNovo
            // 
            buttonNovo.Image = Properties.Resources.Novo32X32;
            buttonNovo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            buttonNovo.Location = new System.Drawing.Point(11, 6);
            buttonNovo.Name = "buttonNovo";
            buttonNovo.Size = new System.Drawing.Size(94, 41);
            buttonNovo.TabIndex = 8;
            buttonNovo.Text = "Novo";
            buttonNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonNovo.UseVisualStyleBackColor = true;
            buttonNovo.Click += buttonNovo_Click;
            // 
            // tabControl1
            // 
            tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(0, 83);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(863, 315);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new System.Drawing.Point(27, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(832, 307);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registros";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Sigla, Nome });
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new System.Drawing.Size(826, 301);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBoxNome);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(textBoxSigla);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new System.Drawing.Point(27, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(832, 307);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Detalhes";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new System.Drawing.Point(22, 93);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new System.Drawing.Size(198, 23);
            textBoxNome.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(22, 75);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(40, 15);
            label4.TabIndex = 2;
            label4.Text = "Nome";
            // 
            // textBoxSigla
            // 
            textBoxSigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            textBoxSigla.Location = new System.Drawing.Point(22, 49);
            textBoxSigla.MaxLength = 2;
            textBoxSigla.Name = "textBoxSigla";
            textBoxSigla.Size = new System.Drawing.Size(32, 23);
            textBoxSigla.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(22, 31);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(32, 15);
            label3.TabIndex = 0;
            label3.Text = "Sigla";
            // 
            // Sigla
            // 
            Sigla.DataPropertyName = "Sigla";
            Sigla.HeaderText = "Sigla";
            Sigla.Name = "Sigla";
            Sigla.Width = 80;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.Width = 400;
            // 
            // FrmEstados
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(863, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            KeyPreview = true;
            Name = "FrmEstados";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Cadastro de Estados";
            KeyDown += FrmEstados_KeyDown;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonAnterior;
        private System.Windows.Forms.Button buttonPrimeira;
        private System.Windows.Forms.Button buttonUltima;
        private System.Windows.Forms.Button buttonProxima;
        private System.Windows.Forms.TextBox textBoxSkip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.CheckBox checkBoxOrdem;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSigla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sigla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
    }
}