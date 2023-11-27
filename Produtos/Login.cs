using Cadastro_login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Produtos
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
       
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;


            try
            {
                var nome = textBoxNome.Text;
                var senha = textBoxSenha.Text;

                conn = new SqlConnection("Data Source=DESKTOP-1Q1907C\\SQLEXPRESS;Initial Catalog=Cadastro;Integrated Security=True");
                conn.Open();
                string sql = $"SELECT * FROM MinhaTabela WHERE nome = @nome AND senha=@senha";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@nome", nome));
                cmd.Parameters.Add(new SqlParameter("@senha", senha));

                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dp.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    Gerenciamento pagina = new Gerenciamento();
                    pagina.ShowDialog();
                    this.Close();

                }
                else if ((string.IsNullOrEmpty(textBoxNome.Text) || string.IsNullOrEmpty(textBoxSenha.Text)))
                {
                    MessageBox.Show("Preencha os  Campos Corretamente!");
                }

                else
                {
                    MessageBox.Show("Nome ou Senha INCORRETA");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("não foi possivel executar a operação: " + ex.Message);
            }
            finally
            {
                if (conn != null) conn.Dispose();
                if (cmd != null) cmd.Dispose();

            }

        }
        private void linkLabelCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Cadastro pagina = new Cadastro();
            pagina.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
