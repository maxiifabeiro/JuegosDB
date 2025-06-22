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

namespace Login
{
    public partial class AvisoStock : Form
    {
        string conexionbd = "Ruta DB";
        public AvisoStock()
        {
            InitializeComponent();
        }

        private void AvisoStock_Load(object sender, EventArgs e)
        {
            ConfigurarListView();
        }

        private void btnFiltrarMayor_Click(object sender, EventArgs e)
        {
            MostrarStock(1);
        }

        private void btnFiltrarIgual_Click(object sender, EventArgs e)
        {
            MostrarStock(2);
        }


        private void btnFiltrarMenor_Click(object sender, EventArgs e)
        {
            MostrarStock(3);
        }

        private void MostrarStock(int TipoDeFiltro)
        {

            using (SqlConnection conexion = new SqlConnection(conexionbd))
            {
                SqlCommand com = new SqlCommand("SP_ListarStockPorFiltro", conexion);
                com.Parameters.AddWithValue("@Cantidad", nupCantidad.Value);
                com.Parameters.AddWithValue("@TipoDeFiltro", TipoDeFiltro);
                com.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                SqlDataReader reader = com.ExecuteReader();
                CargarDatosEnLista(reader);
            }
        }

        private void ConfigurarListView()
        {
            lvwListaJuegos.View = View.Details;
            lvwListaJuegos.FullRowSelect = true;
            lvwListaJuegos.GridLines = true;
            lvwListaJuegos.Columns.Clear();

            lvwListaJuegos.Columns.Add("ID Juego", 100);
            lvwListaJuegos.Columns.Add("Nombre", 150);
            lvwListaJuegos.Columns.Add("Stock", 60);
        }

        private void CargarDatosEnLista(SqlDataReader reader)
        {
            lvwListaJuegos.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["IDJuego"].ToString());
                item.SubItems.Add(reader["NombreJuego"].ToString());
                item.SubItems.Add(reader["Stock"].ToString());
                lvwListaJuegos.Items.Add(item);
            }
            reader.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }    
}
