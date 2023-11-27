using Cadastro_login;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace Produtos
{
    public partial class LojaFisica : MetroFramework.Forms.MetroForm
    {
        public LojaFisica()
        {
            InitializeComponent();
        }

        private void LojaFisica_Load(object sender, EventArgs e)
        {

        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxCep.Text))
            {
                MessageBox.Show("Digite o cep");
            }
            else
            {
                HttpWebRequest Cep = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + textBoxCep.Text + "/json/");
                Cep.ContentType = "application/json";
                Cep.Method = "GET";
                var Resp = (HttpWebResponse)Cep.GetResponse();

                using (var Buscar = new StreamReader(Resp.GetResponseStream()))
                {
                    var resultado = Buscar.ReadToEnd();
                    string obj = resultado;
                    JObject resultcep_ = JObject.Parse(obj);

                    textBoxLogradouro.Text = resultcep_.Root["logradouro"].ToString();
                    textBoxBairro.Text = resultcep_.Root["bairro"].ToString();
                    textBoxCidade.Text = resultcep_.Root["localidade"].ToString();
                    textBoxEstado.Text = resultcep_.Root["uf"].ToString();

                }
            }

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            SqlConnection coon = new SqlConnection("Data Source=DESKTOP-1Q1907C\\SQLEXPRESS;Initial Catalog=CriandoTabela;Integrated Security=True");

            try
            {
                coon.Open();

                string sql = "INSERT INTO SalvarCep (Cep, Logradouro, Bairro, Cidade, Estado, DataPesquisa) " +
                             "VALUES (@cep, @logradouro, @bairro, @cidade, @estado, @datapesquisa)";

                SqlCommand cmd = new SqlCommand(sql, coon);

                if (string.IsNullOrEmpty(textBoxCep.Text))
                {
                    MessageBox.Show("Digite o cep");
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@cep", textBoxCep.Text));
                    cmd.Parameters.Add(new SqlParameter("@logradouro", textBoxLogradouro.Text));
                    cmd.Parameters.Add(new SqlParameter("@bairro", textBoxBairro.Text));
                    cmd.Parameters.Add(new SqlParameter("@cidade", textBoxCidade.Text));
                    cmd.Parameters.Add(new SqlParameter("@estado", textBoxEstado.Text));
                    cmd.Parameters.Add(new SqlParameter("@datapesquisa", dateTimePickerDataPesquisa.Value));

                    int qtdLinhas = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                coon.Close();
                listaGrid();
            }

        }
        public void listaGrid()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1Q1907C\\SQLEXPRESS;Initial Catalog=CriandoTabela;Integrated Security=True");
            conn.Open();
            string strSQL = "SELECT * FROM CriandoTabela.dbo.SalvarCep";
            SqlCommand cmd = new SqlCommand(strSQL, conn);

            try
            {
                SqlDataAdapter objADP = new SqlDataAdapter(cmd);
                DataTable dtLista = new DataTable();

                objADP.Fill(dtLista);

                dataGridViewMostrar.DataSource = dtLista;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro" + ex);
            }
            finally
            {
                if (conn != null) conn.Dispose();
                if (cmd != null) cmd.Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = null;
            try
            {
                string id = textBoxId.Text;
                SqlConnection coon = new SqlConnection("Data Source=DESKTOP-1Q1907C\\SQLEXPRESS;Initial Catalog=CriandoTabela;Integrated Security=True");
                coon.Open();

                string sql = $"DELETE FROM dbo.SalvarCep WHERE ID = @ID";
                cmd = new SqlCommand(sql, coon);
                cmd.Parameters.AddWithValue("@ID", id);

                int qtdLinhasExcluidas = cmd.ExecuteNonQuery();
                string msg = "Dados excluídos com sucesso!";




                if (qtdLinhasExcluidas == 0)
                {
                    msg = "Não foi possível excluir!";
                }

                MessageBox.Show(msg);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir itens: {ex.Message}");
            }

            finally
            {
                if (cmd != null) cmd.Dispose();
                textBoxBairro.Text = "";
                textBoxCep.Text = "";
                textBoxCidade.Text = "";
                textBoxLogradouro.Text = "";
                textBoxEstado.Text = "";
                dataGridViewMostrar = null;
            }
        }
        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gerenciamento pagina = new Gerenciamento();
            pagina.ShowDialog();
            this.Close();
        }
        private void graficoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BalancoGenero pagina = new BalancoGenero();
            pagina.ShowDialog();
        }

        private void gerenciamentoDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void balançoDeGêneroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCep_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLogradouro_TextChanged(object sender, EventArgs e)
        {

        }         
        private void cepToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

}
