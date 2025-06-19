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
using static Login.Inicio;

namespace Login
{
    public partial class ListadoJuegos : Form
    {
        string conexionbd = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = TiendaJuegos; Integrated Security = True"; /*Conexion Maxi*/
        public ListadoJuegos()
        {
            InitializeComponent();
        }

        private void btnListarID_Click(object sender, EventArgs e)
        {
            BuscarJuegosPorID();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            MostrarTodosLosJuegos();
        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (Sesion.EsAdministrador)
            {
                VisorAdmin formulario = new VisorAdmin();
                formulario.Show();
            }
            else
            {
                VisorUsuario formulario = new VisorUsuario();
                formulario.Show();
            }

            this.Close();
        }

        private void BuscarJuegosPorID()
        {
            int idJuego;
            if (int.TryParse(txtListarPorID.Text, out idJuego))
            {
                using (SqlConnection conexion = new SqlConnection(conexionbd))
                {
                    SqlCommand com = new SqlCommand("SP_BuscarJuegoPorID", conexion);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@IdJuego", idJuego);
                    conexion.Open();
                    SqlDataReader reader = com.ExecuteReader();
                    lvwListado.Items.Clear();
                    ConfigurarListView();
                    CargarDatosEnListView(reader);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un ID válido.");
            }
        }

        private void MostrarTodosLosJuegos()
        {
            using (SqlConnection conexion = new SqlConnection(conexionbd))
            {
                SqlCommand com = new SqlCommand("SP_ListarJuegos", conexion);
                com.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                SqlDataReader reader = com.ExecuteReader();
                lvwListado.Items.Clear();
                ConfigurarListView();
                CargarDatosEnListView(reader);
            }
        }

        private void ConfigurarListView()
        {
            lvwListado.View = View.Details;
            lvwListado.FullRowSelect = true;
            lvwListado.GridLines = true;
            lvwListado.Columns.Clear();

            lvwListado.Columns.Add("Nombre", 150);
            lvwListado.Columns.Add("Desarrolladora", 120);
            lvwListado.Columns.Add("Categoría", 100);
            lvwListado.Columns.Add("Formato", 80);
            lvwListado.Columns.Add("Clasificación", 100);
            lvwListado.Columns.Add("Lanzamiento", 100);
            lvwListado.Columns.Add("Tamaño", 70);
            lvwListado.Columns.Add("Jugadores", 80);
            lvwListado.Columns.Add("Descripción", 200);
            lvwListado.Columns.Add("Precio", 70);
            lvwListado.Columns.Add("Stock", 60);
        }

        private void CargarDatosEnListView(SqlDataReader reader)
        {
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["NombreJuego"].ToString());
                item.SubItems.Add(reader["Desarrolladora"].ToString());
                item.SubItems.Add(reader["Categoria"].ToString());
                item.SubItems.Add(reader["Formato"].ToString());
                item.SubItems.Add(reader["ClasificacionEdad"].ToString());
                item.SubItems.Add(Convert.ToDateTime(reader["FechaLanzamiento"]).ToShortDateString());
                item.SubItems.Add(reader["Tamaño"].ToString());
                item.SubItems.Add(reader["CantidadJugadores"].ToString());
                item.SubItems.Add(reader["Descripcion"].ToString());
                item.SubItems.Add(Convert.ToDecimal(reader["Precio"]).ToString("C"));
                item.SubItems.Add(reader["Stock"].ToString());

                lvwListado.Items.Add(item);
            }
            reader.Close();
        }
    }
}
