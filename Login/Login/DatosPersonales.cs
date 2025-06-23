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

namespace Login
{
    public partial class DatosPersonales : Form
    {
        string conexionbd = Conexion.ruta;

        private int idUsuario; 
        public DatosPersonales(int id)
        {
            InitializeComponent();
            CargarPaises();
            idUsuario = id;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(conexionbd))
                {
                    SqlCommand comando = new SqlCommand("SP_DatosUsuarios", conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    comando.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                    comando.Parameters.AddWithValue("@FechaNacimiento", dtpFechaNacimiento.Value);
                    comando.Parameters.AddWithValue("@IDPais", cbxPais.SelectedValue);
                    comando.Parameters.AddWithValue("@Genero", txtGenero.Text);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Datos Personales agregados correctamente.");

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar datos de usuario: " + ex.Message);
            }
        }

        private void CargarPaises()
        {
            SqlDataAdapter daPermisos = new SqlDataAdapter("SELECT IDPais, Nombre FROM Paises", conexionbd);
            DataTable dtPermisos = new DataTable();
            try
            {
                daPermisos.Fill(dtPermisos);
                cbxPais.DataSource = dtPermisos;
                cbxPais.DisplayMember = "Nombre";
                cbxPais.ValueMember = "IDPais";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los paises: " + ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
