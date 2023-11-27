using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Produtos;



namespace Cadastro_login
{
    public partial class Cadastro : MetroFramework.Forms.MetroForm
    {
        public Cadastro()
        {
            InitializeComponent();
        }
        private void Cadastro_Load(object sender, EventArgs e)
        {

        }
        private void chamarLogin()
        {

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1Q1907C\\SQLEXPRESS;Initial Catalog=Cadastro;Integrated Security=True");

            string sql = "INSERT INTO MinhaTabela (nome, senha) VALUES (@nome, @senha)";
            string nome = textBoxNome.Text;
            string senha = textBoxCriarSenha.Text;
            string confSenha = textBoxConfirmarSenha.Text;

            try
            {
                if (string.IsNullOrEmpty(textBoxNome.Text) || string.IsNullOrEmpty(textBoxConfirmarSenha.Text))
                {
                    MessageBox.Show("Preencha os campos corretamente");
                    return;

                }

                else if (senha != confSenha)
                {
                    MessageBox.Show("Senhas Diferentes!");
                    return;
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.Add(new SqlParameter("@nome", this.textBoxNome.Text));
                    cmd.Parameters.Add(new SqlParameter("@senha", this.textBoxConfirmarSenha.Text));
                    int qtdLinhas = cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Criado com sucesso!");


                    this.Hide();
                    Login pagina = new Login();
                    pagina.ShowDialog();
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex);
            }
            finally
            {
                conn.Close();

            }
        }

        private void buttonCadastrar_Click_1(object sender, EventArgs e)
        {
            chamarLogin();

        }
        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login pagina = new Login();
            pagina.ShowDialog();
            this.Close();
        }
        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
