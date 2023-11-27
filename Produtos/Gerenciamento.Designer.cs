namespace Cadastro_login
{
    partial class Gerenciamento
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
            this.buttonBuscarImagem = new System.Windows.Forms.Button();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.textBoxNomeProduto = new System.Windows.Forms.TextBox();
            this.textBoxCor = new System.Windows.Forms.TextBox();
            this.textBoxSKU = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.comboBoxMarcaTenis = new System.Windows.Forms.ComboBox();
            this.radioButtonFeminino = new System.Windows.Forms.RadioButton();
            this.dateTimePickeData = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewMostrar = new System.Windows.Forms.DataGridView();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonExibirTabela = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxImagem = new System.Windows.Forms.TextBox();
            this.pictureBoxImagem = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBuscarImagem
            // 
            this.buttonBuscarImagem.BackColor = System.Drawing.Color.Black;
            this.buttonBuscarImagem.Font = new System.Drawing.Font("Segoe UI Emoji", 8F);
            this.buttonBuscarImagem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonBuscarImagem.Location = new System.Drawing.Point(535, 210);
            this.buttonBuscarImagem.Name = "buttonBuscarImagem";
            this.buttonBuscarImagem.Size = new System.Drawing.Size(124, 35);
            this.buttonBuscarImagem.TabIndex = 0;
            this.buttonBuscarImagem.Text = "Buscar";
            this.buttonBuscarImagem.UseVisualStyleBackColor = false;
            this.buttonBuscarImagem.Click += new System.EventHandler(this.buttonBuscarImagem_Click_1);
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Font = new System.Drawing.Font("Segoe UI Emoji", 8F);
            this.radioButtonMasculino.Location = new System.Drawing.Point(786, 210);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(106, 25);
            this.radioButtonMasculino.TabIndex = 1;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // textBoxNomeProduto
            // 
            this.textBoxNomeProduto.Font = new System.Drawing.Font("Segoe UI Emoji", 8F);
            this.textBoxNomeProduto.Location = new System.Drawing.Point(115, 148);
            this.textBoxNomeProduto.Name = "textBoxNomeProduto";
            this.textBoxNomeProduto.Size = new System.Drawing.Size(353, 29);
            this.textBoxNomeProduto.TabIndex = 4;
            // 
            // textBoxCor
            // 
            this.textBoxCor.Font = new System.Drawing.Font("Segoe UI Emoji", 8F);
            this.textBoxCor.Location = new System.Drawing.Point(518, 323);
            this.textBoxCor.Name = "textBoxCor";
            this.textBoxCor.Size = new System.Drawing.Size(141, 29);
            this.textBoxCor.TabIndex = 6;
            // 
            // textBoxSKU
            // 
            this.textBoxSKU.Font = new System.Drawing.Font("Segoe UI Emoji", 8F);
            this.textBoxSKU.Location = new System.Drawing.Point(748, 268);
            this.textBoxSKU.Name = "textBoxSKU";
            this.textBoxSKU.Size = new System.Drawing.Size(126, 29);
            this.textBoxSKU.TabIndex = 7;
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Segoe UI Emoji", 8F);
            this.textBoxID.Location = new System.Drawing.Point(163, 65);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(81, 29);
            this.textBoxID.TabIndex = 8;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonSalvar.Font = new System.Drawing.Font("Segoe UI Emoji", 8F);
            this.buttonSalvar.Location = new System.Drawing.Point(998, 396);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(118, 35);
            this.buttonSalvar.TabIndex = 10;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click_1);
            // 
            // comboBoxMarcaTenis
            // 
            this.comboBoxMarcaTenis.Font = new System.Drawing.Font("Segoe UI Emoji", 8F);
            this.comboBoxMarcaTenis.FormattingEnabled = true;
            this.comboBoxMarcaTenis.Items.AddRange(new object[] {
            "Adidias",
            "Nike",
            "Vans"});
            this.comboBoxMarcaTenis.Location = new System.Drawing.Point(571, 266);
            this.comboBoxMarcaTenis.Name = "comboBoxMarcaTenis";
            this.comboBoxMarcaTenis.Size = new System.Drawing.Size(107, 29);
            this.comboBoxMarcaTenis.TabIndex = 12;
            this.comboBoxMarcaTenis.SelectedIndexChanged += new System.EventHandler(this.comboBoxMarcaTenis_SelectedIndexChanged);
            // 
            // radioButtonFeminino
            // 
            this.radioButtonFeminino.AutoSize = true;
            this.radioButtonFeminino.Font = new System.Drawing.Font("Segoe UI Emoji", 8F);
            this.radioButtonFeminino.Location = new System.Drawing.Point(922, 210);
            this.radioButtonFeminino.Name = "radioButtonFeminino";
            this.radioButtonFeminino.Size = new System.Drawing.Size(100, 25);
            this.radioButtonFeminino.TabIndex = 13;
            this.radioButtonFeminino.Text = "Feminino";
            this.radioButtonFeminino.UseVisualStyleBackColor = true;
            // 
            // dateTimePickeData
            // 
            this.dateTimePickeData.Font = new System.Drawing.Font("Segoe UI Emoji", 8F);
            this.dateTimePickeData.Location = new System.Drawing.Point(770, 323);
            this.dateTimePickeData.Name = "dateTimePickeData";
            this.dateTimePickeData.Size = new System.Drawing.Size(251, 29);
            this.dateTimePickeData.TabIndex = 14;
            // 
            // dataGridViewMostrar
            // 
            this.dataGridViewMostrar.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMostrar.Location = new System.Drawing.Point(101, 494);
            this.dataGridViewMostrar.Name = "dataGridViewMostrar";
            this.dataGridViewMostrar.RowHeadersWidth = 62;
            this.dataGridViewMostrar.RowTemplate.Height = 28;
            this.dataGridViewMostrar.Size = new System.Drawing.Size(1015, 235);
            this.dataGridViewMostrar.TabIndex = 15;
            // 
            // buttonNovo
            // 
            this.buttonNovo.BackColor = System.Drawing.Color.Orange;
            this.buttonNovo.Font = new System.Drawing.Font("Segoe UI Emoji", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNovo.Location = new System.Drawing.Point(334, 63);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(100, 33);
            this.buttonNovo.TabIndex = 16;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.UseVisualStyleBackColor = false;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNono_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.BackColor = System.Drawing.Color.Orange;
            this.buttonExcluir.Font = new System.Drawing.Font("Segoe UI Emoji", 8F);
            this.buttonExcluir.Location = new System.Drawing.Point(440, 63);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(100, 33);
            this.buttonExcluir.TabIndex = 17;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = false;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click_1);
            // 
            // buttonExibirTabela
            // 
            this.buttonExibirTabela.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonExibirTabela.Font = new System.Drawing.Font("Segoe UI Emoji", 8F);
            this.buttonExibirTabela.Location = new System.Drawing.Point(832, 396);
            this.buttonExibirTabela.Name = "buttonExibirTabela";
            this.buttonExibirTabela.Size = new System.Drawing.Size(160, 35);
            this.buttonExibirTabela.TabIndex = 22;
            this.buttonExibirTabela.Text = "Exibir Tabela";
            this.buttonExibirTabela.UseVisualStyleBackColor = false;
            this.buttonExibirTabela.Click += new System.EventHandler(this.buttonExibirTabela_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.cepToolStripMenuItem,
            this.graficoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(968, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(230, 29);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 8F);
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(89, 25);
            this.menuToolStripMenuItem.Text = "Produtos";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // cepToolStripMenuItem
            // 
            this.cepToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 8F);
            this.cepToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cepToolStripMenuItem.Name = "cepToolStripMenuItem";
            this.cepToolStripMenuItem.Size = new System.Drawing.Size(53, 25);
            this.cepToolStripMenuItem.Text = "Cep";
            this.cepToolStripMenuItem.Click += new System.EventHandler(this.cepToolStripMenuItem_Click);
            // 
            // graficoToolStripMenuItem
            // 
            this.graficoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 8F);
            this.graficoToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.graficoToolStripMenuItem.Name = "graficoToolStripMenuItem";
            this.graficoToolStripMenuItem.Size = new System.Drawing.Size(80, 25);
            this.graficoToolStripMenuItem.Text = "Grafico ";
            this.graficoToolStripMenuItem.Click += new System.EventHandler(this.graficoToolStripMenuItem_Click);
            // 
            // textBoxImagem
            // 
            this.textBoxImagem.Font = new System.Drawing.Font("Segoe UI Emoji", 8F);
            this.textBoxImagem.Location = new System.Drawing.Point(115, 210);
            this.textBoxImagem.Name = "textBoxImagem";
            this.textBoxImagem.Size = new System.Drawing.Size(353, 29);
            this.textBoxImagem.TabIndex = 3;
            // 
            // pictureBoxImagem
            // 
            this.pictureBoxImagem.BackgroundImage = global::Produtos.Properties.Resources.imagem_imagem;
            this.pictureBoxImagem.Location = new System.Drawing.Point(115, 254);
            this.pictureBoxImagem.Name = "pictureBoxImagem";
            this.pictureBoxImagem.Size = new System.Drawing.Size(223, 146);
            this.pictureBoxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagem.TabIndex = 11;
            this.pictureBoxImagem.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Produtos.Properties.Resources.LOJAGERENCIAMENRO1;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1211, 753);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Gerenciamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 748);
            this.Controls.Add(this.buttonExibirTabela);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonNovo);
            this.Controls.Add(this.dataGridViewMostrar);
            this.Controls.Add(this.dateTimePickeData);
            this.Controls.Add(this.radioButtonFeminino);
            this.Controls.Add(this.comboBoxMarcaTenis);
            this.Controls.Add(this.pictureBoxImagem);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxSKU);
            this.Controls.Add(this.textBoxCor);
            this.Controls.Add(this.textBoxNomeProduto);
            this.Controls.Add(this.textBoxImagem);
            this.Controls.Add(this.radioButtonMasculino);
            this.Controls.Add(this.buttonBuscarImagem);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Gerenciamento";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Load += new System.EventHandler(this.Produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuscarImagem;
        private System.Windows.Forms.RadioButton radioButtonMasculino;
        private System.Windows.Forms.TextBox textBoxNomeProduto;
        private System.Windows.Forms.TextBox textBoxCor;
        private System.Windows.Forms.TextBox textBoxSKU;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.PictureBox pictureBoxImagem;
        private System.Windows.Forms.ComboBox comboBoxMarcaTenis;
        private System.Windows.Forms.RadioButton radioButtonFeminino;
        private System.Windows.Forms.DateTimePicker dateTimePickeData;
        private System.Windows.Forms.DataGridView dataGridViewMostrar;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonExibirTabela;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxImagem;
        private System.Windows.Forms.ToolStripMenuItem cepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}