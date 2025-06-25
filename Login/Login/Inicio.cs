using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Login
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(Conexion.ruta); /*Conexion de maxi*/

        private void btningresar_Click(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text;
            string password = txtcontrasena.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor, complete ambos campos.");
                return;
            }

            //string connectionString = @"Data Source=Localhost\SQLEXPRESS;Initial Catalog=JuegosDB;Integrated Security=True";/*Conexion de majo*/
            string connectionString = Conexion.ruta;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("VerificarUsuario", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@NombreUsuario", usuario);
                    cmd.Parameters.AddWithValue("@Contrasena", password);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        bool esAdmin = Convert.ToBoolean(reader["EsAdministrador"]);

                        // Guardo en sesion el nombre de usuario y si es administrador o no
                        Sesion.NombreUsuario = usuario;
                        Sesion.EsAdministrador = esAdmin;
                        if (esAdmin)
                        {
                            //Comprobacion para que no se permita abrir varias ventanas 
                            foreach (var item in Application.OpenForms)
                            {
                                if (item.GetType() == typeof(VisorAdmin))
                                {
                                    MessageBox.Show("Ya se ha abierto una instancia de esta ventana. Termine de trabajar allí");
                                    return;
                                }
                            }

                            VisorAdmin formulario = new VisorAdmin();
                            formulario.ShowDialog();
                            //this.Hide();
                            
                        }
                        else
                        {
                            //Comprobacion para que no se permita abrir varias ventanas 
                            foreach (var item in Application.OpenForms)
                            {
                                if (item.GetType() == typeof(VisorUsuario))
                                {
                                    MessageBox.Show("Ya se ha abierto una instancia de esta ventana. Termine de trabajar allí");
                                    return;
                                }
                            }

                            VisorUsuario formulario = new VisorUsuario();
                            formulario.ShowDialog();
                            //this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos");
                    }
                    reader.Close();
                }
            }
        }


        public static class Sesion
        {
            public static string NombreUsuario { get; set; }
            public static bool EsAdministrador { get; set; }
        }


        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtusuario.Text = "";
            txtcontrasena.Text = "";

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogoTiendaJuego_Click(object sender, EventArgs e)
        {
            LogoTiendaJuego.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void OlvidoContrasena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CambiarContrasena formulario = new CambiarContrasena();
            formulario.Show();
            this.Hide();
        }

      
    }
}
