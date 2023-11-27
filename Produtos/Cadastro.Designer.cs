namespace Cadastro_login
{
    partial class Cadastro
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxCriarSenha = new System.Windows.Forms.TextBox();
            this.textBoxConfirmarSenha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.linkLabelLogin = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(730, 232);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(137, 26);
            this.textBoxNome.TabIndex = 0;
            this.textBoxNome.TextChanged += new System.EventHandler(this.textBoxNome_TextChanged);
            // 
            // textBoxCriarSenha
            // 
            this.textBoxCriarSenha.Location = new System.Drawing.Point(730, 336);
            this.textBoxCriarSenha.Name = "textBoxCriarSenha";
            this.textBoxCriarSenha.Size = new System.Drawing.Size(137, 26);
            this.textBoxCriarSenha.TabIndex = 1;
            this.textBoxCriarSenha.UseSystemPasswordChar = true;
            // 
            // textBoxConfirmarSenha
            // 
            this.textBoxConfirmarSenha.Location = new System.Drawing.Point(811, 446);
            this.textBoxConfirmarSenha.Name = "textBoxConfirmarSenha";
            this.textBoxConfirmarSenha.Size = new System.Drawing.Size(150, 26);
            this.textBoxConfirmarSenha.TabIndex = 2;
            this.textBoxConfirmarSenha.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Produtos.Properties.Resources.Desktop___3__5_;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1068, 704);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonCadastrar.Location = new System.Drawing.Point(757, 563);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(99, 44);
            this.buttonCadastrar.TabIndex = 4;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click_1);
            // 
            // linkLabelLogin
            // 
            this.linkLabelLogin.AutoSize = true;
            this.linkLabelLogin.LinkColor = System.Drawing.Color.DarkOrange;
            this.linkLabelLogin.Location = new System.Drawing.Point(557, 658);
            this.linkLabelLogin.Name = "linkLabelLogin";
            this.linkLabelLogin.Size = new System.Drawing.Size(51, 20);
            this.linkLabelLogin.TabIndex = 5;
            this.linkLabelLogin.TabStop = true;
            this.linkLabelLogin.Text = "Voltar";
            this.linkLabelLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogin_LinkClicked);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 698);
            this.Controls.Add(this.linkLabelLogin);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.textBoxConfirmarSenha);
            this.Controls.Add(this.textBoxCriarSenha);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxCriarSenha;
        private System.Windows.Forms.TextBox textBoxConfirmarSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.LinkLabel linkLabelLogin;
    }
}