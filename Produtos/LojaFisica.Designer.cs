namespace Produtos
{
    partial class LojaFisica
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxCep = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxLogradouro = new System.Windows.Forms.TextBox();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.dataGridViewMostrar = new System.Windows.Forms.DataGridView();
            this.buttonExluirCep = new System.Windows.Forms.Button();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciamentoDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balançoDeGêneroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.dateTimePickerDataPesquisa = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1036, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxCep
            // 
            this.textBoxCep.Font = new System.Drawing.Font("Segoe UI Emoji", 8F);
            this.textBoxCep.Location = new System.Drawing.Point(285, 81);
            this.textBoxCep.Name = "textBoxCep";
            this.textBoxCep.Size = new System.Drawing.Size(200, 29);
            this.textBoxCep.TabIndex = 4;
            this.textBoxCep.TextChanged += new System.EventHandler(this.textBoxCep_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Emoji", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(171, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Data da Busca:";
            // 
            // textBoxLogradouro
            // 
            this.textBoxLogradouro.Font = new System.Drawing.Font("Segoe UI Emoji", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogradouro.Location = new System.Drawing.Point(793, 81);
            this.textBoxLogradouro.Name = "textBoxLogradouro";
            this.textBoxLogradouro.Size = new System.Drawing.Size(285, 29);
            this.textBoxLogradouro.TabIndex = 11;
            this.textBoxLogradouro.TextChanged += new System.EventHandler(this.textBoxLogradouro_TextChanged);
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.Font = new System.Drawing.Font("Segoe UI Emoji", 8F);
            this.textBoxBairro.Location = new System.Drawing.Point(751, 173);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(188, 29);
            this.textBoxBairro.TabIndex = 12;
            this.textBoxBairro.TextChanged += new System.EventHandler(this.textBoxBairro_TextChanged);
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Font = new System.Drawing.Font("Segoe UI Emoji", 8F);
            this.textBoxCidade.Location = new System.Drawing.Point(444, 173);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(180, 29);
            this.textBoxCidade.TabIndex = 13;
            this.textBoxCidade.TextChanged += new System.EventHandler(this.textBoxCidade_TextChanged);
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.Font = new System.Drawing.Font("Segoe UI Emoji", 8F);
            this.textBoxEstado.Location = new System.Drawing.Point(175, 173);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.Size = new System.Drawing.Size(113, 29);
            this.textBoxEstado.TabIndex = 14;
            this.textBoxEstado.TextChanged += new System.EventHandler(this.textBoxEstado_TextChanged);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.Black;
            this.buttonBuscar.Font = new System.Drawing.Font("Segoe UI Emoji", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.Color.White;
            this.buttonBuscar.Location = new System.Drawing.Point(106, 295);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(102, 36);
            this.buttonBuscar.TabIndex = 15;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonSalvar.Location = new System.Drawing.Point(214, 296);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(102, 36);
            this.buttonSalvar.TabIndex = 16;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // dataGridViewMostrar
            // 
            this.dataGridViewMostrar.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMostrar.Location = new System.Drawing.Point(96, 427);
            this.dataGridViewMostrar.Name = "dataGridViewMostrar";
            this.dataGridViewMostrar.RowHeadersWidth = 62;
            this.dataGridViewMostrar.RowTemplate.Height = 28;
            this.dataGridViewMostrar.Size = new System.Drawing.Size(982, 262);
            this.dataGridViewMostrar.TabIndex = 17;
            // 
            // buttonExluirCep
            // 
            this.buttonExluirCep.BackColor = System.Drawing.Color.Orange;
            this.buttonExluirCep.Location = new System.Drawing.Point(314, 295);
            this.buttonExluirCep.Name = "buttonExluirCep";
            this.buttonExluirCep.Size = new System.Drawing.Size(104, 36);
            this.buttonExluirCep.TabIndex = 19;
            this.buttonExluirCep.Text = "Exluir";
            this.buttonExluirCep.UseVisualStyleBackColor = false;
            this.buttonExluirCep.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciamentoDeProdutosToolStripMenuItem,
            this.balançoDeGêneroToolStripMenuItem});
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(101, 29);
            this.menuToolStripMenuItem.Text = "Produtos";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // gerenciamentoDeProdutosToolStripMenuItem
            // 
            this.gerenciamentoDeProdutosToolStripMenuItem.Name = "gerenciamentoDeProdutosToolStripMenuItem";
            this.gerenciamentoDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(343, 34);
            this.gerenciamentoDeProdutosToolStripMenuItem.Text = "Gerenciamento De Produtos ";
            this.gerenciamentoDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.gerenciamentoDeProdutosToolStripMenuItem_Click);
            // 
            // balançoDeGêneroToolStripMenuItem
            // 
            this.balançoDeGêneroToolStripMenuItem.Name = "balançoDeGêneroToolStripMenuItem";
            this.balançoDeGêneroToolStripMenuItem.Size = new System.Drawing.Size(343, 34);
            this.balançoDeGêneroToolStripMenuItem.Text = "Balanço de Gênero";
            this.balançoDeGêneroToolStripMenuItem.Click += new System.EventHandler(this.balançoDeGêneroToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.cepToolStripMenuItem,
            this.graficoToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(890, 4);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(252, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // cepToolStripMenuItem
            // 
            this.cepToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.cepToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cepToolStripMenuItem.Name = "cepToolStripMenuItem";
            this.cepToolStripMenuItem.Size = new System.Drawing.Size(59, 29);
            this.cepToolStripMenuItem.Text = "Cep";
            this.cepToolStripMenuItem.Click += new System.EventHandler(this.cepToolStripMenuItem_Click);
            // 
            // graficoToolStripMenuItem
            // 
            this.graficoToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.graficoToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.graficoToolStripMenuItem.Name = "graficoToolStripMenuItem";
            this.graficoToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.graficoToolStripMenuItem.Text = "Grafico";
            this.graficoToolStripMenuItem.Click += new System.EventHandler(this.graficoToolStripMenuItem_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Segoe UI Emoji", 8F);
            this.textBoxId.Location = new System.Drawing.Point(424, 299);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(91, 29);
            this.textBoxId.TabIndex = 20;
            // 
            // dateTimePickerDataPesquisa
            // 
            this.dateTimePickerDataPesquisa.Font = new System.Drawing.Font("Segoe UI Emoji", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDataPesquisa.Location = new System.Drawing.Point(310, 230);
            this.dateTimePickerDataPesquisa.Name = "dateTimePickerDataPesquisa";
            this.dateTimePickerDataPesquisa.Size = new System.Drawing.Size(252, 29);
            this.dateTimePickerDataPesquisa.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Produtos.Properties.Resources.CEp;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1163, 700);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LojaFisica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 703);
            this.Controls.Add(this.dateTimePickerDataPesquisa);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonExluirCep);
            this.Controls.Add(this.dataGridViewMostrar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxEstado);
            this.Controls.Add(this.textBoxCidade);
            this.Controls.Add(this.textBoxBairro);
            this.Controls.Add(this.textBoxLogradouro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCep);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MinimizeBox = false;
            this.Name = "LojaFisica";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Load += new System.EventHandler(this.LojaFisica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxCep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxLogradouro;
        private System.Windows.Forms.TextBox textBoxBairro;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.TextBox textBoxEstado;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.DataGridView dataGridViewMostrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonExluirCep;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciamentoDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balançoDeGêneroToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficoToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataPesquisa;
    }
}