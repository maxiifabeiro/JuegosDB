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
    public partial class ListadoUsuarios : Form
    {
        string conexionbd = Conexion.ruta;
        public ListadoUsuarios()
        {
            InitializeComponent();
        }

        private void btnBuscarIDUsuario_Click(object sender, EventArgs e)
        {
            int id;
            if (string.IsNullOrWhiteSpace(txtIDUsuario.Text))
            {
                MessageBox.Show("Por favor, ingrese el ID del usuario a buscar.");
                LimpiarCampos();
                return;
            }

            if (!int.TryParse(txtIDUsuario.Text, out id))
            {
                MessageBox.Show("El ID debe ser un número válido.");
                LimpiarCampos();
                return;
            }

            using (SqlConnection conexion = new SqlConnection(conexionbd))
            {
                SqlCommand com = new SqlCommand("SP_ListarUsuariosConID", conexion);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@IDUsuario", id);

                try
                {
                    conexion.Open();
                    SqlDataReader reader = com.ExecuteReader();
                    lvwListadoUsuario.Items.Clear();
                    ConfigurarListView();
                    CargarDatosEnListView(reader);

                    LimpiarCampos();

                }
                catch(Exception ex)
                {
                   MessageBox.Show("Error al eliminar el usuario: " + ex.Message);
                }

            }

        }

        private void btnMostrarTodosUsuarios_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new SqlConnection(conexionbd))
            {
                SqlCommand com = new SqlCommand("SP_ListarUsuarios", conexion);
                com.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                SqlDataReader reader = com.ExecuteReader();
                lvwListadoUsuario.Items.Clear();
                ConfigurarListView();
                CargarDatosEnListView(reader);
            }

        }

        private void ConfigurarListView()
        {
            lvwListadoUsuario.View = View.Details;
            lvwListadoUsuario.FullRowSelect = true;
            lvwListadoUsuario.GridLines = true;
            lvwListadoUsuario.Columns.Clear();

            lvwListadoUsuario.Columns.Add("Nickname", 150);
            lvwListadoUsuario.Columns.Add("Email", 120);
            lvwListadoUsuario.Columns.Add("Fecha de Registro", 100);
            lvwListadoUsuario.Columns.Add("Permiso", 80);
            lvwListadoUsuario.Columns.Add("Nombre", 100);
            lvwListadoUsuario.Columns.Add("Apellido", 100);
            lvwListadoUsuario.Columns.Add("Fecha de Nacimiento", 70);
            lvwListadoUsuario.Columns.Add("Pais", 80);
            lvwListadoUsuario.Columns.Add("Genero", 200);
        }

        private void CargarDatosEnListView(SqlDataReader reader)
        {
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["NombreUsuario"].ToString());
                item.SubItems.Add(reader["Email"].ToString());
                item.SubItems.Add(Convert.ToDateTime(reader["FechaRegistro"]).ToShortDateString());
                item.SubItems.Add(reader["Permiso"].ToString());
                item.SubItems.Add(reader["Nombre"].ToString());
                item.SubItems.Add(reader["Apellido"].ToString());
                item.SubItems.Add(Convert.ToDateTime(reader["FechaNacimiento"]).ToShortDateString());
                item.SubItems.Add(reader["Pais"].ToString());
                item.SubItems.Add(reader["Genero"].ToString());

                lvwListadoUsuario.Items.Add(item);
            }
            reader.Close();
        }
        private void LimpiarCampos()
        {
            txtIDUsuario.Clear();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
