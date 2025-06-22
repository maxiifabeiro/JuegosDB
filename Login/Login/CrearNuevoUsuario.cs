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
        public CrearUsuario()
        {
            InitializeComponent();
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


            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=JuegosDB;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO Usuarios (NombreUsuario, CorreoElectronico, Contrasena, FechaNacimiento, AvatarURL) VALUES (@NombreUsuario, @CorreoElectronico, @Contrasena, @FechaNacimiento, @Avatar)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@NombreUsuario", usuario);
                    cmd.Parameters.AddWithValue("@CorreoElectronico", correo);
                    cmd.Parameters.AddWithValue("@Contrasena", contrasena);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", fecha);
                    cmd.Parameters.AddWithValue("@Avatar", avatarurl);


                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuario creado correctamente");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al crear usuario: " + ex.Message);
                    }
                }
            }
        }

        private bool CorreoExisteEnBD(string correo)
        {
            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=JuegosDB;Integrated Security=True";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
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
    }

}
