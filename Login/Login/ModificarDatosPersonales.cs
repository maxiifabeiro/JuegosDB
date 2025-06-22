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
    public partial class ModificarDatosPersonales : Form
    {
        string conexionbd = Conexion.ruta;

        //Propiedad para obterner IDusuario del form anterior
        public int IDUsuario { get; set; } 

        public ModificarDatosPersonales()
        {
            InitializeComponent();
        }

        private void ModificarDatosPersonales_Load(object sender, EventArgs e)
        {
            CargarPaises();
            CargarDatosPersonales();
        } 

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(conexionbd))
                {
                    SqlCommand comando = new SqlCommand("SP_ModificarDatosUsuarios", conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@IDUsuario", lblMostrarIDUsuario.Text);
                    comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    comando.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                    comando.Parameters.AddWithValue("@FechaNacimiento", dtpFechaNacimiento.Value);
                    comando.Parameters.AddWithValue("@IDPais", cbxPais.SelectedValue);
                    comando.Parameters.AddWithValue("@Genero", txtGenero.Text);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Datos Personales modificado correctamente.");

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar al usuario: " + ex.Message);
            }

        }

        //Cargar datosPersonales en los formularios
        private void CargarDatosPersonales()
        {

            try
            {
                using (SqlConnection conexion = new SqlConnection(conexionbd))
                {
                    SqlCommand com = new SqlCommand("SP_ListarUsuariosConID", conexion);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@IDUsuario", IDUsuario);

                    conexion.Open();
                    SqlDataReader reader = com.ExecuteReader();

                    if (reader.Read())
                    {
                        lblMostrarIDUsuario.Text = IDUsuario.ToString();
                        txtNombre.Text = reader["Nombre"].ToString();
                        txtApellido.Text = reader["Apellido"].ToString();
                        dtpFechaNacimiento.Value = Convert.ToDateTime(reader["FechaNacimiento"]);
                        cbxPais.Text = reader["Pais"].ToString();
                        txtGenero.Text = reader["Genero"].ToString();
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar al usuario: " + ex.Message);
            }

        }
        //Carga los paises en el ComboBox
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
