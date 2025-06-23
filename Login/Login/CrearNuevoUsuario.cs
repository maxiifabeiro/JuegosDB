using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class CrearUsuario : Form
    {
        string conexionbd = Conexion.ruta;
        public CrearUsuario()
        {
            InitializeComponent();
            CargarPermisos();
        }
        private void ComprobarContrasena_Click(object sender, EventArgs e)
        {
            if (txtContrasena.Text.Equals(txtComprobarContrasena.Text))
            {
                dateTimePicker2.Focus();
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
                txtComprobarContrasena.Clear();
                txtComprobarContrasena.Focus();
            }
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {

            string usuario = txtNombreUsuario.Text;
            string correo = txtCorreoElectronico.Text.Trim();
            string contrasena = txtContrasena.Text;
            DateTime fecha = dateTimePicker2.Value.Date;
            string avatarurl = txtAvatar.Text;


            // Validación 1: campo vacío
            if (string.IsNullOrEmpty(correo))
            {
                MessageBox.Show("El correo electrónico es obligatorio.");
                return;
            }

            // Validación 2: formato válido
            if (!CorreoEsValido(correo))
            {
                MessageBox.Show("Ingrese un correo electrónico válido.");
                return;
            }

            // Validación 3: ya registrado
            if (CorreoExisteEnBD(correo))
            {
                MessageBox.Show("Este correo ya está registrado.");
                return;
            }



            int nuevoId = 0;
            using (SqlConnection conexion = new SqlConnection(conexionbd))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_altaUsuario", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreUsuario", usuario);
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Contrasena", contrasena);
                cmd.Parameters.AddWithValue("@FechaNacimiento", fecha);
                cmd.Parameters.AddWithValue("@AvatarURL", avatarurl);
                cmd.Parameters.AddWithValue("@IdPermiso", cmbPermisos.SelectedValue);

                try
                {
                    nuevoId = Convert.ToInt32(cmd.ExecuteScalar());
                    MessageBox.Show("Usuario creado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear usuario: " + ex.Message);
                    return;
                }
            }
            DatosPersonales formulario = new DatosPersonales(nuevoId); // le pasás el ID real
            formulario.ShowDialog();
        }


        private bool CorreoExisteEnBD(string correo)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(conexionbd))
                {
                    string consulta = "SELECT COUNT(*) FROM Usuarios WHERE CorreoElectronico = @Correo";
                    SqlCommand cmd = new SqlCommand(consulta, con);
                    cmd.Parameters.AddWithValue("@Correo", correo);

                    con.Open();
                    int cantidad = (int)cmd.ExecuteScalar();
                    return cantidad > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar la base de datos: {ex.Message}");
                return false;
            }

        }

        private bool CorreoEsValido(string correo)
        {
            string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(correo, patronCorreo);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarPermisos()
        {
            SqlDataAdapter daPermisos = new SqlDataAdapter("SELECT IDPermiso, Nombre FROM Permisos", conexionbd);
            DataTable dtPermisos = new DataTable();
            try
            {
                daPermisos.Fill(dtPermisos);
                cmbPermisos.DataSource = dtPermisos;
                cmbPermisos.DisplayMember = "Nombre";
                cmbPermisos.ValueMember = "IDPermiso";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los permisos: " + ex.Message);
            }
        }

    }

}
