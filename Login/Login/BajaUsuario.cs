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
    public partial class BajaUsuario : Form
    {
        string conexionbd = "server=.\\SQLEXPRESS; database=JuegosDB; integrated security=true";

        public BajaUsuario()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int eliminarUsuario;

            if (string.IsNullOrWhiteSpace(txtIDUsuario.Text))
            {
                MessageBox.Show("Por favor, ingrese el ID del usuario a buscar.");
                return;
            }

            if (!int.TryParse(txtIDUsuario.Text, out eliminarUsuario))
            {
                MessageBox.Show("El ID debe ser un número válido.");
                return;
            }

            using (SqlConnection conexion = new SqlConnection(conexionbd))
            {
                SqlCommand com = new SqlCommand("SP_BuscarUsuarioPorID", conexion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@IDUsuario", eliminarUsuario);

                try
                {
                    conexion.Open();
                    SqlDataReader reader = com.ExecuteReader();
                    if (reader.Read())
                    {
                        txtNombreUsuario.Text = reader["NombreUsuario"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningun usuario con ese ID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar la busqueda: " + ex.Message);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idUsuario;

            if (string.IsNullOrWhiteSpace(txtIDUsuario.Text))
            {
                MessageBox.Show("Por favor, ingrese el ID del juego a eliminar.");
                return;
            }

            if (!int.TryParse(txtIDUsuario.Text, out idUsuario))
            {
                MessageBox.Show("El ID debe ser un número válido.");
                return;
            }

            using (SqlConnection conexion = new SqlConnection(conexionbd))
            {
                SqlCommand com = new SqlCommand("SP_BajaUsuario", conexion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@IDUsuario", idUsuario);

                try
                {
                    conexion.Open();
                    int filas = com.ExecuteNonQuery();
                    if (filas > 0)
                    {
                        MessageBox.Show("Usuario eliminado (estado cambiado a 0).");
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se eliminó ningún usuario. ¿El ID es correcto?");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el usuario: " + ex.Message);
                }
            }

        }

        private void LimpiarCampos()
        {
            txtIDUsuario.Clear();
            txtNombreUsuario.Clear();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
