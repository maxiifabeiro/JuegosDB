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
    public partial class ListarStock : Form
    {
        string conexionbd = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = TiendaJuegos; Integrated Security = True"; /*Conexion Maxi*/
        public ListarStock()
        {
            InitializeComponent();
        }

        private void ListarStock_Load(object sender, EventArgs e)
        {
            ConfigurarListView();
            MostrarStock();
        }

        private void MostrarStock()
        {
            using (SqlConnection conexion = new SqlConnection(conexionbd))
            {
                SqlCommand com = new SqlCommand("SP_ListarStock", conexion);
                com.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                SqlDataReader reader = com.ExecuteReader();
                CargarDatosEnLista(reader);
            }
        }

        private void ConfigurarListView()
        {
            lvListaStock.View = View.Details;
            lvListaStock.FullRowSelect = true;
            lvListaStock.GridLines = true;
            lvListaStock.Columns.Clear();

            lvListaStock.Columns.Add("ID Juego", 100);
            lvListaStock.Columns.Add("Nombre", 150);
            lvListaStock.Columns.Add("Stock", 60);
        }

        private void CargarDatosEnLista(SqlDataReader reader)
        {
            lvListaStock.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["IDJuego"].ToString());
                item.SubItems.Add(reader["NombreJuego"].ToString());
                item.SubItems.Add(reader["Stock"].ToString());
                lvListaStock.Items.Add(item);
            }
            reader.Close();
        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            ABMLJuegos ventana = new ABMLJuegos();
            ventana.Show();
            this.Close();
        }
    }
}
