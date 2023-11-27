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
using System.Windows.Forms.DataVisualization.Charting;

namespace Produtos
{
    public partial class BalancoGenero : MetroFramework.Forms.MetroForm
    {
        public BalancoGenero()
        {
            InitializeComponent();
        }
        private void BalancoGenero_Load(object sender, EventArgs e)
        {

        }
        
        private void ExibirGraficoPizza()
        {
            chart1.Series.Clear();


            SqlConnection conexao = new SqlConnection("Data Source=DESKTOP-1Q1907C\\SQLEXPRESS;Initial Catalog=CriandoTabela;Integrated Security=True");
            conexao.Open();

            string query = "SELECT  genero, COUNT(*) as Quantidade FROM CriandoTabela.dbo.AgoraVai  GROUP BY genero";
            SqlCommand cmd = new SqlCommand(query, conexao);
            SqlDataReader reader = cmd.ExecuteReader();

            List<string> generos = new List<string>();
            List<int> quantidades = new List<int>();

            while (reader.Read())
            {
                generos.Add(reader["genero"].ToString());
                quantidades.Add(Convert.ToInt32(reader["Quantidade"]));
            }

            conexao.Close();

            Series series = new Series();

            for (int i = 0; i < generos.Count; i++)
            {
                DataPoint point = new DataPoint();
                point.SetValueXY(generos[i], quantidades[i]);

                if (i == 0)
                    point.Color = Color.Purple;
                else if (i == 1)
                    point.Color = Color.Blue;

                series.Points.Add(point);
            }

            chart1.Series.Add(series);

            this.Controls.Add(chart1);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ExibirGraficoPizza();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
