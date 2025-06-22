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
    public partial class ModificarUsuario : Form
    {
        string conexionbd = "Ruta DB";

        public ModificarUsuario()
        {
            InitializeComponent();
            CargarPermisos();
        }

        //Busca ID del usuario y lo carga en el formulario
        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtIDUsuario.Text, out id))
            {
                MessageBox.Show("Ingrese un ID válido.");
                return;
            }

            try
            {
                using (SqlConnection conexion = new SqlConnection(conexionbd))
                {
                    SqlCommand com = new SqlCommand("SP_BuscarUsuarioPorID", conexion);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@IDUsuario", id);

                    conexion.Open();
                    SqlDataReader reader = com.ExecuteReader();

                    if (reader.Read())
                    {
                        lblMostrarIDUsuario.Text = id.ToString();
                        txtNombreUsuario.Text = reader["NombreUsuario"].ToString();
                        txtCorreoElectronico.Text = reader["Email"].ToString();
                        txtContraseniaUsuario.Text = reader["Contraseña"].ToString();
                        dtpFechaRegistro.Value = Convert.ToDateTime(reader["Fecha de Registro"]);
                        txtAvatarURL.Text = reader["AvatarURL"].ToString();
                        ckbEsAdministrador.Checked = Convert.ToBoolean(reader["EsAdministrador"]);
                        cbxPermiso.Text = reader["Permiso"].ToString();

                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado.");
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar al usuario: " + ex.Message);
            }

        }

        private void btnModificarDatosUsuario_Click(object sender, EventArgs e)
        {
            ModificarDatosPersonales formulario = new ModificarDatosPersonales();
            try
            {
                formulario.IDUsuario = int.Parse(lblMostrarIDUsuario.Text);
                formulario.ShowDialog();

            }catch(Exception ex)
            {
                MessageBox.Show("Error al intentar abrir la ventana Modificar Datos Personales, verifique que haya ingresado bien el ID de usuario", ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDUsuario.Text))
            {
                MessageBox.Show("Ingrese un ID para modificar.");
                return;
            }

            try
            {
                using (SqlConnection conexion = new SqlConnection(conexionbd))
                {
                    SqlCommand comando = new SqlCommand("SP_ModificarUsuario", conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@IDUsuario", lblMostrarIDUsuario.Text);
                    comando.Parameters.AddWithValue("@NombreUsuario", txtNombreUsuario.Text);
                    comando.Parameters.AddWithValue("@Correo", txtCorreoElectronico.Text);
                    comando.Parameters.AddWithValue("@Contrasena", txtContraseniaUsuario.Text);
                    comando.Parameters.AddWithValue("@FechaRegistro", dtpFechaRegistro.Value);
                    comando.Parameters.AddWithValue("@AvatarURL", txtAvatarURL.Text);
                    comando.Parameters.AddWithValue("@EsAdministrador", Convert.ToBoolean(ckbEsAdministrador.Checked));
                    comando.Parameters.AddWithValue("@IdPermiso", cbxPermiso.SelectedValue);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Usuario modificado correctamente.");

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar al usuario: " + ex.Message);
            }

        }
        //Cargar Permisos en el ComboBox
        private void CargarPermisos()
        {
            SqlDataAdapter daPermisos = new SqlDataAdapter("SELECT IDPermiso, Nombre FROM Permisos", conexionbd);
            DataTable dtPermisos = new DataTable();
            try
            {
                daPermisos.Fill(dtPermisos);
                cbxPermiso.DataSource = dtPermisos;
                cbxPermiso.DisplayMember = "Nombre";
                cbxPermiso.ValueMember = "IDPermiso";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los permisos: " + ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
