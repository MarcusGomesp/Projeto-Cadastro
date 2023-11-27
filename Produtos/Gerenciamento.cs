using Produtos;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Cadastro_login
{
    public partial class Gerenciamento : MetroFramework.Forms.MetroForm
    {
        public Gerenciamento()
        {
            InitializeComponent();
        }

        private void Produtos_Load(object sender, EventArgs e)
        {

        }
      
        private void buttonBuscarImagem_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos os Arquivos|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoDaImagem = openFileDialog.FileName;
                textBoxImagem.Text = caminhoDaImagem; // Define o caminho no TextBox

                pictureBoxImagem.Image = Image.FromFile(caminhoDaImagem); // Exibe a imagem na PictureBox
            }
        }
        private byte[] getPhoto()
        {
            MemoryStream stream = new MemoryStream();
            pictureBoxImagem.Image.Save(stream, pictureBoxImagem.Image.RawFormat);

            return stream.GetBuffer();
        }

        private void buttonNono_Click(object sender, EventArgs e)
        {
            textBoxImagem.Text = "";
            textBoxNomeProduto.Text = "";
            textBoxSKU.Text = "";
            textBoxID.Text = "";
            textBoxCor.Text = "";
            comboBoxMarcaTenis.Text = null;
            pictureBoxImagem.Image = null;
            radioButtonFeminino.Checked = false;
            radioButtonMasculino.Checked = false;

        }

        private void buttonSalvar_Click_1(object sender, EventArgs e)
        {
            SqlConnection coon = new SqlConnection("Data Source=DESKTOP-1Q1907C\\SQLEXPRESS;Initial Catalog=CriandoTabela;Integrated Security=True");

            try
            {
                coon.Open();


                //Logica para o genero                 
                string generoSelecionado = radioButtonMasculino.Checked ? "Masculino" : (radioButtonFeminino.Checked ? "Feminino" : null);

                string sql = "INSERT INTO AgoraVai (NomeProduto, Imagem, Sku, Cor, Genero, DataCadastro) " +
                             "VALUES (@nome, @imagem, @sku, @cor, @genero, @datacadastro)";

                SqlCommand cmd = new SqlCommand(sql, coon);

                cmd.Parameters.Add(new SqlParameter("@nome", this.textBoxNomeProduto.Text));
                cmd.Parameters.Add(new SqlParameter("@imagem", SqlDbType.VarBinary, int.MaxValue)).Value = getPhoto();
                cmd.Parameters.Add(new SqlParameter("@sku", this.textBoxSKU.Text));
                cmd.Parameters.Add(new SqlParameter("@cor", this.textBoxCor.Text));
                cmd.Parameters.Add(new SqlParameter("@genero", generoSelecionado));
                cmd.Parameters.Add(new SqlParameter("@datacadastro", this.dateTimePickeData.Value));

                int qtdLinhas = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                coon.Close();
                MessageBox.Show("Produtos salvos");
            }
        }

        private void buttonExcluir_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = null;
            try
            {
                string id = textBoxID.Text;
                SqlConnection coon = new SqlConnection("Data Source=DESKTOP-1Q1907C\\SQLEXPRESS;Initial Catalog=CriandoTabela;Integrated Security=True");
                coon.Open();

                string sql = $"DELETE FROM AgoraVai WHERE ID = @ID";
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
            }
        }
        
        public void listaGrid()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1Q1907C\\SQLEXPRESS;Initial Catalog=CriandoTabela;Integrated Security=True");
            conn.Open();
            string strSQL = "SELECT * FROM CriandoTabela.dbo.AgoraVai";
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
        private void buttonExibirTabela_Click_1(object sender, EventArgs e)
        {
            listaGrid();
        }

        private void cepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LojaFisica pagina = new LojaFisica();
            pagina.ShowDialog();
            this.Close();
        }
        private void destinatarioDeEnvioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LojaFisica pagina = new LojaFisica();
            pagina.ShowDialog();

        }

        private void graficoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BalancoGenero pagina = new BalancoGenero();
            pagina.ShowDialog();

        }

        private void comboBoxMarcaTenis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
