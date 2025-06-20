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
    public partial class EliminarJuego : Form
    {
        public EliminarJuego()
        {
            InitializeComponent();
        }
        string conexionbd = "server=.\\SQLEXPRESS; database=JuegosDB; integrated security=true";
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Por favor, ingrese el ID del juego a buscar.");
                return;
            }

            int eliminarJuego;
            if (!int.TryParse(txtID.Text, out eliminarJuego))
            {
                MessageBox.Show("El ID debe ser un número válido.");
                return;
            }

            using (SqlConnection conexion = new SqlConnection(conexionbd))
            {
                SqlCommand com = new SqlCommand("SP_BuscarJuegoPorID", conexion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@IdJuego", eliminarJuego);

                try
                {
                    conexion.Open();
                    SqlDataReader reader = com.ExecuteReader();
                    if (reader.Read())
                    {
                        txtNombre.Text = reader["NombreJuego"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un juego con ese ID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar el juego: " + ex.Message);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Por favor, ingrese el ID del juego a eliminar.");
                return;
            }

            int idJuego;
            if (!int.TryParse(txtID.Text, out idJuego))
            {
                MessageBox.Show("El ID debe ser un número válido.");
                return;
            }

            using (SqlConnection conexion = new SqlConnection(conexionbd))
            {
                SqlCommand com = new SqlCommand("SP_BajaJuego", conexion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@IdJuego", idJuego);

                try
                {
                    conexion.Open();
                    int filas = com.ExecuteNonQuery();
                    if (filas > 0)
                    {
                        MessageBox.Show("Juego eliminado (estado cambiado a 0).");
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se eliminó ningún juego. ¿El ID es correcto?");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el juego: " + ex.Message);
                }
            }
        }

        private void LimpiarCampos()
        {
            txtID.Clear();
            txtNombre.Clear();
        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            ABMLJuegos formulario = new ABMLJuegos();
            formulario.Show();
            this.Close();
        }
    }
}
